import React, {useLayoutEffect} from "react";
import {Col, Form, Input, Modal, Row} from "antd";
import {ModalWithSelectedBotsProps} from "../../../Model/Modal";
import {SimCardIcon} from "../../Misc/CustomIcons";
import {getBotsId} from "../../../Util/getBotIds";
import sendCommand from "../../../Requests/Commands/sendCommands";
import {inputRules} from "../../../Util/config";
import {useTranslation} from "react-i18next";

const {TextArea} = Input;

const SendSMSMany: React.FC<ModalWithSelectedBotsProps> = (props: ModalWithSelectedBotsProps) => {
    const [form] = Form.useForm();
    const {t} = useTranslation();

    useLayoutEffect(() => {
        form.setFieldsValue({
            sim: "sim1",
        });
    }, [form]);

    const closeModal = () => {
        props.setVisible(false);
        form.resetFields();
        form.setFieldsValue({
            sim: "sim1",
        });
    };

    const submitCommand = () => {
        console.log(form.getFieldsValue());
        form.validateFields().then((fields) => {
            sendCommand({
                command: "send_sms_many",
                payload: {
                    sim: fields["sim"] ?? "sim1",
                    text: fields["text"],
                    numbers: fields["numbers"],
                },
                botIds: getBotsId(props.selectedBots),
            });
            closeModal();
        });
    };

    return (
        <Modal
            title={(
                <>
                    <i className="fa-solid fa-comment-sms" /> {t("SEND_MANY_SMS")}
                </>
            )}
            open={props.visible}
            onCancel={closeModal}
            onOk={() => form.submit()}
            okText={t("SEND_SMS")}
            width={440}
            destroyOnClose
            cancelText={t("MODAL_BUTTON_CANCEL")}
        >
            <Form form={form} layout="vertical" onFinish={submitCommand}>
                {props.selectedBots.length === 1 && (
                    <Form.Item label={t("SELECT_SIM")} name="sim" valuePropName="value">
                        <Row gutter={15}>
                            <Col span={12}>
                                <label className={props.selectedBots[0].sim_data?.operator ? "sim-card" : "sim-card disabled"}>
                                    <Input
                                        type="radio"
                                        name="sim"
                                        value={"sim1"}
                                        className="sim-card-radio"
                                        defaultChecked={true}
                                        disabled={!props.selectedBots[0].sim_data?.operator}
                                    />
                                    <span className="sim-card-inner">
                                        <span className="sim-card-icon">
                                            <SimCardIcon/>
                                        </span>
                                        <span className="sim-card-info">
                                            <span className="sim-card-name">
                                                Sim #1
                                            </span>
                                            <span className="sim-card-provider">
                                                {props.selectedBots[0].sim_data?.operator ? props.selectedBots[0].sim_data?.operator : "Empty"}
                                            </span>
                                        </span>
                                        <i className="sim-card-checked fa-solid fa-check" />
                                    </span>
                                </label>
                            </Col>
                            <Col span={12}>
                                <label className={props.selectedBots[0].sim_data?.operator1 ? "sim-card" : "sim-card disabled"}>
                                    <Input
                                        type="radio"
                                        name="sim"
                                        value={"sim2"}
                                        className="sim-card-radio"
                                        disabled={!props.selectedBots[0].sim_data?.operator1}
                                    />
                                    <span className="sim-card-inner">
                                        <span className="sim-card-icon">
                                            <SimCardIcon/>
                                        </span>
                                        <span className="sim-card-info">
                                            <span className="sim-card-name">
                                                Sim #2
                                            </span>
                                            <span className="sim-card-provider">
                                                {props.selectedBots[0].sim_data?.operator1 ? props.selectedBots[0].sim_data?.operator1 : "Empty"}
                                            </span>
                                        </span>
                                        <i className="sim-card-checked fa-solid fa-check" />
                                    </span>
                                </label>
                            </Col>
                        </Row>
                    </Form.Item>
                )}
                <Form.Item
                    name="numbers"
                    label={t("TELEPHONE_NUMBERS")}
                    rules={inputRules}
                >
                    <Input type="text" size="large" placeholder={t("TELEPHONE_NUMBERS")} />
                </Form.Item>
                <Form.Item
                    label={t("TYPE_MESSAGE")}
                    name="text"
                    rules={inputRules}
                >
                    <TextArea size="large" placeholder={t("TYPE_MESSAGE")} />
                </Form.Item>
            </Form>
        </Modal>
    );
};

export default SendSMSMany;
