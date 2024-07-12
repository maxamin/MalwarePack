import {WithPaginationFields} from "../../Interfaces/WithPaginationFields";
import {SmartInjectionSession} from "../../Model/SmartInjectionSession";

export const GET_SESSIONS_LIST = "GET_SESSIONS_LIST";
export const CHANGE_FILTERS = "CHANGE_FILTERS";
export const CHANGE_SORT = "CHANGE_SORT";
export const SET_PAGE = "SET_PAGE";
export const UPDATE_SESSION = "UPDATE_SESSION";

export interface SmartInjectionsFilters {
    // TODO
}

export interface SmartInjectionsSort {
    field: string,
    by: string,
}

export interface SmartInjectionsState extends WithPaginationFields {
    isLoaded: boolean,
    sessions: SmartInjectionSession[],
    filters: SmartInjectionsFilters,
    sort: SmartInjectionsSort,
    loaded_page: number,
    loaded_per_page: number,
}

export interface GetSmartInjectionSessionsPayload {
    sessions: SmartInjectionSession[],
    loaded_page: number,
    loaded_per_page: number,
    total: number,
}

export interface GetSmartInjectionSessionsAction {
    type: typeof GET_SESSIONS_LIST,
    payload: GetSmartInjectionSessionsPayload,
}

export type ChangeSmartInjectionsFiltersPayload = Partial<SmartInjectionsFilters>;

export interface ChangeSmartInjectionsFiltersAction {
    type: typeof CHANGE_FILTERS,
    payload: ChangeSmartInjectionsFiltersPayload,
}

export type ChangeSmartInjectionsSortPayload = SmartInjectionsSort;

export interface ChangeSmartInjectionsSortAction {
    type: typeof CHANGE_SORT,
    payload: ChangeSmartInjectionsSortPayload,
}

export interface SetSmartInjectionsPagePayload {
    page: number,
    size: number,
}

export interface SetSmartInjectionsPageAction {
    type: typeof SET_PAGE,
    payload: SetSmartInjectionsPagePayload
}

export type UpdateSmartInjectionSessionPayload = SmartInjectionSession;

export interface UpdateSmartInjectionSessionAction {
    type: typeof UPDATE_SESSION,
    payload: UpdateSmartInjectionSessionPayload
}

export type SmartInjectionsActionTypes = GetSmartInjectionSessionsAction
    | ChangeSmartInjectionsFiltersAction
    | ChangeSmartInjectionsSortAction
    | SetSmartInjectionsPageAction
    | UpdateSmartInjectionSessionAction;
