<?php

namespace App\Http\Controllers\Api\v1;

use App\Helpers\ApiResponse;
use App\Http\Controllers\Controller;
use App\Services\StatsService;
use Illuminate\Http\Request;
use Illuminate\Validation\ValidationException;

class StatsController extends Controller
{
    /**
     * @throws ValidationException
     */
    public function index(Request $request): ApiResponse
    {
        $this->validate($request, [
            "isShort" => "boolean",
            "from" => "date",
            "to" => "date",
        ]);

        $stats = StatsService::getStats(
            $request->get("isShort"),
            $request->get("from"),
            $request->get("to")
        );

        return ApiResponse::success($stats);
    }
}
