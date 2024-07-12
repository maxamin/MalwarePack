import {
    AUTH_CHECK,
    AUTH_LOGIN,
    AUTH_LOGOUT,
    AuthCheckPayload,
    AuthState,
    AuthTypes,
    CHANGE_FORM_STATE,
    ChangeFormStatePayload,
    UPDATE_USER_TELEGRAM_BOT,
    UPDATE_USER_TELEGRAM_INJECTION, UpdateUserTelegramBotPayload,
    UpdateUserTelegramInjectionPayload,
} from "./Types";
import {User} from "../../Model/User";
import {errorNotify, successNotify} from "../../Util/config";
import i18next from "i18next";
import update from "react-addons-update";

const initialState: AuthState = {
    isAuthorized: false,
    user: {} as User,
    token: null,
    isLoaded: false,
    formState: "login",
};

const authorize = (state: AuthState, user: User, token: string): AuthState => {
    localStorage.setItem("token", token);
    successNotify(i18next.t("AUTHORIZATION"), i18next.t("SUCCESS"));

    return {
        user: user,
        token: token,
        isAuthorized: true,
        isLoaded: true,
        formState: "login",
    };
};

const checkAuth = (state: AuthState, payload: AuthCheckPayload): AuthState => {
    if (!payload.isAuthorized && payload.token) {
        errorNotify(i18next.t("AUTHORIZATION"), "Bad token");
        localStorage.removeItem("token");
    }

    return {
        ...state,
        ...payload,
        isLoaded: true,
    };
};

const logout = () => {
    localStorage.removeItem("token");
    successNotify(i18next.t("LOGOUT"), i18next.t("SUCCESS"));
    return {
        ...initialState,
        isLoaded: true,
    };
};

const updateUserTelegramInjection = (state: AuthState, payload: UpdateUserTelegramInjectionPayload): AuthState => {
    return update(state, {
        user: {
            "telegramInjections": {
                [payload.bot_id]: {
                    $set: payload.injections,
                },
            },
        },
    });
};

const updateUserTelegramBot = (state: AuthState, payload: UpdateUserTelegramBotPayload): AuthState => {
    return update(state, {
        user: {
            "telegramBots": {
                $set: payload.telegramBots,
            },
        },
    });
};

const changeFormState = (state: AuthState, payload: ChangeFormStatePayload): AuthState => {
    return {
        ...state,
        formState: payload.state,
    };
};

const AuthReducer = (state: AuthState = initialState, action: AuthTypes): AuthState => {
    switch (action.type) {
    case AUTH_LOGIN:
        return authorize(state, action.payload.user, action.payload.token);
    case AUTH_CHECK:
        return checkAuth(state, action.payload);
    case AUTH_LOGOUT:
        return logout();
    case UPDATE_USER_TELEGRAM_INJECTION:
        return updateUserTelegramInjection(state, action.payload);
    case UPDATE_USER_TELEGRAM_BOT:
        return updateUserTelegramBot(state, action.payload);
    case CHANGE_FORM_STATE:
        return changeFormState(state, action.payload);
    default:
        return state;
    }
};

export default AuthReducer;
