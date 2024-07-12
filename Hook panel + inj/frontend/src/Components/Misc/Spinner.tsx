import React from "react";

interface SpinnerProps {
    size?: number,
    variant?: "circle" | "bubbles",
    title?: string,
    color?: string,
    preloader?: boolean,
}

const Spinner: React.FC<SpinnerProps> = (props: SpinnerProps) => {
    return (
        <div className="app-spinner"
            style={{
                height: props.preloader ? "100%" : "auto",
                maxHeight: props.preloader ? "100%" : "auto",
            }}
        >
            <i className="fa-solid fa-circle-notch"
                style={{
                    fontSize: props.size ? props.size : 32,
                }}
            />

            {props.title && (<div className="app-spinner-title">{props.title}</div>)}
        </div>
    );
};

export default Spinner;
