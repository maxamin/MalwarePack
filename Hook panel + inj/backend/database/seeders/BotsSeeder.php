<?php

namespace Database\Seeders;

use App\Models\Bot;
use Illuminate\Database\Seeder;

class BotsSeeder extends Seeder
{
    /**
     * Run the database seeds.
     *
     * @return void
     */
    public function run(): void
    {
        $bots_count = $this->command->ask('Enter bots count: ');

        $bar = $this->command->getOutput()->createProgressBar($bots_count);

        $bar->start();

        for ($i = 0; $i < $bots_count; ++$i) {
            Bot::factory()->create();
            $bar->advance();
        }

        $bar->finish();

        $this->command->newLine();
    }
}
