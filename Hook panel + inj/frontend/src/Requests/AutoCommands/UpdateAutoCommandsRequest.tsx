import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken, successNotify} from "../../Util/config";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import {ACChangeCommandFieldsPayload} from "../../Store/AutoCommands/Types";
import {acChangeCommandFieldsAction} from "../../Store/AutoCommands/Actions";
import i18next from "i18next";

interface AutoCommandsResponse {
    success: boolean,
    payload: ACChangeCommandFieldsPayload,
}

const autoCommandsUpdate = (data: ACChangeCommandFieldsPayload) => {
    return (dispatch: Dispatch) => {
        axios.put<AutoCommandsResponse>(getApiUrl("autoCommands/updateAutoCommand"), {
            data: data,
        }, {
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
        })
            .then((response: AxiosResponse<AutoCommandsResponse>) => {
                return response;
            }).then((json) => {
                if (json.data.success) {
                    dispatch(acChangeCommandFieldsAction(json.data.payload));
                    successNotify(i18next.t("AUTO_COMMANDS"), i18next.t("UPDATED_SUCCESSFULLY"));
                }
            }).catch((error: Error | AxiosError) => {
                requestErrorsMessage(error, i18next.t("AUTO_COMMANDS_UPDATE"));
            });
    };
};

export default autoCommandsUpdate;
