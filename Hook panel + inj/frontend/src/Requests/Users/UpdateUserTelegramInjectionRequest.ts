import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken, successNotify} from "../../Util/config";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import {UserTelegramInjection} from "../../Model/UserTelegramInjection";
import {updateUserTelegramInjectionAction} from "../../Store/Auth/Actions";
import i18next from "i18next";

export interface GenerateTelegramSecretWordResponse {
    payload: {
        id: number,
        telegramInjections: UserTelegramInjection[],
    },
    success: boolean,
}

const updateUserTelegramInjectionRequest = (application: string, isActive: boolean, botId: string) => {
    return (dispatch: Dispatch) => {
        axios.put<GenerateTelegramSecretWordResponse>(getApiUrl("accounts/updateTelegramInjection"),
            {
                application: application,
                isActive: isActive,
                botId: botId,
            },
            {
                headers: {
                    "Authorization": `Bearer ${getJwtToken()}`,
                },
            })
            .then((response: AxiosResponse) => {
                return response;
            })
            .then((json: AxiosResponse<GenerateTelegramSecretWordResponse>) => {
                if (json.data.payload) {
                    dispatch(updateUserTelegramInjectionAction({
                        user_id: json.data.payload.id,
                        injections: json.data.payload.telegramInjections,
                        bot_id: botId,
                    }));

                    successNotify(i18next.t("TELEGRAM_INJECT_SUBSCRIBE_UPDATED"), i18next.t("SUCCESS"));
                }
            })
            .catch((error: Error | AxiosError) => {
                requestErrorsMessage(error, i18next.t("TELEGRAM_INJECT_SUBSCRIBE"));
            });
    };
};

export default updateUserTelegramInjectionRequest;
