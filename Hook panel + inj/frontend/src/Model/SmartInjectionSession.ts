export interface SmartInjectionSession {
    id: number,
    bot_id: string,
    data: object|null,
    application: string,
    session_id: string,
    action: string,
    created_at: string,
    updated_at: string,
    is_closed: boolean,
}
