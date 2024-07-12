import React from "react";

interface VideoProps {
    poster: string,
    video: string,
}

const LoginVideoBg: React.FC<VideoProps> = (props: VideoProps) => {
    return (
        <div className="Auth-bg">
            <video
                autoPlay={true}
                muted={true}
                loop={true}
                poster={props.poster}
            >
                <source src={props.video} type="video/mp4" />
            </video>
        </div>
    );
};

export default LoginVideoBg;
