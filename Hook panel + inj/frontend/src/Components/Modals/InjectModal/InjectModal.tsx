import React, {useEffect} from "react";
import {ModalsProps} from "../../../Model/Modal";
import {Button, Modal, Space, Table} from "antd";
import {AppState} from "../../../Store/RootReducer";
import {getLogsList} from "../../../Store/Logs/Actions";
import {Bot} from "../../../Model/Bot";
import {BotLog} from "../../../Model/BotLog";
import {useTranslation} from "react-i18next";
import {useAppSelector} from "../../../Hook/useAppSelector";
import {useAppDispatch} from "../../../Hook/useAppDispatch";

interface InjectLogsModalProps extends ModalsProps {
    bot: Bot,
    application: string,
}

const InjectModal: React.FC<InjectLogsModalProps> = (props: InjectLogsModalProps) => {
    const closeModal = () => props.setVisible(false);
    const logsReducer = useAppSelector((state: AppState) => state.logs);
    const dispatch = useAppDispatch();

    useEffect(() => {
        if (props.visible) {
            dispatch(getLogsList("application", props.bot.id, props.application, logsReducer.filters, logsReducer.sort, 1));
        }
    }, [dispatch, props.application, props.bot.id, props.visible]);

    const {t} = useTranslation();

    const columns = [
        {
            title: "# ID",
            dataIndex: "id",
            key: "id",
            width: 56,
            render: (text: string) =>
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>ID</h3>
                    </div>
                    <div className="table-col-item" style={{textAlign: "center"}}>
                        {text}
                    </div>
                </div>,
        },
        {
            title: t("DATA"),
            dataIndex: "data",
            key: "data",
            render: (text: string, log: BotLog) => {
                return (
                    <div className="table-col">
                        <div className="table-col-item">
                            <h3>{t("DATA")}</h3>
                        </div>
                        <div className="table-col-item">
                            <div className="code">{JSON.stringify(log.log, null, 2)}</div>
                        </div>
                    </div>
                );
            },
        },
        {
            title: t("CREATED"),
            dataIndex: "created_at",
            key: "created_at", width: 200,
            render: (text: string) =>
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("CREATED")}</h3>
                    </div>
                    <div className="table-col-item" style={{textAlign: "center"}}>
                        {text}
                    </div>
                </div>,
        },
    ];

    const isLoaded = logsReducer.isLoaded &&
        logsReducer.type === "application" &&
        logsReducer.botId === props.bot.id &&
        logsReducer.application === props.application;


    return (
        <Modal
            title={t("INJECTION_DATA")}
            open={props.visible}
            onCancel={closeModal}
            className="modal-injects"
            destroyOnClose
            footer={(
                <Button type="primary" onClick={closeModal}>
                    {t("CLOSE")}
                </Button>
            )}
            centered
            width={600}
        >
            <div className="table-scroll" style={{maxHeight: 300, overflowY: "auto"}}>
                <Table
                    columns={columns}
                    dataSource={isLoaded ? logsReducer.logs : []}
                    size="small"
                    pagination={false}
                    loading={!isLoaded}
                    rowKey="id"
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

export default InjectModal;
