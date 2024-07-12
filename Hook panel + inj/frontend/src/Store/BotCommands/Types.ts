import {BotCommand} from "../../Model/BotCommand";
import {WithPaginationFields} from "../../Interfaces/WithPaginationFields";

export const GET_BOT_COMMANDS_LIST = "GET_BOT_COMMANDS_LIST";

export interface BotCommandsState extends WithPaginationFields {
    commands: BotCommand[],
    botId: string,
    isLoaded: boolean,
}

export interface GetBotCommandsListPayload extends WithPaginationFields {
    commands: BotCommand[],
    botId: string,
}

export interface GetBotCommandsListAction {
    type: typeof GET_BOT_COMMANDS_LIST,
    payload: GetBotCommandsListPayload,
}

export type BotCommandsTypes = GetBotCommandsListAction;
