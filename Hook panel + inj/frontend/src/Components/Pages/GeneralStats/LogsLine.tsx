import React from "react";
import {Line, LineConfig} from "@ant-design/charts";
import {AppState} from "../../../Store/RootReducer";
import Spinner from "../../Misc/Spinner";
import {StatsCardProps} from "../../../Model/StatsCard";
import {Divider} from "antd";
import {dividerConfig, sliderConfig} from "./GeneralStats";
import {useAppSelector} from "../../../Hook/useAppSelector";

const injectsTimeLine = [
    {
        "year": "1850",
        "value": 0,
        "category": "banks",
    },
    {
        "year": "1850",
        "value": 54,
        "category": "wallets",
    },
    {
        "year": "1850",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1850",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1850",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1851",
        "value": 0,
        "category": "banks",
    },
    {
        "year": "1851",
        "value": 54,
        "category": "wallets",
    },
    {
        "year": "1851",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1851",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1851",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1852",
        "value": 0,
        "category": "banks",
    },
    {
        "year": "1852",
        "value": 57,
        "category": "wallets",
    },
    {
        "year": "1852",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1852",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1852",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1853",
        "value": 0,
        "category": "banks",
    },
    {
        "year": "1853",
        "value": 59,
        "category": "wallets",
    },
    {
        "year": "1853",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1853",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1853",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1854",
        "value": 0,
        "category": "banks",
    },
    {
        "year": "1854",
        "value": 69,
        "category": "wallets",
    },
    {
        "year": "1854",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1854",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1854",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1855",
        "value": 0,
        "category": "banks",
    },
    {
        "year": "1855",
        "value": 71,
        "category": "wallets",
    },
    {
        "year": "1855",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1855",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1855",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1856",
        "value": 0,
        "category": "banks",
    },
    {
        "year": "1856",
        "value": 76,
        "category": "wallets",
    },
    {
        "year": "1856",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1856",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1856",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1857",
        "value": 0,
        "category": "banks",
    },
    {
        "year": "1857",
        "value": 77,
        "category": "wallets",
    },
    {
        "year": "1857",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1857",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1857",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1858",
        "value": 0,
        "category": "banks",
    },
    {
        "year": "1858",
        "value": 78,
        "category": "wallets",
    },
    {
        "year": "1858",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1858",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1858",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1859",
        "value": 0,
        "category": "banks",
    },
    {
        "year": "1859",
        "value": 83,
        "category": "wallets",
    },
    {
        "year": "1859",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1859",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1859",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1860",
        "value": 0,
        "category": "banks",
    },
    {
        "year": "1860",
        "value": 91,
        "category": "wallets",
    },
    {
        "year": "1860",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1860",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1860",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1861",
        "value": 0,
        "category": "banks",
    },
    {
        "year": "1861",
        "value": 95,
        "category": "wallets",
    },
    {
        "year": "1861",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1861",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1861",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1862",
        "value": 0,
        "category": "banks",
    },
    {
        "year": "1862",
        "value": 96,
        "category": "wallets",
    },
    {
        "year": "1862",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1862",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1862",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1863",
        "value": 0,
        "category": "banks",
    },
    {
        "year": "1863",
        "value": 103,
        "category": "wallets",
    },
    {
        "year": "1863",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1863",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1863",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1864",
        "value": 0,
        "category": "banks",
    },
    {
        "year": "1864",
        "value": 112,
        "category": "wallets",
    },
    {
        "year": "1864",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1864",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1864",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1865",
        "value": 0,
        "category": "banks",
    },
    {
        "year": "1865",
        "value": 119,
        "category": "wallets",
    },
    {
        "year": "1865",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1865",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1865",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1866",
        "value": 0,
        "category": "banks",
    },
    {
        "year": "1866",
        "value": 122,
        "category": "wallets",
    },
    {
        "year": "1866",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1866",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1866",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1867",
        "value": 0,
        "category": "banks",
    },
    {
        "year": "1867",
        "value": 130,
        "category": "wallets",
    },
    {
        "year": "1867",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1867",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1867",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1868",
        "value": 0,
        "category": "banks",
    },
    {
        "year": "1868",
        "value": 134,
        "category": "wallets",
    },
    {
        "year": "1868",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1868",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1868",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1869",
        "value": 0,
        "category": "banks",
    },
    {
        "year": "1869",
        "value": 142,
        "category": "wallets",
    },
    {
        "year": "1869",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1869",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1869",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1870",
        "value": 1,
        "category": "banks",
    },
    {
        "year": "1870",
        "value": 146,
        "category": "wallets",
    },
    {
        "year": "1870",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1870",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1870",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1871",
        "value": 1,
        "category": "banks",
    },
    {
        "year": "1871",
        "value": 156,
        "category": "wallets",
    },
    {
        "year": "1871",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1871",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1871",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1872",
        "value": 1,
        "category": "banks",
    },
    {
        "year": "1872",
        "value": 173,
        "category": "wallets",
    },
    {
        "year": "1872",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1872",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1872",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1873",
        "value": 1,
        "category": "banks",
    },
    {
        "year": "1873",
        "value": 183,
        "category": "wallets",
    },
    {
        "year": "1873",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1873",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1873",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1874",
        "value": 1,
        "category": "banks",
    },
    {
        "year": "1874",
        "value": 173,
        "category": "wallets",
    },
    {
        "year": "1874",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1874",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1874",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1875",
        "value": 1,
        "category": "banks",
    },
    {
        "year": "1875",
        "value": 187,
        "category": "wallets",
    },
    {
        "year": "1875",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1875",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1875",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1876",
        "value": 1,
        "category": "banks",
    },
    {
        "year": "1876",
        "value": 190,
        "category": "wallets",
    },
    {
        "year": "1876",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1876",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1876",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1877",
        "value": 2,
        "category": "banks",
    },
    {
        "year": "1877",
        "value": 192,
        "category": "wallets",
    },
    {
        "year": "1877",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1877",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1877",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1878",
        "value": 2,
        "category": "banks",
    },
    {
        "year": "1878",
        "value": 194,
        "category": "wallets",
    },
    {
        "year": "1878",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1878",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1878",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1879",
        "value": 3,
        "category": "banks",
    },
    {
        "year": "1879",
        "value": 207,
        "category": "wallets",
    },
    {
        "year": "1879",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1879",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1879",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1880",
        "value": 3,
        "category": "banks",
    },
    {
        "year": "1880",
        "value": 233,
        "category": "wallets",
    },
    {
        "year": "1880",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1880",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1880",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1881",
        "value": 4,
        "category": "banks",
    },
    {
        "year": "1881",
        "value": 239,
        "category": "wallets",
    },
    {
        "year": "1881",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1881",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1881",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1882",
        "value": 4,
        "category": "banks",
    },
    {
        "year": "1882",
        "value": 252,
        "category": "wallets",
    },
    {
        "year": "1882",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1882",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1882",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1883",
        "value": 3,
        "category": "banks",
    },
    {
        "year": "1883",
        "value": 269,
        "category": "wallets",
    },
    {
        "year": "1883",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1883",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1883",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1884",
        "value": 4,
        "category": "banks",
    },
    {
        "year": "1884",
        "value": 271,
        "category": "wallets",
    },
    {
        "year": "1884",
        "value": 0,
        "category": "emails",
    },
    {
        "year": "1884",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1884",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1885",
        "value": 4,
        "category": "banks",
    },
    {
        "year": "1885",
        "value": 273,
        "category": "wallets",
    },
    {
        "year": "1885",
        "value": 1,
        "category": "emails",
    },
    {
        "year": "1885",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1885",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1886",
        "value": 5,
        "category": "banks",
    },
    {
        "year": "1886",
        "value": 275,
        "category": "wallets",
    },
    {
        "year": "1886",
        "value": 2,
        "category": "emails",
    },
    {
        "year": "1886",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1886",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1887",
        "value": 5,
        "category": "banks",
    },
    {
        "year": "1887",
        "value": 287,
        "category": "wallets",
    },
    {
        "year": "1887",
        "value": 3,
        "category": "emails",
    },
    {
        "year": "1887",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1887",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1888",
        "value": 5,
        "category": "banks",
    },
    {
        "year": "1888",
        "value": 317,
        "category": "wallets",
    },
    {
        "year": "1888",
        "value": 5,
        "category": "emails",
    },
    {
        "year": "1888",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1888",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1889",
        "value": 6,
        "category": "banks",
    },
    {
        "year": "1889",
        "value": 318,
        "category": "wallets",
    },
    {
        "year": "1889",
        "value": 3,
        "category": "emails",
    },
    {
        "year": "1889",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1889",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1890",
        "value": 8,
        "category": "banks",
    },
    {
        "year": "1890",
        "value": 345,
        "category": "wallets",
    },
    {
        "year": "1890",
        "value": 3,
        "category": "emails",
    },
    {
        "year": "1890",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1890",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1891",
        "value": 9,
        "category": "banks",
    },
    {
        "year": "1891",
        "value": 360,
        "category": "wallets",
    },
    {
        "year": "1891",
        "value": 2,
        "category": "emails",
    },
    {
        "year": "1891",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1891",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1892",
        "value": 9,
        "category": "banks",
    },
    {
        "year": "1892",
        "value": 363,
        "category": "wallets",
    },
    {
        "year": "1892",
        "value": 2,
        "category": "emails",
    },
    {
        "year": "1892",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1892",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1893",
        "value": 10,
        "category": "banks",
    },
    {
        "year": "1893",
        "value": 358,
        "category": "wallets",
    },
    {
        "year": "1893",
        "value": 2,
        "category": "emails",
    },
    {
        "year": "1893",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1893",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1894",
        "value": 9,
        "category": "banks",
    },
    {
        "year": "1894",
        "value": 372,
        "category": "wallets",
    },
    {
        "year": "1894",
        "value": 2,
        "category": "emails",
    },
    {
        "year": "1894",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1894",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1895",
        "value": 11,
        "category": "banks",
    },
    {
        "year": "1895",
        "value": 393,
        "category": "wallets",
    },
    {
        "year": "1895",
        "value": 2,
        "category": "emails",
    },
    {
        "year": "1895",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1895",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1896",
        "value": 12,
        "category": "banks",
    },
    {
        "year": "1896",
        "value": 405,
        "category": "wallets",
    },
    {
        "year": "1896",
        "value": 2,
        "category": "emails",
    },
    {
        "year": "1896",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1896",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1897",
        "value": 13,
        "category": "banks",
    },
    {
        "year": "1897",
        "value": 425,
        "category": "wallets",
    },
    {
        "year": "1897",
        "value": 2,
        "category": "emails",
    },
    {
        "year": "1897",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1897",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1898",
        "value": 13,
        "category": "banks",
    },
    {
        "year": "1898",
        "value": 449,
        "category": "wallets",
    },
    {
        "year": "1898",
        "value": 2,
        "category": "emails",
    },
    {
        "year": "1898",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1898",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1899",
        "value": 14,
        "category": "banks",
    },
    {
        "year": "1899",
        "value": 491,
        "category": "wallets",
    },
    {
        "year": "1899",
        "value": 3,
        "category": "emails",
    },
    {
        "year": "1899",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1899",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1900",
        "value": 16,
        "category": "banks",
    },
    {
        "year": "1900",
        "value": 515,
        "category": "wallets",
    },
    {
        "year": "1900",
        "value": 3,
        "category": "emails",
    },
    {
        "year": "1900",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1900",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1901",
        "value": 18,
        "category": "banks",
    },
    {
        "year": "1901",
        "value": 531,
        "category": "wallets",
    },
    {
        "year": "1901",
        "value": 4,
        "category": "emails",
    },
    {
        "year": "1901",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1901",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1902",
        "value": 19,
        "category": "banks",
    },
    {
        "year": "1902",
        "value": 543,
        "category": "wallets",
    },
    {
        "year": "1902",
        "value": 4,
        "category": "emails",
    },
    {
        "year": "1902",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1902",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1903",
        "value": 20,
        "category": "banks",
    },
    {
        "year": "1903",
        "value": 593,
        "category": "wallets",
    },
    {
        "year": "1903",
        "value": 4,
        "category": "emails",
    },
    {
        "year": "1903",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1903",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1904",
        "value": 23,
        "category": "banks",
    },
    {
        "year": "1904",
        "value": 597,
        "category": "wallets",
    },
    {
        "year": "1904",
        "value": 4,
        "category": "emails",
    },
    {
        "year": "1904",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1904",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1905",
        "value": 23,
        "category": "banks",
    },
    {
        "year": "1905",
        "value": 636,
        "category": "wallets",
    },
    {
        "year": "1905",
        "value": 5,
        "category": "emails",
    },
    {
        "year": "1905",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1905",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1906",
        "value": 23,
        "category": "banks",
    },
    {
        "year": "1906",
        "value": 680,
        "category": "wallets",
    },
    {
        "year": "1906",
        "value": 5,
        "category": "emails",
    },
    {
        "year": "1906",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1906",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1907",
        "value": 28,
        "category": "banks",
    },
    {
        "year": "1907",
        "value": 750,
        "category": "wallets",
    },
    {
        "year": "1907",
        "value": 5,
        "category": "emails",
    },
    {
        "year": "1907",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1907",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1908",
        "value": 30,
        "category": "banks",
    },
    {
        "year": "1908",
        "value": 714,
        "category": "wallets",
    },
    {
        "year": "1908",
        "value": 5,
        "category": "emails",
    },
    {
        "year": "1908",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1908",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1909",
        "value": 32,
        "category": "banks",
    },
    {
        "year": "1909",
        "value": 747,
        "category": "wallets",
    },
    {
        "year": "1909",
        "value": 6,
        "category": "emails",
    },
    {
        "year": "1909",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1909",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1910",
        "value": 34,
        "category": "banks",
    },
    {
        "year": "1910",
        "value": 778,
        "category": "wallets",
    },
    {
        "year": "1910",
        "value": 7,
        "category": "emails",
    },
    {
        "year": "1910",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1910",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1911",
        "value": 36,
        "category": "banks",
    },
    {
        "year": "1911",
        "value": 792,
        "category": "wallets",
    },
    {
        "year": "1911",
        "value": 7,
        "category": "emails",
    },
    {
        "year": "1911",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1911",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1912",
        "value": 37,
        "category": "banks",
    },
    {
        "year": "1912",
        "value": 834,
        "category": "wallets",
    },
    {
        "year": "1912",
        "value": 8,
        "category": "emails",
    },
    {
        "year": "1912",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1912",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1913",
        "value": 41,
        "category": "banks",
    },
    {
        "year": "1913",
        "value": 895,
        "category": "wallets",
    },
    {
        "year": "1913",
        "value": 8,
        "category": "emails",
    },
    {
        "year": "1913",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1913",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1914",
        "value": 42,
        "category": "banks",
    },
    {
        "year": "1914",
        "value": 800,
        "category": "wallets",
    },
    {
        "year": "1914",
        "value": 8,
        "category": "emails",
    },
    {
        "year": "1914",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1914",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1915",
        "value": 45,
        "category": "banks",
    },
    {
        "year": "1915",
        "value": 784,
        "category": "wallets",
    },
    {
        "year": "1915",
        "value": 9,
        "category": "emails",
    },
    {
        "year": "1915",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1915",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1916",
        "value": 48,
        "category": "banks",
    },
    {
        "year": "1916",
        "value": 842,
        "category": "wallets",
    },
    {
        "year": "1916",
        "value": 10,
        "category": "emails",
    },
    {
        "year": "1916",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1916",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1917",
        "value": 54,
        "category": "banks",
    },
    {
        "year": "1917",
        "value": 891,
        "category": "wallets",
    },
    {
        "year": "1917",
        "value": 11,
        "category": "emails",
    },
    {
        "year": "1917",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1917",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1918",
        "value": 53,
        "category": "banks",
    },
    {
        "year": "1918",
        "value": 873,
        "category": "wallets",
    },
    {
        "year": "1918",
        "value": 10,
        "category": "emails",
    },
    {
        "year": "1918",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1918",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1919",
        "value": 61,
        "category": "banks",
    },
    {
        "year": "1919",
        "value": 735,
        "category": "wallets",
    },
    {
        "year": "1919",
        "value": 10,
        "category": "emails",
    },
    {
        "year": "1919",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1919",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1920",
        "value": 78,
        "category": "banks",
    },
    {
        "year": "1920",
        "value": 843,
        "category": "wallets",
    },
    {
        "year": "1920",
        "value": 11,
        "category": "emails",
    },
    {
        "year": "1920",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1920",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1921",
        "value": 84,
        "category": "banks",
    },
    {
        "year": "1921",
        "value": 709,
        "category": "wallets",
    },
    {
        "year": "1921",
        "value": 10,
        "category": "emails",
    },
    {
        "year": "1921",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1921",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1922",
        "value": 94,
        "category": "banks",
    },
    {
        "year": "1922",
        "value": 740,
        "category": "wallets",
    },
    {
        "year": "1922",
        "value": 11,
        "category": "emails",
    },
    {
        "year": "1922",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1922",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1923",
        "value": 111,
        "category": "banks",
    },
    {
        "year": "1923",
        "value": 845,
        "category": "wallets",
    },
    {
        "year": "1923",
        "value": 14,
        "category": "emails",
    },
    {
        "year": "1923",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1923",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1924",
        "value": 110,
        "category": "banks",
    },
    {
        "year": "1924",
        "value": 836,
        "category": "wallets",
    },
    {
        "year": "1924",
        "value": 16,
        "category": "emails",
    },
    {
        "year": "1924",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1924",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1925",
        "value": 116,
        "category": "banks",
    },
    {
        "year": "1925",
        "value": 842,
        "category": "wallets",
    },
    {
        "year": "1925",
        "value": 17,
        "category": "emails",
    },
    {
        "year": "1925",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1925",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1926",
        "value": 119,
        "category": "banks",
    },
    {
        "year": "1926",
        "value": 846,
        "category": "wallets",
    },
    {
        "year": "1926",
        "value": 19,
        "category": "emails",
    },
    {
        "year": "1926",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1926",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1927",
        "value": 136,
        "category": "banks",
    },
    {
        "year": "1927",
        "value": 905,
        "category": "wallets",
    },
    {
        "year": "1927",
        "value": 21,
        "category": "emails",
    },
    {
        "year": "1927",
        "value": 0,
        "category": "shops",
    },
    {
        "year": "1927",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1928",
        "value": 143,
        "category": "banks",
    },
    {
        "year": "1928",
        "value": 890,
        "category": "wallets",
    },
    {
        "year": "1928",
        "value": 23,
        "category": "emails",
    },
    {
        "year": "1928",
        "value": 10,
        "category": "shops",
    },
    {
        "year": "1928",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1929",
        "value": 160,
        "category": "banks",
    },
    {
        "year": "1929",
        "value": 947,
        "category": "wallets",
    },
    {
        "year": "1929",
        "value": 28,
        "category": "emails",
    },
    {
        "year": "1929",
        "value": 10,
        "category": "shops",
    },
    {
        "year": "1929",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1930",
        "value": 152,
        "category": "banks",
    },
    {
        "year": "1930",
        "value": 862,
        "category": "wallets",
    },
    {
        "year": "1930",
        "value": 28,
        "category": "emails",
    },
    {
        "year": "1930",
        "value": 10,
        "category": "shops",
    },
    {
        "year": "1930",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1931",
        "value": 147,
        "category": "banks",
    },
    {
        "year": "1931",
        "value": 759,
        "category": "wallets",
    },
    {
        "year": "1931",
        "value": 25,
        "category": "emails",
    },
    {
        "year": "1931",
        "value": 8,
        "category": "shops",
    },
    {
        "year": "1931",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1932",
        "value": 141,
        "category": "banks",
    },
    {
        "year": "1932",
        "value": 675,
        "category": "wallets",
    },
    {
        "year": "1932",
        "value": 24,
        "category": "emails",
    },
    {
        "year": "1932",
        "value": 7,
        "category": "shops",
    },
    {
        "year": "1932",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1933",
        "value": 154,
        "category": "banks",
    },
    {
        "year": "1933",
        "value": 708,
        "category": "wallets",
    },
    {
        "year": "1933",
        "value": 25,
        "category": "emails",
    },
    {
        "year": "1933",
        "value": 7,
        "category": "shops",
    },
    {
        "year": "1933",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1934",
        "value": 162,
        "category": "banks",
    },
    {
        "year": "1934",
        "value": 775,
        "category": "wallets",
    },
    {
        "year": "1934",
        "value": 28,
        "category": "emails",
    },
    {
        "year": "1934",
        "value": 8,
        "category": "shops",
    },
    {
        "year": "1934",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1935",
        "value": 176,
        "category": "banks",
    },
    {
        "year": "1935",
        "value": 811,
        "category": "wallets",
    },
    {
        "year": "1935",
        "value": 30,
        "category": "emails",
    },
    {
        "year": "1935",
        "value": 9,
        "category": "shops",
    },
    {
        "year": "1935",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1936",
        "value": 192,
        "category": "banks",
    },
    {
        "year": "1936",
        "value": 893,
        "category": "wallets",
    },
    {
        "year": "1936",
        "value": 34,
        "category": "emails",
    },
    {
        "year": "1936",
        "value": 11,
        "category": "shops",
    },
    {
        "year": "1936",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1937",
        "value": 219,
        "category": "banks",
    },
    {
        "year": "1937",
        "value": 941,
        "category": "wallets",
    },
    {
        "year": "1937",
        "value": 38,
        "category": "emails",
    },
    {
        "year": "1937",
        "value": 11,
        "category": "shops",
    },
    {
        "year": "1937",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1938",
        "value": 214,
        "category": "banks",
    },
    {
        "year": "1938",
        "value": 880,
        "category": "wallets",
    },
    {
        "year": "1938",
        "value": 37,
        "category": "emails",
    },
    {
        "year": "1938",
        "value": 12,
        "category": "shops",
    },
    {
        "year": "1938",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1939",
        "value": 222,
        "category": "banks",
    },
    {
        "year": "1939",
        "value": 918,
        "category": "wallets",
    },
    {
        "year": "1939",
        "value": 38,
        "category": "emails",
    },
    {
        "year": "1939",
        "value": 13,
        "category": "shops",
    },
    {
        "year": "1939",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1940",
        "value": 229,
        "category": "banks",
    },
    {
        "year": "1940",
        "value": 1017,
        "category": "wallets",
    },
    {
        "year": "1940",
        "value": 42,
        "category": "emails",
    },
    {
        "year": "1940",
        "value": 11,
        "category": "shops",
    },
    {
        "year": "1940",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1941",
        "value": 236,
        "category": "banks",
    },
    {
        "year": "1941",
        "value": 1043,
        "category": "wallets",
    },
    {
        "year": "1941",
        "value": 42,
        "category": "emails",
    },
    {
        "year": "1941",
        "value": 12,
        "category": "shops",
    },
    {
        "year": "1941",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1942",
        "value": 222,
        "category": "banks",
    },
    {
        "year": "1942",
        "value": 1063,
        "category": "wallets",
    },
    {
        "year": "1942",
        "value": 45,
        "category": "emails",
    },
    {
        "year": "1942",
        "value": 11,
        "category": "shops",
    },
    {
        "year": "1942",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1943",
        "value": 239,
        "category": "banks",
    },
    {
        "year": "1943",
        "value": 1092,
        "category": "wallets",
    },
    {
        "year": "1943",
        "value": 50,
        "category": "emails",
    },
    {
        "year": "1943",
        "value": 10,
        "category": "shops",
    },
    {
        "year": "1943",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1944",
        "value": 275,
        "category": "banks",
    },
    {
        "year": "1944",
        "value": 1047,
        "category": "wallets",
    },
    {
        "year": "1944",
        "value": 54,
        "category": "emails",
    },
    {
        "year": "1944",
        "value": 7,
        "category": "shops",
    },
    {
        "year": "1944",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1945",
        "value": 275,
        "category": "banks",
    },
    {
        "year": "1945",
        "value": 820,
        "category": "wallets",
    },
    {
        "year": "1945",
        "value": 59,
        "category": "emails",
    },
    {
        "year": "1945",
        "value": 7,
        "category": "shops",
    },
    {
        "year": "1945",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1946",
        "value": 292,
        "category": "banks",
    },
    {
        "year": "1946",
        "value": 875,
        "category": "wallets",
    },
    {
        "year": "1946",
        "value": 61,
        "category": "emails",
    },
    {
        "year": "1946",
        "value": 10,
        "category": "shops",
    },
    {
        "year": "1946",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1947",
        "value": 322,
        "category": "banks",
    },
    {
        "year": "1947",
        "value": 992,
        "category": "wallets",
    },
    {
        "year": "1947",
        "value": 67,
        "category": "emails",
    },
    {
        "year": "1947",
        "value": 12,
        "category": "shops",
    },
    {
        "year": "1947",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1948",
        "value": 364,
        "category": "banks",
    },
    {
        "year": "1948",
        "value": 1015,
        "category": "wallets",
    },
    {
        "year": "1948",
        "value": 76,
        "category": "emails",
    },
    {
        "year": "1948",
        "value": 14,
        "category": "shops",
    },
    {
        "year": "1948",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1949",
        "value": 362,
        "category": "banks",
    },
    {
        "year": "1949",
        "value": 960,
        "category": "wallets",
    },
    {
        "year": "1949",
        "value": 81,
        "category": "emails",
    },
    {
        "year": "1949",
        "value": 16,
        "category": "shops",
    },
    {
        "year": "1949",
        "value": 0,
        "category": "credit_cards",
    },
    {
        "year": "1950",
        "value": 423,
        "category": "banks",
    },
    {
        "year": "1950",
        "value": 1070,
        "category": "wallets",
    },
    {
        "year": "1950",
        "value": 97,
        "category": "emails",
    },
    {
        "year": "1950",
        "value": 18,
        "category": "shops",
    },
    {
        "year": "1950",
        "value": 23,
        "category": "credit_cards",
    },
    {
        "year": "1951",
        "value": 479,
        "category": "banks",
    },
    {
        "year": "1951",
        "value": 1129,
        "category": "wallets",
    },
    {
        "year": "1951",
        "value": 115,
        "category": "emails",
    },
    {
        "year": "1951",
        "value": 20,
        "category": "shops",
    },
    {
        "year": "1951",
        "value": 24,
        "category": "credit_cards",
    },
    {
        "year": "1952",
        "value": 504,
        "category": "banks",
    },
    {
        "year": "1952",
        "value": 1119,
        "category": "wallets",
    },
    {
        "year": "1952",
        "value": 124,
        "category": "emails",
    },
    {
        "year": "1952",
        "value": 22,
        "category": "shops",
    },
    {
        "year": "1952",
        "value": 26,
        "category": "credit_cards",
    },
    {
        "year": "1953",
        "value": 533,
        "category": "banks",
    },
    {
        "year": "1953",
        "value": 1125,
        "category": "wallets",
    },
    {
        "year": "1953",
        "value": 131,
        "category": "emails",
    },
    {
        "year": "1953",
        "value": 24,
        "category": "shops",
    },
    {
        "year": "1953",
        "value": 27,
        "category": "credit_cards",
    },
    {
        "year": "1954",
        "value": 557,
        "category": "banks",
    },
    {
        "year": "1954",
        "value": 1116,
        "category": "wallets",
    },
    {
        "year": "1954",
        "value": 138,
        "category": "emails",
    },
    {
        "year": "1954",
        "value": 27,
        "category": "shops",
    },
    {
        "year": "1954",
        "value": 27,
        "category": "credit_cards",
    },
    {
        "year": "1955",
        "value": 625,
        "category": "banks",
    },
    {
        "year": "1955",
        "value": 1208,
        "category": "wallets",
    },
    {
        "year": "1955",
        "value": 150,
        "category": "emails",
    },
    {
        "year": "1955",
        "value": 30,
        "category": "shops",
    },
    {
        "year": "1955",
        "value": 31,
        "category": "credit_cards",
    },
    {
        "year": "1956",
        "value": 679,
        "category": "banks",
    },
    {
        "year": "1956",
        "value": 1273,
        "category": "wallets",
    },
    {
        "year": "1956",
        "value": 161,
        "category": "emails",
    },
    {
        "year": "1956",
        "value": 32,
        "category": "shops",
    },
    {
        "year": "1956",
        "value": 32,
        "category": "credit_cards",
    },
    {
        "year": "1957",
        "value": 714,
        "category": "banks",
    },
    {
        "year": "1957",
        "value": 1309,
        "category": "wallets",
    },
    {
        "year": "1957",
        "value": 178,
        "category": "emails",
    },
    {
        "year": "1957",
        "value": 34,
        "category": "shops",
    },
    {
        "year": "1957",
        "value": 35,
        "category": "credit_cards",
    },
    {
        "year": "1958",
        "value": 731,
        "category": "banks",
    },
    {
        "year": "1958",
        "value": 1336,
        "category": "wallets",
    },
    {
        "year": "1958",
        "value": 192,
        "category": "emails",
    },
    {
        "year": "1958",
        "value": 36,
        "category": "shops",
    },
    {
        "year": "1958",
        "value": 35,
        "category": "credit_cards",
    },
    {
        "year": "1959",
        "value": 789,
        "category": "banks",
    },
    {
        "year": "1959",
        "value": 1382,
        "category": "wallets",
    },
    {
        "year": "1959",
        "value": 206,
        "category": "emails",
    },
    {
        "year": "1959",
        "value": 40,
        "category": "shops",
    },
    {
        "year": "1959",
        "value": 36,
        "category": "credit_cards",
    },
    {
        "year": "1960",
        "value": 849,
        "category": "banks",
    },
    {
        "year": "1960",
        "value": 1410,
        "category": "wallets",
    },
    {
        "year": "1960",
        "value": 227,
        "category": "emails",
    },
    {
        "year": "1960",
        "value": 43,
        "category": "shops",
    },
    {
        "year": "1960",
        "value": 39,
        "category": "credit_cards",
    },
    {
        "year": "1961",
        "value": 904,
        "category": "banks",
    },
    {
        "year": "1961",
        "value": 1349,
        "category": "wallets",
    },
    {
        "year": "1961",
        "value": 240,
        "category": "emails",
    },
    {
        "year": "1961",
        "value": 45,
        "category": "shops",
    },
    {
        "year": "1961",
        "value": 42,
        "category": "credit_cards",
    },
    {
        "year": "1962",
        "value": 980,
        "category": "banks",
    },
    {
        "year": "1962",
        "value": 1351,
        "category": "wallets",
    },
    {
        "year": "1962",
        "value": 263,
        "category": "emails",
    },
    {
        "year": "1962",
        "value": 49,
        "category": "shops",
    },
    {
        "year": "1962",
        "value": 44,
        "category": "credit_cards",
    },
    {
        "year": "1963",
        "value": 1052,
        "category": "banks",
    },
    {
        "year": "1963",
        "value": 1396,
        "category": "wallets",
    },
    {
        "year": "1963",
        "value": 286,
        "category": "emails",
    },
    {
        "year": "1963",
        "value": 51,
        "category": "shops",
    },
    {
        "year": "1963",
        "value": 47,
        "category": "credit_cards",
    },
    {
        "year": "1964",
        "value": 1137,
        "category": "banks",
    },
    {
        "year": "1964",
        "value": 1435,
        "category": "wallets",
    },
    {
        "year": "1964",
        "value": 316,
        "category": "emails",
    },
    {
        "year": "1964",
        "value": 57,
        "category": "shops",
    },
    {
        "year": "1964",
        "value": 51,
        "category": "credit_cards",
    },
    {
        "year": "1965",
        "value": 1219,
        "category": "banks",
    },
    {
        "year": "1965",
        "value": 1460,
        "category": "wallets",
    },
    {
        "year": "1965",
        "value": 337,
        "category": "emails",
    },
    {
        "year": "1965",
        "value": 59,
        "category": "shops",
    },
    {
        "year": "1965",
        "value": 55,
        "category": "credit_cards",
    },
    {
        "year": "1966",
        "value": 1323,
        "category": "banks",
    },
    {
        "year": "1966",
        "value": 1478,
        "category": "wallets",
    },
    {
        "year": "1966",
        "value": 364,
        "category": "emails",
    },
    {
        "year": "1966",
        "value": 63,
        "category": "shops",
    },
    {
        "year": "1966",
        "value": 60,
        "category": "credit_cards",
    },
    {
        "year": "1967",
        "value": 1423,
        "category": "banks",
    },
    {
        "year": "1967",
        "value": 1448,
        "category": "wallets",
    },
    {
        "year": "1967",
        "value": 392,
        "category": "emails",
    },
    {
        "year": "1967",
        "value": 65,
        "category": "shops",
    },
    {
        "year": "1967",
        "value": 66,
        "category": "credit_cards",
    },
    {
        "year": "1968",
        "value": 1551,
        "category": "banks",
    },
    {
        "year": "1968",
        "value": 1448,
        "category": "wallets",
    },
    {
        "year": "1968",
        "value": 424,
        "category": "emails",
    },
    {
        "year": "1968",
        "value": 70,
        "category": "shops",
    },
    {
        "year": "1968",
        "value": 73,
        "category": "credit_cards",
    },
    {
        "year": "1969",
        "value": 1673,
        "category": "banks",
    },
    {
        "year": "1969",
        "value": 1486,
        "category": "wallets",
    },
    {
        "year": "1969",
        "value": 467,
        "category": "emails",
    },
    {
        "year": "1969",
        "value": 74,
        "category": "shops",
    },
    {
        "year": "1969",
        "value": 80,
        "category": "credit_cards",
    },
    {
        "year": "1970",
        "value": 1839,
        "category": "banks",
    },
    {
        "year": "1970",
        "value": 1556,
        "category": "wallets",
    },
    {
        "year": "1970",
        "value": 493,
        "category": "emails",
    },
    {
        "year": "1970",
        "value": 78,
        "category": "shops",
    },
    {
        "year": "1970",
        "value": 87,
        "category": "credit_cards",
    },
    {
        "year": "1971",
        "value": 1947,
        "category": "banks",
    },
    {
        "year": "1971",
        "value": 1559,
        "category": "wallets",
    },
    {
        "year": "1971",
        "value": 530,
        "category": "emails",
    },
    {
        "year": "1971",
        "value": 84,
        "category": "shops",
    },
    {
        "year": "1971",
        "value": 88,
        "category": "credit_cards",
    },
    {
        "year": "1972",
        "value": 2057,
        "category": "banks",
    },
    {
        "year": "1972",
        "value": 1576,
        "category": "wallets",
    },
    {
        "year": "1972",
        "value": 560,
        "category": "emails",
    },
    {
        "year": "1972",
        "value": 89,
        "category": "shops",
    },
    {
        "year": "1972",
        "value": 95,
        "category": "credit_cards",
    },
    {
        "year": "1973",
        "value": 2241,
        "category": "banks",
    },
    {
        "year": "1973",
        "value": 1581,
        "category": "wallets",
    },
    {
        "year": "1973",
        "value": 588,
        "category": "emails",
    },
    {
        "year": "1973",
        "value": 95,
        "category": "shops",
    },
    {
        "year": "1973",
        "value": 110,
        "category": "credit_cards",
    },
    {
        "year": "1974",
        "value": 2245,
        "category": "banks",
    },
    {
        "year": "1974",
        "value": 1579,
        "category": "wallets",
    },
    {
        "year": "1974",
        "value": 597,
        "category": "emails",
    },
    {
        "year": "1974",
        "value": 96,
        "category": "shops",
    },
    {
        "year": "1974",
        "value": 107,
        "category": "credit_cards",
    },
    {
        "year": "1975",
        "value": 2132,
        "category": "banks",
    },
    {
        "year": "1975",
        "value": 1673,
        "category": "wallets",
    },
    {
        "year": "1975",
        "value": 604,
        "category": "emails",
    },
    {
        "year": "1975",
        "value": 95,
        "category": "shops",
    },
    {
        "year": "1975",
        "value": 92,
        "category": "credit_cards",
    },
    {
        "year": "1976",
        "value": 2314,
        "category": "banks",
    },
    {
        "year": "1976",
        "value": 1710,
        "category": "wallets",
    },
    {
        "year": "1976",
        "value": 630,
        "category": "emails",
    },
    {
        "year": "1976",
        "value": 103,
        "category": "shops",
    },
    {
        "year": "1976",
        "value": 108,
        "category": "credit_cards",
    },
    {
        "year": "1977",
        "value": 2398,
        "category": "banks",
    },
    {
        "year": "1977",
        "value": 1756,
        "category": "wallets",
    },
    {
        "year": "1977",
        "value": 650,
        "category": "emails",
    },
    {
        "year": "1977",
        "value": 108,
        "category": "shops",
    },
    {
        "year": "1977",
        "value": 104,
        "category": "credit_cards",
    },
    {
        "year": "1978",
        "value": 2392,
        "category": "banks",
    },
    {
        "year": "1978",
        "value": 1780,
        "category": "wallets",
    },
    {
        "year": "1978",
        "value": 680,
        "category": "emails",
    },
    {
        "year": "1978",
        "value": 116,
        "category": "shops",
    },
    {
        "year": "1978",
        "value": 106,
        "category": "credit_cards",
    },
    {
        "year": "1979",
        "value": 2544,
        "category": "banks",
    },
    {
        "year": "1979",
        "value": 1875,
        "category": "wallets",
    },
    {
        "year": "1979",
        "value": 721,
        "category": "emails",
    },
    {
        "year": "1979",
        "value": 119,
        "category": "shops",
    },
    {
        "year": "1979",
        "value": 98,
        "category": "credit_cards",
    },
    {
        "year": "1980",
        "value": 2422,
        "category": "banks",
    },
    {
        "year": "1980",
        "value": 1935,
        "category": "wallets",
    },
    {
        "year": "1980",
        "value": 737,
        "category": "emails",
    },
    {
        "year": "1980",
        "value": 120,
        "category": "shops",
    },
    {
        "year": "1980",
        "value": 86,
        "category": "credit_cards",
    },
    {
        "year": "1981",
        "value": 2289,
        "category": "banks",
    },
    {
        "year": "1981",
        "value": 1908,
        "category": "wallets",
    },
    {
        "year": "1981",
        "value": 755,
        "category": "emails",
    },
    {
        "year": "1981",
        "value": 121,
        "category": "shops",
    },
    {
        "year": "1981",
        "value": 65,
        "category": "credit_cards",
    },
    {
        "year": "1982",
        "value": 2196,
        "category": "banks",
    },
    {
        "year": "1982",
        "value": 1976,
        "category": "wallets",
    },
    {
        "year": "1982",
        "value": 738,
        "category": "emails",
    },
    {
        "year": "1982",
        "value": 121,
        "category": "shops",
    },
    {
        "year": "1982",
        "value": 64,
        "category": "credit_cards",
    },
    {
        "year": "1983",
        "value": 2176,
        "category": "banks",
    },
    {
        "year": "1983",
        "value": 1977,
        "category": "wallets",
    },
    {
        "year": "1983",
        "value": 739,
        "category": "emails",
    },
    {
        "year": "1983",
        "value": 125,
        "category": "shops",
    },
    {
        "year": "1983",
        "value": 58,
        "category": "credit_cards",
    },
    {
        "year": "1984",
        "value": 2199,
        "category": "banks",
    },
    {
        "year": "1984",
        "value": 2074,
        "category": "wallets",
    },
    {
        "year": "1984",
        "value": 807,
        "category": "emails",
    },
    {
        "year": "1984",
        "value": 128,
        "category": "shops",
    },
    {
        "year": "1984",
        "value": 51,
        "category": "credit_cards",
    },
    {
        "year": "1985",
        "value": 2186,
        "category": "banks",
    },
    {
        "year": "1985",
        "value": 2216,
        "category": "wallets",
    },
    {
        "year": "1985",
        "value": 835,
        "category": "emails",
    },
    {
        "year": "1985",
        "value": 131,
        "category": "shops",
    },
    {
        "year": "1985",
        "value": 49,
        "category": "credit_cards",
    },
    {
        "year": "1986",
        "value": 2293,
        "category": "banks",
    },
    {
        "year": "1986",
        "value": 2277,
        "category": "wallets",
    },
    {
        "year": "1986",
        "value": 830,
        "category": "emails",
    },
    {
        "year": "1986",
        "value": 137,
        "category": "shops",
    },
    {
        "year": "1986",
        "value": 46,
        "category": "credit_cards",
    },
    {
        "year": "1987",
        "value": 2306,
        "category": "banks",
    },
    {
        "year": "1987",
        "value": 2339,
        "category": "wallets",
    },
    {
        "year": "1987",
        "value": 892,
        "category": "emails",
    },
    {
        "year": "1987",
        "value": 143,
        "category": "shops",
    },
    {
        "year": "1987",
        "value": 44,
        "category": "credit_cards",
    },
    {
        "year": "1988",
        "value": 2412,
        "category": "banks",
    },
    {
        "year": "1988",
        "value": 2387,
        "category": "wallets",
    },
    {
        "year": "1988",
        "value": 935,
        "category": "emails",
    },
    {
        "year": "1988",
        "value": 152,
        "category": "shops",
    },
    {
        "year": "1988",
        "value": 50,
        "category": "credit_cards",
    },
    {
        "year": "1989",
        "value": 2459,
        "category": "banks",
    },
    {
        "year": "1989",
        "value": 2428,
        "category": "wallets",
    },
    {
        "year": "1989",
        "value": 982,
        "category": "emails",
    },
    {
        "year": "1989",
        "value": 156,
        "category": "shops",
    },
    {
        "year": "1989",
        "value": 41,
        "category": "credit_cards",
    },
    {
        "year": "1990",
        "value": 2492,
        "category": "banks",
    },
    {
        "year": "1990",
        "value": 2359,
        "category": "wallets",
    },
    {
        "year": "1990",
        "value": 1026,
        "category": "emails",
    },
    {
        "year": "1990",
        "value": 157,
        "category": "shops",
    },
    {
        "year": "1990",
        "value": 40,
        "category": "credit_cards",
    },
    {
        "year": "1991",
        "value": 2601,
        "category": "banks",
    },
    {
        "year": "1991",
        "value": 2284,
        "category": "wallets",
    },
    {
        "year": "1991",
        "value": 1051,
        "category": "emails",
    },
    {
        "year": "1991",
        "value": 161,
        "category": "shops",
    },
    {
        "year": "1991",
        "value": 45,
        "category": "credit_cards",
    },
    {
        "year": "1992",
        "value": 2499,
        "category": "banks",
    },
    {
        "year": "1992",
        "value": 2290,
        "category": "wallets",
    },
    {
        "year": "1992",
        "value": 1085,
        "category": "emails",
    },
    {
        "year": "1992",
        "value": 167,
        "category": "shops",
    },
    {
        "year": "1992",
        "value": 36,
        "category": "credit_cards",
    },
    {
        "year": "1993",
        "value": 2515,
        "category": "banks",
    },
    {
        "year": "1993",
        "value": 2225,
        "category": "wallets",
    },
    {
        "year": "1993",
        "value": 1117,
        "category": "emails",
    },
    {
        "year": "1993",
        "value": 176,
        "category": "shops",
    },
    {
        "year": "1993",
        "value": 37,
        "category": "credit_cards",
    },
    {
        "year": "1994",
        "value": 2539,
        "category": "banks",
    },
    {
        "year": "1994",
        "value": 2278,
        "category": "wallets",
    },
    {
        "year": "1994",
        "value": 1133,
        "category": "emails",
    },
    {
        "year": "1994",
        "value": 186,
        "category": "shops",
    },
    {
        "year": "1994",
        "value": 39,
        "category": "credit_cards",
    },
    {
        "year": "1995",
        "value": 2560,
        "category": "banks",
    },
    {
        "year": "1995",
        "value": 2359,
        "category": "wallets",
    },
    {
        "year": "1995",
        "value": 1151,
        "category": "emails",
    },
    {
        "year": "1995",
        "value": 197,
        "category": "shops",
    },
    {
        "year": "1995",
        "value": 39,
        "category": "credit_cards",
    },
    {
        "year": "1996",
        "value": 2626,
        "category": "banks",
    },
    {
        "year": "1996",
        "value": 2382,
        "category": "wallets",
    },
    {
        "year": "1996",
        "value": 1198,
        "category": "emails",
    },
    {
        "year": "1996",
        "value": 203,
        "category": "shops",
    },
    {
        "year": "1996",
        "value": 40,
        "category": "credit_cards",
    },
    {
        "year": "1997",
        "value": 2701,
        "category": "banks",
    },
    {
        "year": "1997",
        "value": 2409,
        "category": "wallets",
    },
    {
        "year": "1997",
        "value": 1197,
        "category": "emails",
    },
    {
        "year": "1997",
        "value": 209,
        "category": "shops",
    },
    {
        "year": "1997",
        "value": 40,
        "category": "credit_cards",
    },
    {
        "year": "1998",
        "value": 2763,
        "category": "banks",
    },
    {
        "year": "1998",
        "value": 2343,
        "category": "wallets",
    },
    {
        "year": "1998",
        "value": 1224,
        "category": "emails",
    },
    {
        "year": "1998",
        "value": 209,
        "category": "shops",
    },
    {
        "year": "1998",
        "value": 36,
        "category": "credit_cards",
    },
    {
        "year": "1999",
        "value": 2741,
        "category": "banks",
    },
    {
        "year": "1999",
        "value": 2310,
        "category": "wallets",
    },
    {
        "year": "1999",
        "value": 1258,
        "category": "emails",
    },
    {
        "year": "1999",
        "value": 217,
        "category": "shops",
    },
    {
        "year": "1999",
        "value": 35,
        "category": "credit_cards",
    },
    {
        "year": "2000",
        "value": 2845,
        "category": "banks",
    },
    {
        "year": "2000",
        "value": 2327,
        "category": "wallets",
    },
    {
        "year": "2000",
        "value": 1289,
        "category": "emails",
    },
    {
        "year": "2000",
        "value": 226,
        "category": "shops",
    },
    {
        "year": "2000",
        "value": 46,
        "category": "credit_cards",
    },
    {
        "year": "2001",
        "value": 2848,
        "category": "banks",
    },
    {
        "year": "2001",
        "value": 2445,
        "category": "wallets",
    },
    {
        "year": "2001",
        "value": 1316,
        "category": "emails",
    },
    {
        "year": "2001",
        "value": 237,
        "category": "shops",
    },
    {
        "year": "2001",
        "value": 47,
        "category": "credit_cards",
    },
    {
        "year": "2002",
        "value": 2832,
        "category": "banks",
    },
    {
        "year": "2002",
        "value": 2518,
        "category": "wallets",
    },
    {
        "year": "2002",
        "value": 1342,
        "category": "emails",
    },
    {
        "year": "2002",
        "value": 252,
        "category": "shops",
    },
    {
        "year": "2002",
        "value": 49,
        "category": "credit_cards",
    },
    {
        "year": "2003",
        "value": 2958,
        "category": "banks",
    },
    {
        "year": "2003",
        "value": 2695,
        "category": "wallets",
    },
    {
        "year": "2003",
        "value": 1397,
        "category": "emails",
    },
    {
        "year": "2003",
        "value": 276,
        "category": "shops",
    },
    {
        "year": "2003",
        "value": 48,
        "category": "credit_cards",
    },
    {
        "year": "2004",
        "value": 3043,
        "category": "banks",
    },
    {
        "year": "2004",
        "value": 2906,
        "category": "wallets",
    },
    {
        "year": "2004",
        "value": 1443,
        "category": "emails",
    },
    {
        "year": "2004",
        "value": 298,
        "category": "shops",
    },
    {
        "year": "2004",
        "value": 54,
        "category": "credit_cards",
    },
    {
        "year": "2005",
        "value": 3068,
        "category": "banks",
    },
    {
        "year": "2005",
        "value": 3108,
        "category": "wallets",
    },
    {
        "year": "2005",
        "value": 1485,
        "category": "emails",
    },
    {
        "year": "2005",
        "value": 320,
        "category": "shops",
    },
    {
        "year": "2005",
        "value": 60,
        "category": "credit_cards",
    },
    {
        "year": "2006",
        "value": 3091,
        "category": "banks",
    },
    {
        "year": "2006",
        "value": 3293,
        "category": "wallets",
    },
    {
        "year": "2006",
        "value": 1534,
        "category": "emails",
    },
    {
        "year": "2006",
        "value": 356,
        "category": "shops",
    },
    {
        "year": "2006",
        "value": 62,
        "category": "credit_cards",
    },
    {
        "year": "2007",
        "value": 3071,
        "category": "banks",
    },
    {
        "year": "2007",
        "value": 3422,
        "category": "wallets",
    },
    {
        "year": "2007",
        "value": 1562,
        "category": "emails",
    },
    {
        "year": "2007",
        "value": 382,
        "category": "shops",
    },
    {
        "year": "2007",
        "value": 66,
        "category": "credit_cards",
    },
    {
        "year": "2008",
        "value": 3103,
        "category": "banks",
    },
    {
        "year": "2008",
        "value": 3587,
        "category": "wallets",
    },
    {
        "year": "2008",
        "value": 1630,
        "category": "emails",
    },
    {
        "year": "2008",
        "value": 388,
        "category": "shops",
    },
    {
        "year": "2008",
        "value": 69,
        "category": "credit_cards",
    },
    {
        "year": "2009",
        "value": 3042,
        "category": "banks",
    },
    {
        "year": "2009",
        "value": 3590,
        "category": "wallets",
    },
    {
        "year": "2009",
        "value": 1584,
        "category": "emails",
    },
    {
        "year": "2009",
        "value": 415,
        "category": "shops",
    },
    {
        "year": "2009",
        "value": 66,
        "category": "credit_cards",
    },
    {
        "year": "2010",
        "value": 3107,
        "category": "banks",
    },
    {
        "year": "2010",
        "value": 3812,
        "category": "wallets",
    },
    {
        "year": "2010",
        "value": 1696,
        "category": "emails",
    },
    {
        "year": "2010",
        "value": 446,
        "category": "shops",
    },
    {
        "year": "2010",
        "value": 67,
        "category": "credit_cards",
    },
    {
        "year": "2011",
        "value": 3134,
        "category": "banks",
    },
    {
        "year": "2011",
        "value": 4055,
        "category": "wallets",
    },
    {
        "year": "2011",
        "value": 1756,
        "category": "emails",
    },
    {
        "year": "2011",
        "value": 494,
        "category": "shops",
    },
    {
        "year": "2011",
        "value": 64,
        "category": "credit_cards",
    },
    {
        "year": "2012",
        "value": 3200,
        "category": "banks",
    },
    {
        "year": "2012",
        "value": 4106,
        "category": "wallets",
    },
    {
        "year": "2012",
        "value": 1783,
        "category": "emails",
    },
    {
        "year": "2012",
        "value": 519,
        "category": "shops",
    },
    {
        "year": "2012",
        "value": 65,
        "category": "credit_cards",
    },
    {
        "year": "2013",
        "value": 3220,
        "category": "banks",
    },
    {
        "year": "2013",
        "value": 4126,
        "category": "wallets",
    },
    {
        "year": "2013",
        "value": 1806,
        "category": "emails",
    },
    {
        "year": "2013",
        "value": 554,
        "category": "shops",
    },
    {
        "year": "2013",
        "value": 68,
        "category": "credit_cards",
    },
    {
        "year": "2014",
        "value": 3280,
        "category": "banks",
    },
    {
        "year": "2014",
        "value": 4117,
        "category": "wallets",
    },
    {
        "year": "2014",
        "value": 1823,
        "category": "emails",
    },
    {
        "year": "2014",
        "value": 568,
        "category": "shops",
    },
    {
        "year": "2014",
        "value": 68,
        "category": "credit_cards",
    },
];

const LogsLine: React.FC<StatsCardProps> = (props: StatsCardProps) => {
    const settingsReducer = useAppSelector((state: AppState) => state.settings);

    const COLOR_PLATE_10 = [
        "#5B8FF9",
        "#5AD8A6",
        "#5D7092",
        "#F6BD16",
        "#E8684A",
        "#6DC8EC",
        "#9270CA",
        "#FF9D4D",
        "#269A99",
        "#FF99C3",
    ];
    const config: LineConfig = {
        data: injectsTimeLine,
        padding: [40, 15, 100, 50],
        xField: "year",
        yField: "value",
        seriesField: "category",
        color: COLOR_PLATE_10,
        point: {
            shape: "circle",
        },
        slider: sliderConfig,
        theme: settingsReducer.theme === "dark" ? "dark" : "light",
        loading: false,
        loadingTemplate: <Spinner variant="circle" />,
    };

    return (
        <div className="stat-block">
            <Divider {...dividerConfig}>
                <h2>{props.title}</h2>
            </Divider>

            <Line {...config} />
        </div>
    );
};

export default LogsLine;
