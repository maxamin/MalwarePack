import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken, successNotify} from "../../Util/config";
import {UserEditRequestPayload} from "../../Store/Users/Types";
import {editUserAction} from "../../Store/Users/Actions";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import i18next from "i18next";

const editRequest = (userId: number, payload: UserEditRequestPayload) => {
    return (dispatch: Dispatch) => {
        axios.put(getApiUrl(`accounts/${userId}/editAccount`),
            payload,
            {
                headers: {
                    "Authorization": `Bearer ${getJwtToken()}`,
                },
            })
            .then((response: AxiosResponse) => {
                return response;
            })
            .then((json) => {
                if (json.data.payload) {
                    dispatch(editUserAction({
                        user: json.data.payload.user,
                    }));
                    successNotify(i18next.t("EDIT_USER"), i18next.t("SUCCESS"));
                }
            })
            .catch((error: Error | AxiosError) => {
                requestErrorsMessage(error, i18next.t("EDIT_USER"));
            });
    };
};

export default editRequest;
