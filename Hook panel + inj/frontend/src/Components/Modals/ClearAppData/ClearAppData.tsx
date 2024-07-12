import React from "react";
import {ModalWithSelectedBotsProps} from "../../../Model/Modal";
import {Form, Modal, Space} from "antd";
import {customStyles, customStylesLight, inputRules} from "../../../Util/config";
import {getBotsId} from "../../../Util/getBotIds";
import sendCommand from "../../../Requests/Commands/sendCommands";
import {AppState} from "../../../Store/RootReducer";
import CreatableSelect from "react-select/creatable";
import {useTranslation} from "react-i18next";
import {useAppSelector} from "../../../Hook/useAppSelector";

const ClearAppData: React.FC<ModalWithSelectedBotsProps> = (props: ModalWithSelectedBotsProps) => {
    const [form] = Form.useForm();

    const renderTitle = (title: string) => (
        <span>
            {title}
        </span>
    );

    const renderItem = (app: string) => ({
        value: app,
        label: (
            <Space size={10}>
                {app}
            </Space>
        ),
    });

    const options: any[] = [];

    if (props.selectedBots.length === 1) {
        props.selectedBots[0].applications?.forEach((application) => {
            options.push({
                label: renderTitle(application),
                options: [renderItem(application)],
            });
        });
    }

    const closeModal = () => {
        props.setVisible(false);
        form.resetFields();
    };
    const formSubmit = () => {
        sendCommand({
            command: "clearcache",
            payload: {
                app: form.getFieldsValue()["app"].value,
            },
            botIds: getBotsId(props.selectedBots),
        });

        closeModal();
    };

    const settingsReducer = useAppSelector((state: AppState) => state.settings);
    const {t} = useTranslation();

    return (
        <Modal
            title={t("CLEAR_CACHE_COMMAND")}
            open={props.visible}
            onCancel={closeModal}
            onOk={() => form.submit()}
            okText={t("CLEAR_CACHE_COMMAND")}
            cancelText={t("MODAL_BUTTON_CANCEL")}
            width={350}
            destroyOnClose
        >
            <Form form={form} layout="vertical" onFinish={formSubmit}>
                <Form.Item label={t("SELECT_APP")} name="app" rules={inputRules}>
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

export default ClearAppData;
