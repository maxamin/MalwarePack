import React, {useEffect} from "react";
import {ModalWithSelectedBotsProps} from "../../../Model/Modal";
import {Col, Form, Input, Modal, Row} from "antd";
import {SimCardIcon} from "../../Misc/CustomIcons";
import {getBotsId} from "../../../Util/getBotIds";
import sendCommand from "../../../Requests/Commands/sendCommands";
import {inputRules} from "../../../Util/config";
import {useTranslation} from "react-i18next";

const ForwardCall: React.FC<ModalWithSelectedBotsProps> = (props: ModalWithSelectedBotsProps) => {
    const [form] = Form.useForm();

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
            command: "forwardCall",
            payload: form.getFieldsValue(),
            botIds: getBotsId(props.selectedBots),
        });

        closeModal();
    };

    const {t} = useTranslation();

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
                <Form.Item label={t("NUMBER")} name="number" rules={inputRules}>
                    <Input type="text" placeholder="Number" />
                </Form.Item>
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
            </Form>
        </Modal>
    );
};

export default ForwardCall;
