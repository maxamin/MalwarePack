import React from "react";
import {Tooltip} from "antd";

import {Bot} from "../../../Model/Bot";
import {useTranslation} from "react-i18next";

interface PermissionProps {
    bot: Bot,
}

const permissionActiveColor = {color: "#4aac16"}; // important important important

const Permissions: React.FC<PermissionProps> = (props: PermissionProps) => {
    const {t} = useTranslation();

    return (
        <>
            <div className="bot-item-permissions">
                <Tooltip title={t("all_permission")} placement="bottom" destroyTooltipOnHide>
                    {
                        props.bot.permissions.all_permission ?
                            <i className="icon-all custom-icon" style={permissionActiveColor} /> :
                            <i className="icon-all custom-icon" />
                    }
                </Tooltip>
                <Tooltip title={t("sms_permission")} placement="bottom" destroyTooltipOnHide>
                    {
                        props.bot.permissions.sms_permission ?
                            <i className="fa-solid fa-envelope custom-icon" style={permissionActiveColor} /> :
                            <i className="fa-solid fa-envelope custom-icon" />
                    }
                </Tooltip>
                <Tooltip title={t("overlay_permission")} placement="bottom" destroyTooltipOnHide>
                    {
                        props.bot.permissions.overlay_permission ?
                            <i className="icon-overlay custom-icon" style={permissionActiveColor} /> :
                            <i className="icon-overlay custom-icon" />
                    }
                </Tooltip>
                <Tooltip title={t("accounts_permission")} placement="bottom" destroyTooltipOnHide>
                    {
                        props.bot.permissions.accounts_permission ?
                            <i className="fa-brands fa-google custom-icon" style={{...permissionActiveColor, fontSize: 18}} /> :
                            <i className="fa-brands fa-google custom-icon" style={{fontSize: 18}} />
                    }
                </Tooltip>
                <Tooltip title={t("contacts_permission")} placement="bottom" destroyTooltipOnHide>
                    {
                        props.bot.permissions.contacts_permission ?
                            <i className="icon-contacts custom-icon" style={permissionActiveColor} /> :
                            <i className="icon-contacts custom-icon" />
                    }
                </Tooltip>
                <Tooltip title={t("notification_permission")} placement="bottom" destroyTooltipOnHide>
                    {
                        props.bot.permissions.notification_permission ?
                            <i className="fa-solid fa-bell custom-icon" style={permissionActiveColor} /> :
                            <i className="fa-solid fa-bell custom-icon" />
                    }
                </Tooltip>
            </div>
        </>
    );
};

export default Permissions;
