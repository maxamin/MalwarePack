import {Bot} from "./Bot";

export interface ModalsProps {
    visible: boolean,
    setVisible: (isVisible: boolean) => void,
}

export interface BotModalProps extends ModalsProps {
    bot: Bot,
}

export interface ModalWithSelectedBotsProps extends ModalsProps {
    selectedBots: Bot[],
    bot?: Bot,
}
