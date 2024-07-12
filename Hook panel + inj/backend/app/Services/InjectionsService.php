<?php

namespace App\Services;

use App\Helpers\ApiResponse;
use App\Models\Injection;
use App\Models\InjectionFile;
use Illuminate\Support\Facades\Storage;
use Throwable;

class InjectionsService
{
    public static function import(): ApiResponse
    {
        $storage = Storage::disk('public');

        foreach ($storage->allFiles('injects/html') as $htmlPath) {
            preg_match("|(?<rootFolder>\S+)/(?<fileType>\S+)/(?<injectType>\S+)/(?<application>\S+).html|Uis", $htmlPath,
                $matches,
                PREG_UNMATCHED_AS_NULL);

            if (!isset($matches['rootFolder'], $matches['injectType'], $matches['application'])) {
                continue;
            }

            $imagePath = "{$matches['rootFolder']}/images/{$matches['injectType']}/{$matches['application']}.png";
            $namePath = "{$matches['rootFolder']}/names/{$matches['injectType']}/{$matches['application']}.txt";

            try {
                $htmlBlob = file_get_contents(base_path() . "/public/$htmlPath");
                $imageBlob = file_get_contents(base_path() . "/public/$imagePath");
                $nameBlob = file_get_contents(base_path() . "/public/$namePath");
            } catch (Throwable) {
                continue;
            }

            $injection = Injection::firstOrNew([
                'application' => $matches['application'],
                'name' => $nameBlob,
            ]);

            $injection->fill([
                'html' => "/$htmlPath",
                'image' => "/$imagePath",
                'type' => $matches['injectType'],
            ]);

            $injection->save();

            if ($injection->save()) {
                $files = InjectionFile::firstOrNew([
                    'injection_id' => $injection->id,
                ]);

                $files->fill([
                    'html_blob' => $htmlBlob,
                    'image_blob' => $imageBlob,
                ]);

                $files->save();
            }
        }

        return ApiResponse::success();
    }

    public static function export(): ApiResponse
    {
        $storage = Storage::disk('public');

        $injections = Injection::with('files')->get();

        foreach ($injections as $inject) {
            $storage->put("injects/html/$inject->type/$inject->application.html", $inject->files->html_blob);
            $storage->put("injects/images/$inject->type/$inject->application.png", $inject->files->image_blob);
            $storage->put("injects/names/$inject->type/$inject->application.txt", $inject->name);
        }

        return ApiResponse::success();
    }
}
