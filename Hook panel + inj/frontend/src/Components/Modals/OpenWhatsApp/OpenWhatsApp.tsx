import React from "react";
import {ModalWithSelectedBotsProps} from "../../../Model/Modal";
import sendCommand from "../../../Requests/Commands/sendCommands";
import {getBotsId} from "../../../Util/getBotIds";
import {Form, Input, Modal} from "antd";
import {inputRules} from "../../../Util/config";
import {t} from "i18next";

const {TextArea} = Input;

const OpenWhatsApp: React.FC<ModalWithSelectedBotsProps> = (props: ModalWithSelectedBotsProps) => {
    const [form] = Form.useForm();

    const closeModal = () => {
        props.setVisible(false);
        form.resetFields();
    };

    const formSubmit = () => {
        sendCommand({
            command: "openwhatsapp",
            payload: form.getFieldsValue(["arg1", "arg2"]),
            botIds: getBotsId(props.selectedBots),
        });

        closeModal();
    };


    return (
        <Modal
            title={t("OPEN_WHATSAPP_COMMAND")}
            open={props.visible}
            onCancel={closeModal}
            onOk={() => form.submit()}
            okText={t("OPEN_WHATSAPP_COMMAND")}
            cancelText={t("MODAL_BUTTON_CANCEL")}
            width={350}
            destroyOnClose
        >
            <Form form={form} layout="vertical" onFinish={formSubmit}>
                <Form.Item label={t("NUMBER")} name="arg1" rules={inputRules}>
                    <Input placeholder={t("NUMBER")} />
                </Form.Item>
                <Form.Item label={t("MESSAGE")} name="arg2" rules={inputRules}>
                    <TextArea placeholder={t("MESSAGE")} />
                </Form.Item>
            </Form>
        </Modal>
    );
};

export default OpenWhatsApp;
