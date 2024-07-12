import React from "react";
import {Button, Modal} from "antd";
import {ModalsProps} from "../../../Model/Modal";
import CommandsList from "../../Misc/Commands";
import {AppState} from "../../../Store/RootReducer";
import {useTranslation} from "react-i18next";
import {useAppSelector} from "../../../Hook/useAppSelector";

const MultiCommandsModal: React.FC<ModalsProps> = (props: ModalsProps) => {
    const selectedBots = useAppSelector((state: AppState) => state.bots.selectedBots);
    const {t} = useTranslation();
    return (
        <Modal
            title={(
                <>
                    <i className="fa-solid fa-terminal" /> {t("COMMANDS")}
                </>
            )}
            open={props.visible}
            onCancel={() => props.setVisible(false)}
            className="commands-modal"
            width={800}
            footer={(
                <>
                    <Button type="primary" onClick={() => props.setVisible(false)}>
                        {t("CLOSE")}
                    </Button>
                </>
            )}
            destroyOnClose
        >
            <CommandsList selectedBots={selectedBots}/>
        </Modal>
    );
};

export default MultiCommandsModal;
