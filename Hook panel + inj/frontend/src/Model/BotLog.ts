import {Bot} from "./Bot";

export interface BotLog {
    id: number,
    bot_id: string,
    application: string,
    type: string,
    log: Record<string, string> | Record<string, Record<string, string>>,
    created_at: string,
    updated_at: string,
    comment: string,
    bot: Bot|null,
}
