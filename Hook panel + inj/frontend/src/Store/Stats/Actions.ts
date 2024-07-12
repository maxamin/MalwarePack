import {FETCH_STATS, GetStatsPayload, StatsActionTypes} from "./Types";
import getStatsRequest from "../../Requests/Stats/GetStatsRequest";

export const getStatsAction = (payload: GetStatsPayload): StatsActionTypes => {
    return {
        type: FETCH_STATS,
        payload: payload,
    };
};

export const getStatsList = (isShort = false) => {
    return getStatsRequest(isShort);
};
