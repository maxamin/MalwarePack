import React from "react";
import {Button, Divider, Result, Space} from "antd";
import {BotDownloadedFile} from "../../../Store/BotFileManager/Types";
import {t} from "i18next";
import {getBackendUrl} from "../../../Util/config";

interface IExplorerDownloadedFilesProps {
    downloadedFiles: BotDownloadedFile[],
    botId: string,
}

const ExplorerDownloadedFiles: React.FC<IExplorerDownloadedFilesProps> = (props: IExplorerDownloadedFilesProps) => {
    const deleteFile = () => {
        alert("deleteFile");
    };

    return (
        <div className="panel-content">
            <div className="fm-content">
                <div className="fm-content-inner">
                    <Divider orientation="left" style={{margin: "0 0"}}>
                        <h1>{t("DOWNLOADED_FILES")}</h1>
                    </Divider>

                    <div className="explorer-content downloaded-content">
                        {props.downloadedFiles.length === 0 ? (
                            <Result
                                icon={(
                                    <span className="anticon">
                                        <i className="fa-solid fa-download" />
                                    </span>
                                )}
                                className="ant-result-accent"
                                title={t("DOWNLOADS_EMPTY")}
                                subTitle={t("DOWNLOADS_EMPTY_DESCRIPTION")}
                            />
                        ) : (
                            <table style={{width: "100%"}}>
                                <thead>
                                    <tr>
                                        <th style={{textAlign: "left"}}>{t("NAME")}</th>
                                        <th>{t("PATH")}</th>
                                        <th>{t("SIZE")}</th>
                                        <th>{t("DATE")}</th>
                                        <th>{t("ACTION")}</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    {props.downloadedFiles.map((file: BotDownloadedFile, key: number) => {
                                        return (
                                            <tr key={key}>
                                                <td>
                                                    <Space size={0} align="center">
                                                        <div className="fm-content-icon">
                                                            <i className="fm-icon fa-solid fa-file" style={{color: "#6db9c8"}} />
                                                        </div>
                                                        <div className="fm-content-body">
                                                            <span className="fm-content-name">
                                                                {file.name}
                                                            </span>
                                                        </div>
                                                    </Space>
                                                </td>
                                                <td style={{textAlign: "center"}}>
                                                    {file.path}
                                                </td>
                                                <td style={{textAlign: "center"}}>
                                                    {file.size} KB
                                                </td>
                                                <td style={{textAlign: "center"}}>
                                                    {file.created_at}
                                                </td>
                                                <td style={{textAlign: "center"}}>
                                                    <Space>
                                                        <Button
                                                            type="primary"
                                                            className="fm-download-button"
                                                            icon={(
                                                                <span role="img" className="anticon">
                                                                    <i className="fa-solid fa-download" />
                                                                </span>
                                                            )}
                                                            href={getBackendUrl(`download/botFile/${file.id}`)}
                                                            size="small"
                                                        />

                                                        <Button
                                                            type="primary"
                                                            className="fm-download-button"
                                                            icon={(
                                                                <span role="img" className="anticon">
                                                                    <i className="fa-solid fa-close" />
                                                                </span>
                                                            )}
                                                            onClick={deleteFile}
                                                            size="small"
                                                            danger
                                                        />
                                                    </Space>
                                                </td>
                                            </tr>
                                        );
                                    })}
                                </tbody>
                            </table>
                        )}
                    </div>
                </div>
            </div>
        </div>
    );
};

export default ExplorerDownloadedFiles;
