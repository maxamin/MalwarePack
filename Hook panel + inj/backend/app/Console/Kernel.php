<?php

namespace App\Console;

use App\Console\Commands\AutoInjectsCommand;
use App\Console\Commands\ClearLogs;
use App\Console\Commands\RunWorkerCommand;
use Illuminate\Console\Scheduling\Schedule;
use Illuminate\Foundation\Console\Kernel as ConsoleKernel;

class Kernel extends ConsoleKernel
{
    /**
     * The Artisan commands provided by your application.
     *
     * @var array
     */
    protected $commands = [
        AutoInjectsCommand::class,
        ClearLogs::class,
        RunWorkerCommand::class,
    ];

    /**
     * Define the application's command schedule.
     *
     * @param Schedule $schedule
     * @return void
     */
    protected function schedule(Schedule $schedule): void
    {
        $schedule->command(AutoInjectsCommand::class)->everyMinute();
        $schedule->command(ClearLogs::class)->everyFiveMinutes();
    }
}
