<?php

namespace App\Http\Middleware;

use Carbon\Carbon;
use Closure;
use Illuminate\Auth\AuthenticationException;
use Illuminate\Auth\Middleware\Authenticate as Middleware;
use Illuminate\Http\Request;

class Authenticate extends Middleware
{
    /**
     * Handle an incoming request.
     *
     * @param Request $request
     * @param Closure $next
     * @param mixed ...$guards
     * @return mixed
     * @throws AuthenticationException
     */
    public function handle($request, Closure $next, ...$guards): mixed
    {
        $this->authenticate($request, $guards);

        if (auth()->guest()) {
            return response()->json([
                'error' => 'Unauthorized',
            ], 401);
        }

        if (auth()->user()->is_paused) {
            return response()->json([
                'error' => 'Your token suspended. Refresh page.',
            ], 401);
        }

        if (auth()->user()?->expired_at !== null && auth()->user()?->expired_at <= Carbon::now()) {
            return response()->json([
                'error' => 'Your token expired. Refresh page.',
            ], 401);
        }

        return $next($request);
    }
}
