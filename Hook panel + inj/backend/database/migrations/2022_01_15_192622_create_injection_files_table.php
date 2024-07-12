<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Schema;

class CreateInjectionFilesTable extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        Schema::create('injection_files', function (Blueprint $table) {
            $table->id('injection_id');

            $table->foreign('injection_id')
                ->references('id')
                ->on('injections')
                ->onDelete('cascade')
                ->onUpdate('cascade');
        });

        DB::statement('ALTER TABLE `injection_files` ADD `html_blob` LONGBLOB');
        DB::statement('ALTER TABLE `injection_files` ADD `image_blob` LONGBLOB');
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('injection_files');
    }
}
