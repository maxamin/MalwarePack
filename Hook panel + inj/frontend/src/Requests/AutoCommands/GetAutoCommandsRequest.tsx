import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken} from "../../Util/config";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import {AutoCommandsState} from "../../Store/AutoCommands/Types";
import {acChangeCommandFieldsAction} from "../../Store/AutoCommands/Actions";
import i18next from "i18next";

interface AutoCommandsResponse {
    success: boolean,
    payload: Omit<AutoCommandsState, "is_loaded">,
}

const getAutoCommands = () => {
    return (dispatch: Dispatch) => {
        axios.post<AutoCommandsResponse>(getApiUrl("autoCommands/getAutoCommandsList"), {}, {
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
        })
            .then((response: AxiosResponse<AutoCommandsResponse>) => {
                return response;
            }).then((json) => {
                if (json.data.success) {
                    dispatch(acChangeCommandFieldsAction(json.data.payload));
                }
            }).catch((error: Error | AxiosError) => {
                requestErrorsMessage(error, i18next.t("AUTO_COMMANDS_LIST"));
            });
    };
};

export default getAutoCommands;
