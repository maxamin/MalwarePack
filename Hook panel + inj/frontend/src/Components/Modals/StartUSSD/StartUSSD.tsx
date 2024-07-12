import React, {useEffect} from "react";
import {ModalWithSelectedBotsProps} from "../../../Model/Modal";
import {Col, Form, Input, Modal, Row} from "antd";
import {getBotsId} from "../../../Util/getBotIds";
import sendCommand from "../../../Requests/Commands/sendCommands";
import {inputRules} from "../../../Util/config";
import {useTranslation} from "react-i18next";
import {SimCardIcon} from "../../Misc/CustomIcons";

const StartUSSD: React.FC<ModalWithSelectedBotsProps> = (props: ModalWithSelectedBotsProps) => {
    const [form] = Form.useForm();
    const {t} = useTranslation();

    useEffect(() => {
        form.setFieldsValue({
            sim: "sim1",
        });
    }, [form]);

    const closeModal = () => {
        props.setVisible(false);
        form.resetFields();
    };
    const formSubmit = () => {
        sendCommand({
            command: "startussd",
            payload: form.getFieldsValue(["sim", "ussd"]),
            botIds: getBotsId(props.selectedBots),
        });

        closeModal();
    };

    return (
        <Modal
            title={t("START_USSD_COMMAND")}
            open={props.visible}
            onCancel={closeModal}
            onOk={() => form.submit()}
            okText={t("START_USSD_COMMAND")}
            cancelText={t("MODAL_BUTTON_CANCEL")}
            width={340}
            destroyOnClose
        >
            <Form.Item label={t("SELECT_SIM")} name="sim" valuePropName="value">
                <Row gutter={15}>
                    <Col span={12}>
                        <label className={props.selectedBots[0].sim_data?.operator ? "sim-card" : "sim-card disabled"}>
                            <Input
                                type="radio"
                                name="sim"
                                value={"sim1"}
                                className="sim-card-radio"
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
                            </span>
                        </label>
                    </Col>
                </Row>
            </Form.Item>
            <Form form={form} layout="vertical" onFinish={formSubmit}>
                <Form.Item
                    label={t("USSD")}
                    name="ussd"
                    rules={inputRules}
                >
                    <Input type="text" placeholder={t("USSD")} />
                </Form.Item>
            </Form>
        </Modal>
    );
};

export default StartUSSD;
