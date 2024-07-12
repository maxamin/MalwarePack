import React, {Dispatch, SetStateAction, useState} from "react";
import {Checkbox, Divider, Tag} from "antd";
import BotInfo from "../../Modals/BotInfo/BotInfo";
import {Bot} from "../../../Model/Bot";

interface ShortInfoProps {
    selected: boolean,
    setSelected: Dispatch<SetStateAction<boolean>>,
    bot: Bot,
    bots: Bot[],
    status: string,
}

const HeadInfo: React.FC<ShortInfoProps> = (props: ShortInfoProps) => {
    const [showBotInfo, setShowBotInfo] = useState(false);

    return (
        <>
            <div className="bot-item-top">
                <div className="bot-item-icon">
                    <span className="icon-bots-information-model" style={{fontSize: 30}} />
                </div>

                <div className="bot-item-info" onClick={() => setShowBotInfo(true)}>
                    <div className="bot-item-name">{props.bot.id}</div>

                    <div className={`bot-item-status ${props.status}`}>
                        <span>{props.status}</span>
                    </div>
                </div>

                <div className="bot-item-select">
                    <Checkbox
                        style={{transform: "scale(1.5)"}}
                        checked={props.selected}
                        onChange={() => {
                            props.setSelected(!props.selected);
                        }}
                    />
                </div>
            </div>

            <Divider
                orientation="left"
            >
                Bot tag: <Tag color={"#177ddc"}>{props.bot.tag}</Tag>
            </Divider>

            <BotInfo visible={showBotInfo} setVisible={setShowBotInfo} bot={props.bot} />
        </>
    );
};

export default HeadInfo;
