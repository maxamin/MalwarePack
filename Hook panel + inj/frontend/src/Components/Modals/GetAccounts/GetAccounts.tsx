import React, {useEffect} from "react";
import {BotModalProps} from "../../../Model/Modal";
import {Button, Modal, Space, Table} from "antd";
import {AppState} from "../../../Store/RootReducer";
import {getLogsList} from "../../../Store/Logs/Actions";
import {getBackendUrl} from "../../../Util/config";
import {RedoOutlined} from "@ant-design/icons";
import {useTranslation} from "react-i18next";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";

interface AccountLog {
    account: string,
    application: string,
    image: string,
}

const GetAccounts: React.FC<BotModalProps> = (props: BotModalProps) => {
    const logsReducer = useAppSelector((state: AppState) => state.logs);
    const dispatch = useAppDispatch();

    useEffect(() => {
        if (props.visible) {
            dispatch(getLogsList("otheraccounts", props.bot.id, null, logsReducer.filters, logsReducer.sort, 1));
        }
    }, [dispatch, props.bot.id, props.visible]);

    const closeModal = () => props.setVisible(false);

    const refreshAppsList = () => {
        dispatch(getLogsList("otheraccounts", props.bot.id, null, logsReducer.filters, logsReducer.sort, 1));
    };

    const {t} = useTranslation();

    const columns = [
        {
            title: t("APPLICATION"),
            dataIndex: "application",
            key: "application",
            render: (text: string, log: AccountLog) => {
                return (
                    <div className="table-col">
                        <div className="table-col-item">
                            <b>Account</b>
                        </div>
                        <div className="table-col-item">
                            <div style={{display: "flex", alignItems: "center", gap: 8}}>
                                <img
                                    src={getBackendUrl(log.image)}
                                    width={16}
                                    alt={log.application}
                                />

                                {log.application}
                            </div>
                        </div>
                    </div>
                );
            },
        },
        {
            title: t("ACCOUNT"),
            dataIndex: "account",
            key: "account",
            render: (account: any, log: AccountLog) => {
                return (
                    <div className="table-col">
                        <div className="table-col-item">
                            <b>Package</b>
                        </div>
                        <div className="table-col-item">
                            <code>{log.account}</code>
                        </div>
                    </div>
                );
            },
        },
    ];


    let dataSource: AccountLog[];

    if (logsReducer.logs.length > 0) {
        dataSource = (logsReducer.logs[0].log) as unknown as AccountLog[];
    } else {
        dataSource= [];
    }

    const isLoaded = logsReducer.isLoaded && logsReducer.type === "otheraccounts" && logsReducer.botId === props.bot.id;

    return (
        <Modal
            title={t("SHOW_ACCOUNTS")}
            open={props.visible}
            onCancel={closeModal}
            width={400}
            className="modal-injects"
            destroyOnClose
            footer={(
                <>
                    <Button
                        type="primary"
                        onClick={refreshAppsList}
                        icon={<RedoOutlined/>}
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

export default GetAccounts;
