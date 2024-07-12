import {
    ADD_INJECT,
    AddInjectPayload,
    CHANGE_INJECTS_FILTERS,
    CHANGE_INJECTS_SORT,
    ChangeInjectionsFiltersPayload,
    ChangeInjectsSortPayload,
    DELETE_INJECT,
    DeleteInjectPayload,
    EDIT_INJECT,
    EditInjectPayload,
    FETCH_INJECTIONS,
    GetInjectsPayload,
    InjectsActionTypes,
    InjectsState,
    SET_INJECT_AUTOINJECT,
    SET_INJECTS_PAGE,
    SetInjectAutoInjectPayload,
    SetInjectsPagePayload,
} from "./Types";
import {Inject} from "../../Model/Inject";
import update from "react-addons-update";

const initialState: InjectsState = {
    per_page: 10,
    page: 1,
    injections: [],
    total: 0,
    isLoaded: false,
    filters: {
        type: "",
        query: "",
        autoInjects: null,
    },
    sort: {
        field: "",
        by: "",
    },
    loaded_per_page: 0,
    loaded_page: 0,
};

const getInjects = (state: InjectsState, payload: GetInjectsPayload): InjectsState => {
    return {
        ...state,
        ...payload,
        isLoaded: true,
    };
};

const changeFilters = (state: InjectsState, payload: ChangeInjectionsFiltersPayload): InjectsState => {
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

const setPage = (state: InjectsState, payload: SetInjectsPagePayload): InjectsState => {
    return {
        ...state,
        page: payload.page,
        per_page: payload.size,
    };
};

const changeSort = (state: InjectsState, payload: ChangeInjectsSortPayload): InjectsState => {
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

const editInject = (state: InjectsState, payload: EditInjectPayload): InjectsState => {
    const injectIndex = state.injections.findIndex((inject: Inject) => inject.id === payload.inject.id);

    return update(state, {
        injections: {
            [injectIndex]: {
                $set: payload.inject,
            },
        },
    });
};

const deleteInject = (state: InjectsState, payload: DeleteInjectPayload): InjectsState => {
    return {
        ...state,
        injections: state.injections.filter((inject: Inject) => !payload.injectIds.includes(inject.id)),
    };
};

const addInject = (state: InjectsState, payload: AddInjectPayload): InjectsState => {
    return {
        ...state,
        injections: [
            payload.inject,
            ...state.injections,
        ],
    };
};

const setAutoInject = (state: InjectsState, payload: SetInjectAutoInjectPayload) => {
    const injectIndex = state.injections.findIndex((inject: Inject) => inject.id === payload.inject.id);

    return update(state, {
        injections: {
            [injectIndex]: {
                $set: payload.inject,
            },
        },
    });
};

const InjectsReducer = (state: InjectsState = initialState, action: InjectsActionTypes): InjectsState => {
    switch (action.type) {
    case FETCH_INJECTIONS:
        return getInjects(state, action.payload);
    case CHANGE_INJECTS_FILTERS:
        return changeFilters(state, action.payload);
    case SET_INJECTS_PAGE:
        return setPage(state, action.payload);
    case CHANGE_INJECTS_SORT:
        return changeSort(state, action.payload);
    case ADD_INJECT:
        return addInject(state, action.payload);
    case EDIT_INJECT:
        return editInject(state, action.payload);
    case DELETE_INJECT:
        return deleteInject(state, action.payload);
    case SET_INJECT_AUTOINJECT:
        return setAutoInject(state, action.payload);
    default:
        return state;
    }
};

export default InjectsReducer;
