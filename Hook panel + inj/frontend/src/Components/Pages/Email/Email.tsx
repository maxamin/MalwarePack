import React from "react";
import BotLogsPageRender from "../../Misc/BotLogsPageRender";
import {useTranslation} from "react-i18next";

const Email: React.FC = () => {
    const {t} = useTranslation();
    return <BotLogsPageRender type={"emails"} title={t("SIDEBAR_NAV_EMAIL")} />;
};

export default Email;
