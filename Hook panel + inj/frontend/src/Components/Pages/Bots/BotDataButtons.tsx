import React, {Dispatch, SetStateAction} from "react";
import {Button, Tooltip} from "antd";
import {Bot} from "../../../Model/Bot";
import {CommandsProps, LogButtonsProps} from "../../../Model/Commands";
import {useTranslation} from "react-i18next";

interface BotDataButtonsProps {
    bot: Bot,
    logsList: LogButtonsProps[],
    setSelectedBot: Dispatch<SetStateAction<Bot>>,
    setShowModal: (modal: string, show: boolean) => void,
}

const BotDataButtons: React.FC<BotDataButtonsProps> = (props: BotDataButtonsProps) => {
    const {t} = useTranslation();

    return (
        <>
            <div className="bot-item-permissions quickAccess">
                {props.logsList.filter((button: LogButtonsProps) => button.hasAccess).map((command: CommandsProps, id: number) => {
                    return (
                        <Tooltip
                            title={command.name}
                            placement="bottom"
                            destroyTooltipOnHide
                            zIndex={1}
                            key={id}
                        >
                            <span
                                className="bot-btn"
                                onClick={(e: any) => {
                                    command.action();
                                    e.target.classList.add("clicked");
                                    props.setSelectedBot(props.bot);
                                }}
                            >
                                {command.icon}
                            </span>
                        </Tooltip>
                    );
                })}
            </div>

            <div style={{display: "flex", flexWrap: "wrap", gridGap: 8, marginTop: 15}}>
                <Button
                    icon={(
                        <span className="anticon">
                            <i className="fa-solid fa-message" />
                        </span>
                    )}
                    onClick={() => {
                        props.setShowModal("hiddenSMS", true);
                        props.setSelectedBot(props.bot);
                    }}
                    block
                    style={{textAlign: "left", width: "calc(50% - 4px)"}}
                >
                    {t("HIDE_SMS")}
                </Button>
                <Button
                    icon={(
                        <span className="anticon">
                            <i className="fa-solid fa-keyboard" />
                        </span>
                    )}
                    onClick={() => {
                        props.setShowModal("keylogger", true);
                        props.setSelectedBot(props.bot);
                    }}
                    block
                    style={{textAlign: "left", width: "calc(50% - 4px)"}}
                >
                    {t("BOTINFO_KEYLOGGER")}
                </Button>
                <Button
                    icon={(
                        <span className="anticon">
                            <i className="fa-solid fa-bell" />
                        </span>
                    )}
                    onClick={() => {
                        props.setShowModal("pushList", true);
                        props.setSelectedBot(props.bot);
                    }}
                    block
                    style={{textAlign: "left", width: "calc(50% - 4px)"}}
                >
                    {t("BOTINFO_READPUSH")}
                </Button>
                <Button
                    icon={(
                        <span className="anticon">
                            <i className="fa-solid fa-server" />
                        </span>
                    )}
                    onClick={() => {
                        props.setShowModal("backendURL", true);
                        props.setSelectedBot(props.bot);
                    }}
                    block
                    style={{textAlign: "left", width: "calc(50% - 4px)"}}
                >
                    {t("BOTINFO_ARRAYURL")}
                </Button>
                <Button
                    icon={(
                        <span className="anticon">
                            <i className="fa-solid fa-warning" />
                        </span>
                    )}
                    onClick={() => {
                        props.setShowModal("events", true);
                        props.setSelectedBot(props.bot);
                    }}
                    block
                    style={{textAlign: "left", width: "calc(50% - 4px)"}}
                >
                    {t("BOTINFO_EVENTS")}
                </Button>
                <Button
                    icon={(
                        <span className="anticon">
                            <i className="fa-solid fa-camera" />
                        </span>
                    )}
                    onClick={() => {
                        props.setShowModal("photo", true);
                        props.setSelectedBot(props.bot);
                    }}
                    block
                    style={{textAlign: "left", width: "calc(50% - 4px)"}}
                >
                    {t("BOTINFO_CAMERA_PHOTOS")}
                </Button>
                <Button
                    icon={(
                        <span className="anticon">
                            <i className="fa-brands fa-google custom-icon" style={{fontSize: "14px"}} />
                        </span>
                    )}
                    onClick={() => {
                        props.setShowModal("googleAuth", true);
                        props.setSelectedBot(props.bot);
                    }}
                    block
                    style={{textAlign: "left", width: "calc(50% - 4px)"}}
                >
                    {t("BOTINFO_GOOGLE_AUTH")}
                </Button>
                <Button
                    icon={(
                        <span className="anticon">
                            <i className="fa-solid fa-cookie" />
                        </span>
                    )}
                    onClick={() => {
                        props.setShowModal("cookies", true);
                        props.setSelectedBot(props.bot);
                    }}
                    block
                    style={{textAlign: "left", width: "calc(50% - 4px)"}}
                >
                    {t("COOKIES")}
                </Button>
            </div>
        </>
    );
};

export default BotDataButtons;
