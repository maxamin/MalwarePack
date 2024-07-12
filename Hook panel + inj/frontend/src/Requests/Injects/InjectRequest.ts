import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken} from "../../Util/config";
import {getInjectsAction} from "../../Store/Injections/Actions";
import {InjectsFilters, InjectsSort} from "../../Store/Injections/Types";
import {Inject} from "../../Model/Inject";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";

interface InjectsResponse {
    payload: {
        injections: {
            data: Inject[],
            current_page: number,
            total: number,
            per_page: number,
        },
    }
}

const getRequest = (
    filters: InjectsFilters,
    sort: InjectsSort,
    per_page: number,
    page: number,
) => {
    return (dispatch: Dispatch) => {
        axios.post<InjectsResponse>(getApiUrl("injects/getInjectionsList"), {
            sort: sort,
            filters: filters,
            per_page: per_page,
            page: page,
        }, {
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
        })
            .then((response: AxiosResponse<InjectsResponse>) => {
                return response;
            }).then((json) => {
                if (json.data.payload) {
                    dispatch(getInjectsAction({
                        injections: json.data.payload.injections.data,
                        total: json.data.payload.injections.total,
                        loaded_per_page: json.data.payload.injections.per_page,
                        loaded_page: json.data.payload.injections.current_page,
                    }));
                }
            }).catch((error: Error | AxiosError | string) => {
                requestErrorsMessage(error, "Injects list");
            });
    };
};

export default getRequest;
