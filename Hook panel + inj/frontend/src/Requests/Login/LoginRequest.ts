import {Dispatch} from "redux";
import axios, {AxiosResponse} from "axios";
import {getApiUrl} from "../../Util/config";
import {authorizeAction, changeFormState} from "../../Store/Auth/Actions";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import i18next from "i18next";

const loginRequest = (token: string, password: string) => {
    return (dispatch: Dispatch) => {
        axios.post(getApiUrl("sign-in"), {
            token: token,
            password: password,
        }).then((response: AxiosResponse) => {
            return response;
        }).then((json) => {
            if (json.data.payload.user && json.data.payload.token) {
                dispatch(authorizeAction(json.data.payload.token, json.data.payload.user));
            }
        }).catch((error) => {
            if (error.response.status === 406) {
                dispatch(changeFormState("telegram"));
            } else if (error.response.status === 400) {
                dispatch(changeFormState("error"));
            }

            requestErrorsMessage(error, i18next.t("LOGIN_ERROR"));
        });
    };
};

export default loginRequest;
