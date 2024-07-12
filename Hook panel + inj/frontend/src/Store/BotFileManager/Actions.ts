import {GET_BOT_FILE_MANAGER_DATA, GetBotFileManagerDataAction, GetBotFileManagerDataPayload} from "./Types";
import getBotFileManagerDataRequest from "../../Requests/BotFileManager/GetBotFileManagerDataRequest";

export const getBotFileManagerDataAction = (payload: GetBotFileManagerDataPayload): GetBotFileManagerDataAction => {
    return {
        type: GET_BOT_FILE_MANAGER_DATA,
        payload: payload,
    };
};

export const getBotFileManagerData = (botId: string) => {
    return getBotFileManagerDataRequest(botId);
};
