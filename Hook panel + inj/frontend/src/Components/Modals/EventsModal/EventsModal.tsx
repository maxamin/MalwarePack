import React, {useLayoutEffect, useRef, useState} from "react";
import {ModalsProps} from "../../../Model/Modal";
import {Button, Modal, Pagination, Radio, RadioChangeEvent, Space, Table} from "antd";
import {Bot} from "../../../Model/Bot";
import {AppState} from "../../../Store/RootReducer";
import {getLogsList, setLogsPage} from "../../../Store/Logs/Actions";
import {RedoOutlined} from "@ant-design/icons";
import {useTranslation} from "react-i18next";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";
import {BotLog} from "../../../Model/BotLog";

interface EventsModalProps extends ModalsProps {
    bot: Bot,
}

const EventsModal: React.FC<EventsModalProps> = (props: EventsModalProps) => {
    const dispatch = useAppDispatch();
    const logsReducer = useAppSelector((state: AppState) => state.logs);
    const tableRef = useRef<HTMLDivElement>(null);
    const {t} = useTranslation();

    const [eventType, setEventType] = useState<string>("success");

    useLayoutEffect(() => {
        if (props.visible) {
            dispatch(getLogsList(
                eventType,
                props.bot.id,
                null,
                logsReducer.filters,
                logsReducer.sort,
                logsReducer.page,
                logsReducer.per_page,
            ));
        }
    }, [dispatch, props.bot.id, props.visible, logsReducer.page, logsReducer.per_page, eventType]);

    const closeModal = () => {
        props.setVisible(false);
    };

    const onChangeAction = (e: RadioChangeEvent) => {
        setEventType(e.target.value);
    };

    const columns = [
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
                        {log.log.text as string}
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

    const isLoaded = logsReducer.isLoaded &&
        ["success", "error"].includes(logsReducer.type || "") &&
        logsReducer.botId === props.bot.id;

    const eventsActions = [
        {label: t("success"), value: "success"},
        {label: t("error"), value: "error"},
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

    const refreshEventsModal = () => {
        dispatch(getLogsList(
            eventType,
            props.bot.id,
            null,
            logsReducer.filters,
            logsReducer.sort,
            logsReducer.page,
            logsReducer.per_page,
        ));
    };

    return (
        <Modal
            title={t("LOGS_EVENTS")}
            className="modal-injects"
            open={props.visible}
            onCancel={closeModal}
            width={600}
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
                        onClick={refreshEventsModal}
                        icon={<RedoOutlined/>}
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
                            options={eventsActions}
                            optionType="button"
                            defaultValue={"success"}
                            onChange={onChangeAction}
                            buttonStyle="solid"
                            className="events-radio"
                        />
                    </div>
                </div>

                <Table
                    columns={columns}
                    dataSource={isLoaded ? logsReducer.logs : []}
                    size="small"
                    pagination={false}
                    sticky={true}
                    className="not-responsive"
                    loading={!isLoaded}
                    rowKey={"id"}
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

export default EventsModal;
