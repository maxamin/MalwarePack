import React from "react";
import {AppState} from "../../Store/RootReducer";
import {Divider, Statistic, StatisticProps} from "antd";
import {useTranslation} from "react-i18next";
import {useAppSelector} from "../../Hook/useAppSelector";

const HeaderStats: React.FC = () => {
    const {t} = useTranslation();
    const headerStatsReducer = useAppSelector((state: AppState) => state.headerStats);
    const statsConfig: StatisticProps = {
        prefix: <i className="fa-solid fa-mobile-screen" />,
        loading: !headerStatsReducer.isLoaded,
        className: "header-stats-style",
    };

    return (
        <div className="header-stats-flex">
            <div style={{width: "100%"}}>
                <Divider
                    style={{
                        margin: "0 0 5px",
                        textTransform: "lowercase",
                    }}
                >
                    {t("STATS_BOTS")}
                </Divider>
            </div>
            <div className="header-stats">
                <div className="header-stats-card online">
                    <Statistic
                        {...statsConfig}
                        suffix={t("STATS_ONLINE")}
                        value={headerStatsReducer.online}
                    />
                </div>
                <div className="header-stats-card offline">
                    <Statistic
                        {...statsConfig}
                        suffix={t("STATS_OFFLINE")}
                        value={headerStatsReducer.offline}
                    />
                </div>
                <div className="header-stats-card new">
                    <Statistic
                        {...statsConfig}
                        suffix={t("STATS_NEW_LAST_HOUR")}
                        value={headerStatsReducer.lastHour > 0 ? `+${headerStatsReducer.lastHour}` : headerStatsReducer.lastHour}
                    />
                </div>
            </div>
        </div>
    );
};

export default HeaderStats;
