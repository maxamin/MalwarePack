import React from "react";
import {scrollToTop} from "../../Util/scrollToTop";
import {Button} from "antd";
import {ArrowUpOutlined} from "@ant-design/icons";

interface ScrollToTopProps {
    visible: boolean,
}

const ScrollToTop: React.FC<ScrollToTopProps> = (props: ScrollToTopProps) => {
    const onClickHandler = () => {
        scrollToTop();
    };

    return (
        <div
            className="scrollToTop"
            style={{
                display: props.visible ? "block" : "none",
            }}
        >
            <Button shape="circle" type="primary" onClick={onClickHandler}>
                <ArrowUpOutlined />
            </Button>
        </div>
    );
};

export default ScrollToTop;
