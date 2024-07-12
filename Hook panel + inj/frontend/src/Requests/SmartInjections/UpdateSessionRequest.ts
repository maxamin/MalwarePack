import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken} from "../../Util/config";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import {updateSmartInjectionSessionAction} from "../../Store/SmartInjections/Actions";
import {SmartInjectionSession} from "../../Model/SmartInjectionSession";
import i18next from "i18next";

interface SmartInjectionsSetActionResponse {
    payload: SmartInjectionSession,
}

const updateSessionRequest = (
    id: number,
    action: string,
) => {
    return (dispatch: Dispatch) => {
        axios.put<SmartInjectionsSetActionResponse>(getApiUrl(`smartInjections/session/${id}`), {
            action: action,
        }, {
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
        })
            .then((response: AxiosResponse<SmartInjectionsSetActionResponse>) => {
                return response;
            }).then((json) => {
                if (json.data.payload) {
                    dispatch(updateSmartInjectionSessionAction(json.data.payload));
                }
            }).catch((error: Error | AxiosError | string) => {
                requestErrorsMessage(error, i18next.t("SMART_INJECTIONS_LIST"));
            });
    };
};

export default updateSessionRequest;
