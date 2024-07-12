import React from "react";
import {Tooltip} from "antd";
import {Bot} from "../../../Model/Bot";
import {useTranslation} from "react-i18next";

interface SubInfoProps {
    bot: Bot,
}

const SubInfo: React.FC<SubInfoProps> = (props: SubInfoProps) => {
    const permissionActiveColor = {color: "#4aac16"}; // important important important
    const {t} = useTranslation();

    return (
        <div className="bot-item-permissions space-between">
            <Tooltip title={t("admin")} placement="bottom" destroyTooltipOnHide>
                {
                    props.bot.sub_info.admin ?
                        <i className="fa-solid fa-user-gear sub-info-icon" style={permissionActiveColor} /> :
                        <i className="fa-solid fa-user-gear sub-info-icon" />
                }
            </Tooltip>
            <Tooltip title={t("screen")} placement="bottom" destroyTooltipOnHide>
                {
                    props.bot.sub_info.screen ?
                        <i className="fa-solid fa-mobile-screen sub-info-icon" style={permissionActiveColor} /> :
                        <i className="fa-solid fa-mobile sub-info-icon" />
                }
            </Tooltip>
            <Tooltip title={t("protect")} placement="bottom" destroyTooltipOnHide>
                {
                    props.bot.sub_info.protect ?
                        <i className="fa-brands fa-google-play sub-info-icon" style={permissionActiveColor} /> :
                        <i className="fa-brands fa-google-play sub-info-icon" />
                }
            </Tooltip>
            <Tooltip title={t("isDozeMode")} placement="bottom" destroyTooltipOnHide>
                {
                    props.bot.sub_info.isDozeMode ?
                        <i className="fa-solid fa-moon sub-info-icon" style={permissionActiveColor} /> :
                        <i className="fa-regular fa-moon sub-info-icon" />
                }
            </Tooltip>
            <Tooltip title={t("accessibility")} placement="bottom" destroyTooltipOnHide>
                {
                    props.bot.sub_info.accessibility ?
                        <i className="fa-solid fa-child-reaching sub-info-icon" style={permissionActiveColor} /> :
                        <i className="fa-solid fa-person sub-info-icon" />
                }
            </Tooltip>
            <Tooltip title={t("isKeyguardLocked")} placement="bottom" destroyTooltipOnHide>
                {
                    props.bot.sub_info.isKeyguardLocked ?
                        <i className="icon-screen-locked sub-info-icon" style={permissionActiveColor} /> :
                        <i className="icon-screen-locked sub-info-icon" />
                }
            </Tooltip>
        </div>
    );
};

export default SubInfo;
