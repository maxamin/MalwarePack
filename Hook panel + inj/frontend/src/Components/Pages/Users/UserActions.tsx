import React from "react";
import {hasAccess} from "../../../Util/hasAccess";
import {Button, Modal, Space} from "antd";
import {deleteUser} from "../../../Store/Users/Actions";
import {User} from "../../../Model/User";
import {t} from "i18next";
import {AppState} from "../../../Store/RootReducer";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";

interface UserActionsProps {
    user: User,
    permissionModal: boolean,
    setPermissionModal: (modalState: boolean, user: User) => void,
    editUserModal: boolean,
    setEditUserModal: (user: User) => void,
}

const UserActions: React.FC<UserActionsProps> = (props: UserActionsProps) => {
    const authReducer = useAppSelector((state: AppState) => state.auth);
    const dispatch = useAppDispatch();

    return (
        <Space size={10}>
            {hasAccess(authReducer.user, "users.edit") && (
                <Button
                    type="primary"
                    shape="circle"
                    icon={<i className="fa-solid fa-pencil" />}
                    onClick={() => props.setEditUserModal(props.user)}
                />
            )}

            {/*
            <Button
                type="primary"
                onClick={() => props.setPermissionModal(true, props.user)}
                icon={<LockOutlined />}
            />
            */}

            {authReducer.user.id !== props.user.id && (
                <>
                    {hasAccess(authReducer.user, "users.delete") && (
                        <Button
                            danger
                            type="primary"
                            shape="circle"
                            icon={<i className="fa-solid fa-trash-arrow-up" />}
                            onClick={() => Modal.confirm({
                                title: t("DELETE_USER_TITLE"),
                                content: t("UNDONE_ACTION"),
                                okText: t("BOT_ACTION_DELETE_CONFIRM"),
                                cancelText: t("MODAL_BUTTON_CANCEL"),
                                onOk: () => {
                                    dispatch(deleteUser(props.user.id));
                                },
                            })}
                        />
                    )}
                </>
            )}
        </Space>
    );
};

export default UserActions;
