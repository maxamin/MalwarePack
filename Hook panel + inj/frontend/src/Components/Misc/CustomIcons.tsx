import Icon from "@ant-design/icons";
import React from "react";

interface CustomIconsProps {
    style?: any,
}

export const OnlineIcon = () => {
    return (
        <Icon style={{fill: "#4aac16"}} component={() => (
            <svg viewBox="0 0 120 120" width={"1rem"} height={"1rem"}>
                <circle cx="60" cy="60" r="50"/>
            </svg>
        )} />
    );
};

export const OfflineIcon = () => {
    return (
        <Icon style={{fill: "#ffd100"}} component={() => (
            <svg viewBox="0 0 120 120" width={"1rem"} height={"1rem"}>
                <circle cx="60" cy="60" r="50"/>
            </svg>
        )} />
    );
};

export const DeadIcon = () => {
    return (
        <Icon style={{fill: "#777"}} component={() => (
            <svg viewBox="0 0 120 120" width={"1rem"} height={"1rem"}>
                <circle cx="60" cy="60" r="50"/>
            </svg>
        )} />
    );
};

export const SimCardIcon = () => {
    return (
        <Icon component={() => (
            <svg viewBox="0 0 384 512" width={"1rem"} height={"1rem"} fill="currentColor">
                {/* eslint-disable-next-line max-len */}
                <path d="M0 64v384c0 35.25 28.75 64 64 64h256c35.25 0 64-28.75 64-64V128l-128-128H64C28.75 0 0 28.75 0 64zM224 256H160V192h64V256zM320 256h-64V192h32c17.75 0 32 14.25 32 32V256zM256 384h64v32c0 17.75-14.25 32-32 32h-32V384zM160 384h64v64H160V384zM64 384h64v64H96c-17.75 0-32-14.25-32-32V384zM64 288h256v64H64V288zM64 224c0-17.75 14.25-32 32-32h32v64H64V224z"/>
            </svg>
        )} />
    );
};

export const BitcoinIcon: React.FC<CustomIconsProps> = (props: CustomIconsProps) => {
    return (
        <Icon component={() => (
            <svg viewBox="0 0 512 512" width={"1rem"} height={"1rem"} fill="currentColor" style={props.style}>
                {/* eslint-disable-next-line max-len */}
                <path d="M504 256c0 136.967-111.033 248-248 248S8 392.967 8 256 119.033 8 256 8s248 111.033 248 248zm-141.651-35.33c4.937-32.999-20.191-50.739-54.55-62.573l11.146-44.702-27.213-6.781-10.851 43.524c-7.154-1.783-14.502-3.464-21.803-5.13l10.929-43.81-27.198-6.781-11.153 44.686c-5.922-1.349-11.735-2.682-17.377-4.084l.031-.14-37.53-9.37-7.239 29.062s20.191 4.627 19.765 4.913c11.022 2.751 13.014 10.044 12.68 15.825l-12.696 50.925c.76.194 1.744.473 2.829.907-.907-.225-1.876-.473-2.876-.713l-17.796 71.338c-1.349 3.348-4.767 8.37-12.471 6.464.271.395-19.78-4.937-19.78-4.937l-13.51 31.147 35.414 8.827c6.588 1.651 13.045 3.379 19.4 5.006l-11.262 45.213 27.182 6.781 11.153-44.733a1038.209 1038.209 0 0 0 21.687 5.627l-11.115 44.523 27.213 6.781 11.262-45.128c46.404 8.781 81.299 5.239 95.986-36.727 11.836-33.79-.589-53.281-25.004-65.991 17.78-4.098 31.174-15.792 34.747-39.949zm-62.177 87.179c-8.41 33.79-65.308 15.523-83.755 10.943l14.944-59.899c18.446 4.603 77.6 13.717 68.811 48.956zm8.417-87.667c-7.673 30.736-55.031 15.12-70.393 11.292l13.548-54.327c15.363 3.828 64.836 10.973 56.845 43.035z"/>
            </svg>
        )}/>
    );
};

export const BatteryIcon = () => {
    return (
        <Icon component={() => (
            <svg viewBox="0 0 24 24" width={"1rem"} height={"1rem"} fill="currentColor">
                <g>
                    <path d="M0 0h24v24H0z" fill="none"/>
                    {/* eslint-disable-next-line max-len */}
                    <path style={{fill: "#0a0"}} d="M13 12h3l-5 7v-5H8l5-7v5zm-2-6H7v14h10V6h-4V4h-2v2zM9 4V3a1 1 0 0 1 1-1h4a1 1 0 0 1 1 1v1h3a1 1 0 0 1 1 1v16a1 1 0 0 1-1 1H6a1 1 0 0 1-1-1V5a1 1 0 0 1 1-1h3z"/>
                </g>
            </svg>
        )}/>
    );
};

