<?php

namespace App\Http\Resources;

use Illuminate\Http\Resources\Json\ResourceCollection;

abstract class BaseCollection extends ResourceCollection
{
    public static $wrap = 'payload';

    public $additional = [
        'success' => true,
    ];
}
