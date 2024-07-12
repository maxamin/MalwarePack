import React, {useEffect, useLayoutEffect} from "react";
import BotLogsTable, {logsType} from "./BotLogsTable";
import {AppState} from "../../Store/RootReducer";
import {changeLogsFilters, changeLogsSort, getLogsList} from "../../Store/Logs/Actions";
import {setCountAction} from "../../Store/Counts/Actions";
import {useAppDispatch} from "../../Hook/useAppDispatch";
import {useAppSelector} from "../../Hook/useAppSelector";

export interface BotLogsPageRenderProps {
    type: logsType,
    title: string,
}

const BotLogsPageRender: React.FC<BotLogsPageRenderProps> = (props: BotLogsPageRenderProps) => {
    const logsReducer = useAppSelector((state: AppState) => state.logs);

    const dispatch = useAppDispatch();

    const isLoaded = logsReducer.isLoaded && logsReducer.type === props.type &&
        logsReducer.isLoaded &&
        logsReducer.page === logsReducer.loaded_page &&
        logsReducer.loaded_per_page === logsReducer.per_page;

    useLayoutEffect(() => {
        if (logsReducer.type !== props.type) {
            if (logsReducer.filters.application !== "") {
                dispatch(changeLogsFilters({
                    application: "",
                }));
            }
            if (logsReducer.filters.query !== "") {
                dispatch(changeLogsFilters({
                    query: "",
                }));
            }
            if (logsReducer.sort.field !== "created_at" && logsReducer.sort.by !== "descend") {
                dispatch(changeLogsSort({
                    field: "created_at",
                    by: "descend",
                }));
            }
        }

        dispatch(getLogsList(props.type, null, null, logsReducer.filters, logsReducer.sort, logsReducer.page, logsReducer.per_page));
    }, [props.type, logsReducer.filters, logsReducer.sort, logsReducer.page, logsReducer.per_page]);

    useEffect(() => {
        dispatch(setCountAction({
            [props.type]: 0,
        }));
    }, [logsReducer.total, dispatch, props.type]);

    return (
        <BotLogsTable {...props}
            logs={logsReducer.logs}
            isLoaded={isLoaded}
            filters={true}
        />
    );
};

export default BotLogsPageRender;
