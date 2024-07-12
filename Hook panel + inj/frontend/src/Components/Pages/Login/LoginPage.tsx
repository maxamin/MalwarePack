import React, {useState} from "react";
import "../../../Assets/Styles/Auth/Auth.scss";
import {KeyOutlined, LockOutlined, LogoutOutlined} from "@ant-design/icons";
import {Button, Divider, Form, Input, Space} from "antd";
import LoginVideoBg from "./LoginVideoBg";
import {authorize} from "../../../Store/Auth/Actions";
import {useTranslation} from "react-i18next";
import LocalePicker from "../../Misc/LocalePicker";
import {panelName} from "../../../Util/config";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";
import {AppState} from "../../../Store/RootReducer";

const LoginPage: React.FC = () => {
    const dispatch = useAppDispatch();
    const [form] = Form.useForm();
    const [loading, setLoading] = useState(false);

    const authReducer = useAppSelector((state: AppState) => state.auth);

    const authState = authReducer.formState;

    const authSubmit = () => {
        setLoading(true);

        dispatch(authorize(form.getFieldValue("token"), form.getFieldValue("password")));

        setTimeout(() => {
            setLoading(false);
        }, 1000);
    };

    const {t} = useTranslation();

    return (
        <>
            <LoginVideoBg
                poster={process.env.PUBLIC_URL + "/assets/images/login_poster.jpg"}
                video={process.env.PUBLIC_URL + "/assets/images/login_sd.mp4"}
            />

            <div className="Auth">
                <div>
                    <div className="Auth-Form-header">
                        <h1 className="Auth-Form-title">
                            <img
                                src={process.env.PUBLIC_URL + "/images/hook.svg"}
                                style={{
                                    width: 60,
                                }}
                                alt=""
                            />
                            {panelName}
                        </h1>
                    </div>

                    <div className="Auth-inner">
                        <Form
                            className="Auth-Form"
                            layout="vertical"
                            onFinish={authSubmit}
                            form={form}
                            style={{
                                width: 400,
                            }}
                        >
                            {authState === "login" && (
                                <>
                                    <Form.Item label={t("Token")} name="token">
                                        <Input
                                            name="token"
                                            prefix={<KeyOutlined/>}
                                            placeholder={t("AUTH_TOKEN_PLACEHOLDER")}
                                            className="ant-login-input"
                                        />
                                    </Form.Item>
                                    <Form.Item label={t("AUTH_CODEWORD")} name="password">
                                        <Input.Password
                                            name="password"
                                            prefix={<LockOutlined/>}
                                            placeholder={t("AUTH_CODEWORD")}
                                            className="ant-login-input"
                                        />
                                    </Form.Item>
                                </>
                            )}

                            {authState === "telegram" && (
                                <div className="auth-error-message">
                                    <h2 style={{lineHeight: 1}}>
                                        {t("LOGIN_ATTEMPT_LIMIT_TITLE")}
                                    </h2>

                                    <p>
                                        {t("LOGIN_ATTEMPT_ERROR_MESSAGE")}
                                    </p>

                                    <Form.Item name="authCheckCode" label={t("LOGIN_ATTEMPT_CODE_MESSAGE")}>
                                        <Input placeholder={t("ACTION_CODE")} className="ant-login-input" />
                                    </Form.Item>
                                </div>
                            )}

                            {authState === "error" && (
                                <div className="auth-error-message">
                                    <h2 style={{lineHeight: 1}}>
                                        {t("LOGIN_ATTEMPT_LIMIT_TITLE")}
                                    </h2>

                                    <p>
                                        {t("LOGIN_ATTEMPT_ERROR_CONTACT_ADMIN")}
                                    </p>
                                </div>
                            )}

                            {authState !== "error" && (
                                <Space style={{justifyContent: "center", width: "100%"}}>
                                    <Button
                                        type="default"
                                        className="Auth-Form-button"
                                        icon={<LogoutOutlined/>}
                                        htmlType="submit"
                                        loading={loading}
                                    >
                                        {t("AUTH_SIGN_IN")}
                                    </Button>
                                </Space>
                            )}

                            <Divider />

                            <div style={{display: "flex", gap: 15, justifyContent: "center", alignItems: "center"}}>
                                <span>{t("CHANGE_LANGUAGE")}</span>
                                <LocalePicker />
                            </div>
                        </Form>
                    </div>
                </div>
            </div>
        </>
    );
};

export default LoginPage;
