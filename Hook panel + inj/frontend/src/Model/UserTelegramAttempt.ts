export interface UserTelegramAttempt {
    id: number,
    user_id: number,
    secret_word: string,
    attempts: number,
    created_at: string,
    updated_at: string,
}
