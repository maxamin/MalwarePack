import React, {useEffect} from "react";
import {Checkbox, Form, Modal, Space, Table} from "antd";
import {getPermissionsList} from "../../../Store/Permissions/Actions";
import {AppState} from "../../../Store/RootReducer";
import {User} from "../../../Model/User";
import {PermissionsDataSource} from "../../Misc/PermissionsList";
import {useTranslation} from "react-i18next";
import {ModalsProps} from "../../../Model/Modal";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";

interface PermissionModalProps extends ModalsProps {
    user: User
}

const PermissionsModal: React.FC<PermissionModalProps> = (props: PermissionModalProps) => {
    const {t} = useTranslation();
    const closeModal = () => {
        props.setVisible(false);
    };

    const [form] = Form.useForm();

    const dispatch = useAppDispatch();

    const permissionsReducer = useAppSelector((state: AppState) => state.permissions);

    useEffect(() => {
        const formValues: Record<string, boolean> = {};
        form.setFieldsValue({...formValues});
    }, [form, permissionsReducer.permissions, props.user]);

    const columns = [
        {
            title: t("PERMISSION_NAME"),
            key: "permission",
            dataIndex: "permission",
            render: (permission: string) => {
                return (
                    <>{t(permission)}</>
                );
            },
        },
        {
            title: "Status",
            dataIndex: "status",
            key: "status",
            width: 60,
            render: (status: boolean, permission: PermissionsDataSource) => {
                return (
                    <Form.Item
                        name={permission.permission}
                        valuePropName="checked"
                        style={{marginBottom: 0}}
                    >
                        <Checkbox/>
                    </Form.Item>
                );
            },
        },
    ];

    const formSubmitHandler = () => {
        // TODO сохранение прав юзера
        alert("formSubmitHandler");
        props.setVisible(false);
    };

    useEffect(() => {
        if (!permissionsReducer.isLoaded) {
            dispatch(getPermissionsList());
        }
    });

    return (
        <Modal
            title={t("USER_PERMISSIONS")}
            className="modal-injects"
            open={props.visible}
            onOk={() => form.submit()}
            okText={t("SAVE")}
            cancelText={t("MODAL_BUTTON_CANCEL")}
            destroyOnClose
            onCancel={closeModal}
        >
            <div className="table-scroll" style={{maxHeight: 400, overflowY: "auto"}}>
                <Form form={form} onFinish={formSubmitHandler}>
                    {Object.keys(permissionsReducer.permissions).map((group: string, key: number) => {
                        const dataSource: PermissionsDataSource[] = [];

                        Object.keys(permissionsReducer.permissions[group]).forEach((permission: string, index: number) => {
                            dataSource.push({
                                key: index,
                                permission: permission,
                                roles: [],
                            });
                        });

                        return (
                            <div key={key}>
                                <Table
                                    columns={columns}
                                    dataSource={dataSource}
                                    pagination={false}
                                    size="small"
                                    title={() => <span className="table-title">{t(group)}</span>}
                                    showHeader={false}
                                    rowKey={"key"}
                                    className="table-permissions-modal"
                                    style={{
                                        marginBottom: 20,
                                    }}
                                    locale={{
                                        emptyText: (
                                            <Space>
                                                <i className="fa-solid fa-robot" /> {t("TABLE_EMPTY")}
                                            </Space>
                                        ),
                                    }}
                                />
                            </div>
                        );
                    })}
                </Form>
            </div>
        </Modal>
    );
};

export default PermissionsModal;
