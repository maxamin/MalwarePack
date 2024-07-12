import React, {useEffect, useLayoutEffect, useState} from "react";
import {Button, Popconfirm, Radio, RadioChangeEvent, Result, Select, Space} from "antd";
import {AppState} from "../../../Store/RootReducer";
import {getSmartInjectionSessionsList, setSmartInjectionsPage} from "../../../Store/SmartInjections/Actions";
import useInterval from "../../../Hook/useInterval";
import {setCountAction} from "../../../Store/Counts/Actions";
import {useTranslation} from "react-i18next";
import {AppstoreOutlined, DatabaseOutlined, OrderedListOutlined} from "@ant-design/icons";
import SmartInjectCardItem from "../SmartInjections/SmartInjectCardItem";
import SmartInjectTable from "../SmartInjections/SmartInjectTable";
import {scrollToTop} from "../../../Util/scrollToTop";
import Spinner from "../../Misc/Spinner";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";

const {Option} = Select;

const Fishing: React.FC = () => {
    const {t} = useTranslation();
    const dispatch = useAppDispatch();
    const [renderType, setRenderType] = useState("cards");

    const paginationHandler = (pageNumber: number, size: number) => {
        if (smartInjectionsReducer.isLoaded &&
            smartInjectionsReducer.page === smartInjectionsReducer.loaded_page &&
            smartInjectionsReducer.page === smartInjectionsReducer.loaded_page &&
            smartInjectionsReducer.loaded_per_page === smartInjectionsReducer.per_page) {
            scrollToTop();
            dispatch(setSmartInjectionsPage(pageNumber, size));
        }
    };

    const smartInjectionsReducer = useAppSelector((state: AppState) => state.smartInjections);

    useLayoutEffect(() => {
        dispatch(getSmartInjectionSessionsList(
            smartInjectionsReducer.filters,
            smartInjectionsReducer.sort,
            smartInjectionsReducer.page,
            smartInjectionsReducer.per_page,
        ));
    }, [
        dispatch,
        smartInjectionsReducer.page,
        smartInjectionsReducer.per_page,
        smartInjectionsReducer.sort,
        smartInjectionsReducer.filters,
    ]);

    useEffect(() => {
        dispatch(setCountAction({
            smart_injects: 0,
        }));
    }, [smartInjectionsReducer.total, dispatch]);

    useInterval(() => dispatch(getSmartInjectionSessionsList(
        smartInjectionsReducer.filters,
        smartInjectionsReducer.sort,
        smartInjectionsReducer.page,
        smartInjectionsReducer.per_page,
    )), 2000);

    const smartInjectionsFilter = (
        <Space direction="vertical">
            <Select
                placeholder="Type"
                optionLabelProp="label"
                className="panel-select"
                allowClear
                style={{width: 280, position: "relative", zIndex: 4}}
                dropdownClassName="select-pop"
            >
                <Option value="app" label="App">App</Option>
                <Option value="site_url" label="Site URL">Site URL</Option>
            </Select>

            <Select
                placeholder="Status"
                optionLabelProp="label"
                className="panel-select"
                allowClear
                style={{width: 280, position: "relative", zIndex: 4}}
                dropdownClassName="select-pop"
            >
                <Option value="sm_active" label="Active only">Active only</Option>
                <Option value="sm_all" label="All">All</Option>
            </Select>
        </Space>
    );

    const changeRenderType = (e: RadioChangeEvent) => {
        setRenderType(e.target.value);
    };

    return (
        <>
            <div className="panel-header">
                <h2 className="panel-title">{t("SIDEBAR_NAV_FISHING")}</h2>
            </div>

            {smartInjectionsReducer.isLoaded ? (
                <>
                    {smartInjectionsReducer.sessions.length < 0 ? (
                        <>
                            <div className="affix-custom">
                                <div className="bots-actions">
                                    <Space>
                                        <Popconfirm
                                            title={smartInjectionsFilter}
                                            icon={null}
                                            placement={"bottomLeft"}
                                            cancelText={t("MODAL_BUTTON_CANCEL")}
                                        >
                                            <Button
                                                type="primary"
                                                icon={<OrderedListOutlined />}
                                            >
                                                {t("FILTERS_BTN")}
                                            </Button>
                                        </Popconfirm>

                                        <Radio.Group
                                            value={renderType}
                                            onChange={changeRenderType}
                                            optionType="button"
                                            buttonStyle="solid"
                                        >
                                            <Radio.Button value="table"><DatabaseOutlined /></Radio.Button>
                                            <Radio.Button value="cards"><AppstoreOutlined /></Radio.Button>
                                        </Radio.Group>
                                    </Space>
                                </div>
                            </div>

                            {renderType === "cards" ? (
                                <SmartInjectCardItem
                                    inject={smartInjectionsReducer.sessions}
                                    paginationHandler={paginationHandler}
                                    isLoaded={smartInjectionsReducer.isLoaded}
                                />
                            ) : (
                                <SmartInjectTable
                                    inject={smartInjectionsReducer.sessions}
                                    paginationHandler={paginationHandler}
                                />
                            )}
                        </>
                    ) : (
                        <div className="bots-list-404">
                            <Result
                                status="warning"
                                title={t("EMPTY")}
                                subTitle={t("EMPTY_DESCRIPTION")}
                                icon={(
                                    <span className="anticon">
                                        <i className="fa-solid fa-robot" />
                                    </span>
                                )}
                            />
                        </div>
                    )}
                </>
            ) : (
                <Spinner />
            )}
        </>
    );
};

export default Fishing;
