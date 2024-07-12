import {Dispatch} from "redux";
import {User} from "../../Model/User";
import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken} from "../../Util/config";
import {getUsersAction} from "../../Store/Users/Actions";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import i18next from "i18next";

export interface UsersResponse {
    users: User[],
    isLoaded: boolean,
}

const getRequest = (page: number, per_page: number) => {
    return (dispatch: Dispatch) => {
        axios.post<UsersResponse>(getApiUrl("accounts/getAccountsList"),
            {
                page: page,
                per_page: per_page,
            },
            {
                headers: {
                    "Authorization": `Bearer ${getJwtToken()}`,
                },
            })
            .then((response: AxiosResponse) => {
                return response;
            })
            .then((json) => {
                if (json.data.payload) {
                    dispatch(getUsersAction({
                        users: json.data.payload.users,
                        total: json.data.meta.total,
                        page: json.data.meta.current_page,
                        per_page: json.data.meta.per_page,
                        tags: json.data.payload.tags,
                    }));
                }
            })
            .catch((error: Error | AxiosError) => {
                requestErrorsMessage(error, i18next.t("SIDEBAR_NAV_USERS"));
            });
    };
};

export default getRequest;
