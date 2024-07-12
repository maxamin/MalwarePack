export const FETCH_COUNTS = "FETCH_COUNTS";
export const SET_COUNT = "SET_COUNT";

interface Counts {
    bots: number,
    banks: number,
    stealers: number,
    crypt: number,
    shops: number,
    emails: number,
    wallets: number,
    credit_cards: number,
    permissionless_bots: number,
    events: number,
    smart_injects: number,
}

export interface CountsState extends Counts {
    isLoaded: boolean,
}

export type GetCountsPayload = Counts;

export interface GetCountsAction {
    type: typeof FETCH_COUNTS,
    payload: GetCountsPayload,
}

export interface SetCountAction {
    type: typeof SET_COUNT,
    payload: Partial<CountsState>,
}

export type CountsActionTypes = GetCountsAction | SetCountAction;
