export const GET_BOT_FILE_MANAGER_DATA = "GET_BOT_FILE_MANAGER_DATA";

export interface BotFileManagerFile {
    name: string,
    path: string,
    isDir: boolean,
}


export interface BotDownloadedFile {
    id: number,
    name: string,
    path: string,
    created_at: string,
    size: number,
}

export interface BotFileManagerState {
    botId: string,
    files: BotFileManagerFile[],
    isLoaded: boolean,
    current_file_manager_path: string,
    downloadedFiles: BotDownloadedFile[],
    updatedAt: string,
    prevUpdatedAt: string,
}

export type GetBotFileManagerDataPayload = Pick<BotFileManagerState, "botId" | "files" | "updatedAt" | "downloadedFiles" | "current_file_manager_path">;

export interface GetBotFileManagerDataAction {
    type: typeof GET_BOT_FILE_MANAGER_DATA,
    payload: GetBotFileManagerDataPayload,
}


export type BotFileManagerTypes = GetBotFileManagerDataAction;
