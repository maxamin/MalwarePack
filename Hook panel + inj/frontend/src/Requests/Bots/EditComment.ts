import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {Bot} from "../../Model/Bot";
import {editBotsCommentAction} from "../../Store/Bots/Actions";
import {getApiUrl, getJwtToken, successNotify} from "../../Util/config";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import i18next from "i18next";

interface EditBotsCommentResponse {
    success: boolean,
    payload: Pick<Bot, "id" | "comment">[],
}

const editBotsCommentRequest = (botIds: string[], comment: string) => {
    return (dispatch: Dispatch) => {
        axios.put<EditBotsCommentResponse>(getApiUrl("bots/editBotComment"), {
            botIds: botIds,
            comment: comment,
        }, {
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
        })
            .then((response: AxiosResponse<EditBotsCommentResponse>) => {
                return response;
            }).then((json) => {
                if (json.data.success) {
                    dispatch(editBotsCommentAction({
                        bots: json.data.payload,
                    }));
                    successNotify(i18next.t("COMMENT"), i18next.t("UPDATED_SUCCESSFULLY"));
                }
            }).catch((error: Error | AxiosError) => {
                requestErrorsMessage(error, i18next.t("COMMENT"));
            });
    };
};

export default editBotsCommentRequest;
