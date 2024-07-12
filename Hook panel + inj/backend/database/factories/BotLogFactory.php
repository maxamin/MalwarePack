<?php

namespace Database\Factories;

use App\Models\BotLog;
use Exception;
use Illuminate\Database\Eloquent\Factories\Factory;

class BotLogFactory extends Factory
{
    /**
     * The name of the factory's corresponding model.
     *
     * @var string
     */
    protected $model = BotLog::class;

    /**
     * Define the model's default state.
     *
     * @throws Exception
     */
    public function definition(): array
    {
        return [];
    }
}
