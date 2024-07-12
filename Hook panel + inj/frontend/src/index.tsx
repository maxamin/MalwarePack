import React from "react";
import App from "./App";
import {Provider} from "react-redux";
import moment from "moment-timezone";
import "./i18n";
import {store} from "./Store";
import {createRoot} from "react-dom/client";
import {Alert} from "antd";
// @ts-ignore - No types declaration
import io from "socket.io-client";

moment.tz.setDefault(process.env.REACT_APP_TIMEZONE);

export const socketUrl: string = process.env.REACT_APP_SOCKET_IO_URL as string;

export const socket = io(socketUrl, {
    transports: ["polling"],
});

socket.on("disconnect", () => {
    console.log("disconnected from socket.io");
});

socket.on("connect", () => {
    console.log("connected to socket.io");
});

socket.connect();

createRoot(document.getElementById("root") as HTMLElement).render(
    <Alert.ErrorBoundary>
        <Provider store={store}>
            <App />
        </Provider>
    </Alert.ErrorBoundary>,
);
