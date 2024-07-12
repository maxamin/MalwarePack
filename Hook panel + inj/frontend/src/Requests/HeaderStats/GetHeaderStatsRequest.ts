import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken} from "../../Util/config";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import {GetHeaderStatsPayload} from "../../Store/HeaderStats/Types";
import {getHeaderStatsAction} from "../../Store/HeaderStats/Actions";
import i18next from "i18next";

interface GetHeaderStatsResponse {
    payload: GetHeaderStatsPayload,
    success: boolean,
}

const getHeaderStatsRequest = () => {
    return (dispatch: Dispatch) => {
        axios.post<GetHeaderStatsResponse>(getApiUrl("statistics/getCurrent"), {}, {
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
        })
            .then((response: AxiosResponse<GetHeaderStatsResponse>) => {
                return response;
            }).then((json:AxiosResponse<GetHeaderStatsResponse>) => {
                if (json.data.payload) {
                    dispatch(getHeaderStatsAction(json.data.payload));
                }
            }).catch((error: Error | AxiosError) => {
                requestErrorsMessage(error, i18next.t("stats"));
            });
    };
};

export default getHeaderStatsRequest;