export const KeyboardIcon = () => {
    return (
        <svg viewBox="0 0 24 24" width={"1rem"} height={"1rem"} fill="currentColor">
            <g>
                <path d="M0 0h24v24H0z" fill="none"/>
                {/* eslint-disable-next-line max-len */}
                <path d="M3 17h18v2H3v-2zm0-6h3v3H3v-3zm5 0h3v3H8v-3zM3 5h3v3H3V5zm10 0h3v3h-3V5zm5 0h3v3h-3V5zm-5 6h3v3h-3v-3zm5 0h3v3h-3v-3zM8 5h3v3H8V5z"/>
            </g>
        </svg>
    );
};

export const SettingsAccessibilityIcon: React.FC<CustomIconsProps> = (props: CustomIconsProps) => {
    return (
        <svg className="md-icon" aria-hidden="true" viewBox="0 0 24 24" width={"1rem"} height={"1rem"} style={props.style}>
            {/* eslint-disable-next-line max-len */}
            <path d="M20.5 4c-2.61.7-5.67 1-8.5 1s-5.89-.3-8.5-1L3 6c1.86.5 4 .83 6 1v12h2v-6h2v6h2V7c2-.17 4.14-.5 6-1l-.5-2zM12 4c1.1 0 2-.9 2-2s-.9-2-2-2-2 .9-2 2 .9 2 2 2zM7 24h2v-2H7v2zm4 0h2v-2h-2v2zm4 0h2v-2h-2v2z" />
        </svg>
    );
};

export const VisibilityIcon: React.FC<CustomIconsProps> = (props: CustomIconsProps) => {
    return (
        <svg className="md-icon" aria-hidden="true" viewBox="0 0 24 24" width={"1rem"} height={"1rem"} style={props.style}>
            {/* eslint-disable-next-line max-len */}
            <path d="M12 4.5C7 4.5 2.73 7.61 1 12c1.73 4.39 6 7.5 11 7.5s9.27-3.11 11-7.5c-1.73-4.39-6-7.5-11-7.5zM12 17c-2.76 0-5-2.24-5-5s2.24-5 5-5 5 2.24 5 5-2.24 5-5 5zm0-8c-1.66 0-3 1.34-3 3s1.34 3 3 3 3-1.34 3-3-1.34-3-3-3z" />
        </svg>
    );
};

export const AccountBoxIcon: React.FC<CustomIconsProps> = (props: CustomIconsProps) => {
    return (
        <svg className="md-icon" aria-hidden="true" viewBox="0 0 24 24" width={"1rem"} height={"1rem"} style={props.style}>
            {/* eslint-disable-next-line max-len */}
            <path d="M3 5v14c0 1.1.89 2 2 2h14c1.1 0 2-.9 2-2V5c0-1.1-.9-2-2-2H5c-1.11 0-2 .9-2 2zm12 4c0 1.66-1.34 3-3 3s-3-1.34-3-3 1.34-3 3-3 3 1.34 3 3zm-9 8c0-2 4-3.1 6-3.1s6 1.1 6 3.1v1H6v-1z" />
        </svg>
    );
};

export const TableViewIcon: React.FC<CustomIconsProps> = (props: CustomIconsProps) => {
    return (
        <svg className="md-icon" aria-hidden="true" viewBox="0 0 24 24" width={"1rem"} height={"1rem"} style={props.style}>
            {/* eslint-disable-next-line max-len */}
            <path d="M19 7H9c-1.1 0-2 .9-2 2v10c0 1.1.9 2 2 2h10c1.1 0 2-.9 2-2V9c0-1.1-.9-2-2-2zm0 2v2H9V9h10zm-6 6v-2h2v2h-2zm2 2v2h-2v-2h2zm-4-2H9v-2h2v2zm6-2h2v2h-2v-2zm-8 4h2v2H9v-2zm8 2v-2h2v2h-2zM6 17H5c-1.1 0-2-.9-2-2V5c0-1.1.9-2 2-2h10c1.1 0 2 .9 2 2v1h-2V5H5v10h1v2z" />
        </svg>
    );
};


export const OfflineBoltIcon: React.FC<CustomIconsProps> = (props: CustomIconsProps) => {
    return (
        <svg className="md-icon" aria-hidden="true" viewBox="0 0 24 24" width={"1rem"} height={"1rem"} style={props.style}>
            {/* eslint-disable-next-line max-len */}
            <path d="M12 2.02c-5.51 0-9.98 4.47-9.98 9.98s4.47 9.98 9.98 9.98 9.98-4.47 9.98-9.98S17.51 2.02 12 2.02zM11.48 20v-6.26H8L13 4v6.26h3.35L11.48 20z" />
        </svg>
    );
};

