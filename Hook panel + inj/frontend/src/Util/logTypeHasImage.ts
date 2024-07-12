export const logTypeHasImage = (logType: string) => {
    return [
        "banks",
        "crypt",
        "wallets",
        "shops",
        "credit_cards",
        "emails",
        "mail",
    ].includes(logType);
};
