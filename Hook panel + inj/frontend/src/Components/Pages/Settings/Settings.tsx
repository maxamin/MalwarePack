import React, {useState} from "react";
import {Button, Form, Input, Space} from "antd";
import {DeleteOutlined, PlusSquareOutlined} from "@ant-design/icons";

interface Contact {
    name: string,
    description: string,
}

const Settings: React.FC = () => {
    const [contacts, setContacts] = useState<Contact[]>([]);

    const formFinish = () => {
    };

    return (
        <>
            <div className="panel-header">
                <h2 className="panel-title">Settings</h2>
            </div>

            <div className="panel-content">
                <Form layout="vertical" onFinish={formFinish}>
                    {contacts?.map((contact: Contact, key: number) => {
                        return (
                            <Space size={15} key={key} style={{width: "100%", marginBottom: 5}}>
                                <Form.Item name={"name" + key} label="Name" rules={[{required: true, message: "Missing name"}]}>
                                    <Input type="text" value={contact.name} onChange={(e) => {
                                        contacts[key].name = e.currentTarget.value;
                                        setContacts([...contacts]);
                                    }}/>
                                </Form.Item>
                                <Form.Item name={"description" + key} label="Description" rules={[{required: true, message: "Missing description"}]}>
                                    <Input type="text" value={contact.description} onChange={(e) => {
                                        contacts[key].description = e.currentTarget.value;
                                        setContacts([...contacts]);
                                    }}/>
                                </Form.Item>

                                <Button
                                    shape="circle"
                                    type="primary"
                                    icon={<DeleteOutlined />}
                                    danger
                                    onClick={() => {
                                        // TODO remove contact from state
                                    }}
                                />
                            </Space>
                        );
                    })}

                    <Space direction="vertical" size={15}>
                        <Button
                            type="dashed"
                            icon={<PlusSquareOutlined />}
                            onClick={() => setContacts([...contacts, {
                                name: "",
                                description: "",
                            }])}
                        >
                            Add contact
                        </Button>

                        <Button
                            htmlType="submit"
                            type="primary"
                        >
                            Save contacts
                        </Button>
                    </Space>
                </Form>
            </div>
        </>
    );
};

export default Settings;
