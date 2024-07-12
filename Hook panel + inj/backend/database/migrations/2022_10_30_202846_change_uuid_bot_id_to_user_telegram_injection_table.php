<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class ChangeUuidBotIdToUserTelegramInjectionTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::table('user_telegram_injections', function (Blueprint $table) {
            $table->dropForeign(['bot_id']);
        });

        Schema::table('user_telegram_injections', function (Blueprint $table) {
            $table->string('bot_id')->change();

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
    public function down()
    {
        Schema::table('user_telegram_injections', function (Blueprint $table) {
            $table->dropForeign(['bot_id']);
        });

        Schema::table('user_telegram_injections', function (Blueprint $table) {
            $table->uuid('bot_id')->change();

            $table->foreign('bot_id')
                ->references('id')
                ->on('bots')
                ->onDelete('cascade')
                ->onUpdate('cascade');
        });
    }
}
