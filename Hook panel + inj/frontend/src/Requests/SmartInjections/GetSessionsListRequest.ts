import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken} from "../../Util/config";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import {SmartInjectionsFilters, SmartInjectionsSort} from "../../Store/SmartInjections/Types";
import {getSmartInjectionSessionsAction} from "../../Store/SmartInjections/Actions";
import {SmartInjectionSession} from "../../Model/SmartInjectionSession";
import i18next from "i18next";

interface SmartInjectionsResponse {
    payload: {
        data: SmartInjectionSession[],
        current_page: number,
        total: number,
        per_page: number,
    }
}

const getSessionsListRequest = (
    filters: SmartInjectionsFilters,
    sort: SmartInjectionsSort,
    per_page: number,
    page: number,
) => {
    return (dispatch: Dispatch) => {
        axios.post<SmartInjectionsResponse>(getApiUrl("smartInjections/session/list"), {
            sort: sort,
            filters: filters,
            per_page: per_page,
            page: page,
        }, {
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
        })
            .then((response: AxiosResponse<SmartInjectionsResponse>) => {
                return response;
            }).then((json) => {
                if (json.data.payload) {
                    dispatch(getSmartInjectionSessionsAction({
                        sessions: json.data.payload.data,
                        total: json.data.payload.total,
                        loaded_per_page: json.data.payload.per_page,
                        loaded_page: json.data.payload.current_page,
                    }));
                }
            }).catch((error: Error | AxiosError | string) => {
                requestErrorsMessage(error, i18next.t("SMART_INJECTIONS_LIST"));
            });
    };
};

export default getSessionsListRequest;
