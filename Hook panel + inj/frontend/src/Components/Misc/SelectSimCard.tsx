import React, {useState} from "react";
import {Col, Row} from "antd";
import {SimCardIcon} from "./CustomIcons";

interface SimData {
    sim_slot: number,
    sim_provider: string | null,
}

interface SelectSimCardProps {
    simData: SimData[]
}

const SelectSimCard: React.FC<SelectSimCardProps> = (props: SelectSimCardProps) => {
    const [simCard, setSimCard] = useState<number>();

    const simCardSelect = (sim: number) => {
        setSimCard(sim);
    };

    return (
        <>
            <Row gutter={15}>
                {props.simData.map((sim, id) => {
                    return (
                        <Col span={12} key={id}>
                            <label className={sim.sim_provider ? "sim-card" : "sim-card disabled"}>
                                <input
                                    type="radio"
                                    name="sim"
                                    value={simCard}
                                    onChange={() => simCardSelect(sim.sim_slot)}
                                    className="sim-card-radio"
                                    disabled={!sim.sim_provider}
                                />
                                <span className="sim-card-inner">
                                    <span className="sim-card-icon">
                                        <SimCardIcon />
                                    </span>
                                    <span className="sim-card-info">
                                        <span className="sim-card-name">
                                            Sim #{sim.sim_slot}
                                        </span>
                                        <span className="sim-card-provider">
                                            {sim.sim_provider ? sim.sim_provider : "Empty"}
                                        </span>
                                    </span>
                                </span>
                            </label>
                        </Col>
                    );
                })}
            </Row>
        </>
    );
};

export default SelectSimCard;
