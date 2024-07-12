import {BotVNCState, BotVNCTypes, GetBotVNCDataPayload} from "./Types";
import update from "react-addons-update";

const initialState: BotVNCState = {
    botId: "",
    screen: "",
    tree: null,
    isLoaded: false,
    isActive: false,
    updatedAt: "",
    prevUpdatedAt: "",
};

const getBotVNCData = (state: BotVNCState, payload: GetBotVNCDataPayload): BotVNCState => {
    return update({
        ...state,
        botId: payload.botId,
        screen: payload.screen,
        isActive: payload.isActive,
        updatedAt: payload.updatedAt,
        isLoaded: true,
    }, {
        tree: {
            $set: payload.tree,
        },
    });
};

const BotVNCReducer = (state: BotVNCState = initialState, action: BotVNCTypes): BotVNCState => {
    switch (action.type) {
    case "GET_BOT_VNC_DATA":
        return getBotVNCData(state, action.payload);
    default:
        return state;
    }
};

export default BotVNCReducer;
