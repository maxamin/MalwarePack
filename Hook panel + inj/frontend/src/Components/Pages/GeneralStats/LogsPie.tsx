import React from "react";
import {Pie} from "@ant-design/charts";
import {StatsCardProps} from "../../../Model/StatsCard";
import {dividerConfig} from "./GeneralStats";
import {Divider} from "antd";

interface LogsProps extends StatsCardProps {
    logs: any,
}

const LogsPie: React.FC<LogsProps> = (props: LogsProps) => {
    const data = [
        {
            type: "logsBotsSMS",
            value: props.logs.smslist,
        },
        {
            type: "logsHideSMS",
            value: props.logs.hidesms,
        },
        {
            type: "logsGoogleAuth",
            value: props.logs.googleauth,
        },
        {
            type: "logsOtherAccounts",
            value: props.logs.otheraccounts,
        },
        {
            type: "Keylogger",
            value: props.logs.keylogger,
        },
        {
            type: "logsPushList",
            value: props.logs.pushlist,
        },
    ];
    const config = {
        appendPadding: 0,
        data,
        angleField: "value",
        colorField: "type",
        radius: 1,
        startAngle: Math.PI,
        endAngle: Math.PI * 1.5,
        label: {
            type: "inner",
            offset: "50%",
            content: "{name}",
            style: {
                fontSize: 12,
            },
        },
        interactions: [
            {
                type: "element-active",
            },
        ],
        pieStyle: {
            lineWidth: 1,
        },
    };
    return (
        <div className="stat-block">
            <Divider {...dividerConfig}>
                <h2>{props.title}</h2>
            </Divider>

            <Pie {...config} />
        </div>
    );
};

export default LogsPie;
