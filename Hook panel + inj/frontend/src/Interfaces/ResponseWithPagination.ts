interface PaginationLink {
    "url": string | null,
    "label": string,
    "active": boolean,
}

export interface ResponseWithPagination<T> {
    payload: T[],
    links: {
        "first": string | null,
        "last": string | null,
        "prev": string | null,
        "next": string | null
    },
    meta: {
        "current_page": number,
        "from": number,
        "last_page": number,
        "links": PaginationLink[],
        "path": string,
        "per_page": number,
        "to": number,
        "total": number,
    },
    success: boolean,
}
