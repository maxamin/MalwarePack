import React from "react";
import {changeLocale} from "../../Store/Settings/Actions";
import {ILocales} from "../../Store/Settings/Types";
import {useTranslation} from "react-i18next";
import {Select, Space} from "antd";
import {languages} from "../../i18n";
import {AppState} from "../../Store/RootReducer";
import {useAppDispatch} from "../../Hook/useAppDispatch";
import {useAppSelector} from "../../Hook/useAppSelector";

const LocalePicker: React.FC = () => {
    const {i18n} = useTranslation();

    const dispatch = useAppDispatch();

    const changeLanguage = (lng: string) => {
        i18n.changeLanguage(lng).then(() => dispatch(changeLocale({
            locale: lng as ILocales,
        })));
    };

    const settingsReducer = useAppSelector((state: AppState) => state.settings);

    return (
        <Select
            optionLabelProp="label"
            defaultValue={settingsReducer.locale}
            onChange={changeLanguage}
            placement="topLeft"
        >
            {Object.keys(languages).map((key: string) => {
                return (
                    <Select.Option
                        key={key}
                        value={languages[key].code}
                        label={
                            <Space>
                                <img
                                    src={`https://purecatamphetamine.github.io/country-flag-icons/3x2/${languages[key].code.toUpperCase()}.svg`}
                                    width={16}
                                    alt={languages[key].name}
                                />
                                <span>{languages[key].name}</span>
                            </Space>
                        }
                    >
                        <Space>
                            <img
                                src={`https://purecatamphetamine.github.io/country-flag-icons/3x2/${languages[key].code.toUpperCase()}.svg`}
                                width={16}
                                alt={languages[key].name}
                            />
                            <span>{languages[key].name}</span>
                        </Space>
                    </Select.Option>
                );
            })}
        </Select>
    );
};

export default LocalePicker;
