import {BotCommandsState, BotCommandsTypes, GetBotCommandsListPayload} from "./Types";

const initialState: BotCommandsState = {
    commands: [],
    botId: "",
    isLoaded: false,
    per_page: 5,
    page: 1,
    total: 0,
};

const getBotCommands = (state: BotCommandsState, payload: GetBotCommandsListPayload): BotCommandsState => {
    return {
        ...payload,
        isLoaded: true,
    };
};

const BotCommandsReducer = (state: BotCommandsState = initialState, action: BotCommandsTypes): BotCommandsState => {
    switch (action.type) {
    case "GET_BOT_COMMANDS_LIST":
        return getBotCommands(state, action.payload);
    default:
        return state;
    }
};

export default BotCommandsReducer;
