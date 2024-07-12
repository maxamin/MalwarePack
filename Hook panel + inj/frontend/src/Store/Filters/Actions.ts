import {FETCH_FILTERS, FiltersActionTypes, GetFiltersPayload} from "./Types";
import getRequest from "../../Requests/Filters/GetRequest";

export const getFiltersAction = (payload: GetFiltersPayload): FiltersActionTypes => {
    return {
        type: FETCH_FILTERS,
        payload: payload,
    };
};

export const getFiltersList = () => {
    return getRequest();
};
