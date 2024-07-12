import {Bot} from "../../Model/Bot";
import {WithPaginationFields} from "../../Interfaces/WithPaginationFields";

export const FETCH_BOTS = "FETCH_BOTS";
export const CHANGE_BOTS_FILTERS = "CHANGE_BOTS_FILTERS";
export const SET_BOTS_IS_LOADED_FALSE = "SET_BOTS_IS_LOADED_FALSE";
export const CHANGE_SELECTED_BOT = "CHANGE_SELECTED_BOT";
export const SELECTED_BOTS_CLEAR = "SELECTED_BOTS_CLEAR";
export const SET_BOT_TYPE_VALUE = "SET_BOT_TYPE_VALUE";
export const UPDATE_BOT_SETTINGS_VALUE = "UPDATE_BOT_SETTINGS_VALUE";
export const UPDATE_BOT_INJECT_IS_ACTIVE = "UPDATE_BOT_INJECT_IS_ACTIVE";
export const DELETE_BOTS = "DELETE_BOTS";
export const DELETE_REMOVED_APP_BOTS = "DELETE_REMOVED_APP_BOTS";
export const SET_BOTS_PAGE = "SET_BOTS_PAGE";
export const EDIT_BOTS_COMMENT = "EDIT_BOTS_COMMENT";
export const SELECT_ALL_BOTS = "SELECT_ALL_BOTS";
export const RESET_FILTERS = "RESET_FILTERS";


export interface BotsFilters {
    countries: string[],
    injections: string[],
    statuses: string[],
    tags: string[],
    types: string[],
    query: string,
    botIds?: string[],
}

export interface BotsState extends WithPaginationFields {
    bots: Bot[],
    selectedBots: Bot[],
    isLoaded: boolean,
    filters: BotsFilters,
    loaded_page: number,
    loaded_per_page: number,
}

export interface GetBotsPayload extends Partial<WithPaginationFields> {
    bots: Bot[],
    loaded_page: number,
    loaded_per_page: number,
}

export interface GetBotsAction {
    type: typeof FETCH_BOTS,
    payload: GetBotsPayload,
}

export interface ChangeBotsFiltersPayload {
    countries?: string[],
    injections?: string[],
    statuses?: string[],
    tags?: string[],
    types?: string[],
    query?: string,
    botIds?: string[],
}

export interface ChangeBotsFiltersAction {
    type: typeof CHANGE_BOTS_FILTERS,
    payload: ChangeBotsFiltersPayload,
}

export interface SetBotsIsLoadedFalseAction {
    type: typeof SET_BOTS_IS_LOADED_FALSE,
}

export interface ChangeSelectedBotPayload {
    bot: Bot,
}

export interface ChangeSelectedBotAction {
    type: typeof CHANGE_SELECTED_BOT,
    payload: ChangeSelectedBotPayload,
}

export interface SelectedBotsClearAction {
    type: typeof SELECTED_BOTS_CLEAR,
}

export interface SetBotTypeValuePayload {
    bot: Bot,
}

export interface SetBotTypeValueAction {
    type: typeof SET_BOT_TYPE_VALUE,
    payload: SetBotTypeValuePayload,
}

export interface UpdateBotSettingsValuePayload {
    bot: Bot,
}

export interface UpdateBotSettingsValueAction {
    type: typeof UPDATE_BOT_SETTINGS_VALUE,
    payload: UpdateBotSettingsValuePayload,
}

export interface UpdateBotInjectIsActivePayload {
    bot: Bot,
}

export interface UpdateBotInjectIsActiveAction {
    type: typeof UPDATE_BOT_INJECT_IS_ACTIVE,
    payload: UpdateBotInjectIsActivePayload,
}

export interface DeleteBotsPayload {
    botIds: string[]
}

export interface DeleteBotsAction {
    type: typeof DELETE_BOTS,
    payload: DeleteBotsPayload,
}

export interface DeleteRemovedAppBotsAction {
    type: typeof DELETE_REMOVED_APP_BOTS,
    payload: DeleteBotsPayload,
}

export interface SetBotsPagePayload {
    page: number,
    size: number,
}

export interface SetBotsPageAction {
    type: typeof SET_BOTS_PAGE,
    payload: SetBotsPagePayload
}

export interface EditBotsCommentPayload {
    bots: Pick<Bot, "id" | "comment">[],
}

export interface EditBotsCommentAction {
    type: typeof EDIT_BOTS_COMMENT,
    payload: EditBotsCommentPayload
}

export type SelectAllBotsPayload = Pick<Bot, "id">[];

export interface SelectAllBotsAction {
    type: typeof SELECT_ALL_BOTS,
    payload: SelectAllBotsPayload,
}

export interface ResetFiltersAction {
    type: typeof RESET_FILTERS,
}

export type BotsActionTypes =
    GetBotsAction |
    ChangeBotsFiltersAction |
    SetBotsIsLoadedFalseAction |
    ChangeSelectedBotAction |
    SelectedBotsClearAction |
    SetBotTypeValueAction |
    UpdateBotSettingsValueAction |
    UpdateBotInjectIsActiveAction |
    DeleteBotsAction |
    DeleteRemovedAppBotsAction |
    SetBotsPageAction |
    EditBotsCommentAction |
    SelectAllBotsAction |
    ResetFiltersAction;

