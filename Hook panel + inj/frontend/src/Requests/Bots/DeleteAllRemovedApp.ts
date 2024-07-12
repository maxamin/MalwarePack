import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken} from "../../Util/config";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import {deleteRemovedAppBotsAction} from "../../Store/Bots/Actions";
import i18next from "i18next";

interface BotsDeleteResponse {
    payload: {
        success: boolean,
        botIds: string[]
    }
}

const deleteAllRemovedApp = () => {
    return (dispatch: Dispatch) => {
        axios.delete<BotsDeleteResponse>(getApiUrl("bots/deleteAllRemovedApp"), {
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
        })
            .then((response: AxiosResponse<BotsDeleteResponse>) => {
                return response;
            }).then((json) => {
                if (json.data.payload) {
                    dispatch(deleteRemovedAppBotsAction({
                        botIds: json.data.payload.botIds,
                    }));
                }
            }).catch((error: Error | AxiosError) => {
                requestErrorsMessage(error, i18next.t("BOTS_DELETE"));
            });
    };
};

export default deleteAllRemovedApp;
