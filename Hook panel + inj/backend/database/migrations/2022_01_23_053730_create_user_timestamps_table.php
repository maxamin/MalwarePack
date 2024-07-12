<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateUserTimestampsTable extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        Schema::create('user_timestamps', function (Blueprint $table) {
            $table->unsignedBigInteger('user_id')->primary();

            $table->timestamp('bots')->nullable();

            $table->timestamp('banks')->nullable();

            $table->timestamp('stealers')->nullable();

            $table->timestamp('crypt')->nullable();

            $table->timestamp('shops')->nullable();

            $table->timestamp('emails')->nullable();

            $table->timestamp('wallets')->nullable();

            $table->timestamp('credit_cards')->nullable();

            $table->timestamp('permissionless_bots')->nullable();

            $table->timestamp('events')->nullable();

            $table->timestamp('smart_injections')->nullable();

            $table->foreign('user_id')
                ->references('id')
                ->on('users')
                ->onDelete('cascade')
                ->onUpdate('cascade');
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('user_timestamps');
    }
}
