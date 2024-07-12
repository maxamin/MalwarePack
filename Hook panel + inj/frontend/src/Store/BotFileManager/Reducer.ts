import {BotFileManagerState, BotFileManagerTypes, GetBotFileManagerDataPayload} from "./Types";

const initialState: BotFileManagerState = {
    botId: "",
    files: [],
    downloadedFiles: [],
    current_file_manager_path: "/storage/emulated/0",
    isLoaded: false,
    updatedAt: "",
    prevUpdatedAt: "",
};

const getBotFileManagerData = (state: BotFileManagerState, payload: GetBotFileManagerDataPayload): BotFileManagerState => {
    return {
        prevUpdatedAt: state.updatedAt,
        ...payload,
        isLoaded: true,
    };
};

const BotFileManagerReducer = (state: BotFileManagerState = initialState, action: BotFileManagerTypes): BotFileManagerState => {
    switch (action.type) {
    case "GET_BOT_FILE_MANAGER_DATA":
        return getBotFileManagerData(state, action.payload);
    default:
        return state;
    }
};

export default BotFileManagerReducer;
