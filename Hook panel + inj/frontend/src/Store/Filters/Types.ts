export const FETCH_FILTERS = "FETCH_FILTERS";

export type CountryFilters = Record<string, string>;

export interface InjectionFilter {
    name: string,
    type: string,
}

export type InjectionFilters = Record<string, InjectionFilter>;

export interface FiltersState {
    countries: CountryFilters,
    injections: InjectionFilters,
    start_date: string
    isLoaded: boolean,
    applications: Record<string, InjectionFilters>,
}

export interface GetFiltersPayload {
    countries: CountryFilters,
    injections: InjectionFilters,
    start_date: string,
    applications: Record<string, InjectionFilters>,
}

export interface GetFiltersAction {
    type: typeof FETCH_FILTERS,
    payload: GetFiltersPayload,
}

export type FiltersActionTypes = GetFiltersAction;
