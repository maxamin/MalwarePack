<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class ChangeUuidIdToBotsTable extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up(): void
    {
        Schema::disableForeignKeyConstraints();

        DB::statement("ALTER TABLE `bots` CHANGE `id` `id` VARCHAR(255) NOT NULL");

        Schema::enableForeignKeyConstraints();
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down(): void
    {
        Schema::disableForeignKeyConstraints();

        DB::statement("ALTER TABLE `bots` CHANGE `id` `id` CHAR(36) NOT NULL");

        Schema::enableForeignKeyConstraints();
    }
}


?>
