import React, { useState } from "react";
import DuesService from "../../services/duesService";
import { Button, Form, Input } from "antd";

export default function DuesAddRange() {
  const [fee, setFee] = useState("");
  const [year, setYear] = useState("");
  


  const addDuesRange = () => {
    let duesService = new DuesService();
    duesService.addDuesRange(
      fee,
      year
    );
  };
  const layout = {
    labelCol: { span: 7 },
    wrapperCol: { span: 8 },
  };
  return (
    <div>
      Yıllık Aidat Ekle
      <Form style={{}} name="basic" {...layout}>
        <Form.Item label="Aidat ücreti" name="fee">
          <Input
            name="fee"
            value={fee}
            onInput={(e) => setFee(e.target.value)}
          />
        </Form.Item>
        <Form.Item label="Yıl" name="year">
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
          <Button type="primary" htmlType="submit" onClick={addDuesRange}>
            Yıllık Aidat Ekle
          </Button>
        </Form.Item>
      </Form>
    </div>
  );
}
