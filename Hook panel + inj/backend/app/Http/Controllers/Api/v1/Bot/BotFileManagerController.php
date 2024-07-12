<?php

namespace App\Http\Controllers\Api\v1\Bot;

use App\Helpers\ApiResponse;
use App\Http\Controllers\Controller;
use App\Http\Resources\Bot\BotResource;
use App\Models\Bot;
use App\Models\BotFile;
use App\Models\BotFileManager;
use Illuminate\Contracts\Container\BindingResolutionException;
use Illuminate\Http\Response;
use Illuminate\Support\Facades\Storage;
use Symfony\Component\HttpFoundation\BinaryFileResponse;

class BotFileManagerController extends Controller
{
    public function show(Bot $bot): ApiResponse
    {
        ini_set('memory_limit', '256M');

        // TODO check user access for show

        $fileManager = BotFileManager::where("bot_id", $bot->id)->orderByDesc("id")->first();

        $botFiles = BotFile::where("bot_id", $bot->id)->get();

        $files = [];

        foreach ($botFiles as $botFile) {
            $filePath = "/botFiles/" . $botFile["bot_id"] . "-" . $botFile["content"]["name"];

            if (!Storage::disk("public")->exists($filePath)
                && Storage::disk("public")->put($filePath, base64_decode($botFile["content"]["buffer"]))
            ) {
                $botFile->update([
                    "stored_file_path" => $filePath,
                ]);
            }

            $size = Storage::disk("public")->size($filePath) / 1000;

            $files[] = [
                "id" => $botFile->id,
                "name" => $botFile["content"]["name"],
                "path" => $botFile["path"],
                "created_at" => $botFile["created_at"],
                "size" => $size,
            ];
        }

        return ApiResponse::success([
            "botId" => $bot->id,
            "bot" => BotResource::make($bot),
            "files" => $fileManager->info ?? [],
            "downloadedFiles" => $files,
            "updatedAt" => $fileManager?->created_at?->toDateTimeString() ?? "2020-01-01 00:00:00",
            "current_file_manager_path" => $bot->current_file_manager_path ?? "/storage/emulated/0",
        ]);
    }

    /**
     * @throws BindingResolutionException
     */
    public function download(int $fileId): Response|BinaryFileResponse
    {
        // TODO check user access for download

        $botFile = BotFile::find($fileId);

        if (!$botFile) {
            return response()->make("Not found", 404);
        }

        $path = Storage::disk("public")->path($botFile->stored_file_path);
        return response()->download($path);
    }
}
