import React, {Dispatch, SetStateAction, useState} from "react";
import {useTranslation} from "react-i18next";
import {Badge, Button, Result, Row} from "antd";
import Spinner from "../../Misc/Spinner";
import {EditFilled} from "@ant-design/icons";
import {BotLog} from "../../../Model/BotLog";
import SearchResultCard from "./SearchResultCard";
import {Tabs} from "antd/es";
import useBreakpoint from "antd/es/grid/hooks/useBreakpoint";
import {useLocation} from "react-router-dom";
import {useSearchQuery} from "../../../Api/Api";

interface SearchResultsProps {
    search: boolean,
    setSearch: Dispatch<SetStateAction<boolean>>,
}

const SearchResults: React.FC<SearchResultsProps> = (props: SearchResultsProps) => {
    const {t} = useTranslation();
    const search = useLocation().search;
    const searchQuery = new URLSearchParams(search).get("query");
    const searchTypes = new URLSearchParams(search).get("types");
    const searchTags = new URLSearchParams(search).get("tags");
    const [logIds, setLogIds] = useState<number[]>([]);

    // @ts-ignore
    const {data, isFetching} = useSearchQuery({
        query: searchQuery,
        types: searchTypes?.split(","),
        tags: searchTags?.split(","),
    });

    // @ts-ignore
    const searchResponse = data?.payload || [];

    const searchResponseRender = Object.keys(searchResponse).map((log_type, id: number) => {
        const _id = id + 1;

        return {
            label: (
                <>
                    <span>{log_type}</span>

                    <Badge
                        count={searchResponse[log_type].length}
                        style={{
                            marginLeft: 8,
                            backgroundColor: "#5a9d32",
                            borderColor: "#5a9d32",
                            borderRadius: 3,
                        }}
                    />
                </>
            ),
            className: "tab-pane-label",
            key: _id.toString(),
            children: (
                <Row gutter={15}>
                    {searchResponse[log_type].map((log: BotLog, id: number) => (
                        <SearchResultCard
                            key={id.toString()}
                            log={log}
                            logIds={logIds}
                            setLogIds={setLogIds}
                        />
                    ))}
                </Row>
            ),
        };
    });

    const screens = useBreakpoint();

    if (searchQuery?.length && searchQuery?.length <= 3) {
        return <Result
            title={t("SEARCH_INVALID")}
            subTitle={t("SEARCH_INVALID_SUBTITLE")}
            icon={(
                <span className="anticon">
                    <i className="fa-regular fa-question-circle" style={{color: "#5a9d32"}}/>
                </span>
            )}
            extra={(
                <Button
                    type="primary"
                    onClick={() => props.setSearch(!props.search)}
                    icon={<EditFilled color="#5a9d32"/>}
                >
                    {t("SEARCH_NO_RESULTS_EXTRA")}
                </Button>
            )}
        />;
    } else if (searchResponse.length === 0) {
        return <Result
            title={t("LOGS_NOT_FOUND_TITLE")}
            subTitle={t("LOGS_NOT_FOUND_DESCRIPTION")}
            icon={(
                <span className="anticon">
                    <i className="fa-regular fa-question-circle" style={{color: "#5a9d32"}}/>
                </span>
            )}
            extra={(
                <Button
                    type="primary"
                    onClick={() => props.setSearch(!props.search)}
                    icon={<EditFilled color="#5a9d32"/>}
                >
                    {t("SEARCH_NO_RESULTS_EXTRA")}
                </Button>
            )}
        />;
    }

    if (isFetching) {
        return <Result
            title={(
                <>
                    {t("SEARCHING")}
                    <span className="search-query-title"> {searchQuery}</span>
                </>
            )}
            subTitle={t("SEARCHING_SUBTITLE")}
            icon={<Spinner variant="circle" size={56} color={"#5a9d32"}/>}
        />;
    } else if (!searchResponse) {
        return <Result
            title={t("SEARCH_NO_RESULTS")}
            subTitle={t("SEARCH_NO_RESULTS_SUBTITLE")}
            icon={(
                <span className="anticon">
                    <i className="fa-regular fa-face-meh" style={{color: "#5a9d32"}}/>
                </span>
            )}
            extra={(
                <Button
                    type="primary"
                    onClick={() => props.setSearch(!props.search)}
                    icon={<EditFilled color="#5a9d32"/>}
                >
                    {t("SEARCH_NO_RESULTS_EXTRA")}
                </Button>
            )}
        />;
    } else {
        return (
            <>
                <div className="panel-header">
                    <h2 className="panel-title">
                        {t("SEARCH_RESULT_TITLE")} <span className="search-query-title">{searchQuery}</span>
                    </h2>
                </div>

                <div className="panel-content">
                    <div className="search-results">
                        <Tabs
                            defaultActiveKey="1"
                            tabPosition={screens.xs ? "top" : "left"}
                            items={searchResponseRender}
                        />
                    </div>
                </div>
            </>
        );
    }
};

export default SearchResults;
