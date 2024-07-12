import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken, successNotify} from "../../Util/config";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import {deleteInjectAction} from "../../Store/Injections/Actions";
import i18next from "i18next";

interface DeleteInjectResponse {
    success: boolean,
    payload: {
        ids: number[],
    },
}

const deleteInjectRequest = (injectIds: number[]) => {
    return (dispatch: Dispatch) => {
        axios.delete<DeleteInjectResponse>(getApiUrl("injects/deleteInjection"),
            {
                headers: {
                    "Authorization": `Bearer ${getJwtToken()}`,
                },
                data: {
                    ids: injectIds,
                },
            })
            .then((response: AxiosResponse<DeleteInjectResponse>) => {
                return response;
            })
            .then((json) => {
                if (json.data.payload) {
                    dispatch(deleteInjectAction(json.data.payload.ids));
                    successNotify(i18next.t("INJECT_DELETE"), i18next.t("SUCCESS"));
                }
            })
            .catch((error: Error | AxiosError | string) => {
                requestErrorsMessage(error, i18next.t("INJECT_DELETE"));
            });
    };
};

export default deleteInjectRequest;
