import {User} from "../../Model/User";
import {UserTelegramInjection} from "../../Model/UserTelegramInjection";
import {UserTelegramBot} from "../../Model/UserTelegramBot";

export const AUTH_LOGIN = "AUTH_LOGIN";
export const AUTH_CHECK = "AUTH_CHECK";
export const AUTH_LOGOUT = "AUTH_LOGOUT";
export const UPDATE_USER_TELEGRAM_INJECTION = "UPDATE_USER_TELEGRAM_INJECTION";
export const UPDATE_USER_TELEGRAM_BOT = "UPDATE_USER_TELEGRAM_BOT";
export const CHANGE_FORM_STATE = "CHANGE_FORM_STATE";

export type AuthFormStatesType = "login" | "telegram" | "error";

export interface AuthState {
    isAuthorized: boolean,
    user: User,
    token: null | string,
    isLoaded: boolean,
    formState: AuthFormStatesType,
}

export interface AuthLoginPayload {
    token: string,
    user: User,
}

export interface AuthLoginAction {
    type: typeof AUTH_LOGIN,
    payload: AuthLoginPayload
}

export interface AuthCheckPayload {
    token: string|null,
    user: User,
    isAuthorized: boolean,
}

export interface AuthCheckAction {
    type: typeof AUTH_CHECK,
    payload: AuthCheckPayload
}

export interface AuthLogoutAction {
    type: typeof AUTH_LOGOUT,
}

export interface UpdateUserTelegramInjectionPayload {
    user_id: number,
    injections: UserTelegramInjection[],
    bot_id: string,
}

export interface UpdateUserTelegramInjectionAction {
    type: typeof UPDATE_USER_TELEGRAM_INJECTION,
    payload: UpdateUserTelegramInjectionPayload,
}

export interface UpdateUserTelegramBotPayload {
    user_id: number,
    telegramBots: UserTelegramBot[],
}

export interface UpdateUserTelegramBotAction {
    type: typeof UPDATE_USER_TELEGRAM_BOT,
    payload: UpdateUserTelegramBotPayload,
}

export interface ChangeFormStatePayload {
    state: AuthFormStatesType,
}

export interface ChangeFormStateAction {
    type: typeof CHANGE_FORM_STATE,
    payload: ChangeFormStatePayload,
}

export type AuthTypes = AuthLoginAction | AuthCheckAction | AuthLogoutAction | UpdateUserTelegramInjectionAction
    | ChangeFormStateAction | UpdateUserTelegramBotAction;
