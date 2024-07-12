import React, {useEffect, useState} from "react";
import {Button, Form, Modal, Radio, RadioChangeEvent, Space} from "antd";
import UserEditModal from "../../Modals/UserModals/UserEdit/UserEditModal";
import {getUsersList} from "../../../Store/Users/Actions";
import {AppState} from "../../../Store/RootReducer";
import {User} from "../../../Model/User";
import {scrollToTop} from "../../../Util/scrollToTop";
import {hasAccess} from "../../../Util/hasAccess";
import UserAddModal from "../../Modals/UserModals/UserAdd/UserAddModal";
import {useTranslation} from "react-i18next";
import TextArea from "antd/es/input/TextArea";
import PermissionsModal from "../../Modals/PermissionsModal/PermissionsModal";
import UsersTable from "./UsersTable";
import UsersCard from "./UsersCard";
import {AppstoreOutlined, DatabaseOutlined} from "@ant-design/icons";
import Spinner from "../../Misc/Spinner";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";
import sendTelegramMessageRequest from "../../../Requests/Users/SendTelegramMessageRequest";

const Users: React.FC = () => {
    const dispatch = useAppDispatch();
    const [showPermissionsModal, setShowPermissionsModal] = useState(false);
    const [showEditUserModal, setShowEditUserModal] = useState(false);
    const [showAddUserModal, setShowAddUserModal] = useState(false);
    const [selectedUser, setSelectedUser] = useState<User | null>(null);
    const {t} = useTranslation();
    const [form] = Form.useForm();

    const openEditUserModal = (user: User) => {
        setSelectedUser(user);
        setShowEditUserModal(true);
    };

    const usersReducer = useAppSelector((state: AppState) => state.users);

    const authReducer = useAppSelector((state: AppState) => state.auth);

    const callPermissionModalUser = (modalState: boolean, user: User) => {
        setSelectedUser(user);
        setShowPermissionsModal(modalState);
    };

    useEffect(() => {
        dispatch(getUsersList(usersReducer.page, usersReducer.per_page));
    }, [dispatch, usersReducer.page, usersReducer.per_page]);

    const paginationHandler = (pageNumber: number, size: number) => {
        scrollToTop();
        dispatch(getUsersList(pageNumber, size));
    };

    const [renderType, setRenderType] = useState("cards");

    const changeRenderType = (e: RadioChangeEvent) => {
        setRenderType(e.target.value);
    };

    const onFinish = () => {
        sendTelegramMessageRequest(form.getFieldValue("mailing_text"));
    };

    return (
        <>
            <div className="panel-header">
                <h2 className="panel-title">{t("SIDEBAR_NAV_USERS")}</h2>
            </div>

            <div className="affix-custom">
                <div className="bots-actions">
                    <Space>
                        {hasAccess(authReducer.user, "users.create") && (
                            <Button
                                type="primary"
                                icon={<i className="fa-solid fa-plus" style={{marginRight: 10}} />}
                                onClick={() => setShowAddUserModal(true)}
                            >
                                {t("NEW_USER")}
                            </Button>
                        )}

                        <Radio.Group
                            value={renderType}
                            onChange={changeRenderType}
                            optionType="button"
                            buttonStyle="solid"
                        >
                            <Radio.Button value="table"><DatabaseOutlined /></Radio.Button>
                            <Radio.Button value="cards"><AppstoreOutlined /></Radio.Button>
                        </Radio.Group>

                        <Button
                            type="primary"
                            icon={<i className="fa-solid fa-envelope" style={{marginRight: 10}} />}
                            onClick={() => {
                                Modal.confirm({
                                    title: t("USER_MAILING"),
                                    icon: (
                                        <span role="img" className="anticon">
                                            <i className="fa-regular fa-envelope" />
                                        </span>
                                    ),
                                    content: (
                                        <Form layout="vertical" form={form} onFinish={onFinish}>
                                            {/*
                                            <Form.Item label={t("SELECT_USER")}>
                                                <Select placeholder={t("SELECT_USER")} defaultValue="all_users">

                                                    <Select.Option value="all_users">
                                                        <Space>
                                                            <span className="anticon">
                                                                <i className="fa-solid fa-users" />
                                                            </span>
                                                            <span>
                                                                {t("ALL_USERS")}
                                                            </span>
                                                        </Space>
                                                    </Select.Option>


                                                    {Object.keys(usersReducer.users).map((user, id) => {
                                                        const currentUser = usersReducer.users[id];

                                                        return (
                                                            <Select.Option value="User #1" key={id}>
                                                                <Space>
                                                                    <span className="anticon">
                                                                        <i className="fa-solid fa-user" />
                                                                    </span>
                                                                    <span>
                                                                        [{currentUser.id}] {currentUser.token}
                                                                    </span>
                                                                </Space>
                                                            </Select.Option>
                                                        );
                                                    })}
                                                </Select>
                                            </Form.Item>
                                            */}
                                            <Form.Item name="mailing_text" label={t("USER_MAILING_TEXT")}>
                                                <TextArea rows={5} placeholder={t("USER_MAILING_TEXT")} />
                                            </Form.Item>
                                        </Form>
                                    ),
                                    cancelText: t("MODAL_BUTTON_CANCEL"),
                                    okText: t("SEND"),
                                    onOk: () => form.submit(),
                                });
                            }}
                        >
                            {t("USER_MAILING")}
                        </Button>
                    </Space>
                </div>
            </div>

            {usersReducer.isLoaded ? (
                <div className="panel-content">
                    {renderType === "cards" ? (
                        <UsersCard
                            users={[...usersReducer.users]}
                            isLoaded={usersReducer.isLoaded}
                            paginationHandler={paginationHandler}
                            editUserModal={showEditUserModal}
                            setEditUserModal={openEditUserModal}
                            permissionModal={showPermissionsModal}
                            setPermissionModal={callPermissionModalUser}
                        />
                    ) : (
                        <UsersTable
                            users={[...usersReducer.users]}
                            isLoaded={usersReducer.isLoaded}
                            paginationHandler={paginationHandler}
                            editUserModal={showEditUserModal}
                            setEditUserModal={openEditUserModal}
                            permissionModal={showPermissionsModal}
                            setPermissionModal={callPermissionModalUser}
                        />
                    )}
                </div>
            ) : (
                <div className="panel-content">

                    <Spinner />
                </div>
            )}

            {selectedUser && (
                <>
                    <UserEditModal tags={usersReducer.tags} visible={showEditUserModal} setVisible={setShowEditUserModal}
                        user={selectedUser}/>
                </>
            )}

            {showAddUserModal && (
                <UserAddModal tags={usersReducer.tags} visible={showAddUserModal} setVisible={setShowAddUserModal}/>
            )}

            {showPermissionsModal && selectedUser && (
                <PermissionsModal
                    user={selectedUser}
                    visible={showPermissionsModal}
                    setVisible={setShowPermissionsModal}
                />
            )}
        </>
    );
};

export default Users;
