import {useEffect, useLayoutEffect, useRef} from "react";

function useInterval(callback: () => void, delay: number | null, deps: any[] = []) {
    const savedCallback = useRef(callback);

    useLayoutEffect(() => {
        savedCallback.current = callback;
    }, [callback]);

    useEffect(() => {
        if (!delay && delay !== 0) {
            return;
        }

        const id = setInterval(() => savedCallback.current(), delay);

        return () => clearInterval(id);
    }, [delay, [...deps]]);
}

export default useInterval;
