import {createApi, fetchBaseQuery} from "@reduxjs/toolkit/query/react";
import {getJwtToken} from "../Util/config";

export const api = createApi({
    baseQuery: fetchBaseQuery({
        baseUrl: process.env.REACT_APP_BACKEND_URL + "api/v1/",
        prepareHeaders: (headers: Headers) => {
            headers.set("Content-Type", "application/json;charset=UTF-8");
            headers.set("Accept", "application/json");

            const token = getJwtToken();

            if (token) {
                headers.set("Authorization", `Bearer ${token}`);
            }

            return headers;
        },
    }),
    endpoints: (builder) => ({
        search: builder.query<string[], string>({
            // TODO type for request
            query: (request: any) => ({
                url: "/search",
                body: request,
                method: "POST",
            }),
        }),
    }),
    tagTypes: ["Search"],
});

export const {useSearchQuery} = api;
