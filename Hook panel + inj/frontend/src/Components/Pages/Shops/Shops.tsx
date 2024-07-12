import React from "react";
import BotLogsPageRender from "../../Misc/BotLogsPageRender";
import {useTranslation} from "react-i18next";

const Shops: React.FC = () => {
    const {t} = useTranslation();
    return <BotLogsPageRender type={"shops"} title={t("SIDEBAR_NAV_SHOPS")} />;
};

export default Shops;
