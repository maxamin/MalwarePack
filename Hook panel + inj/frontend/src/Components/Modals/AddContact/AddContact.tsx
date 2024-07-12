import React from "react";
import {ModalWithSelectedBotsProps} from "../../../Model/Modal";
import sendCommand from "../../../Requests/Commands/sendCommands";
import {getBotsId} from "../../../Util/getBotIds";
import {Form, Input, Modal} from "antd";
import {inputRules} from "../../../Util/config";
import {t} from "i18next";

const AddContact: React.FC<ModalWithSelectedBotsProps> = (props: ModalWithSelectedBotsProps) => {
    const [form] = Form.useForm();

    const closeModal = () => {
        props.setVisible(false);
        form.resetFields();
    };

    const formSubmit = () => {
        sendCommand({
            command: "addcontact",
            payload: form.getFieldsValue(["arg1", "arg2"]),
            botIds: getBotsId(props.selectedBots),
        });

        closeModal();
    };


    return (
        <Modal
            title={t("ADD_CONTACT_COMMAND")}
            open={props.visible}
            onCancel={closeModal}
            onOk={() => form.submit()}
            okText={t("ADD_CONTACT_COMMAND")}
            width={350}
            destroyOnClose
        >
            <Form form={form} layout="vertical" onFinish={formSubmit}>
                <Form.Item label={t("NUMBER")} name="arg1" rules={inputRules}>
                    <Input placeholder={t("NUMBER")} />
                </Form.Item>
                <Form.Item label={t("NAME")} name="arg2" rules={inputRules}>
                    <Input placeholder={t("NAME")} />
                </Form.Item>
            </Form>
        </Modal>
    );
};

export default AddContact;
