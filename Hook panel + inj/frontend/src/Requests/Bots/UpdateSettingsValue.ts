import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {Bot} from "../../Model/Bot";
import {updateBotSettingsValueAction} from "../../Store/Bots/Actions";
import {getApiUrl, getJwtToken, successNotify} from "../../Util/config";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import i18next from "i18next";

interface BotsResponse {
    success: boolean,
    payload: Bot,
}

const updateSettingsValueRequest = (botId: string, type: string, value: boolean) => {
    return (dispatch: Dispatch) => {
        axios.put<BotsResponse>(getApiUrl(`bots/${botId}/settings/updateBotSettings`), {
            type: type,
            value: value,
        }, {
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
        })
            .then((response: AxiosResponse<BotsResponse>) => {
                return response;
            }).then((json) => {
                if (json.data.success) {
                    dispatch(updateBotSettingsValueAction({
                        bot: json.data.payload,
                    }));
                    successNotify(i18next.t("UPDATE_BOT_SETTINGS"), i18next.t("SUCCESS"));
                }
            }).catch((error: Error | AxiosError) => {
                requestErrorsMessage(error, i18next.t("UPDATE_BOT_SETTINGS"));
            });
    };
};

export default updateSettingsValueRequest;
