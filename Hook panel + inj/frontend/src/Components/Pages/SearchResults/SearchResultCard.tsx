import React, {Dispatch, SetStateAction} from "react";
import {BotLog} from "../../../Model/BotLog";
import {Alert, Badge, Button, Col, Divider, Image, Input, Space, Tag} from "antd";
import CopyToClipboard from "react-copy-to-clipboard";
import {successNotify} from "../../../Util/config";
import {useTranslation} from "react-i18next";
import moment from "moment";
import {NavLink} from "react-router-dom";

interface IProps {
    log: BotLog,
    logIds: number[],
    setLogIds: Dispatch<SetStateAction<number[]>>,
}

const SearchResultCard: React.FC<IProps> = (props: IProps) => {
    const log = props.log;

    let parsedLogs = {};

    if (log.log.data !== undefined) {
        if (typeof log.log.data === "string") {
            parsedLogs = JSON.parse(log.log.data.toString());
        } else {
            parsedLogs = log.log.data;
        }
    } else {
        if (Array.isArray(log.log)) {
            parsedLogs = log.log.map((item) => {
                return JSON.stringify(item);
            });
        } else {
            try {
                parsedLogs = JSON.parse(log.log.toString());
            } catch (e) {
                parsedLogs = log.log;
            }
        }
    }

    const {t} = useTranslation();

    const lastConnectionDiff = moment().diff(moment(log.bot?.updated_at)) / 1000;

    const lastConnectionStatus = lastConnectionDiff <= 60 ? (
        <Badge status="processing" text="online"/>
    ) : (lastConnectionDiff >= 144000 ?
        <Badge status="processing" text="uninstalled"/> :
        <Badge status="processing" text="offline"/>
    );

    return (
        <Col xxl={6} xl={8} md={12} sm={24} xs={24} key={log.id} style={{marginBottom: 15}}>
            <div className="inject-card">
                <div>
                    <div className="inject-head" style={{marginTop: 0}}>
                        <div>
                            <div>
                                <Space>
                                    <div className="app-icon" style={{backgroundImage: "url()"}}/>

                                    <div className="app-name"
                                        title={log.application}
                                        style={{
                                            width: "calc(100% - 117px)",
                                            overflow: "hidden",
                                            textOverflow: "ellipsis",
                                        }}>
                                        {log.application}
                                    </div>
                                </Space>
                            </div>
                            <Space className="text-ellipsis">
                                <span>ID: [#{log.id}]</span>
                            </Space>
                        </div>
                    </div>
                    <div className="inject-bot-info">
                        <div>
                            <NavLink
                                to={`/bots?bot_ids=${log.bot_id}`}
                            >
                                {log.bot_id}
                            </NavLink>
                        </div>
                        <Space>
                            <span className={"inject-bot-status " + lastConnectionStatus}>
                                {lastConnectionStatus}
                            </span>
                            <Tag className={"bot-item-tag"}>
                                {log.bot?.tag}
                            </Tag>
                        </Space>
                    </div>
                    <div className="inject-content">
                        {log.comment && (
                            <Alert
                                type={"success"}
                                description={log.comment}
                                icon={(
                                    <span className="anticon">
                                        <i
                                            className="fa-regular fa-message"
                                            style={{color: "#fff", fontSize: 18}}
                                        />
                                    </span>
                                )}
                                showIcon={true}
                                style={{padding: "9px 4px 4px 9px", marginTop: 15}}
                            />
                        )}

                        <div>
                            <div className="inject-data">
                                <Divider orientation="center" style={{margin: "15px 0 0"}}>
                                    {t("DATA")}
                                </Divider>
                                <div className="inject-data-inner">
                                    <div><b>{t("DATE")}</b>: {log.created_at}</div>
                                    <br/>
                                    {Object.keys(parsedLogs).filter((item) => item !== "closed").map((itemLog, key) => {
                                        // @ts-ignore
                                        const itemLogValue = parsedLogs[itemLog] as string;

                                        return (
                                            <Input.Group key={key}>
                                                <Input
                                                    addonBefore={itemLog}
                                                    value={itemLogValue}
                                                    readOnly={true}
                                                    style={{
                                                        width: "calc(100% - 33px)",
                                                    }}
                                                />
                                                <CopyToClipboard
                                                    text={itemLogValue}
                                                    onCopy={() => successNotify(t("SUCCESS"), t("COPIED"))}
                                                >
                                                    <Button
                                                        icon={(
                                                            <span className="anticon">
                                                                <i className="fa-solid fa-paste"/>
                                                            </span>
                                                        )}
                                                        type="primary"
                                                        onClick={() => {

                                                        }}
                                                    />
                                                </CopyToClipboard>
                                            </Input.Group>
                                        );
                                    })}
                                </div>

                                {log.log.additional && (
                                    <Divider orientation="center" style={{margin: "15px 0 0"}}>
                                        {t("LOG_COLUMN_ADDITIONAL")}
                                    </Divider>
                                )}

                                <div className="inject-data-inner">
                                    {log.log.additional && Object.keys(log.log.additional).map((item, key) => {
                                        const additionalData = log.log.additional as any;

                                        if (additionalData[item].includes("data:image")) {
                                            return (
                                                <Image.PreviewGroup key={log.id}>
                                                    <div className="screen-grid-item">
                                                        <Image src={additionalData[item]}/>
                                                    </div>
                                                </Image.PreviewGroup>
                                            );
                                        }

                                        return (
                                            <Input.Group key={key}>
                                                <Input
                                                    addonBefore={item}
                                                    value={additionalData[item]}
                                                    readOnly={true}
                                                    style={{
                                                        width: "calc(100% - 33px)",
                                                    }}
                                                />
                                                <Button
                                                    icon={(
                                                        <span className="anticon">
                                                            <i className="fa-solid fa-paste"/>
                                                        </span>
                                                    )}
                                                    type="primary"
                                                />
                                            </Input.Group>
                                        );
                                    })}
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </Col>
    );
};

export default SearchResultCard;
