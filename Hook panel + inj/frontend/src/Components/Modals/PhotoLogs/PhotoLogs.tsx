import React, {useEffect} from "react";
import {Button, Image, Modal, Result} from "antd";
import {RedoOutlined} from "@ant-design/icons";
import {BotModalProps} from "../../../Model/Modal";
import {useTranslation} from "react-i18next";
import {AppState} from "../../../Store/RootReducer";
import {deleteLog, getLogsList} from "../../../Store/Logs/Actions";
import {BotLog} from "../../../Model/BotLog";
import {getBackendUrl} from "../../../Util/config";
import Spinner from "../../Misc/Spinner";
import sendCommand from "../../../Requests/Commands/sendCommands";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";

interface ScreenshotLog {
    image: string,
    created_at: string,
}

const PhotoLogs: React.FC<BotModalProps> = (props: BotModalProps) => {
    const {t} = useTranslation();

    const logsReducer = useAppSelector((state: AppState) => state.logs);
    const dispatch = useAppDispatch();

    useEffect(() => {
        if (props.visible) {
            dispatch(getLogsList("photo", props.bot.id, null, logsReducer.filters, logsReducer.sort, 1));
        }
    }, [dispatch, props.bot.id, props.visible]);

    const closeModal = () => {
        props.setVisible(false);
    };

    const refreshData = () => {
        dispatch(getLogsList(
            "photo",
            props.bot.id,
            null, logsReducer.
                filters,
            logsReducer.sort,
            1,
        ));
    };

    const isLoaded = logsReducer.isLoaded && logsReducer.type === "photo" &&
        logsReducer.botId === props.bot.id;

    const deleteScreenshot = (logId: number) => {
        Modal.confirm({
            title: t("SCREENSHOT_DELETE") + "?",
            content: t("UNDONE_ACTION"),
            onOk: () => {
                dispatch(deleteLog([logId]));
            },
            okText: t("ACTION_DELETE"),
            okButtonProps: {
                danger: true,
            },
            cancelText: t("MODAL_BUTTON_CANCEL"),
        });
    };

    return (
        <Modal
            title={t("PhotoLogs")}
            open={props.visible}
            onCancel={closeModal}
            width={520}
            destroyOnClose
            footer={(
                <>
                    <Button
                        type="primary"
                        onClick={refreshData}
                        icon={<RedoOutlined />}
                    >
                        {t("REFRESH")}
                    </Button>
                    <Button
                        type="primary"
                        onClick={closeModal}
                        danger
                    >
                        {t("CLOSE")}
                    </Button>
                </>
            )}
        >
            <div className="screen-scroll">
                {isLoaded ? (
                    logsReducer.logs.length > 0 ? (
                        <div className="screen-grid">
                            <Image.PreviewGroup>
                                {logsReducer.logs.map((log: BotLog) => {
                                    const logData = log.log as unknown as ScreenshotLog;
                                    return (
                                        <div className="screen-grid-item" key={log.id}>
                                            <Button
                                                type="primary"
                                                size="small"
                                                icon={(
                                                    <span className="anticon">
                                                        <i className="fa-solid fa-trash" />
                                                    </span>
                                                )}
                                                onClick={() => deleteScreenshot(log.id)}
                                                danger
                                            />
                                            <Image src={getBackendUrl(logData.image)} />
                                            <div className="screen-date">{logData.created_at}</div>
                                        </div>
                                    );
                                })}
                            </Image.PreviewGroup>
                        </div>
                    ) : (
                        <Result
                            status="warning"
                            title={t("EMPTY")}
                            subTitle={t("EMPTY_DESCRIPTION")}
                            icon={(
                                <span className="anticon">
                                    <i className="fa-solid fa-robot" />
                                </span>
                            )}
                            extra={(
                                <Button
                                    type="dashed"
                                    icon={(
                                        <span className="anticon">
                                            <i className="command-icon fa-solid fa-mobile-screen" />
                                        </span>
                                    )}
                                    onClick={() => {
                                        sendCommand({
                                            command: "photo",
                                            payload: [],
                                            botIds: [props.bot.id],
                                        });
                                    }}
                                >
                                    {t("TAKE_SCREENSHOT_COMMAND")}
                                </Button>
                            )}
                        />
                    )
                ) : (
                    <Spinner />
                )}
            </div>
        </Modal>
    );
};

export default PhotoLogs;
