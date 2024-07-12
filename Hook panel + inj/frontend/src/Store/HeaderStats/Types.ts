export const FETCH_HEADER_STATS = "FETCH_HEADER_STATS";

export interface HeaderStatsState {
    isLoaded: boolean,
    online: number,
    offline: number,
    lastHour: number
}

export type GetHeaderStatsPayload = Omit<HeaderStatsState, "isLoaded">;

export interface GetHeaderStatsAction {
    type: typeof FETCH_HEADER_STATS,
    payload: GetHeaderStatsPayload,
}

export type HeaderStatsActionTypes = GetHeaderStatsAction;
