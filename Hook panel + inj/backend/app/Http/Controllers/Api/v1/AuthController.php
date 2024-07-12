<?php

namespace App\Http\Controllers\Api\v1;

use App\Helpers\ApiResponse;
use App\Http\Controllers\Controller;
use App\Http\Resources\User\UserResource;
use App\Models\User;
use App\Services\AuthService\AuthService;
use Carbon\Carbon;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use Illuminate\Validation\ValidationException;
use Psr\Log\LoggerInterface;

class AuthController extends Controller
{
    public function __construct(
        protected AuthService $authService,
    )
    {
    }

    /**
     * Authorize user
     *
     * @throws ValidationException
     */
    public function login(Request $request): ApiResponse
    {
        $this->validate($request, [
            'token' => 'required|string',
            'password' => 'required|string',
        ]);

        $credentials = $request->only(["token", "password"]);
        $authUser = $this->authService->login($credentials);
        $authToken = $this->authService->createToken($authUser)->plainTextToken;

        return $this->respondWithToken($authToken);

    }

    /**
     * Get user details.
     */
    public function me(): ApiResponse
    {
        return ApiResponse::success([
            "user" => UserResource::make(auth("sanctum")->user())->toArray(),
        ]);
    }
}
