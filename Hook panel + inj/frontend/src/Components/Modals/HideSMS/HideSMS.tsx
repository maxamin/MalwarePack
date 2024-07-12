import React, {useEffect} from "react";
import {ModalsProps} from "../../../Model/Modal";
import {Button, Modal, Space, Table} from "antd";
import {AppState} from "../../../Store/RootReducer";
import {getLogsList} from "../../../Store/Logs/Actions";
import {Bot} from "../../../Model/Bot";
import {RedoOutlined} from "@ant-design/icons";
import {useTranslation} from "react-i18next";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";

interface SMSLog {
    text: string,
    number: number,
    created_at: string,
}

interface HideSMSProps extends ModalsProps {
    bot: Bot,
}

const HideSMS: React.FC<HideSMSProps> = (props: HideSMSProps) => {
    const dispatch = useAppDispatch();
    const logsReducer = useAppSelector((state: AppState) => state.logs);
    const {t} = useTranslation();

    useEffect(() => {
        if (props.visible) {
            dispatch(getLogsList("hidesms", props.bot.id, null, logsReducer.filters, logsReducer.sort, 1));
        }
    }, [dispatch, props.visible]);

    const closeModal = () => {
        props.setVisible(false);
    };

    const refreshHideSMS = () => {
        dispatch(getLogsList("hidesms", props.bot.id, null, logsReducer.filters, logsReducer.sort, 1));
    };

    const columns = [
        {
            title: t("NUMBER"),
            dataIndex: "number",
            key: "number",
            render: (text: string, log: SMSLog) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <b>{t("NUMBER")}</b>
                    </div>
                    <div className="table-col-item">
                        {log.number}
                    </div>
                </div>
            ),
        },
        {
            title: t("TEXT"),
            dataIndex: "text",
            key: "text",
            render: (text: string, log: SMSLog) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <b>{t("TEXT")}</b>
                    </div>
                    <div className="table-col-item">
                        {log.text}
                    </div>
                </div>
            ),
        },
        {
            title: t("DATE"),
            dataIndex: "created_at",
            key: "created_at",
            render: (text: string, log: SMSLog) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <b>{t("DATE")}</b>
                    </div>
                    <div className="table-col-item">
                        {log.created_at}
                    </div>
                </div>
            ),
        },
    ];

    let dataSource: SMSLog[] = [];

    if (logsReducer.logs.length > 0) {
        dataSource = (logsReducer.logs[0].log) as unknown as SMSLog[];
    } else {
        dataSource = [];
    }

    const isLoaded = logsReducer.isLoaded && logsReducer.type === "hidesms" && logsReducer.botId === props.bot.id;


    return (
        <Modal
            title={t("HIDE_SMS")}
            open={props.visible}
            onCancel={closeModal}
            width={400}
            className="modal-injects"
            destroyOnClose
            footer={(
                <>
                    <Button
                        type="primary"
                        onClick={refreshHideSMS}
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
                </>
            )}
        >
            <div className="table-scroll" style={{maxHeight: 250, overflowY: "auto"}}>
                <Table
                    columns={columns}
                    dataSource={isLoaded ? dataSource : []}
                    loading={!isLoaded}
                    size="small"
                    pagination={false}
                    sticky={true}
                    className="not-responsive"
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

export default HideSMS;
