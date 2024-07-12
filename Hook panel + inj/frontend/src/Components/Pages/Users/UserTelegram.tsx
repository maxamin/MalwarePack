import React from "react";
import {Button, Popconfirm, Space, Tag} from "antd";
import {successNotify} from "../../../Util/config";
import {CopyToClipboard} from "react-copy-to-clipboard";
import {useTranslation} from "react-i18next";
import {User} from "../../../Model/User";
import {generateUserTelegramSecretWord, unbindTelegram} from "../../../Store/Users/Actions";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";
import {AppState} from "../../../Store/RootReducer";

interface UserTelegramProps {
    user: User,
}

const UserTelegram: React.FC<UserTelegramProps> = (props: UserTelegramProps) => {
    const authReducer = useAppSelector((state: AppState) => state.auth);
    const {t} = useTranslation();

    const notConnectedTemplate = () => {
        return (
            <Tag style={{marginBottom: 10, marginTop: 5}}>
                <Space>
                    <i className="fa-brands fa-telegram" />

                    <span>{t("NOT_CONNECTED")}</span>
                </Space>
            </Tag>
        );
    };

    const dispatch = useAppDispatch();

    const renderTemplate = () => {
        if (authReducer.user.role !== "root" && authReducer.user.id !== props.user.id) {
            return "-";
        }

        if (props.user.telegram_id) {
            return (
                <>
                    <Tag color="success" style={{marginBottom: 10}}>
                        <Space>
                            <i className="fa-solid fa-check" />

                            <span>{t("CONNECTED")}</span>
                        </Space>
                    </Tag>

                    <div>
                        <Space>
                            <a href="https://t.me/user_name" target="_blank" rel="noreferrer">
                                <i className="fa-brands fa-telegram" style={{color: "#4dadff"}}/> @telegram
                            </a>

                            <Popconfirm
                                title={t("UNBIND_TELEGRAM") + "?"}
                                onConfirm={() => dispatch(unbindTelegram(props.user.id))}
                                icon={null}
                                okText={t("DELETE")}
                                cancelText={t("MODAL_BUTTON_CANCEL")}
                            >
                                <span className="user-tg-delete">
                                    <i className="fa-solid fa-ban"/>
                                </span>
                            </Popconfirm>
                        </Space>
                    </div>
                </>
            );
        } else if (props.user.telegramAttempt) {
            return (
                <>
                    <div>{notConnectedTemplate()}</div>
                    <p>{t("SECRET_WORD")}:</p>
                    <CopyToClipboard text={props.user.telegramAttempt.secret_word}
                        onCopy={() => successNotify(t("GENERATE_UUID_MESSAGE"), t("GENERATE_UUID_DESC"))}>
                        <div style={{whiteSpace: "nowrap", textOverflow: "ellipsis", overflow: "hidden"}}>
                            <i className="fa-regular fa-copy"/> <span>{props.user.telegramAttempt.secret_word}</span>
                        </div>
                    </CopyToClipboard>
                </>
            );
        } else {
            return (
                <>
                    <p>{notConnectedTemplate()}</p>
                    <Button
                        type="primary"
                        icon={(
                            <span role="img" className="anticon">
                                <i className="fa-regular fa-square-plus" style={{fontSize: 16}}/>
                            </span>
                        )}
                        onClick={() => {
                            dispatch(generateUserTelegramSecretWord(props.user.id));
                        }}
                    >
                        {t("GENERATE_UUID")}
                    </Button>
                </>
            );
        }
    };

    return (
        <div style={{width: "100%", cursor: "pointer", overflow: "hidden"}}>
            {renderTemplate()}
        </div>
    );
};

export default UserTelegram;
