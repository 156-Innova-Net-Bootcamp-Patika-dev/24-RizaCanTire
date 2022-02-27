import React, { useState } from "react";
import UserResidenceService from "../../services/userResidenceService";
import { Button, Form, Input } from "antd";

export default function UserResidenceAdd() {
  const [userId, setUserID] = useState("");
  const [residenceId, setResidenceId] = useState("");
  const [residentTypeId, setResidenceTypeId] = useState("");
  const addUserResidence = () => {
    let userResidenceService = new UserResidenceService();
    userResidenceService.addUserResidence(userId, residenceId, residentTypeId);
  };

  const layout = {
    labelCol: { span: 7 },
    wrapperCol: { span: 8 },
  };
  return (
    <div>
      Site Sakini Ekle
      <Form style={{}} name="basic" {...layout}>
        <Form.Item label="Üye" name="userId">
          <Input
            name="userId"
            value={userId}
            onInput={(e) => setUserID(e.target.value)}
          />
        </Form.Item>
        <Form.Item label="Daire" name="residenceId">
          <Input
            name="residenceId"
            value={residenceId}
            onInput={(e) => setResidenceId(e.target.value)}
          />
        </Form.Item>
        <Form.Item label="Ev Sahibi - Kiracı" name="residentTypeId">
          <Input
            name="residentTypeId"
            value={residentTypeId}
            onInput={(e) => setResidenceTypeId(e.target.value)}
          />
        </Form.Item>
        
        <Form.Item
          wrapperCol={{
            offset: 8,
            span: 6,
          }}
        >
          <Button type="primary" htmlType="submit" onClick={addUserResidence}>
            Site Sakini Ekle
          </Button>
        </Form.Item>
      </Form>
    </div>
  );
}
