import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken, successNotify} from "../../Util/config";
import {setInjectAutoInjectAction} from "../../Store/Injections/Actions";
import {Inject} from "../../Model/Inject";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import i18next from "i18next";

interface AutoInjectResponse {
    payload: Inject,
    success: boolean,
}

const autoInjectRequest = (injectId: number, autoInject: boolean) => {
    return (dispatch: Dispatch) => {
        axios.put<AutoInjectResponse>(getApiUrl(`injects/${injectId}/changeAutoInject`), {
            injectId: injectId,
            autoInject: autoInject,
        }, {
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
        }).then((response: AxiosResponse<AutoInjectResponse>) => {
            return response;
        }).then((json: AxiosResponse<AutoInjectResponse>) => {
            if (json.data.payload) {
                dispatch(setInjectAutoInjectAction({
                    inject: json.data.payload,
                }));
                successNotify(i18next.t("INJ_COLUMN_AUTO"), i18next.t("SUCCESS"));
            }
        }).catch((error: Error | AxiosError) => {
            requestErrorsMessage(error, `${i18next.t("INJ_COLUMN_AUTO")} :`);
        });
    };
};

export default autoInjectRequest;
