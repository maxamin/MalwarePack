import {CHANGE_LOCALE, CHANGE_THEME, ChangeLocalePayload, ChangeThemePayload, SettingsActionTypes} from "./Types";

export const changeTheme = (payload: ChangeThemePayload): SettingsActionTypes => {
    return {
        type: CHANGE_THEME,
        payload: payload,
    };
};

export const changeLocale = (payload: ChangeLocalePayload): SettingsActionTypes => {
    return {
        type: CHANGE_LOCALE,
        payload: payload,
    };
};
