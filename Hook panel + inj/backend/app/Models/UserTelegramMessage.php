<?php

namespace App\Models;

use Eloquent;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Support\Carbon;

/**
 * App\Models\UserTelegramMessage
 *
 * @property int $id
 * @property int $user_id
 * @property string $message
 * @property int $isSend
 * @property Carbon|null $created_at
 * @property Carbon|null $updated_at
 * @method static Builder|UserTelegramMessage newModelQuery()
 * @method static Builder|UserTelegramMessage newQuery()
 * @method static Builder|UserTelegramMessage query()
 * @method static Builder|UserTelegramMessage whereCreatedAt($value)
 * @method static Builder|UserTelegramMessage whereId($value)
 * @method static Builder|UserTelegramMessage whereIsSend($value)
 * @method static Builder|UserTelegramMessage whereMessage($value)
 * @method static Builder|UserTelegramMessage whereUpdatedAt($value)
 * @method static Builder|UserTelegramMessage whereUserId($value)
 * @mixin Eloquent
 */
class UserTelegramMessage extends Model
{
    protected $fillable = [
        "user_id",
        "message",
        "isSend",
    ];
}
