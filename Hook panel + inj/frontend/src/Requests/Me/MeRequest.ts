import axios, {AxiosError, AxiosResponse} from "axios";
import {errorNotify, getApiUrl} from "../../Util/config";
import {authorizeCheckAction} from "../../Store/Auth/Actions";
import {Dispatch} from "redux";
import {User} from "../../Model/User";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import i18next from "i18next";

const meRequest = (token: string|null) => {
    return (dispatch: Dispatch) => {
        if (!token) {
            dispatch(authorizeCheckAction(token, {} as User, false));
            return null;
        }

        return axios.get(getApiUrl("getUserInfo"), {
            headers: {
                "Authorization": `Bearer ${token}`,
            },
        })
            .then((response: AxiosResponse) => {
                return response;
            })
            .then((json) => {
                if (json.data.payload.user) {
                    dispatch(authorizeCheckAction(token, json.data.payload.user, true));
                } else {
                    errorNotify(i18next.t("AUTHORIZATION"), i18next.t("CHECK_AUTH_ERROR"));
                }
            }).catch((error: Error | AxiosError) => {
                dispatch(authorizeCheckAction(token, {} as User, false));
                requestErrorsMessage(error, i18next.t("CHECK_AUTH_ERROR"));
            });
    };
};

export default meRequest;
