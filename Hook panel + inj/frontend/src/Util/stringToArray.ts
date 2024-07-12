export const stringToArray = (string: string): string[] => {
    const array: string[] = [];

    if (string.length === 0) {
        return [];
    }

    if (string.indexOf(",") > 0) {
        return string.split(",");
    }

    array.push(string);

    return array;
};
