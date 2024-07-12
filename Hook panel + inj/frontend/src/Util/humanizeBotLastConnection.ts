import {useTranslation} from "react-i18next";

export const humanizeBotLastConnection = (time: number) => {
    const {t} = useTranslation();

    if (time <= 60) {
        return `${Math.abs(Math.round(time))} ${t("ONLINE_SEC_AGO")}`;
    } else if (time <= 60*60) {
        return `${Math.abs(Math.round(time / 60))} ${t("ONLINE_MIN_AGO")}`;
    } else if (time <= 60*60*24) {
        return `${Math.abs(Math.round(time / 60 / 60))} ${t("ONLINE_HRS_AGO")}`;
    } else {
        return `${Math.abs(Math.round(time / 60 / 60 / 24))} ${t("ONLINE_DAYS_AGO")}`;
    }
};
