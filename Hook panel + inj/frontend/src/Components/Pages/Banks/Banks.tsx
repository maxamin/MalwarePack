import React from "react";


import BotLogsPageRender from "../../Misc/BotLogsPageRender";
import {useTranslation} from "react-i18next";

const Banks: React.FC = () => {
    const {t} = useTranslation();

    return <BotLogsPageRender type={"banks"} title={t("SIDEBAR_NAV_BANKS")} />;
};

export default Banks;
