import React, {useEffect} from "react";
import {ModalsProps} from "../../../Model/Modal";
import {Button, Modal, Space, Switch, Table} from "antd";
import {Bot, BotInjection} from "../../../Model/Bot";
import {getBackendUrl} from "../../../Util/config";
import {CodeFilled} from "@ant-design/icons";
import {useTranslation} from "react-i18next";
import {useAppDispatch} from "../../../Hook/useAppDispatch";

interface InjectsModalProps extends ModalsProps {
    bot: Bot,
}

const Injects: React.FC<InjectsModalProps> = (props: InjectsModalProps) => {
    const closeModal = () => props.setVisible(false);
    const {t} = useTranslation();

    const columns = [
        {
            title: (
                <>
                    <CodeFilled/> Application
                </>
            ),
            dataIndex: "name",
            key: "name",
            render: (name: string, inject: BotInjection) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <b>Application</b>
                    </div>
                    <div className="table-col-item">
                        <img
                            src={getBackendUrl(`/injects/images/${inject.type}/${inject.application}.png`)}
                            alt={name}
                            width={16}
                        /> {name}
                    </div>
                </div>
            ),
        },
        {
            title: (
                <>
                    Status
                </>
            ),
            dataIndex: "status",
            key: "status",
            width: 70,
            render: () => (
                <Switch defaultChecked={true} size="small"/>
            ),
        },
    ];

    const data = props.bot.injections;

    const dispatch = useAppDispatch();

    useEffect(() => {
    }, [dispatch]);

    return (
        <Modal
            title="Injects"
            open={props.visible}
            onCancel={closeModal}
            className="modal-injects"
            width={400}
            destroyOnClose
            footer={(
                <Button type="primary" onClick={closeModal}>Close</Button>
            )}
            centered
        >
            <div className="table-scroll" style={{maxHeight: 300, overflowY: "auto"}}>
                <Table
                    columns={columns}
                    dataSource={data}
                    size="small"
                    sticky={true}
                    pagination={false}
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

export default Injects;
