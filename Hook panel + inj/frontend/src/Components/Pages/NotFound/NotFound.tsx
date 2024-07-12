import React from "react";
import {Result} from "antd";
import {useTranslation} from "react-i18next";

const NotFound: React.FC = () => {
    const {t} = useTranslation();

    return (
        <Result
            status="warning"
            title={t("404_TITLE")}
            subTitle={t("404_SUBTITLE")}
        />
    );
};

export default NotFound;
