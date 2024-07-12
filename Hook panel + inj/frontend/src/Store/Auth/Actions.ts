import {
    AUTH_CHECK,
    AUTH_LOGIN,
    AUTH_LOGOUT, AuthFormStatesType,
    AuthTypes, CHANGE_FORM_STATE, UPDATE_USER_TELEGRAM_BOT,
    UPDATE_USER_TELEGRAM_INJECTION, UpdateUserTelegramBotPayload,
    UpdateUserTelegramInjectionPayload,
} from "./Types";
import {User} from "../../Model/User";
import loginRequest from "../../Requests/Login/LoginRequest";
import meRequest from "../../Requests/Me/MeRequest";
import updateUserTelegramInjectionRequest from "../../Requests/Users/UpdateUserTelegramInjectionRequest";
import updateUserTelegramBotRequest from "../../Requests/Users/UpdateUserTelegramBotRequest";

export const authorizeAction = (token: string, user: User): AuthTypes => {
    return {
        type: AUTH_LOGIN,
        payload: {
            token: token,
            user: user,
        },
    };
};

export const authorize = (token: string, password: string) => {
    return loginRequest(token, password);
};

export const authorizeCheckAction = (token: string|null, user: User, isAuthorized: boolean): AuthTypes => {
    return {
        type: AUTH_CHECK,
        payload: {
            token: token,
            user: user,
            isAuthorized: isAuthorized,
        },
    };
};

export const updateUserTelegramInjectionAction = (payload: UpdateUserTelegramInjectionPayload): AuthTypes => {
    return {
        type: UPDATE_USER_TELEGRAM_INJECTION,
        payload: payload,
    };
};

export const updateUserTelegramBotAction = (payload: UpdateUserTelegramBotPayload): AuthTypes => {
    return {
        type: UPDATE_USER_TELEGRAM_BOT,
        payload: payload,
    };
};

export const authorizeCheck = (token: string|null) => {
    return meRequest(token);
};

export const logout = (): AuthTypes => {
    return {
        type: AUTH_LOGOUT,
    };
};

export const changeFormState = (state: AuthFormStatesType): AuthTypes => {
    return {
        type: CHANGE_FORM_STATE,
        payload: {
            state: state,
        },
    };
};

export const updateUserTelegramInjection = (application: string, isActive: boolean, botId: string) => {
    return updateUserTelegramInjectionRequest(application, isActive, botId);
};

export const updateUserTelegramBot = (isActive: boolean, botId: string) => {
    return updateUserTelegramBotRequest(isActive, botId);
};
