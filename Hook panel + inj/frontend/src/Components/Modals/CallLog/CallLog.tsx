import React, {useEffect} from "react";
import {BotModalProps} from "../../../Model/Modal";
import {Button, Modal, Space, Table} from "antd";
import {AppState} from "../../../Store/RootReducer";
import {getLogsList} from "../../../Store/Logs/Actions";
import {RedoOutlined} from "@ant-design/icons";
import {useTranslation} from "react-i18next";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";

interface CallLog {
    new: string,
    date: string,
    name: string,
    type: string,
    number: string,
    duration: string
}

const CallLog: React.FC<BotModalProps> = (props: BotModalProps) => {
    const logsReducer = useAppSelector((state: AppState) => state.logs);
    const dispatch = useAppDispatch();

    useEffect(() => {
        if (props.visible) {
            dispatch(getLogsList("callLog", props.bot.id, null, logsReducer.filters, logsReducer.sort, 1));
        }
    }, [dispatch, props.bot.id, props.visible]);

    const closeModal = () => props.setVisible(false);

    const refreshAppsList = () => {
        dispatch(getLogsList("callLog", props.bot.id, null, logsReducer.filters, logsReducer.sort, 1));
    };

    const {t} = useTranslation();

    const columns = [
        {
            title: "date",
            dataIndex: "date",
            key: "date",
            render: (date: string) => {
                return (
                    <div className="table-col">
                        <div className="table-col-item">
                            <b>date</b>
                        </div>
                        <div className="table-col-item">
                            {date}
                        </div>
                    </div>
                );
            },
        },
        {
            title: "name",
            dataIndex: "name",
            key: "name",
            render: (name: string) => {
                return (
                    <div className="table-col">
                        <div className="table-col-item">
                            <b>name</b>
                        </div>
                        <div className="table-col-item">
                            {name}
                        </div>
                    </div>
                );
            },
        },
        {
            title: "number",
            dataIndex: "number",
            key: "number",
            render: (number: string) => {
                return (
                    <div className="table-col">
                        <div className="table-col-item">
                            <b>number</b>
                        </div>
                        <div className="table-col-item">
                            {number}
                        </div>
                    </div>
                );
            },
        },
        {
            title: "duration",
            dataIndex: "duration",
            key: "duration",
            render: (duration: string) => {
                return (
                    <div className="table-col">
                        <div className="table-col-item">
                            <b>duration</b>
                        </div>
                        <div className="table-col-item">
                            {duration}
                        </div>
                    </div>
                );
            },
        },
    ];


    let dataSource: CallLog[];

    if (logsReducer.logs.length > 0) {
        dataSource = (logsReducer.logs[0].log) as unknown as CallLog[];
    } else {
        dataSource= [];
    }

    const isLoaded = logsReducer.isLoaded && logsReducer.type === "callLog" && logsReducer.botId === props.bot.id;

    return (
        <Modal
            title={t("CALL_LOG")}
            open={props.visible}
            onCancel={closeModal}
            width={760}
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

export default CallLog;
