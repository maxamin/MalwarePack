import {
    AC_CHANGE_COMMAND_FIELDS,
    AC_CHANGE_ENABLED,
    ACChangeCommandFieldsPayload,
    ACChangeEnabledPayload,
} from "./Types";
import autoCommandsUpdate from "../../Requests/AutoCommands/UpdateAutoCommandsRequest";

export const acChangeEnabledAction = (payload: ACChangeEnabledPayload) => {
    return {
        type: AC_CHANGE_ENABLED,
        payload: payload,
    };
};

export const acChangeCommandFieldsAction = (payload: ACChangeCommandFieldsPayload) => {
    return {
        type: AC_CHANGE_COMMAND_FIELDS,
        payload: payload,
    };
};

export const updateAutoCommands = (payload: ACChangeCommandFieldsPayload) => {
    return autoCommandsUpdate(payload);
};
