import React from "react";
import {Line, LineConfig} from "@ant-design/charts";
import {AppState} from "../../../Store/RootReducer";
import Spinner from "../../Misc/Spinner";
import {StatsCardProps} from "../../../Model/StatsCard";
import {Divider} from "antd";
import {dividerConfig, sliderConfig} from "./GeneralStats";
import {useAppSelector} from "../../../Hook/useAppSelector";
import {LogTimeline} from "../../../Store/Stats/Types";

interface IInjectsLineProps extends StatsCardProps {
    data: LogTimeline[],
    loading: boolean,
}

const InjectsLine: React.FC<IInjectsLineProps> = (props: IInjectsLineProps) => {
    const settingsReducer = useAppSelector((state: AppState) => state.settings);

    const config: LineConfig = {
        data: props.data,
        padding: [40, 15, 100, 50],
        xField: "date",
        yField: "count",
        seriesField: "category",
        color: [
            "#5B8FF9",
            "#5AD8A6",
            "#5D7092",
            "#F6BD16",
            "#E8684A",
            "#6DC8EC",
            "#9270CA",
            "#FF9D4D",
            "#269A99",
            "#FF99C3",
        ],
        point: {
            shape: "circle",
        },
        slider: sliderConfig,
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

export default InjectsLine;
