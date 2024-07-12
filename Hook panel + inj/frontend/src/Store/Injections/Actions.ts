import {
    ADD_INJECT,
    CHANGE_INJECTS_FILTERS,
    CHANGE_INJECTS_SORT,
    ChangeInjectionsFiltersPayload,
    ChangeInjectsSortPayload,
    DELETE_INJECT,
    EDIT_INJECT,
    FETCH_INJECTIONS,
    GetInjectsPayload,
    InjectAddRequestPayload,
    InjectEditRequestPayload,
    InjectsActionTypes,
    InjectsFilters,
    InjectsSort,
    SET_INJECT_AUTOINJECT,
    SET_INJECTS_PAGE,
    SetInjectAutoInjectPayload,
} from "./Types";
import getRequest from "../../Requests/Injects/InjectRequest";
import {Inject} from "../../Model/Inject";
import createInjectRequest from "../../Requests/Injects/CreateInjectRequest";
import deleteInjectRequest from "../../Requests/Injects/DeleteInjectRequest";
import editInjectRequest from "../../Requests/Injects/EditInjectRequest";
import autoInjectRequest from "../../Requests/Injects/AutoinjectRequest";

export const getInjectsAction = (payload: GetInjectsPayload): InjectsActionTypes => {
    return {
        type: FETCH_INJECTIONS,
        payload: payload,
    };
};

export const changeInjectsFilters = (payload: ChangeInjectionsFiltersPayload): InjectsActionTypes => {
    return {
        type: CHANGE_INJECTS_FILTERS,
        payload: payload,
    };
};

export const setInjectsPage = (page: number, size: number): InjectsActionTypes => {
    return {
        type: SET_INJECTS_PAGE,
        payload: {
            page: page,
            size: size,
        },
    };
};

export const changeInjectsSort = (sort: ChangeInjectsSortPayload): InjectsActionTypes => {
    return {
        type: CHANGE_INJECTS_SORT,
        payload: sort,
    };
};

export const getInjectsList = (
    filters: InjectsFilters,
    sort: InjectsSort,
    page: number = 1,
    per_page: number = 10,
) => {
    return getRequest(filters, sort, per_page, page);
};

export const editInjectAction = (inject: Inject): InjectsActionTypes => {
    return {
        type: EDIT_INJECT,
        payload: {
            inject: inject,
        },
    };
};

export const deleteInjectAction = (injectIds: number[]): InjectsActionTypes => {
    return {
        type: DELETE_INJECT,
        payload: {
            injectIds: injectIds,
        },
    };
};

export const addInjectAction = (inject: Inject): InjectsActionTypes => {
    return {
        type: ADD_INJECT,
        payload: {
            inject: inject,
        },
    };
};

export const editInject = (injectId: number, payload: InjectEditRequestPayload) => {
    return editInjectRequest(injectId, payload);
};

export const deleteInjects = (injectIds: number[]) => {
    return deleteInjectRequest(injectIds);
};

export const addInject = (
    payload: InjectAddRequestPayload,
) => {
    return createInjectRequest(payload);
};

export const setInjectAutoInjectAction = (payload: SetInjectAutoInjectPayload): InjectsActionTypes => {
    return {
        type: SET_INJECT_AUTOINJECT,
        payload: payload,
    };
};

export const setAutoInject = (injectId: number, autoInject: boolean) => {
    return autoInjectRequest(injectId, autoInject);
};
