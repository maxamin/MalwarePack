import React, {useEffect} from "react";
import {DatePicker, Form, Input, Modal, Select} from "antd";
import {ModalsProps} from "../../../../Model/Modal";
import moment from "moment";
import {addUser} from "../../../../Store/Users/Actions";
import {inputRules} from "../../../../Util/config";
import {AppState} from "../../../../Store/RootReducer";
import {hasAccess} from "../../../../Util/hasAccess";
import {useTranslation} from "react-i18next";
import {useAppDispatch} from "../../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../../Hook/useAppSelector";

const {Option} = Select;

interface UserAddProps extends ModalsProps {
    tags: string[],
}

interface CustomTarget extends Node {
    title: string,
}

const UserAddModal: React.FC<UserAddProps> = (props: UserAddProps) => {
    const [form] = Form.useForm();
    const dispatch = useAppDispatch();

    useEffect(() => {
        const observer = new MutationObserver((mutations: MutationRecord[]) => {
            if (mutations.length >= 1 && mutations[0].target !== undefined) {
                const customTarget: CustomTarget = mutations[0].target as CustomTarget;
                if (customTarget.title !== undefined && customTarget.title !== null && customTarget.title) {
                    form.setFieldsValue({
                        expired_at2: moment(customTarget.title),
                    });
                }
            }
        });

        const item = document.getElementById("expired_at2"); // почему не находит?

        if (item) {
            observer.observe(item, {
                attributes: true,
            });
        }
    }, [form]);

    const authReducer = useAppSelector((state: AppState) => state.auth);

    const closeModal = () => {
        form.resetFields();
        props.setVisible(false);
    };

    const formSubmitHandler = () => {
        let formValues = form.getFieldsValue();
        formValues = {
            ...formValues,
            expired_at: formValues.expired_at2 ? moment(formValues.expired_at2)
                .format("YYYY-MM-DD HH:mm:ss") : null,
        };

        dispatch(addUser(formValues));

        closeModal();
    };

    const {t} = useTranslation();

    return (
        <>
            <Modal
                title={t("NEW_USER")}
                open={props.visible}
                onCancel={closeModal}
                onOk={() => form.submit()}
                okText={t("ADD_USER")}
                cancelText={t("MODAL_BUTTON_CANCEL")}
                destroyOnClose
            >
                <Form form={form} layout="vertical" onFinish={formSubmitHandler}>
                    <Form.Item label={t("TOKEN")} name="token" rules={inputRules}>
                        <Input placeholder={t("TOKEN")} />
                    </Form.Item>
                    <Form.Item label={t("PASSWORD")} name="password" rules={inputRules}>
                        <Input type="password" placeholder={t("PASSWORD")} />
                    </Form.Item>
                    <Form.Item label={t("NAME")} name="name" rules={inputRules}>
                        <Input placeholder={t("NAME")} />
                    </Form.Item>
                    <Form.Item label={t("ROLE")} name="role" rules={inputRules}>
                        <Select placeholder={t("ROLE")}>
                            {hasAccess(authReducer.user, "users.createRoot") && <Option value="root">root</Option>}
                            {hasAccess(authReducer.user, "users.createAdmin") && <Option value="admin">admin</Option>}
                        </Select>
                    </Form.Item>
                    <Form.Item label={t("TAGS")} name="tags">
                        <Select mode="tags" allowClear placeholder={t("TAGS")}>
                            {props.tags.map((tag: string, key: number) => (
                                <Option value={tag} key={key.toString(36)}>{tag}</Option>
                            ))}
                        </Select>
                    </Form.Item>
                    <Form.Item label={t("EMAIL")} name="email" rules={inputRules}>
                        <Input type="email" placeholder={t("EMAIL")} />
                    </Form.Item>
                    <Form.Item label={t("EXPIRATION_DATE")} name="expired_at2">
                        <DatePicker placeholder={t("EXPIRATION_DATE")} style={{width: "100%"}} showTime={true} />
                    </Form.Item>
                </Form>
            </Modal>
        </>
    );
};

export default UserAddModal;