export const AdminPanelSettingsIcon: React.FC<CustomIconsProps> = (props: CustomIconsProps) => {
    return (
        <svg className="md-icon" aria-hidden="true" viewBox="0 0 24 24" width={"1rem"} height={"1rem"} style={props.style}>
            {/* eslint-disable-next-line max-len */}
            <path d="M17 11c.34 0 .67.04 1 .09V6.27L10.5 3 3 6.27v4.91c0 4.54 3.2 8.79 7.5 9.82.55-.13 1.08-.32 1.6-.55-.69-.98-1.1-2.17-1.1-3.45 0-3.31 2.69-6 6-6z" />
            {/* eslint-disable-next-line max-len */}
            <path d="M17 13c-2.21 0-4 1.79-4 4s1.79 4 4 4 4-1.79 4-4-1.79-4-4-4zm0 1.38c.62 0 1.12.51 1.12 1.12s-.51 1.12-1.12 1.12-1.12-.51-1.12-1.12.5-1.12 1.12-1.12zm0 5.37c-.93 0-1.74-.46-2.24-1.17.05-.72 1.51-1.08 2.24-1.08s2.19.36 2.24 1.08c-.5.71-1.31 1.17-2.24 1.17z" />
        </svg>
    );
};

export const MarkEmailReadIcon: React.FC<CustomIconsProps> = (props: CustomIconsProps) => {
    return (
        <svg className="md-icon" aria-hidden="true" viewBox="0 0 24 24" width={"1rem"} height={"1rem"} style={props.style}>
            {/* eslint-disable-next-line max-len */}
            <path d="M12 19c0-3.87 3.13-7 7-7 1.08 0 2.09.25 3 .68V6c0-1.1-.9-2-2-2H4c-1.1 0-2 .9-2 2v12c0 1.1.9 2 2 2h8.08c-.05-.33-.08-.66-.08-1zM4 6l8 5 8-5v2l-8 5-8-5V6zm13.34 16-3.54-3.54 1.41-1.41 2.12 2.12 4.24-4.24L23 16.34 17.34 22z" />
        </svg>
    );
};

export const MarkEmailUnreadIcon: React.FC<CustomIconsProps> = (props: CustomIconsProps) => {
    return (
        <svg className="md-icon" aria-hidden="true" viewBox="0 0 24 24" width={"1rem"} height={"1rem"} style={props.style}>
            {/* eslint-disable-next-line max-len */}
            <path d="M22 8.98V18c0 1.1-.9 2-2 2H4c-1.1 0-2-.9-2-2V6c0-1.1.9-2 2-2h10.1c-.06.32-.1.66-.1 1 0 1.48.65 2.79 1.67 3.71L12 11 4 6v2l8 5 5.3-3.32c.54.2 1.1.32 1.7.32 1.13 0 2.16-.39 3-1.02zM16 5c0 1.66 1.34 3 3 3s3-1.34 3-3-1.34-3-3-3-3 1.34-3 3z" />
        </svg>
    );
};

export const KeyboardIconMD: React.FC<CustomIconsProps> = (props: CustomIconsProps) => {
    return (
        <svg className="md-icon" aria-hidden="true" viewBox="0 0 24 24" width={"1rem"} height={"1rem"} style={props.style}>
            {/* eslint-disable-next-line max-len */}
            <path d="M20 5H4c-1.1 0-1.99.9-1.99 2L2 17c0 1.1.9 2 2 2h16c1.1 0 2-.9 2-2V7c0-1.1-.9-2-2-2zm-9 3h2v2h-2V8zm0 3h2v2h-2v-2zM8 8h2v2H8V8zm0 3h2v2H8v-2zm-1 2H5v-2h2v2zm0-3H5V8h2v2zm9 7H8v-2h8v2zm0-4h-2v-2h2v2zm0-3h-2V8h2v2zm3 3h-2v-2h2v2zm0-3h-2V8h2v2z"/>
        </svg>
    );
};

export const HideSMSIcon: React.FC<CustomIconsProps> = (props: CustomIconsProps) => {
    return (
        <svg className="md-icon md-icon-custom-size" aria-hidden="true" viewBox="0 0 24 24" width={"1rem"} height={"1rem"} style={props.style}>
            {/* eslint-disable-next-line max-len */}
            <path fill="currentColor" d="M13.09 18H4V8L12 13L20 8V13.09C20.72 13.21 21.39 13.46 22 13.81V6C22 4.9 21.1 4 20 4H4C2.9 4 2 4.9 2 6V18C2 19.1 2.9 20 4 20H13.09C13.04 19.67 13 19.34 13 19C13 18.66 13.04 18.33 13.09 18M20 6L12 11L4 6H20M20.41 19L22.54 21.12L21.12 22.54L19 20.41L16.88 22.54L15.47 21.12L17.59 19L15.47 16.88L16.88 15.47L19 17.59L21.12 15.47L22.54 16.88L20.41 19Z" />
        </svg>
    );
};

