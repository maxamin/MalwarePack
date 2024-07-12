<?php

namespace App\Console\Commands;

use App\Models\Bot;
use App\Models\BotInjection;
use App\Models\Injection;
use Illuminate\Console\Command;
use Illuminate\Support\Facades\Log;


class AutoInjectsCommand extends Command
{
    /**
     * The name and signature of the console command.
     *
     * @var string
     */
    protected $signature = 'autoInjects:run';

    /**
     * The console command description.
     *
     * @var string
     */
    protected $description = 'Run auto injects';

    /**
     * Execute the console command.
     */
    public function handle(): void
    {
        $autoInjectApplications = Injection::select('application')
            ->where('auto', true)
            ->get()
            ->pluck('application');

        if (!$autoInjectApplications->count()) {
            return;
        }

        $newBotIds = Bot::select('id')
            ->where('is_new', true)
            ->get()
            ->pluck('id');

        Log::channel('auto_injects')->info('Auto injects enabled for botIds', $newBotIds->toArray());

        if (!$newBotIds->count()) {
            return;
        }

        BotInjection::whereIn('bot_id', $newBotIds)
            ->whereIn('application', $autoInjectApplications)
            ->update([
                'is_active' => true,
            ]);

        Bot::whereIn('id', $newBotIds)->update([
            'update_settings' => true,
            'is_new' => false,
        ]);

        Log::channel('auto_injects')->info('Auto injects enabled for botIds', $newBotIds->toArray());
    }
}