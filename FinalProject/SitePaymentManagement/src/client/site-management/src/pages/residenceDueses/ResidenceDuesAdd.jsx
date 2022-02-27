import React, { useState } from "react";
import ResidenceDuesService from "../../services/residenceDuesService";
import { Button, Form, Input } from "antd";

export default function ResidenceDuesAdd() {
  const [duesId, setDuesId] = useState("");
  const [userResidenceId, setUserResidenceId] = useState("");

  const addResidenceDues = () => {
    let residenceDuesService = new ResidenceDuesService();
    residenceDuesService.addResidenceDues(duesId, userResidenceId);
  };

  const layout = {
    labelCol: { span: 7 },
    wrapperCol: { span: 8 },
  };
  return (
    <div>
      Site Sakini Aidat Ekle
      <Form style={{}} name="basic" {...layout}>
        <Form.Item label="Aidat Numarası" name="duesId">
          <Input
            name="duesId"
            value={duesId}
            onInput={(e) => setDuesId(e.target.value)}
          />
        </Form.Item>
        <Form.Item label="Site Sakini Dairesi" name="userResidenceId">
          <Input
            name="userResidenceId"
            value={userResidenceId}
            onInput={(e) => setUserResidenceId(e.target.value)}
          />
        </Form.Item>

        <Form.Item
          wrapperCol={{
            offset: 8,
            span: 6,
          }}
        >
          <Button
            type="primary"
            htmlType="submit"
            onClick={addResidenceDues}
          >
            Site Sakini Aidat Ekle
          </Button>
        </Form.Item>
      </Form>
    </div>
  );
}
