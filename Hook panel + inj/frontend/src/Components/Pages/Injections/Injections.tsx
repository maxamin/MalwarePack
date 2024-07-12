import React, {useLayoutEffect, useState} from "react";
import {Button, Input, Popconfirm, Radio, RadioChangeEvent, Result, Space} from "antd";
import {AppstoreOutlined, DatabaseOutlined, OrderedListOutlined, PlusSquareOutlined} from "@ant-design/icons";
import AddInject from "../../Modals/AddInject/AddInject";
import {AppState} from "../../../Store/RootReducer";
import {changeInjectsFilters, getInjectsList, setInjectsPage} from "../../../Store/Injections/Actions";
import {Inject} from "../../../Model/Inject";
import {scrollToTop} from "../../../Util/scrollToTop";
import EditInject from "../../Modals/EditInject/EditInject";
import {hasAccess} from "../../../Util/hasAccess";
import InjectionsFilter from "./InjectionsFilter";
import {useTranslation} from "react-i18next";
import InjectionsCards from "./InjectionsCards";
import InjectionsTable from "./InjectionsTable";
import Spinner from "../../Misc/Spinner";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";

const Injections: React.FC = () => {
    const [showEditInject, setShowEditInject] = useState(false);
    const [showAddInject, setShowAddInject] = useState(false);
    const [selectedInjection, setSelectedInjection] = useState<Inject|null>(null);
    const [renderType, setRenderType] = useState("cards");

    const setShowEditInjectModal = (injection: Inject) => {
        setSelectedInjection(injection);
        setShowEditInject(true);
    };

    const dispatch = useAppDispatch();

    const injectionsReducer = useAppSelector((state: AppState) => state.injects);

    useLayoutEffect(() => {
        dispatch(getInjectsList(
            injectionsReducer.filters,
            injectionsReducer.sort,
            injectionsReducer.page,
            injectionsReducer.per_page,
        ));
    }, [dispatch, injectionsReducer.page, injectionsReducer.per_page, injectionsReducer.sort, injectionsReducer.filters]);

    const injectsPaginationHandler = (pageNumber: number, size: number) => {
        if (injectionsReducer.isLoaded &&
            injectionsReducer.page === injectionsReducer.loaded_page &&
            injectionsReducer.page === injectionsReducer.loaded_page &&
            injectionsReducer.loaded_per_page === injectionsReducer.per_page) {
            scrollToTop();
            dispatch(setInjectsPage(pageNumber, size));
        }
    };

    const isLoaded = injectionsReducer.isLoaded &&
        injectionsReducer.isLoaded &&
        injectionsReducer.page === injectionsReducer.loaded_page &&
        injectionsReducer.loaded_per_page === injectionsReducer.per_page;

    const authReducer = useAppSelector((state: AppState) => state.auth);

    const {t} = useTranslation();

    const changeRenderType = (e: RadioChangeEvent) => {
        setRenderType(e.target.value);
    };

    return (
        <>
            <div className="panel-header">
                <h2 className="panel-title">{t("SIDEBAR_NAV_INJECTIONS")}</h2>
            </div>

            <div className="affix-custom">
                <div className="bots-actions">
                    <Space>
                        <Popconfirm
                            title={<InjectionsFilter />}
                            icon={null}
                            placement="bottomLeft"
                            cancelText={t("MODAL_BUTTON_CANCEL")}
                        >
                            <Button
                                icon={<OrderedListOutlined />}
                                type="primary"
                                disabled={!injectionsReducer.isLoaded}
                            >
                                {t("FILTERS_BTN")}
                            </Button>
                        </Popconfirm>

                        <Radio.Group
                            value={renderType}
                            onChange={changeRenderType}
                            optionType="button"
                            buttonStyle="solid"
                            disabled={!injectionsReducer.isLoaded}
                        >
                            <Radio.Button value="table">
                                <DatabaseOutlined />
                            </Radio.Button>
                            <Radio.Button value="cards">
                                <AppstoreOutlined />
                            </Radio.Button>
                        </Radio.Group>

                        {hasAccess(authReducer.user, "injections.create") && (
                            <Button
                                type="primary"
                                icon={<PlusSquareOutlined/>}
                                onClick={() => setShowAddInject(true)}
                                disabled={!injectionsReducer.isLoaded}
                            >
                                {t("NEW_INJECT")}
                            </Button>
                        )}

                        <Input.Search
                            className="panel-select"
                            placeholder={t("SEARCH_INJECT_NAME")}
                            enterButton={t("SEARCH_INJECT")}
                            loading={!isLoaded}
                            defaultValue={injectionsReducer.filters.query}
                            allowClear
                            onSearch={(searchQuery: string) => {
                                dispatch(changeInjectsFilters({
                                    query: searchQuery,
                                }));
                            }}
                            disabled={!injectionsReducer.isLoaded}
                        />
                    </Space>
                </div>
            </div>

            {injectionsReducer.isLoaded ? (
                <>
                    {injectionsReducer.injections.length !== 0 ? (
                        <>
                            {renderType === "cards" ? (
                                <InjectionsCards
                                    inject={injectionsReducer.injections}
                                    paginationHandler={injectsPaginationHandler}
                                    showEditInjectModal={showEditInject}
                                    setShowEditInjectModal={setShowEditInjectModal}
                                    isLoaded={isLoaded}
                                />
                            ) : (
                                <InjectionsTable
                                    inject={injectionsReducer.injections}
                                    paginationHandler={injectsPaginationHandler}
                                    isLoaded={isLoaded}
                                    showEditInjectModal={showEditInject}
                                    setShowEditInjectModal={setShowEditInjectModal}
                                />
                            )}
                        </>
                    ) : (
                        <Result
                            className="ant-result-accent"
                            icon={(
                                <span className="anticon">
                                    <i className="fa-solid fa-list-check" />
                                </span>
                            )}
                            title={t("EMPTY")}
                            subTitle={t("EMPTY_DESCRIPTION")}
                        />
                    )}
                </>
            ): (
                <Spinner />
            )}

            {selectedInjection && (
                <>
                    <EditInject visible={showEditInject} setVisible={setShowEditInject} injection={selectedInjection} />
                </>
            )}

            <AddInject visible={showAddInject} setVisible={setShowAddInject} />
        </>
    );
};

export default Injections;
