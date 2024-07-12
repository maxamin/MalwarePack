import React, {useEffect} from "react";
import {Col, Form, Row, Space, Switch, Table} from "antd";
import {AppState} from "../../../Store/RootReducer";
import {PermissionsDataSource} from "../../Misc/PermissionsList";
import {getPermissionsList, updatePermission} from "../../../Store/Permissions/Actions";
import {useTranslation} from "react-i18next";
import Spinner from "../../Misc/Spinner";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";

const Permissions: React.FC = () => {
    const [form] = Form.useForm();
    const dispatch = useAppDispatch();
    const {t} = useTranslation();
    const permissionsReducer = useAppSelector((state: AppState) => state.permissions);

    const updatePermissionRole = (checked: boolean, permission: PermissionsDataSource, role: string) => {
        let roles = permission.roles;

        if (checked && !roles.includes(role)) {
            roles.push(role);
        } else if (!checked && roles.includes(role)) {
            roles = roles.filter((_role) => _role !== role);
        }

        dispatch(updatePermission(permission.permission, roles));
    };

    const columns = [
        {
            title: t("PERMISSION_NAME"),
            key: "permission",
            dataIndex: "permission",
            render: (text: string) => {
                return (
                    <div className="table-col">
                        <div className="table-col-item">
                            <b>{t("PERMISSION_NAME")}</b>
                        </div>
                        <div className="table-col-item">
                            {t(text)}
                        </div>
                    </div>
                );
            },
        },
        {
            title: "root",
            dataIndex: "root",
            key: "root",
            width: 60,
            render: (status: boolean, permission: PermissionsDataSource) => {
                return (
                    <div className="table-col">
                        <div className="table-col-item">
                            <h3>root</h3>
                        </div>
                        <div className="table-col-item">
                            <Form.Item
                                valuePropName="checked"
                                style={{marginBottom: 0}}
                            >
                                <Switch
                                    checked={permission.roles.includes("root")}
                                    size="small"
                                    onChange={(checked: boolean) => updatePermissionRole(checked, permission, "root")}/>
                            </Form.Item>
                        </div>
                    </div>
                );
            },
        },
        {
            title: "admin",
            dataIndex: "admin",
            key: "admin",
            width: 60,
            render: (status: boolean, permission: PermissionsDataSource) => {
                return (
                    <div className="table-col">
                        <div className="table-col-item">
                            <h3>admin</h3>
                        </div>
                        <div className="table-col-item">
                            <Form.Item
                                valuePropName="checked"
                                style={{marginBottom: 0}}
                            >
                                <Switch
                                    checked={permission.roles.includes("admin")}
                                    size="small"
                                    onChange={(checked: boolean) => updatePermissionRole(checked, permission, "admin")}/>
                            </Form.Item>
                        </div>
                    </div>
                );
            },
        },
    ];

    useEffect(() => {
        if (!permissionsReducer.isLoaded) {
            dispatch(getPermissionsList());
        }
    });

    return (
        <>
            <div className="panel-header">
                <h2 className="panel-title">{t("BOT_PERMISSIONS")}</h2>
            </div>

            <div className="panel-content">
                {permissionsReducer.isLoaded ? (
                    <div className="table-inner">
                        <Form form={form}>
                            <Row gutter={15}>
                                {Object.keys(permissionsReducer.permissions).map((group: string, key: number) => {
                                    const dataSource: PermissionsDataSource[] = [];

                                    Object.keys(permissionsReducer.permissions[group]).forEach((permission: string, index: number) => {
                                        dataSource.push({
                                            key: index,
                                            permission: permission,
                                            roles: permissionsReducer.permissions[group][permission],
                                        });
                                    });

                                    return (
                                        <Col xl={12} md={12} sm={24} xs={24} key={key} style={{marginBottom: 40}}>
                                            <Table
                                                columns={columns}
                                                dataSource={dataSource}
                                                pagination={false}
                                                size="small"
                                                title={() => <span className="table-title">{t(group)}</span>}
                                                rowKey={"key"}
                                                className="not-responsive"
                                                locale={{
                                                    emptyText: (
                                                        <Space>
                                                            <i className="fa-solid fa-robot" /> {t("TABLE_EMPTY")}
                                                        </Space>
                                                    ),
                                                }}
                                            />
                                        </Col>
                                    );
                                })}
                            </Row>
                        </Form>
                    </div>
                ) : (
                    <Spinner />
                )}
            </div>
        </>
    );
};

export default Permissions;
