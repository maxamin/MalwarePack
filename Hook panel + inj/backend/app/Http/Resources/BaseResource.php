<?php

namespace App\Http\Resources;

use Illuminate\Http\JsonResponse;
use Illuminate\Http\Resources\Json\JsonResource;
use Symfony\Component\HttpFoundation\Response;

abstract class BaseResource extends JsonResource
{
    public static $wrap = 'payload';

    public $additional = [
        'success' => true,
    ];

    protected int $statusCode = Response::HTTP_OK;

    public function toResponse($request): JsonResponse
    {
        return parent::toResponse($request)->setStatusCode($this->statusCode);
    }

    /**
     * Set status code for response
     *
     * Helper to use    Resource::make()->withStatusCode()
     *    instead of    (Resource::make())->response()->setStatusCode()
     */
    public function withStatusCode(int $statusCode): self
    {
        $this->statusCode = $statusCode;
        return $this;
    }

    public function compareStringBoolean(string $field, string $key): bool
    {
        return isset($this->{$field}[$key]) && $this->{$field}[$key] === "true";
    }
}
