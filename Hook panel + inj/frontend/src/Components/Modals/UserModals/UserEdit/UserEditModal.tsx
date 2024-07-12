import React, {useEffect} from "react";
import {DatePicker, Form, Input, Modal, Select} from "antd";
import {ModalsProps} from "../../../../Model/Modal";
import {User} from "../../../../Model/User";
import {editUser} from "../../../../Store/Users/Actions";
import moment from "moment";
import {AppState} from "../../../../Store/RootReducer";
import {hasAccess} from "../../../../Util/hasAccess";
import {inputRules} from "../../../../Util/config";
import {useTranslation} from "react-i18next";
import {useAppDispatch} from "../../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../../Hook/useAppSelector";

const {Option} = Select;

interface UserEditProps extends ModalsProps {
    user: User,
    tags: string[],
}

interface CustomTarget extends Node{
    title: string,
}

const UserEditModal: React.FC<UserEditProps> = (props: UserEditProps) => {
    const [form] = Form.useForm();
    const dispatch = useAppDispatch();

    const authReducer = useAppSelector((state: AppState) => state.auth);

    useEffect(() => {
        const observer = new MutationObserver((mutations: MutationRecord[]) => {
            if (mutations.length >= 1 && mutations[0].target !== undefined) {
                const customTarget: CustomTarget = mutations[0].target as CustomTarget;
                if (customTarget.title !== undefined && customTarget.title !== null && customTarget.title) {
                    form.setFieldsValue({
                        expired_at: moment(customTarget.title),
                    });
                }
            }
        });

        const item = document.getElementById("expired_at");

        if (item) {
            observer.observe(item, {
                attributes: true,
            });
        }
    });

    useEffect(() => {
        form.setFieldsValue({
            tags: props.user.tags,
            role: props.user.role,
            name: props.user.name,
            token: props.user.token,
            email: props.user.email,
            expired_at: props.user.expired_at ? moment(props.user.expired_at) : null,
        });
    });

    const closeModal = () => {
        props.setVisible(false);

        // form.resetFields();
    };

    const formSubmitHandler = () => {
        let formValues = form.getFieldsValue();

        formValues = {
            ...formValues,
            expired_at: formValues.expired_at ? moment(formValues.expired_at)
                .format("YYYY-MM-DD HH:mm:ss") : null,
        };

        dispatch(editUser(props.user.id, formValues));

        closeModal();
    };

    const {t} = useTranslation();

    return (
        <>
            <Modal
                forceRender={true}
                title={t("EDIT_USER")}
                open={props.visible}
                onCancel={closeModal}
                onOk={() => form.submit()}
                cancelText={t("MODAL_BUTTON_CANCEL")}
                destroyOnClose
            >
                <Form
                    form={form}
                    onFinish={formSubmitHandler}
                    layout="vertical"
                >
                    {hasAccess(authReducer.user, "users.token") && (
                        <Form.Item label={t("TOKEN")} name="token" rules={inputRules}>
                            <Input placeholder={t("TOKEN")} />
                        </Form.Item>
                    )}
                    <Form.Item label={t("NAME")} name="name" rules={inputRules}>
                        <Input placeholder={t("NAME")} />
                    </Form.Item>
                    <Form.Item label={t("NEW_PASSWORD")} name="password">
                        <Input type="password" placeholder={t("NEW_PASSWORD")} />
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
                        <Input name="email" type="email" placeholder={t("EMAIL")} />
                    </Form.Item>
                    <Form.Item label={t("EXPIRATION_DATE")} name="expired_at">
                        <DatePicker
                            placeholder={t("EXPIRATION_DATE")}
                            style={{width: "100%"}}
                            showTime={true}
                        />
                    </Form.Item>
                </Form>
            </Modal>
        </>
    );
};

export default UserEditModal;
