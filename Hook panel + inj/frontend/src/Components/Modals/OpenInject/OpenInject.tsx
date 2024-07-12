import React from "react";
import {ModalWithSelectedBotsProps} from "../../../Model/Modal";
import {Form, Modal, Space} from "antd";
import {getBotsId} from "../../../Util/getBotIds";
import sendCommand from "../../../Requests/Commands/sendCommands";
import {AppState} from "../../../Store/RootReducer";
import {customStyles, customStylesLight, getBackendUrl, inputRules} from "../../../Util/config";
import CreatableSelect from "react-select/creatable";
import {useTranslation} from "react-i18next";
import {useAppSelector} from "../../../Hook/useAppSelector";
import {BotInjection} from "../../../Model/Bot";

const OpenInject: React.FC<ModalWithSelectedBotsProps> = (props: ModalWithSelectedBotsProps) => {
    const [form] = Form.useForm();

    const renderItem = (app: string, icon: string) => ({
        value: app,
        label: (
            <Space size={10}>
                <div className="app-icon" style={{backgroundImage: `url(${icon})`}} />
                {app}
            </Space>
        ),
    });

    const options: any[] = [];

    const renderTitle = (title: string) => (
        <span>
            {title}
        </span>
    );

    if (props.selectedBots.length === 1) {
        props.selectedBots[0].injections?.forEach((application: BotInjection) => {
            options.push({
                label: renderTitle(application.application),
                options: [renderItem(application.application, getBackendUrl(`injects/images/${application.type}/${application.application}.png`))],
            });
        });
    }

    const closeModal = () => {
        props.setVisible(false);
        form.resetFields();
    };

    const formSubmit = () => {
        sendCommand({
            command: "startinject",
            payload: {
                app: form.getFieldsValue()["app"].value,
            },
            botIds: getBotsId(props.selectedBots),
        });

        closeModal();
    };

    const settingsReducer = useAppSelector((state: AppState) => state.settings);
    const {t} = useTranslation();

    return (
        <Modal
            title={t("START_INJECT_COMMAND")}
            open={props.visible}
            onCancel={closeModal}
            onOk={() => form.submit()}
            okText={t("START_INJECT_COMMAND")}
            cancelText={t("MODAL_BUTTON_CANCEL")}
            width={340}
            destroyOnClose
        >
            <Form form={form} layout="vertical" onFinish={formSubmit}>
                <Form.Item label={t("APPLICATION")} name="app" rules={inputRules}>
                    <CreatableSelect
                        styles={settingsReducer.theme === "light" ? customStylesLight : customStyles}
                        options={options}
                        placeholder={t("SELECT_APP")}
                    />
                </Form.Item>
            </Form>
        </Modal>
    );
};

export default OpenInject;
