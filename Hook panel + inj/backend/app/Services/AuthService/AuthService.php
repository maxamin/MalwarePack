<?php

namespace App\Services\AuthService;

use App\Models\User;
use Exception;
use Illuminate\Support\Carbon;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\Validator;
use Illuminate\Validation\ValidationException;
use Laravel\Sanctum\NewAccessToken;
use Laravel\Sanctum\PersonalAccessToken;
use Psr\Log\LoggerInterface;
use Throwable;

class AuthService
{
    public const TOKEN_DEFAULT = "default";

    public function __construct(
        protected LoggerInterface $logger,
    )
    {
    }

    /**
     * @throws ValidationException
     * @throws Throwable
     */
    public function login(array $credentials): User
    {
        Validator::make($credentials, [
            "token" => ["required", "string"],
            "password" => ["required", "string"],
        ])->validate();

        $user = User::whereToken($credentials["token"])->first();

        if (!$user) {
            throw new Exception("Bad token or password", 401);
        }

        if ($user->failed_auth_attempts >= config("auth.attempts", 5)) {
            if ($user->telegram_id) {
                throw new Exception("Attempts exceeded", 406);
            }
            throw new Exception("Attempts exceeded", 406);
        }

        if ($user->is_paused) {
            throw new Exception("Your token suspended", 403);
        }

        if ($user->expired_at !== null && $user?->expired_at <= Carbon::now()) {
            throw new Exception("Your token expired", 403);
        }

        if (!Auth::attempt($credentials)) {
            $user->update([
                "failed_auth_attempts" => $user->failed_auth_attempts + 1,
            ]);
            throw new Exception("Bad token or password", 401);
        }

        $user->update([
            "failed_auth_attempts" => 0,
        ]);

        if (!auth()->validate($credentials)) {
            throw new Exception("BadCredentialsException");
        }

        return $user;
    }

    public function createToken(User $user): NewAccessToken
    {
        return $user->createToken(self::TOKEN_DEFAULT);
    }

    public function logout(User $user): void
    {
        $token = $user->currentAccessToken();

        if (!$token instanceof PersonalAccessToken) {
            $token = $user->tokens()
                ->where("name", self::TOKEN_DEFAULT)
                ->first();
        }

        $token?->delete();
    }
}
