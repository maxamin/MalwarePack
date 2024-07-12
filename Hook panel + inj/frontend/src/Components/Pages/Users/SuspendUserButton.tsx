import React from "react";
import {hasAccess} from "../../../Util/hasAccess";
import {Button, Modal} from "antd";
import {editUser} from "../../../Store/Users/Actions";
import {useAppSelector} from "../../../Hook/useAppSelector";
import {AppState} from "../../../Store/RootReducer";
import {User} from "../../../Model/User";
import {t} from "i18next";
import {useAppDispatch} from "../../../Hook/useAppDispatch";

interface ISuspendUserButtonProps {
    user: User,
}

const SuspendUserButton: React.FC<ISuspendUserButtonProps> = (props: ISuspendUserButtonProps) => {
    const authReducer = useAppSelector((state: AppState) => state.auth);
    const dispatch = useAppDispatch();

    return hasAccess(authReducer.user, "users.edit") ? (
        <Button
            type={props.user.is_paused ? "primary" : "default"}
            shape="circle"
            icon={props.user.is_paused ? <i className="fa-solid fa-play" /> :
                <i className="fa-solid fa-pause" />}
            onClick={() => {
                props.user.is_paused ? Modal.confirm({
                    title: t("ACTIVATE_USER_TITLE"),
                    content: t("ACTIVATE_USER_DESC"),
                    cancelText: t("MODAL_BUTTON_CANCEL"),
                    onOk: () => dispatch(editUser(props.user.id, {
                        is_paused: !props.user.is_paused,
                    })),
                }) : Modal.confirm({
                    title: t("SUSPEND_USER_TITLE"),
                    content: t("SUSPEND_USER_DESC"),
                    cancelText: t("MODAL_BUTTON_CANCEL"),
                    onOk: () => dispatch(editUser(props.user.id, {
                        is_paused: !props.user.is_paused,
                    })),
                });
            }}
        />
    ) : (<></>);
};

export default SuspendUserButton;
