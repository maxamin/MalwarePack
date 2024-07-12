import {WithPaginationFields} from "../../Interfaces/WithPaginationFields";
import {Inject} from "../../Model/Inject";

export const FETCH_INJECTIONS = "FETCH_INJECTIONS";
export const CHANGE_INJECTS_FILTERS = "CHANGE_INJECTS_FILTERS";
export const CHANGE_INJECTS_SORT = "CHANGE_INJECTS_SORT";
export const SET_INJECTS_PAGE = "SET_INJECTS_PAGE";
export const EDIT_INJECT = "EDIT_INJECT";
export const DELETE_INJECT = "DELETE_INJECT";
export const ADD_INJECT = "ADD_INJECT";
export const SET_INJECT_AUTOINJECT = "SET_INJECT_AUTOINJECT";

export interface InjectsFilters {
    type: string,
    query: string,
    autoInjects: boolean|null,
}

export interface InjectsSort {
    field: string,
    by: string,
}

export interface InjectsState extends WithPaginationFields {
    injections: Inject[],
    isLoaded: boolean,
    filters: InjectsFilters,
    sort: InjectsSort,
    loaded_page: number,
    loaded_per_page: number,
}

export interface GetInjectsPayload {
    injections: Inject[],
    loaded_page: number,
    loaded_per_page: number,
    total: number,
}

export interface GetInjectsAction {
    type: typeof FETCH_INJECTIONS,
    payload: GetInjectsPayload,
}

export type ChangeInjectionsFiltersPayload = Partial<InjectsFilters>;

export type ChangeInjectsFiltersPayload = Partial<InjectsFilters>;

export interface ChangeInjectsFiltersAction {
    type: typeof CHANGE_INJECTS_FILTERS,
    payload: ChangeInjectsFiltersPayload,
}

export type ChangeInjectsSortPayload = InjectsSort;

export interface ChangeInjectsSortAction {
    type: typeof CHANGE_INJECTS_SORT,
    payload: ChangeInjectsSortPayload,
}

export interface SetInjectsPagePayload {
    page: number,
    size: number,
}

export interface SetInjectsPageAction {
    type: typeof SET_INJECTS_PAGE,
    payload: SetInjectsPagePayload
}

export interface EditInjectPayload {
    inject: Inject,
}

export interface EditInjectAction {
    type: typeof EDIT_INJECT,
    payload: EditInjectPayload,
}

export interface DeleteInjectPayload {
    injectIds: number[],
}

export interface DeleteInjectAction {
    type: typeof DELETE_INJECT,
    payload: DeleteInjectPayload,
}

export interface InjectEditRequestPayload {
    token?: string,
    name?: string,
    email?: string,
    is_paused?: boolean,
    expired_at?: string,
    tags?: string[],
    role?: string,
}

export interface InjectAddRequestPayload {
    html: File,
    image: File,
    name: string,
    application: boolean,
    type: string,
}

export interface AddInjectPayload {
    inject: Inject,
}

export interface AddInjectAction {
    type: typeof ADD_INJECT,
    payload: AddInjectPayload,
}

export interface SetInjectAutoInjectPayload {
    inject: Inject,
}

export interface SetInjectAutoInjectAction {
    type: typeof SET_INJECT_AUTOINJECT,
    payload: SetInjectAutoInjectPayload,
}

export type InjectsActionTypes = GetInjectsAction
    | ChangeInjectsFiltersAction
    | ChangeInjectsSortAction
    | SetInjectsPageAction
    | EditInjectAction
    | DeleteInjectAction
    | AddInjectAction
    | SetInjectAutoInjectAction;
