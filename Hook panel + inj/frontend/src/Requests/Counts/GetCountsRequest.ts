import {Dispatch} from "redux";
import axios, {AxiosResponse} from "axios";
import {getApiUrl, getJwtToken} from "../../Util/config";
import {getCountsAction} from "../../Store/Counts/Actions";
import {GetCountsPayload} from "../../Store/Counts/Types";

interface GetCountsResponse {
    payload: GetCountsPayload,
    success: boolean,
}

const getCountsRequest = () => {
    return (dispatch: Dispatch) => {
        axios.post<GetCountsResponse>(getApiUrl("counts/getCounts"), {}, {
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
        })
            .then((response: AxiosResponse<GetCountsResponse>) => {
                return response;
            }).then((json:AxiosResponse<GetCountsResponse>) => {
                if (json.data.payload) {
                    dispatch(getCountsAction(json.data.payload));
                }
            });
    };
};

export default getCountsRequest;
