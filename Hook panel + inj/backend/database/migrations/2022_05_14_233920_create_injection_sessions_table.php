<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateInjectionSessionsTable extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        Schema::create('injection_sessions', function (Blueprint $table) {
            $table->id();

            $table->string('bot_id');

            $table->string('application');

            $table->json('data')->nullable();

            $table->string('session_id', 36);

            $table->string('action')->default('default');

            $table->boolean('is_closed')->default(false);

            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('injection_sessions');
    }
}
