import React, {useEffect, useState} from "react";
import {Divider, Modal, Popover, PopoverProps, Space, Switch} from "antd";
import CommandsModal from "../../Modals/CommandsModal/CommandsModal";
import BotInjectsModal from "../../Modals/Injects/BotInjectsModal";
import {Bot} from "../../../Model/Bot";
import {deleteBots, setBotTypeValue, updateBotSettingsValue} from "../../../Store/Bots/Actions";
import {useTranslation} from "react-i18next";
import Spinner from "../../Misc/Spinner";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";
import {AppState} from "../../../Store/RootReducer";
import {AppstoreOutlined, EditFilled} from "@ant-design/icons";
import BotComment from "../../Modals/BotComment/BotComment";

interface ActionProps {
    bot: Bot,
}

const Actions: React.FC<ActionProps> = (props: ActionProps) => {
    const [showCommands, setShowCommands] = useState(false);
    const [showInjects, setShowInjects] = useState(false);
    const [showPopover, setShowPopover] = useState(false);

    const getBotAction = () => {
        dispatch(deleteBots([props.bot.id]));
    };

    const dispatch = useAppDispatch();

    const onChangeSettings = (type: string, value: boolean) => {
        dispatch(updateBotSettingsValue(props.bot.id, type, value));
    };

    const setTypeValue = (type: string) => {
        if (type === "favorite") {
            setFavoriteIsLoadingState(true);
            dispatch(setBotTypeValue(props.bot.id, type, !props.bot.is_favorite));
        } else {
            dispatch(setBotTypeValue(props.bot.id, type, !props.bot.is_blacklisted));
        }
    };

    const [favoriteIsLoadingState, setFavoriteIsLoadingState] = useState(false);
    const [comment, setComment] = useState(false);

    const botsReducer = useAppSelector((state: AppState) => state.bots);

    useEffect(() => {
        setFavoriteIsLoadingState(false);
    }, [botsReducer]);

    const {t} = useTranslation();

    const botSettings = (
        <div style={{width: 300}}>
            <Divider orientation="left" style={{marginTop: 0, marginBottom: 10}}>
                {t("BOTINFO_SETTINGS")}
            </Divider>
            <div className="botinfo-settings">
                <span className="botinfo-list-item">
                    <Space size={10}>
                        <Switch size="small" defaultChecked={props.bot.settings.hideSMS}
                            onChange={(value: boolean) => onChangeSettings("hideSMS", value)}/>
                        {t("BOTINFO_HIDESMS")}
                    </Space>
                </span>
                <span className="botinfo-list-item">
                    <Space size={10}>
                        <Switch size="small" defaultChecked={props.bot.settings.clearPush}
                            onChange={(value: boolean) => onChangeSettings("clearPush", value)}/>
                        {t("BOTINFO_CLEARPUSH")}
                    </Space>
                </span>
                <span className="botinfo-list-item">
                    <Space size={10}>
                        <Switch size="small" defaultChecked={props.bot.settings.keylogger}
                            onChange={(value: boolean) => onChangeSettings("keylogger", value)}/>
                        {t("BOTINFO_KEYLOGGER")}
                    </Space>
                </span>
                <span className="botinfo-list-item">
                    <Space size={10}>
                        <Switch size="small" defaultChecked={props.bot.settings.lockDevice}
                            onChange={(value: boolean) => onChangeSettings("lockDevice", value)}/>
                        {t("BOTINFO_LOCKDEVICE")}
                    </Space>
                </span>
                <span className="botinfo-list-item">
                    <Space size={10}>
                        <Switch size="small" defaultChecked={props.bot.settings.offSound}
                            onChange={(value: boolean) => onChangeSettings("offSound", value)}/>
                        {t("BOTINFO_OFFSOUND")}
                    </Space>
                </span>
                <span className="botinfo-list-item">
                    <Space size={10}>
                        <Switch size="small" defaultChecked={props.bot.settings.readPush}
                            onChange={(value: boolean) => onChangeSettings("readPush", value)}/>
                        {t("BOTINFO_READPUSH")}
                    </Space>
                </span>
            </div>
        </div>
    );

    const botSettingsConfig: PopoverProps = {
        content: botSettings,
        placement: "topRight",
        trigger: ["click"],
        onOpenChange: (open) => {
            setShowPopover(open);
        },
    };

    return (
        <div>
            <BotComment selectedBots={[props.bot]} visible={comment} setVisible={setComment}/>

            <div className="bot-item-actions">
                <Space size="small">
                    <button className="bot-item-btn" onClick={() => setTypeValue("favorite")} disabled={favoriteIsLoadingState}>
                        {favoriteIsLoadingState ? (
                            <Spinner size={24} />
                        ) : (
                            props.bot.is_favorite ? (
                                <i className="fa-solid fa-heart-crack bot-item-like" />
                            ) : (
                                <i className="fa-solid fa-heart" />
                            )
                        )}
                    </button>

                    <button
                        className="bot-item-btn"
                        onClick={() => {
                            Modal.confirm({
                                title: t("BOT_ACTION_DELETE_TITLE"),
                                content: t("UNDONE_ACTION"),
                                onOk: () => getBotAction(),
                                okText: t("BOT_ACTION_DELETE_CONFIRM"),
                                cancelText: t("MODAL_BUTTON_CANCEL"),
                                okButtonProps: {
                                    danger: true,
                                },
                                centered: true,
                            });
                        }}
                    >
                        <i className="fa-solid fa-trash-can-arrow-up" />
                    </button>

                    <button
                        className="bot-item-btn"
                        onClick={() => setShowCommands(true)}
                    >
                        <i className="fa-solid fa-bars-staggered" />
                    </button>

                    <button
                        className="bot-item-btn"
                        onClick={() => {
                            setComment(true);
                        }}
                    >
                        <EditFilled/>
                    </button>

                    <button
                        className="bot-item-btn"
                        onClick={() => {
                            setShowInjects(true);
                        }}
                    >
                        <AppstoreOutlined/>
                    </button>
                </Space>

                <Popover {...botSettingsConfig}>
                    <button className="bot-item-btn">
                        <i className="fa-solid fa-gear" style={{
                            transform: `rotate(${showPopover ? "135deg" : "0deg"})`,
                            transition: "all 300ms ease-in-out",
                        }} />
                    </button>
                </Popover>
            </div>

            <BotInjectsModal visible={showInjects} setVisible={setShowInjects} bot={props.bot} />

            <CommandsModal
                visible={showCommands}
                setVisible={(isVisible: boolean) => setShowCommands(isVisible)}
                bot={props.bot}
            />
        </div>
    );
};

export default Actions;
