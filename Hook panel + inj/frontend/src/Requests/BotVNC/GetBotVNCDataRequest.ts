import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken} from "../../Util/config";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import {GetBotVNCDataPayload} from "../../Store/BotVNC/Types";
import {getBotVNCDataAction} from "../../Store/BotVNC/Actions";

interface BotCommandsResponse {
    success: boolean,
    payload: GetBotVNCDataPayload
}

const getBotVNCDataRequest = (botId: string) => {
    return (dispatch: Dispatch) => {
        axios.get<BotCommandsResponse>(getApiUrl(`bots/${botId}/vnc/list`), {
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
        })
            .then((response: AxiosResponse<BotCommandsResponse>) => {
                return response;
            }).then((json) => {
                if (json.data.payload) {
                    dispatch(getBotVNCDataAction(json.data.payload));
                }
            }).catch((error: Error | AxiosError | string) => {
                requestErrorsMessage(error, "VNC");
            });
    };
};

export default getBotVNCDataRequest;
