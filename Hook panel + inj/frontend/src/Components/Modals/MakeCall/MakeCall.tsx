import React from "react";
import {ModalWithSelectedBotsProps} from "../../../Model/Modal";
import {Form, Input, Modal} from "antd";
import {getBotsId} from "../../../Util/getBotIds";
import sendCommand from "../../../Requests/Commands/sendCommands";
import {inputRules} from "../../../Util/config";
import {useTranslation} from "react-i18next";

const MakeCall: React.FC<ModalWithSelectedBotsProps> = (props: ModalWithSelectedBotsProps) => {
    const [form] = Form.useForm();
    const {t} = useTranslation();

    const closeModal = () => {
        props.setVisible(false);
        form.resetFields();
    };
    const formSubmit = () => {
        sendCommand({
            command: "makecall",
            payload: form.getFieldsValue(["arg1"]),
            botIds: getBotsId(props.selectedBots),
        });

        closeModal();
    };

    return (
        <Modal
            title="Make Call"
            open={props.visible}
            onCancel={closeModal}
            onOk={() => form.submit()}
            okText="Send"
            width={340}
            destroyOnClose
        >
            <Form form={form} layout="vertical" onFinish={formSubmit}>
                <Form.Item
                    label={t("NUMBER")}
                    name="arg1"
                    rules={inputRules}
                >
                    <Input type="text" placeholder={t("NUMBER")} />
                </Form.Item>
            </Form>
        </Modal>
    );
};

export default MakeCall;
