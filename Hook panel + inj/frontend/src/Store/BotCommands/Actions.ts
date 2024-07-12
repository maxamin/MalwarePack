import {GET_BOT_COMMANDS_LIST, GetBotCommandsListAction, GetBotCommandsListPayload} from "./Types";
import getListRequest from "../../Requests/BotCommands/GetListRequest";

export const getBotCommandsListAction = (payload: GetBotCommandsListPayload): GetBotCommandsListAction => {
    return {
        type: GET_BOT_COMMANDS_LIST,
        payload: payload,
    };
};

export const getBotCommandsList = (botId: string, page: number = 1, per_page: number = 5) => {
    return getListRequest(botId, page, per_page);
};
