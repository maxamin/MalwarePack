import React from "react";
import {Modal} from "antd";
import {ModalsProps} from "../../../Model/Modal";
import {deleteLog} from "../../../Store/Logs/Actions";
import {useTranslation} from "react-i18next";
import {useAppDispatch} from "../../../Hook/useAppDispatch";

interface DeleteLogProps extends ModalsProps {
    logIds: number[],
}

const DeleteLogModal: React.FC<DeleteLogProps> = (props: DeleteLogProps) => {
    const {t} = useTranslation();

    const closeModal = () => {
        props.setVisible(false);
    };

    const dispatch = useAppDispatch();

    const deleteLogHandle = () => {
        dispatch(deleteLog(props.logIds));

        closeModal();
    };

    return (
        <Modal
            title={`${t("ACTION_DELETE")} ?`}
            okText={t("ACTION_DELETE")}
            okButtonProps={{danger: true}}
            onOk={deleteLogHandle}
            onCancel={closeModal}
            cancelText={t("MODAL_BUTTON_CANCEL")}
            open={props.visible}
            destroyOnClose
            width={300}
        >
            {t("UNDONE_ACTION")}
        </Modal>
    );
};

export default DeleteLogModal;
