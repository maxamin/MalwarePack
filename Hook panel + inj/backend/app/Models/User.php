<?php

namespace App\Models;

use Database\Factories\UserFactory;
use Eloquent;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Eloquent\Factories\HasFactory;
use Illuminate\Database\Eloquent\Relations\HasMany;
use Illuminate\Database\Eloquent\Relations\HasOne;
use Illuminate\Foundation\Auth\User as Authenticatable;
use Illuminate\Notifications\DatabaseNotification;
use Illuminate\Notifications\DatabaseNotificationCollection;
use Illuminate\Notifications\Notifiable;
use Illuminate\Support\Carbon;
use Illuminate\Support\Collection;
use Laravel\Sanctum\HasApiTokens;
use Laravel\Sanctum\PersonalAccessToken;
use Spatie\Permission\Models\Permission;
use Spatie\Permission\Models\Role;
use Spatie\Permission\Traits\HasRoles;

/**
 * App\Models\User
 *
 * @property int $id
 * @property string $name Имя пользователя
 * @property string $password Закриптованный токен пользователя
 * @property string $token Незакриптованный токен пользователя
 * @property string|null $email Адрес электронной почты. Nullable
 * @property bool $is_paused Приостановлен ли пользователь.
 * @property Carbon|null $expired_at Дата истечения токена.
 * @property Carbon|null $created_at
 * @property Carbon|null $updated_at
 * @property-read UserTimestamp|null $entitiesTimestamps
 * @property-read \Illuminate\Database\Eloquent\Collection|Permission[] $permissions
 * @property-read int|null $permissions_count
 * @property-read \Illuminate\Database\Eloquent\Collection|Role[] $roles
 * @property-read int|null $roles_count
 * @property-read \Illuminate\Database\Eloquent\Collection|UserTag[] $tags
 * @property-read int|null $tags_count
 * @method static Builder|User newModelQuery()
 * @method static Builder|User newQuery()
 * @method static Builder|User permission($permissions)
 * @method static Builder|User query()
 * @method static Builder|User role($roles, $guard = NULL)
 * @method static Builder|User whereCreatedAt($value)
 * @method static Builder|User whereEmail($value)
 * @method static Builder|User whereExpiredAt($value)
 * @method static Builder|User whereId($value)
 * @method static Builder|User whereIsPaused($value)
 * @method static Builder|User whereName($value)
 * @method static Builder|User wherePassword($value)
 * @method static Builder|User whereToken($value)
 * @method static Builder|User whereUpdatedAt($value)
 * @property-read Collection $tags_names
 * @property int|null $created_user_id
 * @property string|null $telegram_id
 * @property int $failed_auth_attempts
 * @property string|null $telegram_auth_code
 * @property-read \Illuminate\Database\Eloquent\Collection<int, UserTimestamp> $botTimestamps
 * @property-read int|null $bot_timestamps_count
 * @property-read User|null $createdUser
 * @property-read string|null $role
 * @property-read DatabaseNotificationCollection<int, DatabaseNotification> $notifications
 * @property-read int|null $notifications_count
 * @property-read UserTelegramAttempt|null $telegramAttempt
 * @property-read \Illuminate\Database\Eloquent\Collection<int, UserTelegramBot> $telegramBots
 * @property-read int|null $telegram_bots_count
 * @property-read \Illuminate\Database\Eloquent\Collection<int, UserTelegramInjection> $telegramInjections
 * @property-read int|null $telegram_injections_count
 * @property-read \Illuminate\Database\Eloquent\Collection<int, PersonalAccessToken> $tokens
 * @property-read int|null $tokens_count
 * @property-read Collection|string[] $tagsNames
 * @method static UserFactory factory($count = NULL, $state = [])
 * @method static Builder|User whereCreatedUserId($value)
 * @method static Builder|User whereFailedAuthAttempts($value)
 * @method static Builder|User whereTelegramAuthCode($value)
 * @method static Builder|User whereTelegramId($value)
 * @mixin Eloquent
 */
class User extends Authenticatable
{
    use HasApiTokens, HasFactory, Notifiable, HasRoles;

    /**
     * The attributes that are mass assignable.
     *
     * @var array
     */
    protected $fillable = [
        "name", "email", "expired_at", "is_paused", "token", "created_user_id", "failed_auth_attempts",
    ];

    /**
     * The attributes excluded from the model's JSON form.
     *
     * @var array
     */
    protected $hidden = [
        "password",
    ];


    /**
     * The attributes that should be cast.
     *
     * @var array<string, string>
     */
    protected $casts = [
        "is_paused" => "boolean",
        "expired_at" => "datetime",
    ];

    public function tags(): HasMany
    {
        return $this->hasMany(UserTag::class, "user_id", "id");
    }

    public function entitiesTimestamps(): HasOne
    {
        return $this->hasOne(UserTimestamp::class, "user_id", "id");
    }

    public function botTimestamps(): HasMany
    {
        return $this->hasMany(UserTimestamp::class, "user_id", "id");
    }

    public function telegramInjections(): HasMany
    {
        return $this->hasMany(UserTelegramInjection::class, "user_id", "id");
    }

    public function telegramAttempt(): HasOne
    {
        return $this->hasOne(UserTelegramAttempt::class, "user_id", "id");
    }

    public function createdUser(): HasOne
    {
        return $this->hasOne(User::class, "id", "created_user_id");
    }

    public function getTagsNamesAttribute(): Collection
    {
        return $this->tags->pluck("tag");
    }

    public function getRoleAttribute(): string|null
    {
        return $this->getRoleNames()[0] ?? NULL;
    }

    public function telegramBots(): HasMany
    {
        return $this->hasMany(UserTelegramBot::class, "user_id", "id");
    }
}
