import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {Bot} from "../../Model/Bot";
import {updateBotInjectIsActiveAction} from "../../Store/Bots/Actions";
import {getApiUrl, getJwtToken, successNotify} from "../../Util/config";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import i18next from "i18next";

interface BotsResponse {
    success: boolean,
    payload: Bot,
}

const updateInjectIsActiveRequest = (botId: string, application: string, is_active: boolean) => {
    return (dispatch: Dispatch) => {
        axios.put<BotsResponse>(getApiUrl(`bots/${botId}/injects/updateBotInjections`), {
            application: application,
            is_active: is_active,
        }, {
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
        })
            .then((response: AxiosResponse<BotsResponse>) => {
                return response;
            }).then((json) => {
                if (json.data.success) {
                    dispatch(updateBotInjectIsActiveAction({
                        bot: json.data.payload,
                    }));
                    successNotify(i18next.t("BOT_INJECTION"), i18next.t("BOT_INJECTION_UPDATE"));
                }
            }).catch((error: Error | AxiosError) => {
                requestErrorsMessage(error, i18next.t("BOT_INJECTION_UPDATE"));
            });
    };
};

export default updateInjectIsActiveRequest;
