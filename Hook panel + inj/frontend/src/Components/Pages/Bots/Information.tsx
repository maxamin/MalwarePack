import React from "react";
import {Divider, Space, Tooltip} from "antd";
import {Bot} from "../../../Model/Bot";
import {humanizeBotLastConnection} from "../../../Util/humanizeBotLastConnection";
import {useTranslation} from "react-i18next";

interface InformationProps {
    bot: Bot,
    lastConnectionDiff: number,
    renderType: "table" | "cards",
}

const Information: React.FC<InformationProps> = (props: InformationProps) => {
    const {t} = useTranslation();

    return props.renderType === "cards" ? (
        <div className="bot-item-information">
            <Divider orientation="left">
                Information
            </Divider>

            <div className="bot-item-connect">
                <div className="bot-item-connect-info">
                    <i className="bot-item-connect-badge">
                        <span className="icon-bots-information-model" />
                    </i>
                    {props.bot.metadata.version} / {props.bot.metadata.device}
                </div>
                <div className="bot-item-connect-info">
                    <i className="bot-item-connect-badge">IP</i>
                    {props.bot.ip} /&nbsp;
                    <Space>
                        <img
                            width={16}
                            alt={props.bot.country_code.toUpperCase()}
                            src={`https://purecatamphetamine.github.io/country-flag-icons/3x2/${props.bot.country_code.toUpperCase()}.svg`}
                        />

                        <span>{props.bot.country}</span>
                    </Space>
                </div>
                <div className="bot-item-connect-info">
                    <Tooltip placement="right" title="First connection..." destroyTooltipOnHide>
                        <i className="bot-item-connect-badge">FC</i>
                    </Tooltip>
                    {props.bot.created_at}
                </div>
                <div className="bot-item-connect-info">
                    <Tooltip placement="right" title="Last connection..." destroyTooltipOnHide>
                        <i className="bot-item-connect-badge">LC</i>
                    </Tooltip>
                    <span className={"bot-item-connect-last"}>
                        {humanizeBotLastConnection(props.lastConnectionDiff)}
                    </span>
                </div>
                {props.bot.comment && (
                    <div className="bot-item-connect-info">
                        <i className="bot-item-connect-badge">
                            <span className="icon-bots-information-comment" />
                        </i>

                        <span style={{flex: 1}}>
                            {props.bot.comment}
                        </span>
                    </div>
                )}
            </div>
        </div>
    ) : (
        <>
            <div className="bot-item-connect-info">
                <Tooltip placement="right" title={t("BOT_FC")} destroyTooltipOnHide>
                    <i className="bot-item-connect-badge">FC</i>
                </Tooltip>
                {props.bot.created_at}
            </div>
            <div className="bot-item-connect-info">
                <Tooltip placement="right" title={t("BOT_LC")} destroyTooltipOnHide>
                    <i className="bot-item-connect-badge">LC</i>
                </Tooltip>
                <span className={"bot-item-connect-last"}>
                    {humanizeBotLastConnection(props.lastConnectionDiff)}
                </span>
            </div>
        </>
    );
};

export default Information;
