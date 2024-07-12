import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken, successNotify} from "../../Util/config";
import {deleteUserAction} from "../../Store/Users/Actions";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import i18next from "i18next";

const deleteRequest = (userId: number) => {
    return (dispatch: Dispatch) => {
        axios.delete(getApiUrl(`accounts/${userId}/deleteAccount`),
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
                    dispatch(deleteUserAction({
                        userId: json.data.payload.user.id,
                    }));
                    successNotify(i18next.t("users.delete"), i18next.t("SUCCESS"));
                }
            })
            .catch((error: Error | AxiosError) => {
                requestErrorsMessage(error, i18next.t("users.delete"));
            });
    };
};

export default deleteRequest;
