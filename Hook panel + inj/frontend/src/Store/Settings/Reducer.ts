import {
    CHANGE_LOCALE,
    CHANGE_THEME,
    ChangeLocalePayload,
    ChangeThemePayload,
    ILocales,
    IThemes,
    SettingsActionTypes,
    SettingsState,
} from "./Types";

if (!localStorage.getItem("i18nextLng")) {
    localStorage.setItem("i18nextLng", navigator.language.split("-")[0]);
}

if (!localStorage.getItem("theme")) {
    localStorage.setItem("theme", "light");
}

const initialState: SettingsState = {
    theme: localStorage.getItem("theme") as IThemes,
    locale: localStorage.getItem("i18nextLng") as ILocales,
};

const changeTheme = (state: SettingsState, payload: ChangeThemePayload): SettingsState => {
    localStorage.setItem("theme", payload.theme);

    return {
        ...state,
        theme: payload.theme,
    };
};

const changeLocale = (state: SettingsState, payload: ChangeLocalePayload): SettingsState => {
    localStorage.setItem("i18nextLng", payload.locale);

    return {
        ...state,
        locale: payload.locale,
    };
};

const SettingsReducer = (state: SettingsState = initialState, action: SettingsActionTypes): SettingsState => {
    switch (action.type) {
    case CHANGE_THEME:
        return changeTheme(state, action.payload);
    case CHANGE_LOCALE:
        return changeLocale(state, action.payload);
    default:
        return state;
    }
};

export default SettingsReducer;
