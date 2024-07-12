<?php

namespace App\Models;

use Eloquent;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Support\Carbon;

/**
 * App\Models\InjectionSession
 *
 * @property int $id
 * @property string $bot_id
 * @property string $application
 * @property array|null $data
 * @property string $session_id
 * @property string $action
 * @property bool $is_closed
 * @property Carbon|null $created_at
 * @property Carbon|null $updated_at
 * @method static Builder|InjectionSession newModelQuery()
 * @method static Builder|InjectionSession newQuery()
 * @method static Builder|InjectionSession query()
 * @method static Builder|InjectionSession whereAction($value)
 * @method static Builder|InjectionSession whereApplication($value)
 * @method static Builder|InjectionSession whereBotId($value)
 * @method static Builder|InjectionSession whereCreatedAt($value)
 * @method static Builder|InjectionSession whereData($value)
 * @method static Builder|InjectionSession whereId($value)
 * @method static Builder|InjectionSession whereIsClosed($value)
 * @method static Builder|InjectionSession whereSessionId($value)
 * @method static Builder|InjectionSession whereUpdatedAt($value)
 * @mixin Eloquent
 */
class InjectionSession extends Model
{
    protected $fillable = [
        "session_id",
        "bot_id",
        "application",
        "data",
        "is_closed",
    ];

    protected $casts = [
        "data" => "array",
        "is_closed" => "boolean",
    ];
}
