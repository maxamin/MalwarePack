<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Artisan;
use Illuminate\Support\Facades\Schema;
use Spatie\Permission\Models\Permission;
use Spatie\Permission\Models\Role;

return new class extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        Permission::query()->update([
            "guard_name" => "web",
        ]);

        Role::query()->update([
            "guard_name" => "web",
        ]);

        Artisan::call("permission:cache-reset");
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Permission::query()->update([
            "guard_name" => "api",
        ]);

        Role::query()->update([
            "guard_name" => "api",
        ]);

        Artisan::call("permission:cache-reset");
    }
};
