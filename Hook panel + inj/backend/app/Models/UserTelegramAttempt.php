<?php

namespace App\Models;

use Eloquent;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Support\Carbon;

/**
 * App\Models\UserTelegramAttempt
 *
 * @property int $id
 * @property int $user_id
 * @property string $secret_word
 * @property int $attempts
 * @property Carbon|null $created_at
 * @property Carbon|null $updated_at
 * @method static Builder|UserTelegramAttempt newModelQuery()
 * @method static Builder|UserTelegramAttempt newQuery()
 * @method static Builder|UserTelegramAttempt query()
 * @method static Builder|UserTelegramAttempt whereAttempts($value)
 * @method static Builder|UserTelegramAttempt whereCreatedAt($value)
 * @method static Builder|UserTelegramAttempt whereId($value)
 * @method static Builder|UserTelegramAttempt whereSecretWord($value)
 * @method static Builder|UserTelegramAttempt whereUpdatedAt($value)
 * @method static Builder|UserTelegramAttempt whereUserId($value)
 * @mixin Eloquent
 */
class UserTelegramAttempt extends Model
{
    protected $fillable = [
        "user_id",
        "secret_word",
        "attempts",
    ];
}
