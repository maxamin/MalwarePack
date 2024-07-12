<?php

namespace App\Models;

use Database\Factories\BotCommandFactory;
use Eloquent;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Support\Carbon;

/**
 * App\Models\BotCommand
 *
 * @property int $id
 * @property string $bot_id
 * @property array $command json массив настроек: {command:"sendSMS",payload:{phone:"123456",text:"52314234"}}
 * @property bool $is_processed Флаг, по которому можно понять - обработана ли команда, или нет
 * @property string|null $run_at Запуск комманды в указанное время, формат Y-m-d H:i:s. Если указано NULL - запускать сразу
 * @property Carbon|null $created_at
 * @property Carbon|null $updated_at
 * @method static BotCommandFactory factory(...$parameters)
 * @method static Builder|BotCommand newModelQuery()
 * @method static Builder|BotCommand newQuery()
 * @method static Builder|BotCommand query()
 * @method static Builder|BotCommand whereBotId($value)
 * @method static Builder|BotCommand whereCommand($value)
 * @method static Builder|BotCommand whereCreatedAt($value)
 * @method static Builder|BotCommand whereId($value)
 * @method static Builder|BotCommand whereIsProcessed($value)
 * @method static Builder|BotCommand whereRunAt($value)
 * @method static Builder|BotCommand whereUpdatedAt($value)
 * @mixin Eloquent
 */
class BotCommand extends Model
{
    use HasFactory;

    protected $casts = [
        "is_processed" => "boolean",
        "command" => "array",
    ];

    protected $fillable = [
        "bot_id",
        "command",
        "run_at",
        "is_processed",
    ];
}
