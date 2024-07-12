import React, {useEffect} from "react";
import {Button, Col, Form, Input, Result, Row, Space} from "antd";
import Spinner from "../../Misc/Spinner";
import {AppState} from "../../../Store/RootReducer";
import {useQuery} from "../../../Hook/useQuery";
import {useTranslation} from "react-i18next";
import sendCommand from "../../../Requests/Commands/sendCommands";
import {getBotFileManagerData} from "../../../Store/BotFileManager/Actions";
import ExplorerFiles from "./ExplorerFiles";
import ExplorerDownloadedFiles from "./ExplorerDownloadedFiles";
import useInterval from "../../../Hook/useInterval";
import {useAppSelector} from "../../../Hook/useAppSelector";
import {useAppDispatch} from "../../../Hook/useAppDispatch";

const Explorer: React.FC = () => {
    const dispatch = useAppDispatch();

    const botFileManagerReducer = useAppSelector((state: AppState) => state.botFileManager);

    const [form] = Form.useForm();

    const query = useQuery();

    const selectedBot: string = query.get("bot_id") as string;

    useEffect(() => {
        if (selectedBot && botFileManagerReducer.botId !== selectedBot) {
            dispatch(getBotFileManagerData(selectedBot));
        }
    }, [selectedBot, getBotFileManagerData, dispatch, botFileManagerReducer.botId]);

    useEffect(() => {
        form.setFieldsValue({
            current_file_manager_path: botFileManagerReducer.current_file_manager_path,
        });
    }, [botFileManagerReducer.current_file_manager_path]);

    useInterval(() => {
        if (selectedBot.length > 1) {
            dispatch(getBotFileManagerData(selectedBot));
        }
    }, 5000);

    const {t} = useTranslation();

    const sendGetFilesCommand = () => {
        sendCommand({
            command: "fmmanager",
            payload: {
                path: form.getFieldValue("current_file_manager_path"),
                extra: "ls",
            },
            botIds: [selectedBot as string],
        });
    };

    const isLoaded = botFileManagerReducer.isLoaded && botFileManagerReducer.botId === selectedBot;

    return (
        <div>
            <div className="panel-content">
                <div className="fm-content">
                    <Row>
                        <Col xl={4} lg={8} md={8} sm={24} xs={24} className="fm-content-side">
                            <div>
                                <div className="fm-content-inner">
                                    <div className="fm-list">
                                        <Form form={form} layout={"vertical"}>
                                            <Form.Item
                                                label={t("FILEMANAGER_CURRENT_PATH")}
                                                name="current_file_manager_path"
                                                initialValue={botFileManagerReducer.current_file_manager_path}
                                            >
                                                <Input
                                                    className="panel-select"
                                                    placeholder={t("FILEMANAGER_CURRENT_PATH")}
                                                />
                                            </Form.Item>
                                            <Space size={15} direction="vertical">
                                                <Button
                                                    type="primary"
                                                    icon={(
                                                        <span className="anticon">
                                                            <i className="fa-solid fa-folder-tree" />
                                                        </span>
                                                    )}
                                                    onClick={sendGetFilesCommand}
                                                >
                                                    {t("FILEMANAGER_CHANGE_DIR")}
                                                </Button>
                                                <Button
                                                    type="primary"
                                                    icon={(
                                                        <span className="anticon">
                                                            <i className="fa-solid fa-refresh" />
                                                        </span>
                                                    )}
                                                    onClick={() => dispatch(getBotFileManagerData(selectedBot))}
                                                >
                                                    {t("UPDATE")}
                                                </Button>
                                            </Space>
                                        </Form>
                                    </div>
                                </div>
                            </div>
                        </Col>
                        <Col xl={20} lg={16} md={16} sm={24} xs={24} className="fm-content-main">
                            <div className="fm-content-inner">
                                {selectedBot ? (
                                    <div className="fm-content-list2">
                                        <div className="explorer-inner">
                                            {!isLoaded && (
                                                <div className="explorer-spin">
                                                    <Spinner variant="circle" size={50} />
                                                </div>
                                            )}
                                            <ExplorerFiles files={botFileManagerReducer.files} botId={botFileManagerReducer.botId} />
                                        </div>
                                    </div>
                                ) : (
                                    <Result
                                        title={t("SELECT_BOT")}
                                        subTitle={t("SELECT_BOT_DESCRIPTION")}
                                        className="ant-result-accent"
                                        icon={(
                                            <span className="anticon">
                                                <i className="fa-regular fa-folder-open" />
                                            </span>
                                        )}
                                    />
                                )}
                            </div>
                        </Col>
                    </Row>
                </div>
            </div>

            <ExplorerDownloadedFiles downloadedFiles={botFileManagerReducer.downloadedFiles} botId={botFileManagerReducer.botId}/>
        </div>
    );
};

export default Explorer;
