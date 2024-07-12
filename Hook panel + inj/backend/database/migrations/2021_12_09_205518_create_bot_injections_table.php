<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateBotInjectionsTable extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        Schema::create('bot_injections', function (Blueprint $table) {
            $table->id();

            $table->string('bot_id');

            $table->string('application')
                ->index()
                ->comment('Название пакета приложения. Пример: org.app.name');

            $table->boolean('is_active');

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
        Schema::dropIfExists('bot_injections');
    }
}
