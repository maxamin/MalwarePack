<?php

namespace App\Http\Resources\User;

use App\Http\Resources\BaseResource;
use App\Models\Bot;
use App\Models\UserTelegramBot;
use Illuminate\Support\Collection;

class UserResource extends BaseResource
{
    public function toArray($request = NULL): array
    {
        $permissions = collect($this->getAllPermissions())
            ->pluck("name")
            ->toArray();

        $isAuthorizedUser = auth()->user()->id === $this->id;

        $this->load("createdUser");

        if ($isAuthorizedUser) {
            $this->load("telegramInjections");
            $this->load("telegramBots");
        }

        if (auth()->user()->role === 'root') {
            $this->load("telegramAttempt");
        }

        $tags = $this->tags->pluck("tag");

        if($this->role === "root") {
            $tags = Bot::select("tag")->groupBy("tag")->get()->pluck("tag");
        }

        return [
            "id" => $this->id,
            "name" => $this->name,
            "token" => $this->token,
            "email" => $this->email,
            "is_paused" => $this->is_paused,
            "expired_at" => $this->expired_at?->format("Y-m-d H:i:s"),
            "created_at" => $this->created_at?->format("Y-m-d H:i:s"),
            "updated_at" => $this->updated_at?->format("Y-m-d H:i:s"),
            "role" => $this->getRoleNames()->first(),
            "tags" => $tags,
            "permissions" => $permissions,
            "telegramAttempt" => $this->relationLoaded("telegramAttempt") ? $this->telegramAttempt : [],
            "telegram_id" => $this->telegram_id,
            "createdUser" => $this->createdUser ? [
                "id" => $this->createdUser->id,
                "name" => $this->createdUser->name,
            ] : NULL,
            "telegramInjections" => $this->relationLoaded("telegramInjections") ? $this->telegramInjections
                ->groupBy("bot_id")->map(function (Collection $collection) {
                    return $collection->pluck("application");
                }) : [],
            "telegramBots" => $this->relationLoaded("telegramBots") ? $this->telegramBots
                ->map(function (UserTelegramBot $bot) {
                    return $bot->bot_id;
                }) : [],
        ];
    }
}
