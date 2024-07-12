<?php

namespace App\Http\Controllers;

use App\Helpers\ApiResponse;
use App\Http\Resources\User\UserResource;
use Illuminate\Foundation\Auth\Access\AuthorizesRequests;
use Illuminate\Foundation\Validation\ValidatesRequests;
use Illuminate\Routing\Controller as BaseController;

class Controller extends BaseController
{
    use AuthorizesRequests, ValidatesRequests;

    public function respondWithToken(string $token): ApiResponse
    {
        return ApiResponse::success([
            'token' => $token,
            'token_type' => 'bearer',
            'expires_in' => NULL,
            'user' => UserResource::make(auth()->user()),
        ]);

    }
}
