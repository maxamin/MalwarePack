import React, {Dispatch, SetStateAction} from "react";
import {Switch} from "antd";

interface IVncSocketCheckboxProps {
    textModeIsEnabled: boolean,
    setTextModeIsEnabled: Dispatch<SetStateAction<boolean>>,
}

const VNCTextModeCheckbox: React.FC<IVncSocketCheckboxProps> = (props: IVncSocketCheckboxProps) => {
    return (
        <Switch
            checked={props.textModeIsEnabled}
            size="small"
            onChange={(is_active: boolean) => {
                props.setTextModeIsEnabled(is_active);
            }}
        />
    );
};

export default VNCTextModeCheckbox;
