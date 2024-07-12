import React from "react";
import BotLogsPageRender from "../../Misc/BotLogsPageRender";
import {useTranslation} from "react-i18next";

const Wallet: React.FC = () => {
    const {t} = useTranslation();
    return <BotLogsPageRender type={"wallets"} title={t("SIDEBAR_NAV_BANKS")} />;
};

export default Wallet;
