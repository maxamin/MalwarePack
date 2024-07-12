import {FETCH_STATS, GetStatsPayload, StatsActionTypes, StatsState} from "./Types";

const initialState: StatsState = {
    isLoaded: false,
    bots: {
        counts: {
            totalToday: 0,
            online: 0,
            offline: 0,
            total: 0,
            uninstalled: 0,
            permissionless: 0,
            lastHour: 0,
            lastDay: 0,
            lastWeek: 0,
            lastMonth: 0,
        },
        countries: [],
        timelines: [],
        models: [],
        androids: [],
        map: {},
    },
    injects: {
        timelines: [],
        counts: {
            banks: 0,
            credit_cards: 0,
            stealers: 0,
            crypt: 0,
            shops: 0,
            emails: 0,
            wallets: 0,
            sum: 0,
        },
    },
    logs: {
        timelines: [],
        counts: {
            smslist: 0,
            hidesms: 0,
            googleauth: 0,
            otheraccounts: 0,
            pushlist: 0,
            keylogger: 0,
            sum: 0,
        },
    },
};

const getStats = (state: StatsState, payload: GetStatsPayload): StatsState => {
    return {
        ...payload,
        isLoaded: true,
    };
};

const StatsReducer = (state: StatsState = initialState, action: StatsActionTypes): StatsState => {
    switch (action.type) {
    case FETCH_STATS:
        return getStats(state, action.payload);
    default:
        return state;
    }
};

export default StatsReducer;
