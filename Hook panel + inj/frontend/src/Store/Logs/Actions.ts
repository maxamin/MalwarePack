import {
    CHANGE_LOGS_FILTERS,
    CHANGE_LOGS_SORT,
    ChangeLogsSortPayload,
    DELETE_LOGS,
    DeleteLogsPayload,
    EDIT_LOG_COMMENT,
    EditLogCommentPayload,
    FETCH_LOGS,
    GetLogsPayload,
    LogsActionTypes,
    LogsFilters,
    LogsSort,
    SET_LOGS_PAGE,
} from "./Types";
import getRequest from "../../Requests/Logs/GetRequest";
import deleteLogRequest from "../../Requests/Logs/DeleteLog";
import editLogCommentRequest from "../../Requests/Logs/EditLogComment";

export const getLogsAction = (payload: GetLogsPayload): LogsActionTypes => {
    return {
        type: FETCH_LOGS,
        payload: payload,
    };
};

export const getLogsList = (
    type: string | null,
    bot_id: string | null,
    application: string | null,
    filters: LogsFilters,
    sort: LogsSort,
    page: number = 1,
    per_page: number = 10,
    body: Record<string, string> = {},
) => {
    return getRequest(per_page, type, bot_id, application, page, body, filters, sort);
};

export const deleteLogsAction = (payload: DeleteLogsPayload): LogsActionTypes => {
    return {
        type: DELETE_LOGS,
        payload: payload,
    };
};

export const deleteLog = (logIds: number[]) => {
    return deleteLogRequest(logIds);
};

export const editLogCommentAction = (payload: EditLogCommentPayload): LogsActionTypes => {
    return {
        type: EDIT_LOG_COMMENT,
        payload: payload,
    };
};

export const editCommentLogs = (logIds: number[], comment: string) => {
    return editLogCommentRequest(logIds, comment);
};

export const changeLogsFilters = (filters: Partial<LogsFilters>): LogsActionTypes => {
    return {
        type: CHANGE_LOGS_FILTERS,
        payload: filters,
    };
};

export const setLogsPage = (page: number, size: number): LogsActionTypes => {
    return {
        type: SET_LOGS_PAGE,
        payload: {
            page: page,
            size: size,
        },
    };
};

export const changeLogsSort = (sort: ChangeLogsSortPayload): LogsActionTypes => {
    return {
        type: CHANGE_LOGS_SORT,
        payload: sort,
    };
};
