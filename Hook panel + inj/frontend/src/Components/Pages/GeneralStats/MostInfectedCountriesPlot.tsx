import React from "react";
import {Bar} from "@ant-design/charts";
import Spinner from "../../Misc/Spinner";
import {sliderConfig} from "./GeneralStats";
import {StatsCardProps} from "../../../Model/StatsCard";
import {themeAccentColor} from "../../../Util/config";
import {AppState} from "../../../Store/RootReducer";
import {useAppSelector} from "../../../Hook/useAppSelector";
import {useTranslation} from "react-i18next";
import {StatsBotsCountry} from "../../../Store/Stats/Types";

interface IMostInfectedCountriesPlotProps extends StatsCardProps {
    data: StatsBotsCountry[],
    loading: boolean,
}

const MostInfectedCountriesPlot: React.FC<IMostInfectedCountriesPlotProps> = (props: IMostInfectedCountriesPlotProps) => {
    const settingsReducer = useAppSelector((state: AppState) => state.settings);
    const {t} = useTranslation();

    const config = {
        data: props.data,
        padding: [15, 15, 85, 120],
        xField: "count",
        yField: "country",
        barWidthRatio: 0.8,
        color: themeAccentColor,
        meta: {
            device: {
                alias: t("BOT_MODEL"),
            },
            count: {
                alias: t(" "),
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
            <Bar {...config} />
        </div>
    );
};

export default MostInfectedCountriesPlot;
