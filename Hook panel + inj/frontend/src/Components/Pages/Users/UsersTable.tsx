import React from "react";
import {User} from "../../../Model/User";
import {Button, Modal, Space, Table, Tag} from "antd";
import {hasAccess} from "../../../Util/hasAccess";
import {useTranslation} from "react-i18next";
import {AppState} from "../../../Store/RootReducer";
import UserTelegram from "./UserTelegram";
import UserActions from "./UserActions";
import {useAppSelector} from "../../../Hook/useAppSelector";
import {editUser} from "../../../Store/Users/Actions";
import {useAppDispatch} from "../../../Hook/useAppDispatch";

interface UsersTableProps {
    users: User[],
    isLoaded: boolean,
    paginationHandler: (pageNumber: number, size: number) => void,
    permissionModal: boolean,
    setPermissionModal: (modalState: boolean, user: User) => void,
    editUserModal: boolean,
    setEditUserModal: (user: User) => void,
}

const UsersTable: React.FC<UsersTableProps> = (props: UsersTableProps) => {
    const {t} = useTranslation();
    const usersReducer = useAppSelector((state: AppState) => state.users);
    const authReducer = useAppSelector((state: AppState) => state.auth);
    const dispatch = useAppDispatch();

    const columns = [
        {
            title: () => (
                <div style={{textAlign: "center"}}>
                    <i className="fa-solid fa-key" /> {t("USER_COLUMN_TOKEN")}
                </div>
            ),
            dataIndex: "token",
            key: "token",
            render: (token: string, user: User) => hasAccess(authReducer.user, "users.token") && (
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("USER_COLUMN_TOKEN")}</h3>
                    </div>
                    <div className="table-col-item" style={{textAlign: "center"}}>
                        <div>{token}</div>
                        <Button
                            type={user.is_paused ? "primary" : "default"}
                            // shape="circle"
                            size="small"
                            icon={user.is_paused ? <i className="fa-solid fa-play" /> :
                                <i className="fa-solid fa-pause" />}
                            onClick={() => {
                                user.is_paused ? Modal.confirm({
                                    title: t("ACTIVATE_USER_TITLE"),
                                    content: t("ACTIVATE_USER_DESC"),
                                    cancelText: t("MODAL_BUTTON_CANCEL"),
                                    onOk: () => dispatch(editUser(user.id, {
                                        is_paused: !user.is_paused,
                                    })),
                                }) : Modal.confirm({
                                    title: t("SUSPEND_USER_TITLE"),
                                    content: t("SUSPEND_USER_DESC"),
                                    cancelText: t("MODAL_BUTTON_CANCEL"),
                                    onOk: () => dispatch(editUser(user.id, {
                                        is_paused: !user.is_paused,
                                    })),
                                });
                            }}
                            style={{display: "inline-block", marginTop: 8}}
                        />
                    </div>
                </div>
            ),

        },
        {
            title: (
                <>
                    <i className="fa-solid fa-user" /> {t("USER_COLUMN_NAME")}
                </>
            ),
            dataIndex: "name",
            key: "name",
            render: (name: string) => {
                return (
                    <div className="table-col">
                        <div className="table-col-item">
                            <h3>{t("USER_COLUMN_NAME")}</h3>
                        </div>
                        <div className="table-col-item">
                            <Tag>{name}</Tag>
                        </div>
                    </div>
                );
            },
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-user-shield" /> {t("USER_COLUMN_ROLE")}
                </>
            ),
            key: "role",
            dataIndex: "role",
            render: (role: string) => {
                return (
                    <div className="table-col">
                        <div className="table-col-item">
                            <h3>{t("USER_COLUMN_ROLE")}</h3>
                        </div>
                        <div className="table-col-item">
                            <Tag>{role.toUpperCase()}</Tag>
                        </div>
                    </div>
                );
            },
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-tags" /> {t("USER_COLUMN_TAG")}
                </>
            ),
            key: "tags",
            dataIndex: "tags",
            filters: [
                {
                    text: "tag1",
                    value: "tag1",
                },
                {
                    text: "tag2",
                    value: "tag2",
                },
                {
                    text: "tag3",
                    value: "tag3",
                },
                {
                    text: "tag4",
                    value: "tag4",
                },
            ],
            onFilter: (value: any, record: any) => record.tags.indexOf(value) === 0,
            render: (tags: string[]) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("USER_COLUMN_TAG")}</h3>
                    </div>
                    <div className="table-col-item">
                        {tags.map((item: string) => {
                            return (
                                <Tag color="success" key={item}>
                                    {item.toUpperCase()}
                                </Tag>
                            );
                        })}
                    </div>
                </div>
            ),
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-envelope" /> {t("USER_COLUMN_EMAIL")}
                </>
            ),
            dataIndex: "email",
            key: "email",
            render: (email: string) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("USER_COLUMN_EMAIL")}</h3>
                    </div>
                    <div className="table-col-item">
                        <a href="/" onClick={(e) => e.preventDefault()}>{email}</a>
                    </div>
                </div>
            ),
        },
        {
            title: (
                <>
                    <i className="fa-brands fa-telegram" /> Telegram
                </>
            ),
            dataIndex: "telegram",
            key: "telegram",
            render: (telegram: string, user: User) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>Telegram</h3>
                    </div>
                    <div className="table-col-item">
                        <UserTelegram user={user} />
                    </div>
                </div>
            ),
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-clock" /> {t("USER_COLUMN_DATE")}
                </>
            ),
            dataIndex: "created_at",
            key: "created_at",
            render: (date: string) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("USER_COLUMN_DATE")}</h3>
                    </div>
                    <div className="table-col-item">
                        {date}
                    </div>
                </div>
            ),
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-user-clock" /> {t("USER_COLUMN_EXP")}
                </>
            ),
            dataIndex: "expired_at",
            key: "expired_at",
            render: (date: string) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("USER_COLUMN_EXP")}</h3>
                    </div>
                    <div className="table-col-item">
                        {date ? date : t("NEVER")}
                    </div>
                </div>
            ),
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-user" /> {t("USER_COLUMN_CREATED_BY")}
                </>
            ),
            dataIndex: "created_by",
            key: "created_by",
            render: (date: string, user: User) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("USER_COLUMN_CREATED_BY")}</h3>
                    </div>
                    <div className="table-col-item">
                        {user.createdUser?.name}
                    </div>
                </div>
            ),
        },
        {
            title: (
                <>
                    <i className="fa-solid fa-gear" /> {t("USER_COLUMN_ACTIONS")}
                </>
            ),
            dataIndex: "action",
            key: "action",
            render: (text: string, user: User) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>{t("USER_COLUMN_ACTIONS")}</h3>
                    </div>
                    <div className="table-col-item">
                        <UserActions
                            user={user}
                            permissionModal={props.permissionModal}
                            setPermissionModal={props.setPermissionModal}
                            editUserModal={props.editUserModal}
                            setEditUserModal={props.setEditUserModal}
                        />
                    </div>
                </div>
            ),
        },
    ];

    return (
        <Table
            columns={columns}
            dataSource={props.users}
            size="large"
            loading={!props.isLoaded}
            rowKey={"id"}
            pagination={{
                total: usersReducer.total,
                defaultPageSize: usersReducer.per_page,
                onChange: props.paginationHandler,
                showSizeChanger: true,
                current: usersReducer.page,
                position: ["bottomLeft", "topLeft"],
                locale: {
                    items_per_page: "",
                },
            }}
            className="users-table"
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

export default UsersTable;
