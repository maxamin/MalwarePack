import {
    BotsActionTypes,
    BotsState,
    CHANGE_BOTS_FILTERS,
    CHANGE_SELECTED_BOT,
    ChangeBotsFiltersPayload,
    ChangeSelectedBotPayload,
    DELETE_BOTS,
    DELETE_REMOVED_APP_BOTS,
    DeleteBotsPayload,
    EDIT_BOTS_COMMENT,
    EditBotsCommentPayload,
    FETCH_BOTS,
    GetBotsPayload,
    RESET_FILTERS,
    SELECT_ALL_BOTS,
    SelectAllBotsPayload,
    SELECTED_BOTS_CLEAR,
    SET_BOT_TYPE_VALUE,
    SET_BOTS_IS_LOADED_FALSE,
    SET_BOTS_PAGE,
    SetBotsPagePayload,
    SetBotTypeValuePayload,
    UPDATE_BOT_INJECT_IS_ACTIVE,
    UPDATE_BOT_SETTINGS_VALUE,
    UpdateBotSettingsValuePayload,
} from "./Types";
import {Bot} from "../../Model/Bot";
import update from "react-addons-update";


const initialState: BotsState = {
    bots: [],
    selectedBots: [],
    isLoaded: false,
    filters: {
        countries: [],
        injections: [],
        statuses: [],
        tags: [],
        types: [],
        query: "",
    },
    total: 0,
    page: 1,
    per_page: 12,
    loaded_page: 0,
    loaded_per_page: 0,
};

const getBots = (state: BotsState, payload: GetBotsPayload): BotsState => {
    return {
        ...state,
        ...payload,
        isLoaded: true,
    };
};

const changeFilters = (state: BotsState, payload: ChangeBotsFiltersPayload): BotsState => {
    return {
        ...state,
        filters: {
            ...state.filters,
            ...payload,
        },
        page: 1,
        isLoaded: false,
    };
};

const setIsLoadedFalse = (state: BotsState): BotsState => {
    return {
        ...state,
        isLoaded: false,
    };
};

const changeSelectedBot = (state: BotsState, payload: ChangeSelectedBotPayload): BotsState => {
    const isSelected = state.selectedBots.filter((bot: Bot) => {
        return payload.bot.id === bot.id;
    }).length > 0;

    if (isSelected) {
        state.selectedBots = state.selectedBots.filter((bot) => bot.id !== payload.bot.id);
    } else {
        state.selectedBots.push(payload.bot);
    }

    return {
        ...state,
        selectedBots: [...state.selectedBots],
    };
};

const selectedBotsClear = (state: BotsState): BotsState => {
    return {
        ...state,
        selectedBots: [],
    };
};

const setTypeValue = (state: BotsState, payload: SetBotTypeValuePayload): BotsState => {
    const botIndex = state.bots.findIndex((bot: Bot) => bot.id === payload.bot.id);

    return update(state, {
        bots: {
            [botIndex]: {
                $set: payload.bot,
            },
        },
    });
};

const updateSettings = (state: BotsState, payload: UpdateBotSettingsValuePayload): BotsState => {
    const botIndex = state.bots.findIndex((bot: Bot) => bot.id === payload.bot.id);

    return update(state, {
        bots: {
            [botIndex]: {
                $set: payload.bot,
            },
        },
    });
};

const updateInjectionIsActive = (state: BotsState, payload: UpdateBotSettingsValuePayload): BotsState => {
    const botIndex = state.bots.findIndex((bot: Bot) => bot.id === payload.bot.id);

    return update(state, {
        bots: {
            [botIndex]: {
                $set: payload.bot,
            },
        },
    });
};

const deleteBots = (state: BotsState, payload: DeleteBotsPayload): BotsState => {
    const bots = state.bots.filter((bot: Bot) => !payload.botIds.includes(bot.id));
    return {
        ...state,
        bots: [...bots],
        selectedBots: [],
    };
};

const deleteRemovedAppBots = (state: BotsState, payload: DeleteBotsPayload): BotsState => {
    const bots = state.bots.filter((bot: Bot) => !payload.botIds.includes(bot.id));
    return {
        ...state,
        bots: [...bots],
    };
};

const setBotsPage = (state: BotsState, payload: SetBotsPagePayload): BotsState => {
    return {
        ...state,
        page: payload.page,
        per_page: payload.size,
    };
};

const editBotsComment = (state: BotsState, payload: EditBotsCommentPayload): BotsState => {
    const botIds = payload.bots.map((bot) => bot.id);
    const bots = state.bots.map((bot) => {
        if (botIds.includes(bot.id)) {
            const newBot = payload.bots.filter((newBot) => newBot.id === bot.id)[0];
            return {
                ...bot,
                comment: newBot.comment,
            };
        }
        return bot;
    });

    return {
        ...state,
        bots: bots,
    };
};

const selectAllBots = (state: BotsState, payload: SelectAllBotsPayload): BotsState => {
    return {
        ...state,
        selectedBots: payload as Bot[],
    };
};

const resetFilters = (state: BotsState): BotsState => {
    return {
        ...state,
        filters: {
            countries: [],
            injections: [],
            statuses: [],
            tags: [],
            types: [],
            query: "",
        },
        page: 1,
    };
};

const BotsReducer = (state: BotsState = initialState, action: BotsActionTypes): BotsState => {
    switch (action.type) {
    case FETCH_BOTS:
        return getBots(state, action.payload);
    case CHANGE_BOTS_FILTERS:
        return changeFilters(state, action.payload);
    case SET_BOTS_IS_LOADED_FALSE:
        return setIsLoadedFalse(state);
    case CHANGE_SELECTED_BOT:
        return changeSelectedBot(state, action.payload);
    case SELECTED_BOTS_CLEAR:
        return selectedBotsClear(state);
    case SET_BOT_TYPE_VALUE:
        return setTypeValue(state, action.payload);
    case UPDATE_BOT_SETTINGS_VALUE:
        return updateSettings(state, action.payload);
    case UPDATE_BOT_INJECT_IS_ACTIVE:
        return updateInjectionIsActive(state, action.payload);
    case DELETE_BOTS:
        return deleteBots(state, action.payload);
    case DELETE_REMOVED_APP_BOTS:
        return deleteRemovedAppBots(state, action.payload);
    case SET_BOTS_PAGE:
        return setBotsPage(state, action.payload);
    case EDIT_BOTS_COMMENT:
        return editBotsComment(state, action.payload);
    case SELECT_ALL_BOTS:
        return selectAllBots(state, action.payload);
    case RESET_FILTERS:
        return resetFilters(state);
    default:
        return state;
    }
};

export default BotsReducer;
