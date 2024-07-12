import axios, {AxiosError, AxiosResponse} from "axios";
import {getApiUrl, getJwtToken, successNotify} from "../../Util/config";
import {requestErrorsMessage} from "../../Util/requestErrorsMessage";
// @ts-ignore
import i18next from "i18next";
import {socket} from "../../index";

export interface SendCommandPayload {
    command: string,
    payload: object,
    botIds: string[],
}

const sendCommand = (payload: SendCommandPayload) => {
    axios.post(getApiUrl("bots/sendBotsCommand"),
        payload, {
            headers: {
                "Authorization": `Bearer ${getJwtToken()}`,
            },
        })
        .then((response: AxiosResponse) => {
            return response;
        }).then(() => {
            payload.botIds.forEach((botId) => {
                console.log(`socket emmit: {"updateCommands", {"uid": "${botId}"}`);
                socket.emit("updateCommands", `{"uid": "${botId}"}`);
            });

            successNotify(i18next.t("SEND_COMMAND"), i18next.t("SUCCESS"));
        }).catch((error: Error | AxiosError) => {
            if (process.env.NODE_ENV && process.env.NODE_ENV !== "development") {
                requestErrorsMessage(error, i18next.t("SEND_COMMAND"));
            }
        });
};

export default sendCommand;
