import React from "react";
import BotLogsPageRender from "../../Misc/BotLogsPageRender";
import {useTranslation} from "react-i18next";

const Crypt: React.FC = () => {
    const {t} = useTranslation();
    return <BotLogsPageRender type={"crypt"} title={t("SIDEBAR_NAV_CRYPT")} />;
};

export default Crypt;
