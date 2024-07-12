<?php

use App\Models\UserTelegramInjection;
use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class AddBotIdToUserTelegramInjectionsTable extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        UserTelegramInjection::truncate();

        Schema::table('user_telegram_injections', function (Blueprint $table) {
            $table->string('bot_id');

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
        Schema::table('user_telegram_injections', function (Blueprint $table) {
            $table->dropForeign(['bot_id']);
            $table->dropColumn('bot_id');
        });
    }
}
