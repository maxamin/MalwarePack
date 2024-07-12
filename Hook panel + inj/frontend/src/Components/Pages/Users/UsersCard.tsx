import React from "react";
import {User} from "../../../Model/User";
import {Col, Divider, Pagination, Row, Tag} from "antd";
import {useTranslation} from "react-i18next";
import UserTelegram from "./UserTelegram";
import UserActions from "./UserActions";
import {AppState} from "../../../Store/RootReducer";
import {useAppSelector} from "../../../Hook/useAppSelector";
import SuspendUserButton from "./SuspendUserButton";

interface UsersCardProps {
    users: User[],
    isLoaded: boolean,
    paginationHandler: (pageNumber: number, size: number) => void,
    permissionModal: boolean,
    setPermissionModal: (modalState: boolean, user: User) => void,
    editUserModal: boolean,
    setEditUserModal: (user: User) => void,
}

const UsersCard: React.FC<UsersCardProps> = (props: UsersCardProps) => {
    const {t} = useTranslation();
    const usersReducer = useAppSelector((state: AppState) => state.users);

    return (
        <>
            <Row gutter={15}>
                {props.users.map((user, key) => {
                    const userTags = user.tags;

                    return (
                        <Col xxl={6} xl={8} md={12} sm={24} xs={24} key={key} style={{marginBottom: 15}}>
                            <div className="inject-card">
                                <div>
                                    <div className="inject-head" style={{marginTop: 0}}>
                                        <div style={{whiteSpace: "nowrap", overflow: "hidden", textOverflow: "ellipsis"}}>
                                            <h2>
                                                <i className="fa-solid fa-key" /> <span>{user.token}</span>
                                            </h2>
                                        </div>
                                        <div>
                                            <SuspendUserButton user={user} />
                                        </div>
                                    </div>

                                    <div className="inject-content">
                                        <Divider style={{margin: 0}}>
                                            {t("DATA")}
                                        </Divider>

                                        <ul className="user-info">
                                            <li>
                                                <span><b>{t("NAME")}: </b></span>
                                                <span>{user.name}</span>
                                            </li>
                                            <li>
                                                <span><b>{t("USER_COLUMN_ROLE")}: </b></span>
                                                <span>{user.role}</span>
                                            </li>
                                            <li>
                                                <span><b>{t("USER_COLUMN_EMAIL")}: </b></span>
                                                <span><a>{user.email}</a></span>
                                            </li>
                                            <li>
                                                <span><b>{t("USER_COLUMN_TAG")}: </b></span>
                                                <span>
                                                    {userTags.length > 0 ? userTags.map((tag, key) => (
                                                        <Tag key={key} color="success">
                                                            {tag.toUpperCase()}
                                                        </Tag>
                                                    )) : (
                                                        <>
                                                            &ndash;
                                                        </>
                                                    )}
                                                </span>
                                            </li>
                                            <li>
                                                <span><b>{t("USER_COLUMN_DATE")}: </b></span>
                                                <span>{user.created_at}</span>
                                            </li>
                                            <li>
                                                <span><b>{t("USER_COLUMN_EXP")}: </b></span>
                                                <span>{user.expired_at ? user.expired_at : t("NEVER")}</span>
                                            </li>
                                            {user.createdUser && (
                                                <li>
                                                    <span><b>{t("USER_COLUMN_CREATED_BY")}: </b></span>
                                                    <span><a>{user.createdUser?.name}</a></span>
                                                </li>
                                            )}
                                            <li>
                                                <div><b>Telegram: </b></div>
                                                <div>
                                                    <UserTelegram user={user} />
                                                </div>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                                <div>
                                    <Divider
                                        style={{
                                            margin: 0,
                                        }}
                                    >
                                        {t("USER_COLUMN_ACTIONS")}
                                    </Divider>
                                    <UserActions
                                        user={user}
                                        permissionModal={props.permissionModal}
                                        setPermissionModal={props.setPermissionModal}
                                        editUserModal={props.editUserModal}
                                        setEditUserModal={props.setEditUserModal}
                                    />
                                </div>
                            </div>
                        </Col>
                    );
                })}
            </Row>

            <Pagination
                onChange={props.paginationHandler}
                total={usersReducer.total}
                defaultPageSize={usersReducer.per_page}
                current={usersReducer.page}
                showSizeChanger={true}
                pageSizeOptions={[4, 8, 16, 32, 64]}
                locale={{
                    items_per_page: "",
                }}
                style={{marginTop: 15}}
            />
        </>
    );
};

export default UsersCard;
