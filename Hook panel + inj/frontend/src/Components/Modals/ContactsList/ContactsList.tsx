import React, {useEffect} from "react";
import {ModalsProps} from "../../../Model/Modal";
import {Button, Modal, Space, Table} from "antd";
import {Bot} from "../../../Model/Bot";
import {AppState} from "../../../Store/RootReducer";
import {getLogsList} from "../../../Store/Logs/Actions";
import {RedoOutlined} from "@ant-design/icons";
import {useTranslation} from "react-i18next";
import {useAppSelector} from "../../../Hook/useAppSelector";
import {useAppDispatch} from "../../../Hook/useAppDispatch";

interface PhoneNumberLog {
    name: string,
    phoneNo: string,
}

export interface ContactsListProps extends ModalsProps {
    bot: Bot,
}

const ContactsList: React.FC<ContactsListProps> = (props: ContactsListProps) => {
    const logsReducer = useAppSelector((state: AppState) => state.logs);
    const dispatch = useAppDispatch();
    const {t} = useTranslation();

    useEffect(() => {
        if (props.visible) {
            dispatch(getLogsList("phonenumber", props.bot.id, null, logsReducer.filters, logsReducer.sort, 1));
        }
    }, [dispatch, props.bot.id, props.visible]);

    const closeModal = () => {
        props.setVisible(false);
    };


    const refreshContactsList = () => {
        dispatch(getLogsList("phonenumber", props.bot.id, null, logsReducer.filters, logsReducer.sort, 1));
    };

    const columns = [
        {
            title: t("NUMBER"),
            dataIndex: "number",
            key: "number",
            render: (text: string, log: PhoneNumberLog) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <b>{t("NUMBER")}</b>
                    </div>
                    <div className="table-col-item">
                        {log.phoneNo}
                    </div>
                </div>
            ),
        },
        {
            title: t("NAME"),
            dataIndex: "name",
            key: "name",
            render: (text: string, log: PhoneNumberLog) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <b>{t("NAME")}</b>
                    </div>
                    <div className="table-col-item">
                        {log.name}
                    </div>
                </div>
            ),
        },
    ];

    let dataSource: PhoneNumberLog[];

    if (logsReducer.logs.length > 0) {
        dataSource = (logsReducer.logs[0].log) as unknown as PhoneNumberLog[];
    } else {
        dataSource= [];
    }

    const isLoaded = logsReducer.isLoaded && logsReducer.type === "phonenumber" && logsReducer.botId === props.bot.id;

    return (
        <Modal
            title={t("CONTACTS_LIST")}
            open={props.visible}
            onCancel={closeModal}
            width={500}
            className="modal-injects"
            destroyOnClose
            footer={[
                <>
                    {/*
                    <Button
                        type="primary"
                        onClick={downloadHTML}
                        icon={<DownloadOutlined/>}
                    >
                        Download as HTML
                    </Button>
                    */}
                    <Button
                        type="primary"
                        onClick={refreshContactsList}
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

export default ContactsList;
