import {Dispatch} from "redux";
import {getApiUrl, getJwtToken, successNotify} from "../../Util/config";
import axios, {AxiosError, AxiosResponse} from "axios";
import {deleteLogsAction} from "../../Store/Logs/Actions";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import i18next from "i18next";

interface DeleteLogResponse {
    success: boolean,
    payload: {
        logIds: number[],
    },
}

const deleteLogRequest = (logIds: number[]) => {
    return (dispatch: Dispatch) => {
        axios.delete<DeleteLogResponse>(getApiUrl("logs/deleteLog"), {
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
            data: {
                logIds: logIds,
            },
        }).then((response: AxiosResponse<DeleteLogResponse>) => {
            return response;
        }).then((json) => {
            if (json.data.success) {
                dispatch(deleteLogsAction({
                    logIds: json.data.payload.logIds,
                }));
                successNotify(i18next.t("LOG_ACTION"), i18next.t("SUCCESS"));
            }
        }).catch((error: Error | AxiosError) => {
            requestErrorsMessage(error, i18next.t("LOG_ACTION"));
        });
    };
};

export default deleteLogRequest;
