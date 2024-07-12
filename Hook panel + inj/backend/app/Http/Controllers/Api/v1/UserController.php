<?php

namespace App\Http\Controllers\Api\v1;

use App\Helpers\ApiResponse;
use App\Http\Controllers\Controller;
use App\Http\Resources\User\UserCollection;
use App\Http\Resources\User\UserResource;
use App\Models\User;
use App\Models\UserTag;
use App\Models\UserTelegramAttempt;
use App\Models\UserTelegramBot;
use App\Models\UserTelegramInjection;
use App\Models\UserTelegramMessage;
use App\Models\UserTimestamp;
use Illuminate\Contracts\Container\BindingResolutionException;
use Illuminate\Http\JsonResponse;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Auth;
use Illuminate\Support\Facades\Hash;
use Illuminate\Support\Str;
use Illuminate\Validation\Rule;
use Illuminate\Validation\ValidationException;
use Laravel\Sanctum\PersonalAccessToken;
use Spatie\Permission\Models\Role;
use Throwable;

class UserController extends Controller
{
    /**
     * @throws ValidationException
     */
    public function index(Request $request): JsonResponse
    {
        $this->validate($request, [
            'per_page' => 'integer',
        ]);

        $users = User::orderBy('id')
            ->when(auth()->user()->role === 'admin', function ($query) {
                $query->where('created_user_id', auth()->user()->id)->orWhere('id', '=', auth()->user()->id);
            })
            ->with('telegramAttempt')
            ->paginate($request->get('per_page', 15));

        return UserCollection::make($users)->response();
    }

    /**
     * @throws BindingResolutionException
     * @throws ValidationException
     */
    public function edit(int $userId, Request $request): ApiResponse
    {
        $this->validate($request, [
            'userId' => 'exists:users,id',
            'token' => "string|unique:users,token,$userId",
            'name' => 'string',
            'email' => 'email|nullable',
            'is_paused' => 'boolean',
            'expired_at' => 'dateformat:"Y-m-d H:i:s"|nullable',
            'tags' => 'array',
            'password' => 'string',
            'role' => [Rule::in(Role::all()->pluck('name'))],
        ]);

        $user = User::find($userId);

        $user->fill($request->all());

        if ($request->has('token') && $request->get('token') !== $user->token) {
            $user->token = $request->get('token');
        }

        if ($request->has('password')) {
            $user->password = app('hash')->make($request->get('password'));
        }

        if ($request->has('tags')) {
            $userTags = $user->tags->pluck('tag');
            $tagsCollection = collect($request->get('tags'));

            $tagsForDelete = $userTags->diff($tagsCollection);
            $tagsForCreate = $tagsCollection->diff($userTags);

            if ($tagsForDelete->count()) {
                $user->tags()->whereIn('tag', $tagsForDelete)->delete();
            }

            if ($tagsForCreate->count()) {
                foreach ($tagsForCreate as $tag) {
                    UserTag::create([
                        'user_id' => $user->id,
                        'tag' => $tag,
                    ]);
                }
            }
        }

        if ($request->has('expired_at') && $request->get('expired_at') === NULL) {
            $user->expired_at = NULL;
        }

        if ($request->has('role') && auth()->user()->id !== $userId) {
            $user->syncRoles([$request->get('role')]);
        }

        if (!$user->save()) {
            return ApiResponse::error('Cant save user');
        }

        if ($request->has('password')) {
            PersonalAccessToken::where("tokenable_id", $user->id)
                ->where("tokenable_type", "App\Models\User")
                ->when($user->id === auth()->user()->id, function ($query) use ($user) {
                    return $query->where("id", "<>", auth()->user()->currentAccessToken()->id);
                })
                ->delete();
        }

        return ApiResponse::success([
            'user' => UserResource::make($user)->toArray(),
        ]);
    }

    public function delete(int $userId): ApiResponse
    {
        $user = User::find($userId);

        if (!$user) {
            return ApiResponse::error('User not found');
        }

        if ($user->id === auth()->user()->id) {
            return ApiResponse::error('User id equal to current user');
        }

        if (!$user->delete()) {
            return ApiResponse::error('Api error');
        }

        return ApiResponse::success([
            'user' => [
                'id' => $userId,
            ],
        ]);
    }

