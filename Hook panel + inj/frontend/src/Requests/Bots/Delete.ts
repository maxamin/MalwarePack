import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {Bot} from "../../Model/Bot";
import {getApiUrl, getJwtToken, successNotify} from "../../Util/config";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import {deleteBotsAction} from "../../Store/Bots/Actions";
import i18next from "i18next";

interface BotsDeleteResponse {
    isLoaded: boolean,
    bots: Bot[]
}

const deleteRequest = (botIds: string[]) => {
    return (dispatch: Dispatch) => {
        axios.delete<BotsDeleteResponse>(getApiUrl("bots/deleteBot"), {
            data: {
                botIds: botIds,
            },
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
        })
            .then((response: AxiosResponse) => {
                return response;
            }).then((json) => {
                if (json.data.payload) {
                    dispatch(deleteBotsAction({
                        botIds: botIds,
                    }));
                    successNotify(i18next.t("BOTS_DELETE"), i18next.t("SUCCESS"));
                }
            }).catch((error: Error | AxiosError) => {
                requestErrorsMessage(error, i18next.t("BOTS_DELETE"));
            });
    };
};

export default deleteRequest;
