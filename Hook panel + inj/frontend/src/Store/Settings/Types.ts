export const CHANGE_THEME = "CHANGE_THEME";
export const CHANGE_LOCALE = "CHANGE_LOCALE";

export type IThemes = "dark" | "light";
export type ILocales = "ru" | "en" | "de";

export interface SettingsState {
    theme: IThemes;
    locale: ILocales;
}

export interface ChangeThemePayload {
    theme: IThemes,
}

export interface ChangeThemeAction {
    type: typeof CHANGE_THEME,
    payload: ChangeThemePayload,
}

export interface ChangeLocalePayload {
    locale: ILocales,
}

export interface ChangeLocaleAction {
    type: typeof CHANGE_LOCALE,
    payload: ChangeLocalePayload,
}

export type SettingsActionTypes = ChangeThemeAction | ChangeLocaleAction;
