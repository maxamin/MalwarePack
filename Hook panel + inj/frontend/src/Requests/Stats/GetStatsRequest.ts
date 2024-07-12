import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken} from "../../Util/config";
import {getStatsAction} from "../../Store/Stats/Actions";
import {GetStatsPayload} from "../../Store/Stats/Types";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import i18next from "i18next";
import {getHeaderStatsAction} from "../../Store/HeaderStats/Actions";

interface GetStatsResponse {
    payload: GetStatsPayload,
    success: boolean,
}

const getStatsRequest = (isShort = false) => {
    return (dispatch: Dispatch) => {
        axios.post<GetStatsResponse>(getApiUrl("statistics/getStats"), {
            isShort: isShort,
        }, {
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
        })
            .then((response: AxiosResponse<GetStatsResponse>) => {
                return response;
            }).then((json:AxiosResponse<GetStatsResponse>) => {
                if (json.data.payload) {
                    if (isShort) {
                        dispatch(getHeaderStatsAction({
                            offline: json.data.payload.bots.counts.offline,
                            online: json.data.payload.bots.counts.online,
                            lastHour: json.data.payload.bots.counts.totalToday,
                        }));
                    } else {
                        dispatch(getStatsAction(json.data.payload));
                    }
                }
            }).catch((error: Error | AxiosError) => {
                requestErrorsMessage(error, i18next.t("stats"));
            });
    };
};

export default getStatsRequest;
