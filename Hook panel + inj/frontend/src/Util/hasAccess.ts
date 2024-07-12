import {User} from "../Model/User";

export const hasAccess = (user: User, access: string) => {
    return user.permissions.includes(access);
};
