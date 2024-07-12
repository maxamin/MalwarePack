<?php

namespace App\Models;

use Eloquent;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Eloquent\Model;

/**
 * App\Models\UserTelegramInjection
 *
 * @property int $id
 * @property int $user_id
 * @property string $application
 * @property string $bot_id
 * @method static Builder|UserTelegramInjection newModelQuery()
 * @method static Builder|UserTelegramInjection newQuery()
 * @method static Builder|UserTelegramInjection query()
 * @method static Builder|UserTelegramInjection whereApplication($value)
 * @method static Builder|UserTelegramInjection whereBotId($value)
 * @method static Builder|UserTelegramInjection whereId($value)
 * @method static Builder|UserTelegramInjection whereUserId($value)
 * @mixin Eloquent
 */
class UserTelegramInjection extends Model
{
    protected $fillable = [
        "user_id",
        "application",
        "bot_id",
    ];

    public $timestamps = false;
}
