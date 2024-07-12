<?php

namespace App\Http\Resources\BotCommand;

use App\Http\Resources\BaseResource;

class BotCommandResource extends BaseResource
{
    public function toArray($request = NULL): array
    {
        return [
            'id' => $this->id,
            'bot_id' => $this->bot_id,
            'command' => $this->command,
            'is_processed' => $this->is_processed,
            'created_at' => $this->created_at?->format('Y-m-d H:i:s'),
            'updated_at' => $this->updated_at?->format('Y-m-d H:i:s'),
        ];
    }
}
