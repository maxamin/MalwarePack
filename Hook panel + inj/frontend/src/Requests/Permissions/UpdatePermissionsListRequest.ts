import {Dispatch} from "redux";
import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken, successNotify} from "../../Util/config";
import {UpdatePermissionPayload} from "../../Store/Permissions/Types";
import {updatePermissionAction} from "../../Store/Permissions/Actions";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
import i18next from "i18next";

interface UpdatePermissionResponse {
    payload: UpdatePermissionPayload,
}

const updatePermissionsListRequest = (permission: string, roles: string[]) => {
    return (dispatch: Dispatch) => {
        axios.put<UpdatePermissionResponse>(getApiUrl("permissions/updatePermission"), {
            permission: permission,
            roles: roles,
        }, {
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
        })
            .then((response: AxiosResponse<UpdatePermissionResponse>) => {
                return response;
            }).then((json: AxiosResponse) => {
                dispatch(updatePermissionAction(json.data.payload));
                successNotify(i18next.t("PERMISSIONS_CHANGES"), i18next.t("SUCCESS"));
            }).catch((error: Error | AxiosError) => {
                requestErrorsMessage(error, i18next.t("PERMISSIONS_CHANGES"));
            });
    };
};

export default updatePermissionsListRequest;
