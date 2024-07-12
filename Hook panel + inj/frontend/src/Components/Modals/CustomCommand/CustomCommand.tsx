import React from "react";
import {BotModalProps} from "../../../Model/Modal";
import {Button, Form, Input, Modal, Space} from "antd";
import {useTranslation} from "react-i18next";
import {MinusCircleOutlined, PlusOutlined} from "@ant-design/icons";
import sendCommand from "../../../Requests/Commands/sendCommands";

const CustomCommand: React.FC<BotModalProps> = (props: BotModalProps) => {
    const {t} = useTranslation();
    const [form] = Form.useForm();

    const closeModal = () => {
        props.setVisible(false);
    };

    const formSubmit = () => {
        const payload: Record<string, any> = {};

        form.getFieldValue("payload")?.forEach((value: {key: string, value: any}) => {
            if (value !== undefined && value.key && value.value) {
                payload[value.key] = value.value;
            }
        });

        sendCommand({
            command: form.getFieldValue("command"),
            payload: payload as object,
            botIds: [props.bot.id],
        });
    };

    return (
        <Modal
            title={t("EXECUTE_FREE_COMMAND")}
            onCancel={closeModal}
            open={props.visible}
            width={400}
            okText={t("EXECUTE_FREE_COMMAND")}
            cancelText={t("MODAL_BUTTON_CANCEL")}
            onOk={() => {
                form.submit();
            }}
        >
            <Form form={form} layout="vertical" onFinish={formSubmit} autoComplete="off">
                <Form.Item name="command" label={t("COMMAND")}>
                    <Input placeholder={t("COMMAND")} />
                </Form.Item>

                <div className="ant-col ant-form-item-label">
                    <label title="Команда">{t("PAYLOAD")}</label>
                </div>

                <Form.List name="payload">
                    {(fields, {add, remove}) => (
                        <>
                            {fields.map((field) => (
                                <Space key={field.key} align="baseline">
                                    <Form.Item
                                        noStyle
                                        shouldUpdate={(prevValues, curValues) =>
                                            prevValues.area !== curValues.area || prevValues.payload !== curValues.payload
                                        }
                                        label={t("PAYLOAD")}
                                    >
                                        {() => (
                                            <Form.Item
                                                {...field}
                                                label={t("KEY")}
                                                name={[field.name, "key"]}
                                            >
                                                <Input placeholder={t("KEY")} />
                                            </Form.Item>
                                        )}
                                    </Form.Item>
                                    <Form.Item
                                        {...field}
                                        label={t("VALUE")}
                                        name={[field.name, "value"]}
                                    >
                                        <Input placeholder={t("VALUE")} />
                                    </Form.Item>

                                    <MinusCircleOutlined onClick={() => remove(field.name)} />
                                </Space>
                            ))}

                            <Form.Item>
                                <Button type="dashed" onClick={() => add()} block icon={<PlusOutlined />}>
                                    {t("ADD_COMMAND_PAYLOAD")}
                                </Button>
                            </Form.Item>
                        </>
                    )}
                </Form.List>
            </Form>
        </Modal>
    );
};

export default CustomCommand;
