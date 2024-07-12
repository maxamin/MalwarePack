import {
    CHANGE_FILTERS,
    CHANGE_SORT,
    ChangeSmartInjectionsFiltersPayload,
    ChangeSmartInjectionsSortPayload,
    GET_SESSIONS_LIST,
    GetSmartInjectionSessionsPayload,
    SET_PAGE,
    SetSmartInjectionsPagePayload,
    SmartInjectionsActionTypes,
    SmartInjectionsState,
    UPDATE_SESSION,
    UpdateSmartInjectionSessionPayload,
} from "./Types";
import {SmartInjectionSession} from "../../Model/SmartInjectionSession";
import update from "react-addons-update";

const initialState: SmartInjectionsState = {
    per_page: 10,
    page: 1,
    sessions: [],
    total: 0,
    isLoaded: false,
    filters: {
        type: "",
        query: "",
        autoSmartInjections: null,
    },
    sort: {
        field: "",
        by: "",
    },
    loaded_per_page: 0,
    loaded_page: 0,
};

const getSessions = (state: SmartInjectionsState, payload: GetSmartInjectionSessionsPayload): SmartInjectionsState => {
    return {
        ...state,
        ...payload,
        isLoaded: true,
    };
};

const changeFilters = (state: SmartInjectionsState, payload: ChangeSmartInjectionsFiltersPayload): SmartInjectionsState => {
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

const setPage = (state: SmartInjectionsState, payload: SetSmartInjectionsPagePayload): SmartInjectionsState => {
    return {
        ...state,
        page: payload.page,
        per_page: payload.size,
    };
};

const changeSort = (state: SmartInjectionsState, payload: ChangeSmartInjectionsSortPayload): SmartInjectionsState => {
    return {
        ...state,
        sort: {
            ...state.sort,
            ...payload,
        },
        page: 1,
        isLoaded: false,
    };
};

const updateSession = (state: SmartInjectionsState, payload: UpdateSmartInjectionSessionPayload): SmartInjectionsState => {
    const injectIndex = state.sessions.findIndex((session: SmartInjectionSession) => session.id === payload.id);
    state.sessions[injectIndex] = payload;

    return update(state, {
        sessions: {
            [injectIndex]: {
                $set: payload,
            },
        },
    });
};

const SmartInjectionsReducer = (state: SmartInjectionsState = initialState, action: SmartInjectionsActionTypes): SmartInjectionsState => {
    switch (action.type) {
    case GET_SESSIONS_LIST:
        return getSessions(state, action.payload);
    case CHANGE_FILTERS:
        return changeFilters(state, action.payload);
    case SET_PAGE:
        return setPage(state, action.payload);
    case CHANGE_SORT:
        return changeSort(state, action.payload);
    case UPDATE_SESSION:
        return updateSession(state, action.payload);
    default:
        return state;
    }
};

export default SmartInjectionsReducer;
