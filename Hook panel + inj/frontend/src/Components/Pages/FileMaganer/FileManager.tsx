import React from "react";
import Explorer from "./Explorer";
import {useTranslation} from "react-i18next";


const FileManager = () => {
    const {t} = useTranslation();

    return (
        <>
            <div className="panel-header">
                <h2 className="panel-title">{t("SIDEBAR_NAV_FILE")}</h2>
            </div>

            <Explorer />
        </>
    );
};

export default FileManager;
