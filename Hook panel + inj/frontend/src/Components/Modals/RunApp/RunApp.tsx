import React, {useState} from "react";
import {ModalWithSelectedBotsProps} from "../../../Model/Modal";
import {Button, Form, Modal, Space} from "antd";
import {getBotsId} from "../../../Util/getBotIds";
import sendCommand from "../../../Requests/Commands/sendCommands";
import {customStyles, customStylesLight, inputRules} from "../../../Util/config";
import {AppState} from "../../../Store/RootReducer";
import CreatableSelect from "react-select/creatable";
import {useTranslation} from "react-i18next";
import {useAppSelector} from "../../../Hook/useAppSelector";

const RunApp: React.FC<ModalWithSelectedBotsProps> = (props: ModalWithSelectedBotsProps) => {
    const [form] = Form.useForm();
    const {t} = useTranslation();
    const [command, setCommand] = useState("");

    const renderTitle = (title: string) => (
        <span>
            {title}
        </span>
    );

    const renderItem = (app: string) => ({
        value: app,
        label: (
            <Space size={10}>
                {app}
            </Space>
        ),
    });

    const options: any[] = [];

    if (props.selectedBots.length === 1) {
        props.selectedBots[0].applications?.forEach((application) => {
            options.push({
                label: renderTitle(application),
                options: [renderItem(application)],
            });
        });
    }

    const closeModal = () => {
        props.setVisible(false);
        form.resetFields();
    };

    const formSubmit = () => {
        sendCommand({
            command: command,
            payload: {
                app: form.getFieldsValue()["app"].value,
            },
            botIds: getBotsId(props.selectedBots),
        });

        closeModal();
    };

    const settingsReducer = useAppSelector((state: AppState) => state.settings);

    return (
        <Modal
            title={(
                <>
                    <i className="fa-solid fa-terminal" /> {t("RUN_APP")}
                </>
            )}
            open={props.visible}
            width={430}
            destroyOnClose
            onCancel={closeModal}
            footer={(
                <Button
                    onClick={closeModal}
                >
                    {t("MODAL_BUTTON_CANCEL")}
                </Button>
            )}
        >
            <Form form={form} layout="vertical" onFinish={formSubmit}>
                <Form.Item label={t("APPLICATION")} name="app" rules={inputRules}>
                    <CreatableSelect
                        styles={settingsReducer.theme === "light" ? customStylesLight : customStyles}
                        options={options}
                        placeholder={t("SELECT_APP")}
                    />
                </Form.Item>

                <div>
                    <Button
                        type="primary"
                        onClick={() => {
                            setCommand("openapp");
                            form.submit();
                        }}
                        style={{marginRight: 8}}
                    >
                        {t("RUN_APP")}
                    </Button>
                    <Button
                        type="primary"
                        onClick={() => {
                            setCommand("startapp");
                            form.submit();
                        }}
                    >
                        {t("START_APP")}
                    </Button>
                </div>
            </Form>
        </Modal>
    );
};

export default RunApp;
