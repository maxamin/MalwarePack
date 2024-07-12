import React from "react";
import {Bar} from "@ant-design/charts";
import Spinner from "../../Misc/Spinner";
import {Divider} from "antd";
import {dividerConfig, sliderConfig} from "./GeneralStats";
import {StatsCardProps} from "../../../Model/StatsCard";
import {themeAccentColor} from "../../../Util/config";
import {AppState} from "../../../Store/RootReducer";
import {useAppSelector} from "../../../Hook/useAppSelector";
import {useTranslation} from "react-i18next";

const CountriesPlot: React.FC<StatsCardProps> = (props: StatsCardProps) => {
    const settingsReducer = useAppSelector((state: AppState) => state.settings);
    const {t} = useTranslation();

    const data = [
        {
            country: "Russia",
            bots: 38,
        },
        {
            country: "Belarus",
            bots: 52,
        },
        {
            country: "Indonesia",
            bots: 61,
        },
        {
            country: "United Kingdom",
            bots: 145,
        },
        {
            country: "Africa",
            bots: 48,
        },
        {
            country: "Australia",
            bots: 38,
        },
        {
            country: "Canada",
            bots: 38,
        },
        {
            country: "India",
            bots: 38,
        },
    ];

    const config = {
        data,
        padding: [15, 15, 85, 120],
        xField: "bots",
        yField: "country",
        barWidthRatio: 0.8,
        color: themeAccentColor,
        meta: {
            country: {
                alias: t("COUNTRY"),
            },
            bots: {
                alias: t("BOTS_COUNT"),
            },
        },
        loading: false,
        loadingTemplate: <Spinner variant="circle" />,
        renderType: "canvas",
        slider: sliderConfig,
        theme: settingsReducer.theme === "dark" ? "dark" : "light",
        areaStyle: {
            fill: "#f00",
        },
    };

    return (
        <div className="stat-block">
            <Divider {...dividerConfig}>
                <h2>{props.title}</h2>
            </Divider>

            <Bar {...config} />
        </div>
    );
};

export default CountriesPlot;
