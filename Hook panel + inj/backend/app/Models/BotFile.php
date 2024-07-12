<?php

namespace App\Models;

use Eloquent;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Support\Carbon;

/**
 * App\Models\BotFile
 *
 * @property int $id
 * @property string $bot_id
 * @property string $path
 * @property array $content
 * @property Carbon|null $created_at
 * @property Carbon|null $updated_at
 * @property string|null $stored_file_path
 * @method static Builder|BotFile newModelQuery()
 * @method static Builder|BotFile newQuery()
 * @method static Builder|BotFile query()
 * @method static Builder|BotFile whereBotId($value)
 * @method static Builder|BotFile whereContent($value)
 * @method static Builder|BotFile whereCreatedAt($value)
 * @method static Builder|BotFile whereId($value)
 * @method static Builder|BotFile wherePath($value)
 * @method static Builder|BotFile whereStoredFilePath($value)
 * @method static Builder|BotFile whereUpdatedAt($value)
 * @mixin Eloquent
 */
class BotFile extends Model
{
    protected $casts = [
        "content" => "array",
    ];

    protected $fillable = [
        "bot_id ",
        "path",
        "content",
        "stored_file_path",
        "created_at",
        "updated_at",
    ];
}
