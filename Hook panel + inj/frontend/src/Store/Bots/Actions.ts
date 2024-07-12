import {
    BotsActionTypes,
    BotsFilters,
    CHANGE_BOTS_FILTERS,
    CHANGE_SELECTED_BOT,
    ChangeBotsFiltersPayload,
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
    SetBotTypeValuePayload,
    UPDATE_BOT_INJECT_IS_ACTIVE,
    UPDATE_BOT_SETTINGS_VALUE,
    UpdateBotInjectIsActivePayload,
    UpdateBotSettingsValuePayload,
} from "./Types";
import getRequest from "../../Requests/Bots/GetRequest";
import {Bot} from "../../Model/Bot";
import setTypeValueRequest from "../../Requests/Bots/SetTypeValue";
import updateSettingsValueRequest from "../../Requests/Bots/UpdateSettingsValue";
import updateInjectIsActiveRequest from "../../Requests/Bots/UpdateInjectIsActive";
import deleteRequest from "../../Requests/Bots/Delete";
import deleteAllRemovedApp from "../../Requests/Bots/DeleteAllRemovedApp";
import editBotsCommentRequest from "../../Requests/Bots/EditComment";

export const getBotsAction = (payload: GetBotsPayload): BotsActionTypes => {
    return {
        type: FETCH_BOTS,
        payload: payload,
    };
};

export const getBotsList = (filters: BotsFilters, page: number = 1, per_page: number = 12) => {
    return getRequest(page, per_page, filters);
};

export const changeBotsFilter = (filters: ChangeBotsFiltersPayload): BotsActionTypes => {
    return {
        type: CHANGE_BOTS_FILTERS,
        payload: filters,
    };
};

export const setBotsIsLoadedFalse = (): BotsActionTypes => {
    return {
        type: SET_BOTS_IS_LOADED_FALSE,
    };
};

export const changeSelectedBot = (bot: Bot): BotsActionTypes => {
    return {
        type: CHANGE_SELECTED_BOT,
        payload: {
            bot: bot,
        },
    };
};

export const selectedBotsClear = (): BotsActionTypes => {
    return {
        type: SELECTED_BOTS_CLEAR,
    };
};

export const setBotTypeValueAction = (payload: SetBotTypeValuePayload): BotsActionTypes => {
    return {
        type: SET_BOT_TYPE_VALUE,
        payload: payload,
    };
};

export const setBotTypeValue = (botId: string, type: string, value: boolean) => {
    return setTypeValueRequest(botId, type, value);
};

export const updateBotSettingsValueAction = (payload: UpdateBotSettingsValuePayload): BotsActionTypes => {
    return {
        type: UPDATE_BOT_SETTINGS_VALUE,
        payload: payload,
    };
};

export const updateBotSettingsValue = (botId: string, type: string, value: boolean) => {
    return updateSettingsValueRequest(botId, type, value);
};

export const updateBotInjectIsActiveAction = (payload: UpdateBotInjectIsActivePayload): BotsActionTypes => {
    return {
        type: UPDATE_BOT_INJECT_IS_ACTIVE,
        payload: payload,
    };
};

export const updateBotInjectIsActive = (botId: string, application: string, is_active: boolean) => {
    return updateInjectIsActiveRequest(botId, application, is_active);
};

export const deleteBotsAction = (payload: DeleteBotsPayload): BotsActionTypes => {
    return {
        type: DELETE_BOTS,
        payload: payload,
    };
};

export const deleteBots = (botIds: string[]) => {
    return deleteRequest(botIds);
};

export const deleteRemovedAppBotsAction = (payload: DeleteBotsPayload): BotsActionTypes => {
    return {
        type: DELETE_REMOVED_APP_BOTS,
        payload: payload,
    };
};

export const deleteRemovedAppBots = () => {
    return deleteAllRemovedApp();
};

export const setBotPage = (page: number, size: number): BotsActionTypes => {
    return {
        type: SET_BOTS_PAGE,
        payload: {
            page: page,
            size: size,
        },
    };
};

export const editBotsCommentAction = (payload: EditBotsCommentPayload): BotsActionTypes => {
    return {
        type: EDIT_BOTS_COMMENT,
        payload: payload,
    };
};

export const editBotsComment = (botIds: string[], comment: string) => {
    return editBotsCommentRequest(botIds, comment);
};

export const selectAllBotsAction = (payload: SelectAllBotsPayload): BotsActionTypes => {
    return {
        type: SELECT_ALL_BOTS,
        payload: payload,
    };
};

export const selectAllBots = (filters: BotsFilters) => {
    return getRequest(1, 1, filters, {noLimit: true});
};

export const resetFiltersAction = () => {
    return {
        type: RESET_FILTERS,
    };
};
