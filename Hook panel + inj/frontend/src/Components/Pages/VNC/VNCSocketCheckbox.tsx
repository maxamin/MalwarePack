import React from "react";
import {Switch} from "antd";
import {socket} from "../../../index";

const VncSocketCheckbox: React.FC = () => {
    return (
        <Switch
            defaultChecked={socket.connected}
            size="small"
            onChange={(is_active: boolean) => {
                socket.connected ? socket.disconnect() : socket.connect();
            }}
        />
    );
};

export default VncSocketCheckbox;
