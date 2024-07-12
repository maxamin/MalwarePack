import axios, {AxiosError} from "axios";
import {errorNotify} from "./config";

export const requestErrorsMessage = (error: (Error | AxiosError | string), prefix: string) => {
    if (typeof error === "string") {
        errorNotify("Error: ", error);
        return;
    }

    if (axios.isAxiosError(error)) {
        if (error.response?.data.error !== undefined) {
            errorNotify(prefix, error.response.data.error);
        } else if (error.response?.data.message !== undefined) {
            errorNotify(prefix, error.response.data.message);
        } else if (typeof error.response?.data === "string") {
            errorNotify("Error: ", error.response?.data);
        } else {
            Object.keys(error.response?.data).forEach((key) => {
                const value = error.response?.data[key];

                if (typeof value === "object") {
                    error.response?.data[key].forEach((value: string) => {
                        errorNotify(prefix, value);
                    });
                } else {
                    errorNotify(prefix, value);
                }
            });
        }
    } else {
        errorNotify(prefix, error.message);
    }
};
