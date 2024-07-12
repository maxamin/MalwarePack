<?php

namespace App\Models;

use Eloquent;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Eloquent\Model;

/**
 * App\Models\UserTelegramBot
 *
 * @property int $id
 * @property int $user_id
 * @property string $bot_id
 * @method static Builder|UserTelegramBot newModelQuery()
 * @method static Builder|UserTelegramBot newQuery()
 * @method static Builder|UserTelegramBot query()
 * @method static Builder|UserTelegramBot whereBotId($value)
 * @method static Builder|UserTelegramBot whereId($value)
 * @method static Builder|UserTelegramBot whereUserId($value)
 * @mixin Eloquent
 */
class UserTelegramBot extends Model
{
    protected $fillable = [
        "user_id",
        "bot_id",
    ];

    public $timestamps = false;
}
