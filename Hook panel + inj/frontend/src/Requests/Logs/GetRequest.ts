import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken} from "../../Util/config";
import {getLogsAction} from "../../Store/Logs/Actions";
import {LogsFilters, LogsSort} from "../../Store/Logs/Types";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import i18next from "i18next";

const getRequest = (
    per_page: number,
    type: string | null,
    bot_id: string | null,
    application: string | null,
    page: number,
    body: Record<string, string>,
    filters: LogsFilters,
    sort: LogsSort,
) => {
    return (dispatch: Dispatch) => {
        axios.post(getApiUrl("logs/getLogsList"), {
            ...body,
            type: type,
            bot_id: bot_id,
            application: application,
            page: page,
            per_page: per_page,
            filters: filters,
            sort: sort,
        }, {
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
        })
            .then((response: AxiosResponse) => {
                return response;
            }).then((json) => {
                if (json.data.payload) {
                    dispatch(getLogsAction({
                        logs: json.data.payload,
                        total: json.data.meta.total,
                        type: type,
                        botId: bot_id,
                        application: application,
                        loaded_page: json.data.meta.current_page,
                        loaded_per_page: per_page,
                        per_page: json.data.meta.per_page,
                    }));
                }
            }).catch((error: Error | AxiosError) => {
                requestErrorsMessage(error, `${i18next.t("BOTS_TABLE_LOGS")} ${type}`);
            });
    };
};

export default getRequest;
