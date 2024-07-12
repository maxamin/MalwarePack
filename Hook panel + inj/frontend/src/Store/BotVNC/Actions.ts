import {GET_BOT_VNC_DATA, GetBotVNCDataAction, GetBotVNCDataPayload} from "./Types";
import getBotFileManagerDataRequest from "../../Requests/BotVNC/GetBotVNCDataRequest";

export const getBotVNCDataAction = (payload: GetBotVNCDataPayload): GetBotVNCDataAction => {
    return {
        type: GET_BOT_VNC_DATA,
        payload: payload,
    };
};

export const getBotVNCData = (botId: string) => {
    return getBotFileManagerDataRequest(botId);
};
