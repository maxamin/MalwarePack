import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken, successNotify} from "../../Util/config";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import i18next from "i18next";

export interface SendTelegramMessageRequestResponse {
    success: boolean,
}

const sendTelegramMessageRequest = (message: string) => {
    axios.post<SendTelegramMessageRequestResponse>(getApiUrl("accounts/sendTelegramMessage"),
        {
            message: message,
        },
        {
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
        })
        .then((response: AxiosResponse) => {
            return response;
        })
        .then((json: AxiosResponse<SendTelegramMessageRequestResponse>) => {
            successNotify(i18next.t("TELEGRAM_MESSAGE_SEND_SUCCESS"), i18next.t("SUCCESS"));
        })
        .catch((error: Error | AxiosError) => {
            requestErrorsMessage(error, i18next.t("TELEGRAM_MESSAGE_SEND_ERROR"));
        });
};

export default sendTelegramMessageRequest;
