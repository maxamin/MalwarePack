<?php

namespace App\Http\Resources\BotLog;

use App\Http\Resources\BaseResource;
use App\Models\Injection;
use App\Services\LogsService\LogsService;
use Throwable;

class BotLogResource extends BaseResource
{
    public function toArray($request = NULL): array
    {
        $logs = LogsService::getArrayLog($this->log);

        return [
            'id' => $this->id,
            'bot_id' => $this->bot_id,
            'type' => $this->type,
            'application' => $this->application,
            'log' => $logs,
            'created_at' => $this->created_at?->format('Y-m-d H:i:s'),
            'updated_at' => $this->updated_at?->format('Y-m-d H:i:s'),
            'comment' => $this->comment,
            'bot' => $this->relationLoaded("bot") ? $this->bot : NULL,
        ];
    }
}
