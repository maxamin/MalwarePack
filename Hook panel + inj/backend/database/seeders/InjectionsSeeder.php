<?php

namespace Database\Seeders;

use App\Services\InjectionsService;
use Illuminate\Database\Seeder;

class InjectionsSeeder extends Seeder
{
    /**
     * Run the database seeds.
     */
    public function run(): void
    {
        InjectionsService::import();
    }
}