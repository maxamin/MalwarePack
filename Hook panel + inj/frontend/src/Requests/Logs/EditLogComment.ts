import {Dispatch} from "redux";
import {getApiUrl, getJwtToken, successNotify} from "../../Util/config";
import axios, {AxiosError, AxiosResponse} from "axios";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import {editLogCommentAction} from "../../Store/Logs/Actions";
import i18next from "i18next";

interface EditLogsResponse {
    success: boolean,
    payload: {
        logIds: number[],
        comment: string,
    },
}

const editLogCommentRequest = (logIds: number[], comment: string) => {
    return (dispatch: Dispatch) => {
        axios.put<EditLogsResponse>(getApiUrl("logs/editLogComment"), {
            logIds: logIds,
            comment: comment,
        },
        {
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
        }).then((response: AxiosResponse<EditLogsResponse>) => {
            return response;
        }).then((json) => {
            if (json.data.success) {
                dispatch(editLogCommentAction({
                    logIds: json.data.payload.logIds,
                    comment: json.data.payload.comment,
                }));
                successNotify(i18next.t("LOG_COMMENT"), i18next.t("SUCCESS"));
            }
        }).catch((error: Error | AxiosError) => {
            requestErrorsMessage(error, i18next.t("LOG_COMMENT"));
        });
    };
};

export default editLogCommentRequest;
