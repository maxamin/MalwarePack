import React, {CSSProperties, useLayoutEffect, useState} from "react";
import {Divider, Space, Table} from "antd";
import {useTranslation} from "react-i18next";
import {AppState} from "../../Store/RootReducer";
import {getBotCommandsList} from "../../Store/BotCommands/Actions";
import {BotCommand} from "../../Model/BotCommand";
import {useAppDispatch} from "../../Hook/useAppDispatch";
import {useAppSelector} from "../../Hook/useAppSelector";

interface IBotCommandsProps {
    botId: string,
    load: boolean,
    style?: CSSProperties,
}

const BotCommands: React.FC<IBotCommandsProps> = (props: IBotCommandsProps) => {
    const botCommandsReducer = useAppSelector((state: AppState) => state.botCommands);

    const dispatch = useAppDispatch();

    const [currentPageNumber, setCurrentPageNumber] = useState(1);
    const [currentPageSize, setCurrentPageSize] = useState(5);

    useLayoutEffect(() => {
        if (props.load) {
            dispatch(getBotCommandsList(props.botId, 1, currentPageSize));
        }

        setCurrentPageNumber(1);
        setCurrentPageSize(5);
    }, [dispatch, props.botId, props.load]);


    const isLoaded = botCommandsReducer.isLoaded && botCommandsReducer.botId === props.botId &&
        currentPageNumber === botCommandsReducer.page;

    const paginationHandle = (pageNumber: number, size: number) => {
        setCurrentPageNumber(pageNumber);
        setCurrentPageSize(5);

        dispatch(getBotCommandsList(props.botId, pageNumber, size));
    };

    const {t} = useTranslation();

    const columns = [
        {
            title: t("USER"),
            dataIndex: "user",
            key: "user",
            isVisible: true,
            render: (user: string, command: BotCommand) => <span>{command.id}</span>,
        },
        {
            title: t("COMMAND"),
            dataIndex: "command",
            key: "command",
            width: 250,
            render: (text: string, command: BotCommand) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <b>Command</b>
                    </div>
                    <div className="table-col-item">
                        <Space size={5} align="center" style={{fontSize: 12}}>
                            {command.is_processed ?
                                <i className="fa-solid fa-circle-check" style={{color: "#4aac16"}} /> :
                                <i className="fa-solid fa-clock-rotate-left" style={{color: "#777"}} />
                            }
                            <span className={command.is_processed ? "command-span command-processed" : "command-span"}>{command.command.command}</span>
                        </Space>
                    </div>
                </div>
            ),
            isVisible: true,
        },
        {
            title: t("PAYLOAD"),
            dataIndex: "payload",
            key: "payload",
            width: 300,
            render: (text: string, command: BotCommand) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <b>Payload</b>
                    </div>
                    <div className="table-col-item">
                        <div className="code">{JSON.stringify(command.command.payload, null, 2)}</div>
                    </div>
                </div>
            ),
            isVisible: process.env.NODE_ENV && process.env.NODE_ENV == "development",
        },
        {
            title: t("DATE"),
            dataIndex: "date",
            key: "date",
            width: 250,
            render: (text: string, command: BotCommand) => (
                <div className="table-col">
                    <div className="table-col-item">
                        <b>Date</b>
                    </div>
                    <div className="table-col-item" style={{fontSize: 12}}>
                        {command.created_at ? command.created_at : "-"}
                    </div>
                </div>
            ),
            isVisible: true,
        },
    ];

    return (
        <div style={props.style} className="botinfo-info">
            <Divider orientation="center" style={{marginBottom: 10, ...props.style}}>
                {t("COMMAND_HISTORY")}
            </Divider>

            <Table
                columns={columns.filter((column: any) => column.isVisible)}
                dataSource={botCommandsReducer.commands}
                loading={!isLoaded}
                size="small"
                rowKey={"id"}
                pagination={{
                    total: botCommandsReducer.total,
                    defaultPageSize: botCommandsReducer.per_page,
                    current: botCommandsReducer.page,
                    onChange: paginationHandle,
                    position: ["bottomCenter"],
                    size: "default",
                    locale: {
                        items_per_page: "",
                    },
                    pageSizeOptions: [5, 10, 15, 20, 100],
                }}
                locale={{
                    emptyText: (
                        <Space>
                            <i className="fa-solid fa-robot" /> {t("TABLE_EMPTY")}
                        </Space>
                    ),
                }}
            />
        </div>
    );
};

export default BotCommands;
