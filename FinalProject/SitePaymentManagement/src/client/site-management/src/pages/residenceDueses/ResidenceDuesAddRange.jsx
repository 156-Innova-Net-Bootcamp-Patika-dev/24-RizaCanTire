import React, { useState } from "react";
import ResidenceDuesService from "../../services/residenceDuesService";
import { Button, Form, Input } from "antd";

export default function ResidenceAddRange() {
  const [year, setYear] = useState("");

  const addResidenceDuesRange = () => {
    let residenceDuesService = new ResidenceDuesService();
    residenceDuesService.addResidenceDuesRange(
      year
    );
  };
  const layout = {
    labelCol: { span: 7 },
    wrapperCol: { span: 8 },
  };
  return (
    <div>
      Blok Ekle
      <Form style={{}} name="basic" {...layout}>
        <Form.Item label="Aidat Yılı" name="year">
          <Input
            name="year"
            value={year}
            onInput={(e) => setYear(e.target.value)}
          />
        </Form.Item>
        
        <Form.Item
          wrapperCol={{
            offset: 8,
            span: 6,
          }}
        >
          <Button type="primary" htmlType="submit" onClick={addResidenceDuesRange}>
            Toplu Aidat Ekle
          </Button>
        </Form.Item>
      </Form>
    </div>
  );
}
