import React from "react";
import {MapContainer, Marker, Popup, TileLayer} from "react-leaflet";
import "leaflet/dist/leaflet.css";
import {divIcon} from "leaflet";
import useBreakpoint from "antd/es/grid/hooks/useBreakpoint";
import {OnlineBotMapStats} from "../../Store/Stats/Types";

interface IProps {
    data: OnlineBotMapStats,
}

const LeafletBotsMap: React.FC<IProps> = (props: IProps) => {
    const screens = useBreakpoint();

    return (
        <div style={{width: "100%", height: screens.xs ? 300 : 440}}>
            <MapContainer center={[35.6270675, 85.0348155]} zoom={2} scrollWheelZoom={false}>
                <TileLayer url="https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png" />
                {Object.keys(props.data).map((botId: string, key: number) => (
                    <Marker
                        position={[props.data[botId].lat, props.data[botId].lon]}
                        icon={divIcon({className: "bot-pin"})}
                        key={key}
                    >
                        <Popup>{botId}</Popup>
                    </Marker>
                ))}
            </MapContainer>
        </div>
    );
};

export default LeafletBotsMap;
