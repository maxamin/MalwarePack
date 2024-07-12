import {FETCH_HEADER_STATS, GetHeaderStatsPayload, HeaderStatsActionTypes, HeaderStatsState} from "./Types";

const initialState: HeaderStatsState = {
    isLoaded: false,
    online: 0,
    offline: 0,
    lastHour: 0,
};

const getStats = (state: HeaderStatsState, payload: GetHeaderStatsPayload): HeaderStatsState => {
    return {
        ...payload,
        isLoaded: true,
    };
};

const HeaderStatsReducer = (state: HeaderStatsState = initialState, action: HeaderStatsActionTypes): HeaderStatsState => {
    switch (action.type) {
    case FETCH_HEADER_STATS:
        return getStats(state, action.payload);
    default:
        return state;
    }
};

export default HeaderStatsReducer;
