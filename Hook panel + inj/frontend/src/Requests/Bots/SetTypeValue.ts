import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {Bot} from "../../Model/Bot";
import {setBotTypeValueAction} from "../../Store/Bots/Actions";
import {getApiUrl, getJwtToken, successNotify} from "../../Util/config";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import i18next from "i18next";

interface BotsResponse {
    success: boolean,
    payload: Bot,
}

const setTypeValueRequest = (botId: string, type: string, value: boolean) => {
    return (dispatch: Dispatch) => {
        axios.put<BotsResponse>(getApiUrl(`bots/${botId}/setBotType`), {
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
                    dispatch(setBotTypeValueAction({
                        bot: json.data.payload,
                    }));
                    successNotify(i18next.t("SET_BOTS_TYPE"), i18next.t("SUCCESSFUL"));
                }
            }).catch((error: Error | AxiosError) => {
                requestErrorsMessage(error, i18next.t("SET_BOTS_TYPE"));
            });
    };
};

export default setTypeValueRequest;
