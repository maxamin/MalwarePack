import i18n from "i18next";
import LanguageDetector from "i18next-browser-languagedetector";
import {initReactI18next} from "react-i18next";

export interface ILanguage {
    name: string,
    code: string,
}

export type ILanguages = Record<string, ILanguage>;

export const languages: ILanguages = {
    "en": {
        name: "English",
        code: "us",
    },
    "ru": {
        name: "Russian",
        code: "ru",
    },
    "cn": {
        name: "Chinese",
        code: "cn",
    },
};

export default i18n.use(LanguageDetector)
    .use(initReactI18next)
    .init({
        resources: {
            en: require("./Lang/en.json"),
            ru: require("./Lang/ru.json"),
            cn: require("./Lang/cn.json"),
        },
        fallbackLng: "en",
        debug: true,
        lng: localStorage?.getItem("i18nextLng")?.split("-")[0] ?? "us",

        ns: ["translations"],
        defaultNS: "translations",

        keySeparator: false,

        interpolation: {
            escapeValue: false,
        },
        returnNull: false,
    });
