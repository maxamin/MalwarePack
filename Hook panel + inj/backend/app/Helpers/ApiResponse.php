<?php

namespace App\Helpers;

use Illuminate\Http\JsonResponse;
use Symfony\Component\HttpFoundation\Response;

class ApiResponse extends JsonResponse
{
    public static function success($data = NULL, int $code = Response::HTTP_OK): self
    {
        $result = ['success' => true];

        if ($data) {
            $result['payload'] = $data;
        }

        return new self($result, $code, [], JSON_UNESCAPED_UNICODE);
    }

    public static function error($data = NULL, int $code = Response::HTTP_BAD_REQUEST): self
    {
        $result = ['success' => false];

        if ($data) {
            $result['error'] = $data;
        }

        return new self($result, $code, [], JSON_UNESCAPED_UNICODE);
    }

    public static function unauthorized(): self
    {
        return self::error('Unauthorized', 401);
    }
}
