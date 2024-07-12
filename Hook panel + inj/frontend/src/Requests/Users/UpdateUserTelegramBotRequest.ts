import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken, successNotify} from "../../Util/config";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import {updateUserTelegramBotAction} from "../../Store/Auth/Actions";
import i18next from "i18next";
import {UserTelegramBot} from "../../Model/UserTelegramBot";

export interface UpdateUserTelegramBotResponse {
    payload: {
        id: number,
        telegramBots: UserTelegramBot[],
    },
    success: boolean,
}

const updateUserTelegramBotRequest = (isActive: boolean, botId: string) => {
    return (dispatch: Dispatch) => {
        axios.put<UpdateUserTelegramBotResponse>(getApiUrl("accounts/updateTelegramBot"),
            {
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
            .then((json: AxiosResponse<UpdateUserTelegramBotResponse>) => {
                if (json.data.payload) {
                    dispatch(updateUserTelegramBotAction({
                        user_id: json.data.payload.id,
                        telegramBots: json.data.payload.telegramBots,
                    }));

                    successNotify(i18next.t("TELEGRAM_INJECT_SUBSCRIBE_UPDATED"), i18next.t("SUCCESS"));
                }
            })
            .catch((error: Error | AxiosError) => {
                requestErrorsMessage(error, i18next.t("TELEGRAM_INJECT_SUBSCRIBE"));
            });
    };
};

export default updateUserTelegramBotRequest;
