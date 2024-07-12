import {CountsActionTypes, CountsState, FETCH_COUNTS, GetCountsPayload, SET_COUNT} from "./Types";

const initialState: CountsState = {
    isLoaded: false,
    bots: 0,
    banks: 0,
    stealers: 0,
    crypt: 0,
    shops: 0,
    emails: 0,
    wallets: 0,
    credit_cards: 0,
    permissionless_bots: 0,
    events: 0,
    smart_injects: 0,
};

const getCounts = (state: CountsState, payload: GetCountsPayload): CountsState => {
    return {
        ...payload,
        isLoaded: true,
    };
};

const setCount = (state: CountsState, payload: Partial<CountsState>): CountsState => {
    return {
        ...state,
        ...payload,
    };
};

const CountsReducer = (state: CountsState = initialState, action: CountsActionTypes): CountsState => {
    switch (action.type) {
    case FETCH_COUNTS:
        return getCounts(state, action.payload);
    case SET_COUNT:
        return setCount(state, action.payload);
    default:
        return state;
    }
};

export default CountsReducer;
