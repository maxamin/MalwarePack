<?php

namespace App\Http\Response;

use App\Helpers\ApiResponse;
use Symfony\Component\HttpFoundation\Response;

class AccessDeniedResponse
{
    public static function response(): ApiResponse
    {
        return ApiResponse::error("Access denied", Response::HTTP_FORBIDDEN);
    }
}
