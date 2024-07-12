import {ITree} from "../../Interfaces/Inspector/ITree";

export const GET_BOT_VNC_DATA = "GET_BOT_VNC_DATA";

export interface BotVNCState {
    botId: string,
    screen: string,
    tree: ITree | null,
    isLoaded: boolean,
    isActive: boolean,
    updatedAt: string,
    prevUpdatedAt: string,
}

export type GetBotVNCDataPayload = Pick<BotVNCState, "botId" | "screen" | "tree" | "isActive" | "updatedAt">;

export interface GetBotVNCDataAction {
    type: typeof GET_BOT_VNC_DATA,
    payload: GetBotVNCDataPayload,
}

export type BotVNCTypes = GetBotVNCDataAction;
