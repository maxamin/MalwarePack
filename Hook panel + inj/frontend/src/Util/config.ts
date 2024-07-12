import {notification} from "antd";
import i18next from "i18next";

export const panelName = "Hook";

export const apiUrl: string = process.env.REACT_APP_BACKEND_URL as string;

export const themeAccentColor: string = "#5a9d32";

export const getBackendUrl = (url: string) => {
    return apiUrl + url;
};

export const getApiUrl = (url: string) => {
    return apiUrl + "api/v1/" + url;
};

export const getJwtToken = () => {
    return localStorage.getItem("token");
};

export const inputRules = [
    {
        required: true,
        message: i18next.t("EMPTY_FIELD"),
    },
];

export const customStyles = {
    menu: (provided: any) => ({
        ...provided,
        backgroundColor: "#191c24",
        gap: 0,
        zIndex: 15,
    }),
    input: (provided: any) => ({
        ...provided,
        color: "#ffffff",
        padding: "1px 0",
    }),
    option: (provided: any, state: { isFocused: boolean; }) => ({
        ...provided,
        backgroundColor: state.isFocused ? "#2e3342" : "#191c24",
        cursor: "pointer",
        margin: 0,
    }),
    group: () => ({}),
    container: () => ({
        backgroundColor: "#181b20",
        cursor: "pointer",
    }),
    control: () => ({
        display: "flex",
        border: "1px solid #434343",
        borderRadius: 0,
    }),
    indicatorsContainer: (provided: any) => {
        const borderLeft = "none";
        const padding = "0";

        return {...provided, borderLeft, padding};
    },
    groupHeading: () => ({
        display: "none",
    }),
    singleValue: (provided: any, state: { isDisabled: boolean; }) => {
        const opacity = state.isDisabled ? 0.5 : 1;
        const transition = "opacity 300ms";
        const color = "#ffffff";

        return {...provided, opacity, transition, color};
    },
    indicatorSeparator: (provided: any) => ({
    }),
    clearIndicator: (provided: any) => ({
        ...provided,
        padding: 5,
    }),
    dropdownIndicator: (provided: any) => ({
        ...provided,
        padding: 5,
    }),
    valueContainer: (provided: any) => ({
        ...provided,
        padding: "0 10px",
    }),
};

export const customStylesLight = {
    menu: (provided: any) => ({
        ...provided,
        backgroundColor: "#f7f7f7",
        gap: 0,
        zIndex: 15,
    }),
    input: (provided: any) => ({
        ...provided,
        color: "#333",
        backgroundColor: null,
        padding: "1px 0",
    }),
    option: (provided: any, state: { isFocused: boolean; }) => ({
        ...provided,
        backgroundColor: state.isFocused ? "#e0e0e0" : "#f0f0f0",
        cursor: "pointer",
        color: "#333",
        margin: 0,
    }),
    group: () => ({}),
    container: () => ({
        cursor: "pointer",
    }),
    control: () => ({
        display: "flex",
        border: "1px solid #dadada",
        borderRadius: 0,
    }),
    indicatorsContainer: (provided: any) => {
        const borderLeft = "none";
        const padding = "0";

        return {...provided, borderLeft, padding};
    },
    groupHeading: () => ({
        display: "none",
    }),
    singleValue: (provided: any, state: { isDisabled: boolean; }) => {
        const opacity = state.isDisabled ? 0.5 : 1;
        const transition = "opacity 300ms";
        const color = "#333";

        return {...provided, opacity, transition, color};
    },
    indicatorSeparator: (provided: any) => ({
    }),
    clearIndicator: (provided: any) => ({
        ...provided,
        padding: 5,
    }),
    dropdownIndicator: (provided: any) => ({
        ...provided,
        padding: 5,
    }),
    valueContainer: (provided: any) => ({
        ...provided,
        padding: "0 10px",
    }),
    placeholder: (provided: any) => ({
        ...provided,
        color: "#dadada",
    }),
};

export const successNotify = (message: string, description: string) => {
    return notification.success({
        message: message,
        description: description,
        placement: "bottomLeft",
    });
};

export const errorNotify = (message: string, description: string) => {
    return notification.error({
        message: message,
        description: description,
        placement: "bottomLeft",
    });
};
