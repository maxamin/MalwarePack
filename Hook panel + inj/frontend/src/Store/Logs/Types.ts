import {BotLog} from "../../Model/BotLog";
import {WithPaginationFields} from "../../Interfaces/WithPaginationFields";

export const FETCH_LOGS = "FETCH_LOGS";
export const DELETE_LOGS = "DELETE_LOGS";
export const EDIT_LOG_COMMENT = "EDIT_LOG_COMMENT";
export const CHANGE_LOGS_FILTERS = "CHANGE_LOGS_FILTERS";
export const CHANGE_LOGS_SORT = "CHANGE_LOGS_SORT";
export const SET_LOGS_PAGE = "SET_LOGS_PAGE";

export interface LogsFilters {
    application: string,
    query: string,
    keyloggerAction: string,
}

export interface LogsSort {
    field: string,
    by: string,
}

export interface LogsState extends WithPaginationFields {
    logs: BotLog[],
    isLoaded: boolean,
    type: string|null,
    application: string|null,
    botId: string|null,
    filters: LogsFilters,
    sort: LogsSort,
    loaded_page: number,
    loaded_per_page: number,
}

export interface GetLogsPayload extends Partial<WithPaginationFields> {
    logs: BotLog[],
    type: string|null,
    application: string|null,
    botId: string|null,
    loaded_page: number,
    loaded_per_page: number,
}

export interface GetLogsAction {
    type: typeof FETCH_LOGS,
    payload: GetLogsPayload,
}

export interface DeleteLogsPayload {
    logIds: number[],
}

export interface DeleteLogsAction {
    type: typeof DELETE_LOGS
    payload: DeleteLogsPayload,
}

export interface EditLogCommentPayload {
    logIds: number[],
    comment: string,
}

export interface EditLogCommentAction {
    type: typeof EDIT_LOG_COMMENT,
    payload: EditLogCommentPayload
}

export type ChangeLogsFiltersPayload = Partial<LogsFilters>;

export interface ChangeLogsFiltersAction {
    type: typeof CHANGE_LOGS_FILTERS,
    payload: ChangeLogsFiltersPayload,
}

export type ChangeLogsSortPayload = LogsSort;

export interface ChangeLogsSortAction {
    type: typeof CHANGE_LOGS_SORT,
    payload: ChangeLogsSortPayload,
}

export interface SetLogsPagePayload {
    page: number,
    size: number,
}

export interface SetLogsPageAction {
    type: typeof SET_LOGS_PAGE,
    payload: SetLogsPagePayload
}

export type LogsActionTypes = GetLogsAction
    | DeleteLogsAction
    | EditLogCommentAction
    | ChangeLogsFiltersAction
    | SetLogsPageAction
    | ChangeLogsSortAction;
