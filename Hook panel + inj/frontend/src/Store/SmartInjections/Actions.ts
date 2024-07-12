import {
    CHANGE_FILTERS,
    CHANGE_SORT,
    ChangeSmartInjectionsSortPayload,
    GET_SESSIONS_LIST,
    GetSmartInjectionSessionsPayload,
    SET_PAGE,
    SmartInjectionsActionTypes,
    SmartInjectionsFilters,
    SmartInjectionsSort,
    UPDATE_SESSION,
    UpdateSmartInjectionSessionPayload,
} from "./Types";
import {ChangeInjectionsFiltersPayload} from "../Injections/Types";
import getSessionsListRequest from "../../Requests/SmartInjections/GetSessionsListRequest";
import updateSessionRequest from "../../Requests/SmartInjections/UpdateSessionRequest";

export const getSmartInjectionSessionsAction = (payload: GetSmartInjectionSessionsPayload): SmartInjectionsActionTypes => {
    return {
        type: GET_SESSIONS_LIST,
        payload: payload,
    };
};

export const getSmartInjectionSessionsList = (
    filters: SmartInjectionsFilters,
    sort: SmartInjectionsSort,
    page: number = 1,
    per_page: number = 10,
) => {
    return getSessionsListRequest(filters, sort, per_page, page);
};


export const changeSmartInjectionsFilters = (payload: ChangeInjectionsFiltersPayload): SmartInjectionsActionTypes => {
    return {
        type: CHANGE_FILTERS,
        payload: payload,
    };
};

export const setSmartInjectionsPage = (page: number, size: number): SmartInjectionsActionTypes => {
    return {
        type: SET_PAGE,
        payload: {
            page: page,
            size: size,
        },
    };
};

export const changeSmartInjectionsSort = (sort: ChangeSmartInjectionsSortPayload): SmartInjectionsActionTypes => {
    return {
        type: CHANGE_SORT,
        payload: sort,
    };
};

export const updateSmartInjectionSessionAction = (payload: UpdateSmartInjectionSessionPayload): SmartInjectionsActionTypes => {
    return {
        type: UPDATE_SESSION,
        payload: payload,
    };
};

export const updateSmartInjectionSession = (
    id: number,
    action: string,
) => {
    return updateSessionRequest(id, action);
};
