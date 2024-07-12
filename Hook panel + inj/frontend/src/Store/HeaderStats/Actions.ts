import {FETCH_HEADER_STATS, GetHeaderStatsPayload, HeaderStatsActionTypes} from "./Types";
import getStatsRequest from "../../Requests/Stats/GetStatsRequest";

export const getHeaderStatsAction = (payload: GetHeaderStatsPayload): HeaderStatsActionTypes => {
    return {
        type: FETCH_HEADER_STATS,
        payload: payload,
    };
};

export const getHeaderStatsList = () => {
    return getStatsRequest(true);
};
