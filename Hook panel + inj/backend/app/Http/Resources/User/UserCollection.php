<?php

namespace App\Http\Resources\User;

use App\Http\Resources\BaseCollection;
use App\Models\Bot;
use Spatie\Permission\Models\Role;

class UserCollection extends BaseCollection
{
    public function toArray($request): array
    {
        $user = auth()->user();
        return [
            'tags' => $user?->role === 'root' ? Bot::distinct('tag')->pluck('tag') : $user?->tagsNames,
            'roles' => Role::all()->pluck('name'),
            'users' => parent::toArray($request),
        ];
    }
}
