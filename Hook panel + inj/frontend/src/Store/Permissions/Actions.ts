import {
    FETCH_PERMISSIONS,
    GetPermissionsPayload,
    PermissionsActionTypes,
    UPDATE_PERMISSION,
    UpdatePermissionPayload,
} from "./Types";
import getRequest from "../../Requests/Permissions/GetPermissionsListRequest";
import updatePermissionsListRequest from "../../Requests/Permissions/UpdatePermissionsListRequest";

export const getPermissionsAction = (payload: GetPermissionsPayload): PermissionsActionTypes => {
    return {
        type: FETCH_PERMISSIONS,
        payload: payload,
    };
};

export const getPermissionsList = () => {
    return getRequest();
};

export const updatePermissionAction = (payload: UpdatePermissionPayload): PermissionsActionTypes => {
    return {
        type: UPDATE_PERMISSION,
        payload: payload,
    };
};

export const updatePermission = (permission: string, roles: string[]) => {
    return updatePermissionsListRequest(permission, roles);
};
