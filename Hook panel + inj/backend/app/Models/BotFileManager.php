<?php

namespace App\Models;

use Eloquent;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Support\Carbon;

/**
 * App\Models\BotFileManager
 *
 * @property int $id
 * @property string $bot_id
 * @property array $info
 * @property Carbon|null $created_at
 * @property Carbon|null $updated_at
 * @method static Builder|BotFileManager newModelQuery()
 * @method static Builder|BotFileManager newQuery()
 * @method static Builder|BotFileManager query()
 * @method static Builder|BotFileManager whereBotId($value)
 * @method static Builder|BotFileManager whereCreatedAt($value)
 * @method static Builder|BotFileManager whereId($value)
 * @method static Builder|BotFileManager whereInfo($value)
 * @method static Builder|BotFileManager whereUpdatedAt($value)
 * @mixin Eloquent
 */
class BotFileManager extends Model
{
    protected $table = 'bot_filemanager';

    protected $casts = [
        'info' => 'array',
    ];
}
