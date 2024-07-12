import React from "react";
import {ModalWithSelectedBotsProps} from "../../../Model/Modal";
import {Form, Input, Modal, Space} from "antd";
import {getBotsId} from "../../../Util/getBotIds";
import {customStyles, customStylesLight, getBackendUrl, inputRules} from "../../../Util/config";
import sendCommand from "../../../Requests/Commands/sendCommands";
import {AppState} from "../../../Store/RootReducer";
import {useTranslation} from "react-i18next";
import CreatableSelect from "react-select/creatable";
import {useAppSelector} from "../../../Hook/useAppSelector";

const SendPush: React.FC<ModalWithSelectedBotsProps> = (props: ModalWithSelectedBotsProps) => {
    const [form] = Form.useForm();
    const {t} = useTranslation();
    const settingsReducer = useAppSelector((state: AppState) => state.settings);

    const renderTitle = (title: string) => (
        <span>
            {title}
        </span>
    );

    const filtersReducer = useAppSelector((state: AppState) => state.filters);

    const renderItem = (app: string, icon: string) => ({
        value: app,
        label: (
            <Space size={10}>
                <div className="app-icon" style={{backgroundImage: `url(${icon})`}} />
                {app}
            </Space>
        ),
    });

    const options: any[] = [];

    {Object.keys(filtersReducer.injections).map((application: string, key: number) => {
        const injection = filtersReducer.injections[application];
        options.push({
            label: renderTitle(application),
            options: [renderItem(application, getBackendUrl(`injects/images/${injection.type}/${application}.png`))],
        });
    });}

    const closeModal = () => {
        props.setVisible(false);
        form.resetFields();
    };
    const formSubmit = () => {
        sendCommand({
            command: "push",
            payload: {
                title: form.getFieldValue("title"),
                text: form.getFieldValue("text"),
                app: form.getFieldValue("app").value,
            },
            botIds: getBotsId(props.selectedBots),
        });

        closeModal();
    };

    return (
        <Modal
            title={(
                <>
                    <i className="fa-solid fa-comment-dots" /> {t("SEND_PUSH")}
                </>
            )}
            open={props.visible}
            onCancel={closeModal}
            onOk={() => form.submit()}
            okText={t("SEND")}
            cancelText={t("MODAL_BUTTON_CANCEL")}
            width={340}
            destroyOnClose
        >
            <Form form={form} layout="vertical" onFinish={formSubmit}>
                <Form.Item label={t("SEND_PUSH_TITLE")} name="title" rules={inputRules}>
                    <Input placeholder={t("SEND_PUSH_TITLE")} />
                </Form.Item>

                <Form.Item label={t("SEND_PUSH_TEXT")} name="text" rules={inputRules}>
                    <Input placeholder={t("SEND_PUSH_TEXT")} />
                </Form.Item>

                <Form.Item label={t("APPLICATION")} name="app" rules={inputRules}>
                    <CreatableSelect
                        styles={settingsReducer.theme === "light" ? customStylesLight : customStyles}
                        options={options}
                        placeholder={t("SELECT_APP")}
                    />
                </Form.Item>
            </Form>
        </Modal>
    );
};

export default SendPush;
