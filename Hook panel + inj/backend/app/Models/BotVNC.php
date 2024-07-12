<?php

namespace App\Models;

use Eloquent;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Support\Carbon;

/**
 * App\Models\BotVNC
 *
 * @property int $id
 * @property string $bot_id
 * @property array $tree
 * @property Carbon|null $created_at
 * @property Carbon|null $updated_at
 * @property mixed|null $image_blob
 * @method static Builder|BotVNC newModelQuery()
 * @method static Builder|BotVNC newQuery()
 * @method static Builder|BotVNC query()
 * @method static Builder|BotVNC whereBotId($value)
 * @method static Builder|BotVNC whereCreatedAt($value)
 * @method static Builder|BotVNC whereId($value)
 * @method static Builder|BotVNC whereImageBlob($value)
 * @method static Builder|BotVNC whereTree($value)
 * @method static Builder|BotVNC whereUpdatedAt($value)
 * @mixin Eloquent
 */
class BotVNC extends Model
{
    protected $table = "bot_vnc";

    protected $casts = [
        "tree" => "array",
    ];
}
