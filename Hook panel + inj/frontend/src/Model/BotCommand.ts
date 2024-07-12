export interface BotCommand {
    id: number,
    bot_id: string,
    command: {
        command: string,
        payload: string[]
    },
    is_processed: boolean,
    created_at: string | null,
    updated_at: string | null,
}
