import React from "react";
import {changeTheme} from "../../Store/Settings/Actions";
import {Switch} from "antd";
import {AppState} from "../../Store/RootReducer";
import {useAppDispatch} from "../../Hook/useAppDispatch";
import {useAppSelector} from "../../Hook/useAppSelector";

const ThemePicker: React.FC = () => {
    const dispatch = useAppDispatch();

    const handleChangeTheme = (isChecked: boolean) => {
        dispatch(changeTheme({
            theme: isChecked ? "light" : "dark",
        }));
    };

    const settingsReducer = useAppSelector((state: AppState) => state.settings);

    const isLightThemeSelected = settingsReducer.theme === "light";

    return (
        <Switch
            checkedChildren={(<i className="icon-theme icon-theme-dark" />)}
            unCheckedChildren={(<i className="icon-theme icon-theme-light" />)}
            checked={isLightThemeSelected}
            onChange={handleChangeTheme}
            style={{
                transform: "scale(1.15) translateX(-3px)",
            }}
        />
    );
};

export default ThemePicker;
