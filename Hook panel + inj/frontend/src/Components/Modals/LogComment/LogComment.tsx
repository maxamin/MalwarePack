import React from "react";
import {ModalsProps} from "../../../Model/Modal";
import {Form, Input, Modal} from "antd";
import {editCommentLogs} from "../../../Store/Logs/Actions";
import {useTranslation} from "react-i18next";
import {useAppDispatch} from "../../../Hook/useAppDispatch";

const {TextArea} = Input;

interface LogCommentProps extends ModalsProps {
    logIds: number[],
}

const LogComment: React.FC<LogCommentProps> = (props: LogCommentProps) => {
    const [form] = Form.useForm();

    const closeModal = () => {
        props.setVisible(false);
        form.resetFields();
    };

    const dispatch = useAppDispatch();

    const formSubmit = () => {
        dispatch(editCommentLogs(props.logIds, form.getFieldValue("comment")));
        closeModal();
    };

    const {t} = useTranslation();

    return (
        <Modal
            title={t("LOG_COMMENT")}
            open={props.visible}
            onCancel={closeModal}
            okText={t("SAVE_COMMENT")}
            cancelText={t("CLOSE")}
            onOk={() => form.submit()}
            width={340}
            destroyOnClose
        >
            <Form form={form} onFinish={formSubmit} layout="vertical">
                <Form.Item name="comment">
                    <TextArea placeholder={t("COMMENT_TEXT")} />
                </Form.Item>
            </Form>
        </Modal>
    );
};

export default LogComment;
