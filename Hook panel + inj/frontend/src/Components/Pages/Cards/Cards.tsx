import React from "react";
import BotLogsPageRender from "../../Misc/BotLogsPageRender";
import {useTranslation} from "react-i18next";

const Cards: React.FC = () => {
    const {t} = useTranslation();
    return <BotLogsPageRender type={"credit_cards"} title={t("SIDEBAR_NAV_CARDS")} />;
};

export default Cards;
