<?php

namespace App\Models;

use Database\Factories\BotInjectionFactory;
use Eloquent;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Eloquent\Collection;
use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Database\Eloquent\Relations\HasMany;
use Illuminate\Database\Eloquent\Relations\HasManyThrough;
use Illuminate\Database\Eloquent\Relations\HasOne;

/**
 * App\Models\BotInjection
 *
 * @property int $id
 * @property string $bot_id
 * @property string $application Название пакета приложения. Пример: org.app.name
 * @property int $is_active
 * @method static BotInjectionFactory factory(...$parameters)
 * @method static Builder|BotInjection newModelQuery()
 * @method static Builder|BotInjection newQuery()
 * @method static Builder|BotInjection query()
 * @method static Builder|BotInjection whereApplication($value)
 * @method static Builder|BotInjection whereBotId($value)
 * @method static Builder|BotInjection whereId($value)
 * @method static Builder|BotInjection whereIsActive($value)
 * @property-read Collection<int, BotLog> $botLogs
 * @property-read int|null $bot_logs_count
 * @property-read Injection|null $injection
 * @property-read Collection<int, UserBotTimestamp> $logs
 * @property-read int|null $logs_count
 * @mixin Eloquent
 */
class BotInjection extends Model
{
    use HasFactory;

    protected $fillable = [
        "is_active",
    ];

    public $timestamps = false;

    public function botLogs(): HasMany
    {
        return $this->hasMany(BotLog::class, "application", "application");
    }

    public function injection(): HasOne
    {
        return $this->hasOne(Injection::class, "application", "application");
    }

    public function logs(): HasManyThrough
    {
        return $this->hasManyThrough(
            UserBotTimestamp::class,
            BotLog::class,
            "bot_id",
            "applicatiosn",
            secondLocalKey: "application"
        );
    }
}
