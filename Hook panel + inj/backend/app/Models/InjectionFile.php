<?php

namespace App\Models;

use Eloquent;
use Illuminate\Database\Eloquent\Builder;
use Illuminate\Database\Eloquent\Model;

/**
 * App\Models\InjectionFile
 *
 * @property int $injection_id
 * @property mixed|null $html_blob
 * @property mixed|null $image_blob
 * @method static Builder|InjectionFile newModelQuery()
 * @method static Builder|InjectionFile newQuery()
 * @method static Builder|InjectionFile query()
 * @method static Builder|InjectionFile whereHtmlBlob($value)
 * @method static Builder|InjectionFile whereImageBlob($value)
 * @method static Builder|InjectionFile whereInjectionId($value)
 * @mixin Eloquent
 */
class InjectionFile extends Model
{
    public $timestamps = false;

    protected $fillable = [
        "image_blob",
        "html_blob",
    ];
}
