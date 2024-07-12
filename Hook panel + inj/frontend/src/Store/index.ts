import RootReducer from "./RootReducer";
import {configureStore} from "@reduxjs/toolkit";
import {api} from "../Api/Api";
import {setupListeners} from "@reduxjs/toolkit/query";

export const store = configureStore({
    reducer: RootReducer,
    middleware: (getDefaultMiddleware) =>
        getDefaultMiddleware({thunk: true})
            .concat(api.middleware),
});

setupListeners(store.dispatch);

export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;
