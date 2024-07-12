import React from "react";
import {Col, Input, Row, Space} from "antd";
import {AppState} from "../../Store/RootReducer";
import {changeLogsFilters} from "../../Store/Logs/Actions";
import {InjectionFilter} from "../../Store/Filters/Types";
import {customStyles, customStylesLight, getBackendUrl} from "../../Util/config";
import CreatableSelect from "react-select/creatable";
import {logsType} from "./BotLogsTable";
import {useTranslation} from "react-i18next";
import {useAppDispatch} from "../../Hook/useAppDispatch";
import {useAppSelector} from "../../Hook/useAppSelector";

const {Search} = Input;

interface LogsFilterProps {
    logsType: logsType,
}

const LogsFilter: React.FC<LogsFilterProps> = (props: LogsFilterProps) => {
    const dispatch = useAppDispatch();
    const filters = useAppSelector((state: AppState) => state.filters);

    const injectionsFilterChange = (application: string) => {
        dispatch(changeLogsFilters({
            application: application,
        }));
    };

    const renderTitle = (title: string) => (
        <span>
            {title}
        </span>
    );

    const renderItem = (app: string, icon: string) => ({
        value: app,
        label: (
            <Space size={10}>
                <img width={16} src={icon} alt={app} />
                {app}
            </Space>
        ),
    });

    const applications: any[] = [];

    if (filters.isLoaded && filters.applications[props.logsType] !== undefined) {
        Object.keys(filters.applications[props.logsType]).map((application: string) => {
            const injection: InjectionFilter = filters.applications[props.logsType][application];

            applications.push({
                label: renderTitle(application),
                options: [renderItem(application, getBackendUrl(`injects/images/${injection.type}/${application}.png`))],
            });
        });
    }

    const {t} = useTranslation();

    const settingsReducer = useAppSelector((state: AppState) => state.settings);

    return (
        <Row gutter={15}>
            <Col span={24} style={{marginBottom: 15}}>
                <Search name={"searchQuery"} className="panel-select"
                    enterButton={t("SEARCH_PLACEHOLDER")} placeholder={t("SEARCH_PLACEHOLDER")} onSearch={(searchQuery: string) => {
                        dispatch(changeLogsFilters({
                            query: searchQuery,
                        }));
                    }}/>
            </Col>
            <Col span={24} style={{marginBottom: 15}}>
                <CreatableSelect
                    styles={settingsReducer.theme === "light" ? customStylesLight : customStyles}
                    options={applications}
                    onChange={(value) => {
                        if (!value) {
                            injectionsFilterChange("");
                        } else {
                            injectionsFilterChange(value.value);
                        }
                    }}
                    placeholder={t("SELECT_APP")}
                    formatCreateLabel={(label: string) => label}
                    isClearable
                />
            </Col>
        </Row>
    );
};

export default LogsFilter;
