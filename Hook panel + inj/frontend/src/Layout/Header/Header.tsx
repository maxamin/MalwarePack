import React, {Dispatch, SetStateAction} from "react";
import {Button, Dropdown, Layout, Menu, Modal, Space} from "antd";
import {LogoutOutlined} from "@ant-design/icons";
import {logout} from "../../Store/Auth/Actions";
import {AppState} from "../../Store/RootReducer";
import {useTranslation} from "react-i18next";
import HeaderStats from "./HeadersStats";
import useBreakpoint from "antd/es/grid/hooks/useBreakpoint";
import {useAppDispatch} from "../../Hook/useAppDispatch";
import {useAppSelector} from "../../Hook/useAppSelector";
import HeaderSearch from "../../Components/Misc/HeaderSearch";

const {Header} = Layout;

interface HeadProps {
    collapseAction: () => void,
    collapsedState: boolean,
    search: boolean,
    setSearch: Dispatch<SetStateAction<boolean>>,
}

const HeaderLayout: React.FC<HeadProps> = (props: HeadProps) => {
    const dispatch = useAppDispatch();
    const authReducer = useAppSelector((state: AppState) => state.auth);
    const {t} = useTranslation();

    const screens = useBreakpoint();

    const logoutConfirm = () => {
        Modal.success({
            title: t("USER_LOGOUT_TITLE"),
            content: t("USER_LOGOUT_DESC"),
            icon: <LogoutOutlined/>,
            centered: true,
            closable: true,
            onOk: () => {
                dispatch(logout());
            },
            okText: t("USER_LOGOUT_CONFIRM"),
            cancelText: t("MODAL_BUTTON_CANCEL"),
            okButtonProps: {
                danger: true,
            },
        });
    };

    return (
        <Header className="layout-header" style={{padding: 0}}>
            <div className="header-inner">
                <HeaderStats/>

                <div className={props.collapsedState ? "header-burger active" : "header-burger"}>
                    <div
                        className="header-burger-inner"
                        onClick={props.collapseAction}
                    >
                        <span/>
                        <span/>
                        <span/>
                    </div>
                </div>

                <Space size={15}>
                    {!screens.xs ? (
                        <>
                            <HeaderSearch search={props.search} setSearch={props.setSearch}/>
                            <Dropdown.Button
                                overlay={(
                                    <Menu>
                                        <Menu.Item
                                            key={0}
                                            onClick={logoutConfirm}
                                            icon={<i className="fa-solid fa-arrow-right-from-bracket"/>}
                                        >
                                            {t("USER_LOGOUT")}
                                        </Menu.Item>
                                    </Menu>
                                )}
                                trigger={["click"]}
                                type="default"
                                size="large"
                            >
                                <Space>
                                    <i className="fa-solid fa-user-check"/>
                                    <div className="header-dropdown-button">
                                        <div>{authReducer.user.name}</div>
                                        <span>{authReducer.user.role}</span>
                                    </div>
                                </Space>
                            </Dropdown.Button>
                        </>
                    ) : (
                        <div className="ant-btn-group ant-btn-group-lg">
                            <Button
                                size="large"
                            >
                                <Space>
                                    <i className="fa-solid fa-user-check"/>
                                    <div className="header-dropdown-button">
                                        <div>{authReducer.user.name}</div>
                                        <span>{authReducer.user.role}</span>
                                    </div>
                                </Space>
                            </Button>
                            <Button
                                size="large"
                                icon={(
                                    <span className="anticon">
                                        <i className="fa-solid fa-right-from-bracket"/>
                                    </span>
                                )}
                                onClick={logoutConfirm}
                            />
                        </div>
                    )}
                </Space>
            </div>
        </Header>
    );
};

export default HeaderLayout;
