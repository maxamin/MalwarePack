import {GetPermissionsPayload, PermissionsActionTypes, PermissionsState, UpdatePermissionPayload} from "./Types";

const initialState: PermissionsState = {
    permissions: {},
    isLoaded: false,
};

const getPermissions = (state: PermissionsState, payload: GetPermissionsPayload): PermissionsState => {
    return {
        ...payload,
        isLoaded: true,
    };
};

const updatePermission = (state: PermissionsState, payload: UpdatePermissionPayload): PermissionsState => {
    const newPermissions = state.permissions;
    newPermissions[payload.group][payload.permission] = payload.roles;

    return {
        ...state,
        permissions: {
            ...newPermissions,
        },
    };
};

const PermissionsReducer = (state: PermissionsState = initialState, action: PermissionsActionTypes): PermissionsState => {
    switch (action.type) {
    case "FETCH_PERMISSIONS":
        return getPermissions(state, action.payload);
    case "UPDATE_PERMISSION":
        return updatePermission(state, action.payload);
    default:
        return state;
    }
};

export default PermissionsReducer;
