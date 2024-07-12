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
import {BotModelsStats} from "../../../Store/Stats/Types";

interface IDeviceModelPlotProps extends StatsCardProps {
    data: BotModelsStats[],
    loading: boolean,
}

const DeviceModelPlot: React.FC<IDeviceModelPlotProps> = (props: IDeviceModelPlotProps) => {
    const settingsReducer = useAppSelector((state: AppState) => state.settings);
    const {t} = useTranslation();

    const config = {
        data: props.data,
        padding: [15, 15, 85, 120],
        xField: "count",
        yField: "device",
        barWidthRatio: 0.8,
        color: themeAccentColor,
        meta: {
            device: {
                alias: t("BOT_MODEL"),
            },
            count: {
                alias: t("STATS_COLUMN_COUNT"),
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

export default DeviceModelPlot;
