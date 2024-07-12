import {FETCH_FILTERS, FiltersActionTypes, FiltersState, GetFiltersPayload} from "./Types";

const initialState: FiltersState = {
    countries: {},
    injections: {},
    start_date: "2022-01-18 00:00:00",
    isLoaded: false,
    applications: {},
};

const getFilters = (state: FiltersState, payload: GetFiltersPayload): FiltersState => {
    return {
        countries: payload.countries,
        injections: payload.injections,
        start_date: payload.start_date,
        isLoaded: true,
        applications: payload.applications,
    };
};

const FiltersReducer = (state: FiltersState = initialState, action: FiltersActionTypes): FiltersState => {
    switch (action.type) {
    case FETCH_FILTERS:
        return getFilters(state, action.payload);
    default:
        return state;
    }
};

export default FiltersReducer;
