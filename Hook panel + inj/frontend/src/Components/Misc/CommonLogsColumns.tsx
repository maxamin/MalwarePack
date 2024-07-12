import {BotLog} from "../../Model/BotLog";
import {Space} from "antd";
import {logTypeHasImage} from "../../Util/logTypeHasImage";
import {getBackendUrl} from "../../Util/config";
import {AndroidFilled, CodeFilled} from "@ant-design/icons";
import React from "react";

export const CommonLogsColumns = [
    {
        title: "# ID",
        dataIndex: "id",
        key: "id",
        width: 50,
        render: (text: string) =>
            <div className="table-col">
                <div className="table-col-item">
                    <h3>ID</h3>
                </div>
                <div className="table-col-item" style={{textAlign: "center"}}>
                    {text}
                </div>
            </div>,
    },
    {
        title: (
            <>
                <AndroidFilled /> Bot ID
            </>
        ),
        dataIndex: "bot_id",
        key: "bot_id",
        width: 300,
        render: (text: string) =>
            <div className="table-col">
                <div className="table-col-item">
                    <h3>Bot ID</h3>
                </div>
                <div className="table-col-item">
                    <a href="/" onClick={(e) => e.preventDefault()}>{text}</a>
                </div>
            </div>,
    },
    {
        title: (
            <>
                <CodeFilled /> Application
            </>
        ),
        dataIndex: "application",
        key: "application",
        render: (application: string, log: BotLog) => (
            <>
                <div className="table-col">
                    <div className="table-col-item">
                        <h3>Application</h3>
                    </div>
                    <div className="table-col-item">
                        <Space size={5}>
                            {logTypeHasImage(log.type) && (
                                <img
                                    src={getBackendUrl(`/injects/images/${log.type}/${application}.png`)}
                                    width={16}
                                    alt={application}
                                />
                            )}
                            {application}
                        </Space>
                    </div>
                </div>
            </>
        ),
    },
];
