
export interface BotLocation {
    lat: number,
    lon: number,
}

export interface BotInjection {
    name: string,
    type: string
    is_active: boolean,
    application: string,
    newData: boolean,
}

export interface BotSimCard {
    operator: string,
    phone_number: string,
    isDualSim: boolean,
    operator1: string,
    phone_number1: string,
}

export interface BotMetadata {
    device: string,
    android: string,
    version: string,
    manufacturer: string,
    screenResolution: {
        width: number,
        height: number,
    }
}

export interface BotSubInfo {
    admin: boolean,
    screen: boolean,
    protect: number,
    isDozeMode: boolean,
    batteryLevel: number,
    accessibility: boolean,
    isKeyguardLocked: boolean
}

export interface BotSettings {
    hideSMS: boolean,
    lockDevice: boolean,
    offSound: boolean,
    keylogger: boolean,
    clearPush: boolean,
    readPush: boolean,
    arrayUrl: string[]
}

export interface BotPermissions {
    all_permission: boolean,
    sms_permission: boolean,
    overlay_permission: boolean,
    accounts_permission: boolean,
    contacts_permission: boolean,
    notification_permission: boolean
}

export interface Bot {
    id: string,
    tag: string,
    sim_data?: BotSimCard,
    metadata: BotMetadata,
    permissions: BotPermissions,
    sub_info: BotSubInfo,
    settings: BotSettings,
    ip: string,
    country: string,
    country_code: string,
    last_connection: string,
    created_at: string,
    updated_at: string,
    injections: BotInjection[],
    is_favorite: boolean,
    is_blacklisted: boolean,
    set_contact_list: boolean,
    set_windows_fake: boolean,
    comment: string|null,
    location: BotLocation,
    applications: string[],
}
