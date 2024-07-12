import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken} from "../../Util/config";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import {GetBotFileManagerDataPayload} from "../../Store/BotFileManager/Types";
import {getBotFileManagerDataAction} from "../../Store/BotFileManager/Actions";
import i18next from "i18next";

interface BotCommandsResponse {
    success: boolean,
    payload: GetBotFileManagerDataPayload
}

const getBotFileManagerDataRequest = (botId: string) => {
    return (dispatch: Dispatch) => {
        axios.get<BotCommandsResponse>(getApiUrl(`bots/${botId}/fileManager/list`), {
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
        })
            .then((response: AxiosResponse<BotCommandsResponse>) => {
                return response;
            }).then((json) => {
                if (json.data.payload) {
                    dispatch(getBotFileManagerDataAction(json.data.payload));
                }
            }).catch((error: Error | AxiosError) => {
                requestErrorsMessage(error, i18next.t("SIDEBAR_NAV_FILE"));
            });
    };
};

export default getBotFileManagerDataRequest;
