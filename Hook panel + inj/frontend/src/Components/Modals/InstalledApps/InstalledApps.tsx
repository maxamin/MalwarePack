import React, {useEffect} from "react";
import {BotModalProps} from "../../../Model/Modal";
import {Button, Modal, Space, Table} from "antd";
import {RedoOutlined} from "@ant-design/icons";
import {AppState} from "../../../Store/RootReducer";
import {getLogsList} from "../../../Store/Logs/Actions";
import {getBackendUrl} from "../../../Util/config";
import {useTranslation} from "react-i18next";
import {useAppSelector} from "../../../Hook/useAppSelector";
import {useAppDispatch} from "../../../Hook/useAppDispatch";

interface InstalledApplicationLog {
    application: string,
    image: string,
    name: string,
}

const InstalledApps: React.FC<BotModalProps> = (props: BotModalProps) => {
    const logsReducer = useAppSelector((state: AppState) => state.logs);
    const dispatch = useAppDispatch();
    const {t} = useTranslation();

    useEffect(() => {
        if (props.visible) {
            dispatch(getLogsList("applist", props.bot.id, null, logsReducer.filters, logsReducer.sort, 1));
        }
    }, [dispatch, props.bot.id, props.visible]);


    const closeModal = () => {
        props.setVisible(false);
    };

    const refreshAppsList = () => {
        dispatch(getLogsList("applist", props.bot.id, null, logsReducer.filters, logsReducer.sort, 1));
    };

    const columns = [
        {
            title: t("APPLICATION"),
            dataIndex: "app",
            render: (text: string, log: InstalledApplicationLog) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <b>{t("APPLICATION")}</b>
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
            ),
        },
        {
            title: t("NAME"),
            dataIndex: "app_id",
            render: (text: string, log: InstalledApplicationLog) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <b>{t("NAME")}</b>
                    </div>
                    <div className="table-col-item">
                        <code>{log.name}</code>
                    </div>
                </div>
            ),
        },
    ];

    let dataSource: InstalledApplicationLog[] = [];

    if (logsReducer.logs.length > 0) {
        dataSource = (logsReducer.logs[0].log) as unknown as InstalledApplicationLog[];
    } else {
        dataSource= [];
    }

    const isLoaded = logsReducer.isLoaded && logsReducer.type === "applist" && logsReducer.botId === props.bot.id;

    return (
        <Modal
            title={t("INSTALLED_APPS")}
            open={props.visible}
            onCancel={closeModal}
            width={400}
            className="modal-injects"
            destroyOnClose
            footer={[
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
                        {t("CLOSE")}
                    </Button>
                </>,
            ]}
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

export default InstalledApps;
