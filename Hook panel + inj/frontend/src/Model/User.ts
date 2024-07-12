import {UserTelegramAttempt} from "./UserTelegramAttempt";
import {UserTelegramInjection} from "./UserTelegramInjection";
import {UserTelegramBot} from "./UserTelegramBot";

export interface User {
    id: number,
    name: string,
    email?: string,
    is_paused: boolean,
    expired_at?: string,
    created_at: string,
    updated_at: string,
    permissions: string[],
    token: string,
    tags: string[],
    role: string,
    telegramAttempt: UserTelegramAttempt | null,
    telegramInjections: Record<string, UserTelegramInjection[]>,
    telegramBots: UserTelegramBot[],
    telegram_id: number|null,
    createdUser?: {
        id: number,
        name: string
    },
}
