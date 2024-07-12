<?php

namespace App\Models;

use Eloquent;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Eloquent\Model;

/**
 * App\Models\UserBotTimestamp
 *
 * @property int $id
 * @property int $user_id
 * @property string $bot_id
 * @property string $application
 * @property string|null $visited_at
 * @method static Builder|UserBotTimestamp newModelQuery()
 * @method static Builder|UserBotTimestamp newQuery()
 * @method static Builder|UserBotTimestamp query()
 * @method static Builder|UserBotTimestamp whereApplication($value)
 * @method static Builder|UserBotTimestamp whereBotId($value)
 * @method static Builder|UserBotTimestamp whereId($value)
 * @method static Builder|UserBotTimestamp whereUserId($value)
 * @method static Builder|UserBotTimestamp whereVisitedAt($value)
 * @mixin Eloquent
 */
class UserBotTimestamp extends Model
{
    public $timestamps = false;

    protected $table = "user_bot_timestamp";

    protected $fillable = [
        "user_id",
        "bot_id",
        "application",
        "visited_at",
    ];

    protected $primaryKey = "user_id";
}
