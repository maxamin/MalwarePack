import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken, successNotify} from "../../Util/config";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import i18next from "i18next";
import {telegramUnbindAction} from "../../Store/Users/Actions";

export interface UnbindTelegramResponse {
    success: boolean,
}

const unbindTelegramRequest = (userId: number) => {
    return (dispatch: Dispatch) => {
        axios.put<UnbindTelegramResponse>(getApiUrl("accounts/unbindTelegram"),
            {
                userId: userId,
            },
            {
                headers: {
                    "Authorization": `Bearer ${getJwtToken()}`,
                },
            })
            .then((response: AxiosResponse) => {
                return response;
            })
            .then((json: AxiosResponse<UnbindTelegramResponse>) => {
                if (json.data.success) {
                    dispatch(telegramUnbindAction({
                        userId: userId,
                    }));

                    successNotify(i18next.t("TELEGRAM_UNBIND_UPDATED"), i18next.t("SUCCESS"));
                }
            })
            .catch((error: Error | AxiosError) => {
                requestErrorsMessage(error, i18next.t("TELEGRAM_UNBIND"));
            });
    };
};

export default unbindTelegramRequest;
