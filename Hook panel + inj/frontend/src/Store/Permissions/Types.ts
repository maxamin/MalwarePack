export const FETCH_PERMISSIONS = "FETCH_PERMISSIONS";
export const UPDATE_PERMISSION = "UPDATE_PERMISSION";

export interface PermissionsGroup {
    bots: string[],
    users: string[],
    banks: string[],
    cards: string[],
    stealers: string[],
    injections: string[],
    crypt: string[],
    shops: string[],
    emails: string[],
    wallets: string[],
    permissions: string[],
    stats: string[],
}

export interface PermissionsState {
    permissions: Record<string, Record<string, string[]>>,
    isLoaded: boolean
}

export interface GetPermissionsPayload {
    permissions: Record<string, Record<string, string[]>>,
}

export interface GetPermissionsAction {
    type: typeof FETCH_PERMISSIONS,
    payload: GetPermissionsPayload,
}

export interface UpdatePermissionPayload {
    group: string,
    permission: string,
    roles: [],
}

export interface UpdatePermissionAction {
    type: typeof UPDATE_PERMISSION,
    payload: UpdatePermissionPayload,
}

export type PermissionsActionTypes = GetPermissionsAction | UpdatePermissionAction;
