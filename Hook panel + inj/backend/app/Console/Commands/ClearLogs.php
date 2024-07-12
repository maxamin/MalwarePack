<?php

namespace App\Console\Commands;

use App\Models\BotLog;
use Illuminate\Console\Command;
use Illuminate\Support\Carbon;
use Illuminate\Support\Facades\Log;


class ClearLogs extends Command
{
    /**
     * The name and signature of the console command.
     *
     * @var string
     */
    protected $signature = 'bot-logs:clear-old';

    /**
     * The console command description.
     *
     * @var string
     */
    protected $description = 'Clear old logs (created_at > 7 days)';

    /**
     * Execute the console command.
     */
    public function handle(): void
    {
        $uselessLogs = BotLog::whereIn('type', [
            'Calling',
            'getApps',
            'getContacts',
            'getSMS',
            'killApplication',
            'killme',
            'logAccounts',
            'openFake',
            'sendNotification',
            'sendSms',
            'startadmin',
            'startApplication',
            'startClearCash',
            'updateinjectandlistapps',
            'sendSmsStatus',
            'openUrlBraw',
        ]);

        $uselessLogsCount = (clone $uselessLogs)->count();

        if ($uselessLogsCount) {
            $uselessLogs->delete();
            Log::channel('logs_clear')->info("Deleted $uselessLogsCount useless logs");
        }

        $usefulLogs = BotLog::whereIn('type', [
            'keylogger',
            'events',
            'pushlist',
            'pushlist2',
        ])->where('created_at', '<', Carbon::now()->subDay());

        $usefulLogs->delete();

        $successAndErrorLogs = BotLog::whereIn('type', [
            'success',
            'error',
        ])->where('created_at', '<', Carbon::now()->subMinutes(5))->limit(1000000);

        $successAndErrorLogs->delete();
    }
}
