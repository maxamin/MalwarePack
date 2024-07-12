import React, {Dispatch, SetStateAction} from "react";
import {Switch} from "antd";

interface IVNCScreenViewCheckboxProps {
    disableScreenView: boolean,
    setDisableScreenView: Dispatch<SetStateAction<boolean>>,
}

const VNCScreenViewCheckbox: React.FC<IVNCScreenViewCheckboxProps> = (props: IVNCScreenViewCheckboxProps) => {
    return (
        <Switch
            checked={props.disableScreenView}
            size="small"
            onChange={(is_active: boolean) => {
                props.setDisableScreenView(is_active);
            }}
        />
    );
};

export default VNCScreenViewCheckbox;
