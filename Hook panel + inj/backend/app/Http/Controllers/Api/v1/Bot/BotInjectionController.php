<?php

namespace App\Http\Controllers\Api\v1\Bot;

use App\Helpers\ApiResponse;
use App\Http\Controllers\Controller;
use App\Http\Resources\Bot\BotResource;
use App\Models\Bot;
use App\Models\BotInjection;
use Exception;
use Illuminate\Http\Request;
use Illuminate\Validation\ValidationException;

class BotInjectionController extends Controller
{
    /**
     * @throws ValidationException
     */
    public function update(Bot $bot, Request $request): ApiResponse
    {
        $this->validate($request, [
            'application' => 'required|string|exists:injections,application',
            'is_active' => 'required|boolean',
        ]);

        try {
            $botInjection = BotInjection::where('bot_id', $bot->id)
                ->where('application', $request->get('application'))
                ->firstOrFail();
        } catch (Exception) {
            return ApiResponse::error('Bot inject not found');
        }

        $botInjection->update([
            'is_active' => $request->get('is_active'),
        ]);

        $bot->update([
            'update_settings' => true,
        ]);

        return ApiResponse::success(BotResource::make($bot));
    }
}
