import {Dispatch} from "redux";
import axios, {AxiosResponse} from "axios";
import {getApiUrl, getJwtToken} from "../../Util/config";
import {getFiltersAction} from "../../Store/Filters/Actions";

const getRequest = () => {
    return (dispatch: Dispatch) => {
        axios.get(getApiUrl("bots/getBotsFilter"), {
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
        })
            .then((response: AxiosResponse) => {
                return response;
            }).then((json) => {
                if (json.data.payload) {
                    dispatch(getFiltersAction(json.data.payload));
                }
            });
    };
};

export default getRequest;
