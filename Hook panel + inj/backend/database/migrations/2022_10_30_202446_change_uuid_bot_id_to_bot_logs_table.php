<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class ChangeUuidBotIdToBotLogsTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up(): void
    {
        Schema::table('bot_logs', function (Blueprint $table) {
            $table->dropForeign(['bot_id']);
        });

        DB::statement("ALTER TABLE `bot_logs` CHANGE `bot_id` `bot_id` VARCHAR(255) NOT NULL");

        Schema::table('bot_logs', function (Blueprint $table) {
            $table->foreign('bot_id')
                ->references('id')
                ->on('bots')
                ->onDelete('cascade')
                ->onUpdate('cascade');
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down(): void
    {
        Schema::table('bot_logs', function (Blueprint $table) {
            $table->dropForeign(['bot_id']);
        });

        Schema::table('bot_logs', function (Blueprint $table) {
            $table->uuid('bot_id')->change();

            $table->foreign('bot_id')
                ->references('id')
                ->on('bots')
                ->onDelete('cascade')
                ->onUpdate('cascade');
        });
    }
}
