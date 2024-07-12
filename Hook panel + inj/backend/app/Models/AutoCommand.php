<?php

namespace App\Models;

use Eloquent;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Eloquent\Model;
use Illuminate\Support\Carbon;

/**
 * App\Models\AutoCommand
 *
 * @property int $id
 * @property array|null $data
 * @property Carbon|null $created_at
 * @property Carbon|null $updated_at
 * @method static Builder|AutoCommand newModelQuery()
 * @method static Builder|AutoCommand newQuery()
 * @method static Builder|AutoCommand query()
 * @method static Builder|AutoCommand whereCreatedAt($value)
 * @method static Builder|AutoCommand whereData($value)
 * @method static Builder|AutoCommand whereId($value)
 * @method static Builder|AutoCommand whereUpdatedAt($value)
 * @mixin Eloquent
 */
class AutoCommand extends Model
{
    protected $casts = [
        "data" => "json",
    ];

    protected $fillable = [
        "data",
    ];
}
