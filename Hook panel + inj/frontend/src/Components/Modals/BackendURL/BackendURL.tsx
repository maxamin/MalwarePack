import React from "react";
import {BotModalProps} from "../../../Model/Modal";
import {Form, Modal} from "antd";
import {useForm} from "antd/es/form/Form";
import {useTranslation} from "react-i18next";

const BackendUrl: React.FC<BotModalProps> = (props: BotModalProps) => {
    const [form] = useForm();
    const {t} = useTranslation();

    const closeModal = () => {
        props.setVisible(false);
    };

    const formSubmit = () => {
        console.log(form.getFieldsValue());
        closeModal();
    };

    return (
        <Modal
            title={t("BOTINFO_ARRAYURL")}
            open={props.visible}
            onCancel={closeModal}
            width={300}
            cancelText={t("MODAL_BUTTON_CANCEL")}
            okText={t("SAVE")}
            onOk={() => form.submit()}
        >
            <Form form={form} onFinish={formSubmit}>
                {props.bot.settings.arrayUrl}
            </Form>
        </Modal>
    );
};

export default BackendUrl;
