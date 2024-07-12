<?php

namespace App\Console\Commands;

use Illuminate\Console\Command;
use Workerman\Worker;


class RunWorkerCommand extends Command
{
    /**
     * The name and signature of the console command.
     *
     * @var string
     */
    protected $signature = 'sockets {action} {daemon}';

    /**
     * The console command description.
     *
     * @var string
     */
    protected $description = 'Run sockets for smartInjects';

    /**
     * Execute the console command.
     */
    public function handle(): void
    {
        $websocketWorker = new Worker("websocket://0.0.0.0:" . config('app.websocketPort'));

        $sessions = [];

        $websocketWorker->onConnect = static function ($connection) use (&$sessions) {
            $connection->onWebSocketConnect = static function ($connection) use (&$sessions) {
                $sessions[$_GET['session_id']] = $connection;
            };
        };

        $websocketWorker->onClose = static function ($connection) use (&$sessions) {
            $user = array_search($connection, $sessions, true);
            unset($sessions[$user]);
        };

        $websocketWorker->onWorkerStart = static function () use (&$sessions) {
            $tcpWorker = new Worker("tcp://0.0.0.0:" . config('app.tcpPort'));
            $tcpWorker->onMessage = static function ($connection, $data) use (&$sessions) {
                $data = json_decode($data, true, 512, JSON_THROW_ON_ERROR);

                if (isset($sessions[$data["session_id"]])) {
                    $webConnection = $sessions[$data["session_id"]];
                    $webConnection->send($data["message"]);
                }
            };
            $tcpWorker->listen();
        };

        Worker::runAll();
    }
}
