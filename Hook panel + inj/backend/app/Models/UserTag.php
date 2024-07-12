<?php

namespace App\Models;

use Eloquent;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Eloquent\Model;

/**
 * App\Models\UserTag
 *
 * @property int $id
 * @property int $user_id
 * @property string $tag
 * @method static Builder|UserTag newModelQuery()
 * @method static Builder|UserTag newQuery()
 * @method static Builder|UserTag query()
 * @method static Builder|UserTag whereId($value)
 * @method static Builder|UserTag whereTag($value)
 * @method static Builder|UserTag whereUserId($value)
 * @mixin Eloquent
 */
class UserTag extends Model
{
    public $timestamps = false;

    protected $fillable = [
        "user_id",
        "tag",
    ];
}