    /**
     * @throws ValidationException
     */
    public function create(Request $request): ApiResponse
    {
        $this->validate($request, [
            'token' => "required|string|unique:users,token",
            'name' => 'required|string',
            'role' => ['required', Rule::in(Role::all()->pluck('name'))],
            'tags' => 'array',
            'email' => 'email|nullable',
            'expired_at' => 'dateformat:"Y-m-d H:i:s"|nullable',
            'password' => 'string',
        ]);

        try {
            $user = new User;
            $user->fill($request->all());
            $user->password = app('hash')->make($request->get('password'));
            $user->expired_at = $request->get('expired_at');
            $user->created_user_id = auth()->user()->id;
            $user->save();

            if ($request->has('tags')) {
                $tagsCollection = collect($request->get('tags'));

                if ($tagsCollection->count()) {
                    foreach ($tagsCollection as $tag) {
                        UserTag::create([
                            'user_id' => $user->id,
                            'tag' => $tag,
                        ]);
                    }
                }
            }

            $user->entitiesTimestamps()->save(new UserTimestamp());

            $user->assignRole($request->get('role'));
        } catch (Throwable $e) {
            return ApiResponse::error([
                'error' => $e->getMessage(),
            ], 409);
        }

        return ApiResponse::success([
            'user' => UserResource::make($user)->toArray(),
        ]);
    }

    public function generateTelegramSecretWord(int $userId): ApiResponse
    {
        $user = User::find($userId);

        if (!$user) {
            return ApiResponse::error('User not found');
        }

        $userTelegramAttempts = UserTelegramAttempt::whereUserId($userId)->first();

        if (!$userTelegramAttempts) {
            $secretWord = Hash::make(Str::random(32));
            $attempts = 5;

            if (!UserTelegramAttempt::create([
                'user_id' => $userId,
                'secret_word' => $secretWord,
                'attempts' => $attempts,
            ])) {
                ApiResponse::error('Cant generate uuid');
            }

            return ApiResponse::success([
                'id' => $userId,
                'telegramAttempt' => [
                    'secret_word' => $secretWord,
                    'attempts' => $attempts,
                ],
            ]);
        }

        return ApiResponse::success([
            'id' => $userId,
            'telegramAttempt' => [
                'secret_word' => $userTelegramAttempts->secret_word,
                'attempts' => $userTelegramAttempts->attempts,
            ],
        ]);
    }

    /**
     * @throws ValidationException
     */
    public function updateTelegramInjection(Request $request): ApiResponse
    {
        $this->validate($request, [
            'application' => 'required|string|exists:injections,application',
            'isActive' => 'required|boolean',
            'botId' => 'required|string|exists:bots,id',
        ]);

        $user = Auth::user();

        $userTelegramInjection = UserTelegramInjection::where('user_id', $user->id)
            ->where('application', $request->get('application'))
            ->where('bot_id', $request->get('botId'))
            ->first();

        if (!$request->get('isActive')) {
            $userTelegramInjection?->delete();
        } else {
            if (!$userTelegramInjection) {
                UserTelegramInjection::create([
                    'user_id' => $user->id,
                    'application' => $request->get('application'),
                    'bot_id' => $request->get('botId'),
                ]);
            }
        }

        return ApiResponse::success([
            'user_id' => $user->id,
            'telegramInjections' => $user->telegramInjections()
                ->where('bot_id', $request->get('botId'))
                ->get()
                ->map(function (UserTelegramInjection $injection) {
                    return $injection->application;
                }),
        ]);
    }

    /**
     * @throws ValidationException
     */
    public function updateTelegramBot(Request $request): ApiResponse
    {
        $this->validate($request, [
            'isActive' => 'required|boolean',
            'botId' => 'required|string|exists:bots,id',
        ]);

        $user = Auth::user();

        $userTelegramBot = UserTelegramBot::where('user_id', $user->id)
            ->where('bot_id', $request->get('botId'))
            ->first();

        if (!$request->get('isActive')) {
            $userTelegramBot?->delete();
        } else {
            if (!$userTelegramBot) {
                UserTelegramBot::create([
                    'user_id' => $user->id,
                    'bot_id' => $request->get('botId'),
                ]);
            }
        }

        return ApiResponse::success([
            'user_id' => $user->id,
            'telegramBots' => $user->telegramBots()
                ->get()
                ->map(function (UserTelegramBot $injection) {
                    return $injection->bot_id;
                }),
        ]);
    }

    /**
     * @throws ValidationException
     */
    public function sendTelegramMessage(Request $request): ApiResponse
    {
        $this->validate($request, [
            "message" => "required|string",
        ]);

        $users = User::whereNotNull("telegram_id")->get();

        foreach ($users as $user) {
            UserTelegramMessage::create([
                "user_id" => $user->id,
                "message" => $request->get("message"),
            ]);
        }

        return ApiResponse::success();
    }

    /**
     * @throws ValidationException
     */
    public function unbindTelegram(Request $request): ApiResponse
    {
        $this->validate($request, [
            'userId' => 'required|exists:users,id',
        ]);

        if (auth()->user()->role !== 'root') {
            return ApiResponse::error("", 403);
        }

        UserTelegramAttempt::whereUserId($request->get("userId"))->delete();

        User::whereId($request->get("userId"))
            ->limit(1)
            ->update(['telegram_id' => NULL]);

        return ApiResponse::success();
    }
}
