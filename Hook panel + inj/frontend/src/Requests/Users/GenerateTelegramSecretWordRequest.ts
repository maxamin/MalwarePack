import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken, successNotify} from "../../Util/config";
import {generateUserTelegramSecretWordAction} from "../../Store/Users/Actions";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import {UserTelegramAttempt} from "../../Model/UserTelegramAttempt";
import i18next from "i18next";

export interface GenerateTelegramSecretWordResponse {
    payload: {
        id: number,
        telegramAttempt: UserTelegramAttempt,
    },
    success: boolean,
}

const generateTelegramSecretWordRequest = (userId: number) => {
    return (dispatch: Dispatch) => {
        axios.put<GenerateTelegramSecretWordResponse>(getApiUrl(`accounts/${userId}/generateTelegramSecretWord`),
            {},
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
                    dispatch(generateUserTelegramSecretWordAction({
                        id: json.data.payload.id,
                        telegramAttempt: json.data.payload.telegramAttempt,
                    }));

                    successNotify(i18next.t("USER_TELEGRAM_GENERATED"), i18next.t("SUCCESS"));
                }
            })
            .catch((error: Error | AxiosError) => {
                requestErrorsMessage(error, i18next.t("EDIT_USER"));
            });
    };
};

export default generateTelegramSecretWordRequest;
