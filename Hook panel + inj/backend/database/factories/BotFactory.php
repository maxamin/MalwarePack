<?php

namespace Database\Factories;

use App\Models\Bot;
use App\Models\BotCommand;
use App\Models\BotInjection;
use App\Models\Injection;
use App\Models\User;
use App\Models\UserTag;
use Exception;
use Illuminate\Database\Eloquent\Factories\Factory;
use Illuminate\Support\Carbon;
use Illuminate\Support\Facades\Http;
use Illuminate\Support\Str;
use Throwable;

class BotFactory extends Factory
{
    /**
     * The name of the factory's corresponding model.
     *
     * @var string
     */
    protected $model = Bot::class;

    /**
     * Define the model's default state.
     *
     * @throws Exception
     */
    public function definition(): array
    {
        $isDualSim = random_int(1, 2) === 1;

        $tags = ['tag1', 'tag2', 'test', 'tag'];

        $simData = [
            "operator" => $this->faker->company,
            "phone_number" => $this->faker->phoneNumber(),
            "isDualSim" => $isDualSim ? "true" : "false",
            "operator1" => $isDualSim ? $this->faker->company : '',
            "phone_number1" => $isDualSim ? $this->faker->phoneNumber() : '',
        ];

        $country_code = $this->faker->countryCode();

        try {
            $response = Http::get('https://restcountries.com/v3.1/alpha/' . $country_code);
            $country_name = $response->json()[0]['name']['common'];
        } catch (Throwable $exception) {
            dd($exception->getMessage());
        }

        $arrayUrl = [];
        for ($i = 0; $i < random_int(1, 3); ++$i) {
            $arrayUrl[] = $this->faker->url;
        }

        $updatedAt = Carbon::parse($this->faker->dateTimeBetween('-10days'))->toDateTimeString();

        $location = [];

        if ($this->faker->boolean()) {
            $location = [
                'lat' => $this->faker->latitude,
                'lon' => $this->faker->longitude,
            ];
        }

        $id = 'HW-' . Str::random();

        return [
            'id' => $id,
            'sim_data' => $simData,
            'tag' => $tags[random_int(0, count($tags) - 1)],
            'ip' => $this->faker->ipv4 . ':' . random_int(80, 25555),
            'country' => $country_name,
            'country_code' => $country_code,
            'last_connection' => Carbon::parse($this->faker->dateTimeBetween('-60days'))->toDateTimeString(),
            'update_settings' => random_int(0, 1),
            'working_time' => random_int(0, 2147483647),
            'metadata' => [
                "device" => $this->faker->word(),
                "android" => $this->faker->randomDigit(),
                "version" => random_int(8, 13),
                "manufacturer" => $this->faker->word()
            ],
            'permissions' => [
                "all_permission" => $this->faker->boolean() ? "true" : "false",
                "sms_permission" => $this->faker->boolean() ? "true" : "false",
                "overlay_permission" => $this->faker->boolean() ? "true" : "false",
                "accounts_permission" => $this->faker->boolean() ? "true" : "false",
                "contacts_permission" => $this->faker->boolean() ? "true" : "false",
                "notification_permission" => $this->faker->boolean() ? "true" : "false",
            ],
            'settings' => [
                'hideSMS' => $this->faker->boolean() ? "1" : "0",
                'lockDevice' => $this->faker->boolean() ? "1" : "0",
                'offSound' => $this->faker->boolean() ? "1" : "0",
                'keylogger' => $this->faker->boolean() ? "1" : "0",
                'clearPush' => $this->faker->boolean() ? "1" : "0",
                'readPush' => $this->faker->boolean() ? "1" : "0",
                'arrayUrl' => $arrayUrl,
            ],
            'sub_info' => [
                "admin" => $this->faker->boolean() ? "true" : "false",
                "screen" => $this->faker->boolean() ? "true" : "false",
                "protect" => $this->faker->boolean() ? "1" : "0",
                "isDozeMode" => $this->faker->boolean() ? "true" : "false",
                "batteryLevel" => random_int(1, 100),
                "accessibility" => $this->faker->boolean() ? "true" : "false",
                "isKeyguardLocked" => $this->faker->boolean() ? "true" : "false"
            ],
            'is_favorite' => $this->faker->boolean(),
            'is_blacklisted' => $this->faker->boolean(),
            'created_at' => $updatedAt,
            'updated_at' => $updatedAt,
            'location' => $location,
        ];
    }

    /**
     * Configure the model factory.
     */
    public function configure(): self
    {
        return $this->afterCreating(function (Bot $bot) {
            $injections = Injection::inRandomOrder()->limit(random_int(1, 15))->get();
            foreach ($injections as $injection) {
                BotInjection::factory([
                    'bot_id' => $bot->id,
                    'application' => $injection->application,
                ])->make()->save();
            }

            for ($i = 0; $i < random_int(1, 5); ++$i) {
                BotCommand::factory([
                    'bot_id' => $bot->id,
                ])->make()->save();
            }

            UserTag::firstOrCreate([
                'user_id' => User::inRandomOrder()->first()->id,
                'tag' => $bot->tag,
            ]);
        });
    }
}
