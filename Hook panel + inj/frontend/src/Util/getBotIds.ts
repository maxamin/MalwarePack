import {Bot} from "../Model/Bot";

export const getBotsId = (bots: Bot[]) => {
    return bots.map((bot: Bot) => bot.id);
};
