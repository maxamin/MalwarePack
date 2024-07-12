import React from "react";
import {Line, LineConfig} from "@ant-design/charts";
import {AppState} from "../../../Store/RootReducer";
import Spinner from "../../Misc/Spinner";
import {StatsCardProps} from "../../../Model/StatsCard";
import {Divider} from "antd";
import {dividerConfig, sliderConfig} from "./GeneralStats";
import {themeAccentColor} from "../../../Util/config";
import {useAppSelector} from "../../../Hook/useAppSelector";
import {BotTimeline} from "../../../Store/Stats/Types";

interface IBotsLineProps extends StatsCardProps {
    data: BotTimeline[],
    loading: boolean,
}

const BotsLine: React.FC<IBotsLineProps> = (props: IBotsLineProps) => {
    const settingsReducer = useAppSelector((state: AppState) => state.settings);
    const config: LineConfig = {
        data: props.data,
        padding: [15, 15, 100, 50],
        xField: "date",
        yField: "count",
        xAxis: {
            tickCount: 10,
        },
        yAxis: {
            tickCount: 10,
        },
        slider: sliderConfig,
        color: themeAccentColor,
        theme: settingsReducer.theme === "dark" ? "dark" : "light",
        loading: props.loading,
        loadingTemplate: <Spinner variant="circle" />,
    };

    return (
        <div className="stat-block">
            <Divider {...dividerConfig}>
                <h2>{props.title}</h2>
            </Divider>

            <Line {...config} />
        </div>
    );
};

export default BotsLine;
