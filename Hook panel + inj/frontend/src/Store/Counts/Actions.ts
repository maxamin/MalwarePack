import {CountsActionTypes, CountsState, FETCH_COUNTS, GetCountsPayload, SET_COUNT} from "./Types";
import getCountsRequest from "../../Requests/Counts/GetCountsRequest";

export const getCountsAction = (payload: GetCountsPayload): CountsActionTypes => {
    return {
        type: FETCH_COUNTS,
        payload: payload,
    };
};

export const getCountsList = () => {
    return getCountsRequest();
};

export const setCountAction = (payload: Partial<CountsState>): CountsActionTypes => {
    return {
        type: SET_COUNT,
        payload: payload,
    };
};
