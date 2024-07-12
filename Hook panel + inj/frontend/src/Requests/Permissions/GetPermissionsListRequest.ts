import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken} from "../../Util/config";
import {getPermissionsAction} from "../../Store/Permissions/Actions";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import i18next from "i18next";

const getRequest = () => {
    return (dispatch: Dispatch) => {
        axios.post(getApiUrl("permissions/getPermissionsList"), {}, {
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
        })
            .then((response: AxiosResponse) => {
                return response;
            }).then((json) => {
                if (json.data.payload) {
                    dispatch(getPermissionsAction({
                        permissions: json.data.payload.permissions,
                    }));
                }
            }).catch((error: Error | AxiosError) => {
                requestErrorsMessage(error, i18next.t("PERMISSIONS_LIST"));
            });
    };
};

export default getRequest;
