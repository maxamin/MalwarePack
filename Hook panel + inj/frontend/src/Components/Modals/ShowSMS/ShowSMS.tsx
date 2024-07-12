import React, {useEffect} from "react";
import {BotModalProps} from "../../../Model/Modal";
import {Button, Modal, Space, Table} from "antd";
import {AppState} from "../../../Store/RootReducer";
import {getLogsList} from "../../../Store/Logs/Actions";
import {LoginOutlined, LogoutOutlined, RedoOutlined} from "@ant-design/icons";
import {useTranslation} from "react-i18next";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";

interface SMSLog {
    address: string,
    body: string,
    date: string,
    id: string,
    name: string,
    threadId: string,
    type: string,
}

const ShowSMS: React.FC<BotModalProps> = (props: BotModalProps) => {
    const logsReducer = useAppSelector((state: AppState) => state.logs);
    const dispatch = useAppDispatch();
    const {t} = useTranslation();

    useEffect(() => {
        if (props.visible) {
            dispatch(getLogsList("smslist", props.bot.id, null, logsReducer.filters, logsReducer.sort, 1));
        }
    }, [dispatch, props.visible]);

    const columns = [
        {
            title: "#",
            dataIndex: "type",
            key: "type",
            width: 25,
            render: (type: string) =>
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>#</h3>
                    </div>
                    <div className="table-col-item" style={{textAlign: "center"}}>
                        {type === "1" ? (
                            <LoginOutlined style={{color: "green"}} />
                        ) : (
                            <LogoutOutlined />
                        )}
                    </div>
                </div>,
        },
        {
            title: t("NUMBER"),
            dataIndex: "address",
            key: "address",
            render: (text: string, log: SMSLog) =>
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("NUMBER")}</h3>
                    </div>
                    <div className="table-col-item">
                        {log.address}
                    </div>
                </div>,
        },
        {
            title: t("MESSAGE"),
            dataIndex: "message",
            key: "message",
            render: (text: string, log: SMSLog) => {
                return (
                    <div className="table-col">
                        <div className="table-col-item">
                            <h3>{t("MESSAGE")}</h3>
                        </div>
                        <div className="table-col-item">
                            {log.body}
                        </div>
                    </div>
                );
            },
        },
    ];

    const closeModal = () => {
        props.setVisible(false);
    };

    const refreshSMSList = async () => {
        dispatch(getLogsList("smslist", props.bot.id, null, logsReducer.filters, logsReducer.sort, 1));
    };

    let dataSource: SMSLog[] = [];

    if (logsReducer.logs.length > 0) {
        dataSource = (logsReducer.logs[0].log) as unknown as SMSLog[];
    } else {
        dataSource= [];
    }

    const isLoaded = logsReducer.isLoaded && logsReducer.type === "smslist" && logsReducer.botId === props.bot.id;

    return (
        <Modal
            title={t("smslist")}
            className="modal-injects"
            open={props.visible}
            onCancel={closeModal}
            width={520}
            destroyOnClose
            footer={(
                <>
                    <Button
                        type="primary"
                        onClick={refreshSMSList}
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
            <div className="table-scroll" style={{maxHeight: 200, overflowY: "auto"}}>
                <Table
                    columns={columns}
                    dataSource={isLoaded ? dataSource : []}
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
                />
            </div>
        </Modal>
    );
};

export default ShowSMS;
