<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateBotCommandsTable extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        Schema::create('bot_commands', function (Blueprint $table) {
            $table->id();

            $table->string('bot_id');

            /*
            [
                "command" => "string",
                "payload" => [
                    "phone" => "123456",
                    "text" => "52314234",
                ],
            ]
            */
            $table->json('command')
                ->comment('json массив настроек: {command:"sendSMS",payload:{phone:"123456",text:"52314234"}}');

            $table->boolean('is_processed')
                ->comment('Флаг, по которому можно понять - обработана ли команда, или нет');

            $table->timestamp('run_at')
                ->nullable()
                ->comment('Запуск комманды в указанное время, формат Y-m-d H:i:s. Если указано NULL - запускать сразу');

            $table->timestamps();

            $table->foreign('bot_id')
                ->references('id')
                ->on('bots')
                ->onDelete('cascade')
                ->onUpdate('cascade');
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('bot_commands');
    }
}
