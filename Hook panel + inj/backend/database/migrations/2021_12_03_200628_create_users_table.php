<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateUsersTable extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        Schema::create('users', function (Blueprint $table) {
            $table->id();

            $table->string('name')
                ->comment('Имя пользователя');

            $table->string('password')
                ->comment('Закриптованный токен пользователя');

            $table->string('token')
                ->unique()
                ->comment('Незакриптованный токен пользователя');

            $table->string('email')
                ->nullable()
                ->comment('Адрес электронной почты. Nullable');

            $table->boolean('is_paused')
                ->default(false)
                ->comment('Приостановлен ли пользователь.');

            $table->timestamp('expired_at')
                ->nullable()
                ->comment('Дата истечения токена.');

            $table->unsignedBigInteger('created_user_id')
                ->nullable();

            $table->string('telegram_id')->nullable();

            $table->foreign('created_user_id')
                ->references('id')
                ->on('users')
                ->onDelete('cascade')
                ->onUpdate('cascade');

            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('users');
    }
}
