import React, { useState } from "react";
import DuesService from "../../services/duesService";
import { Button, Form, Input } from "antd";

export default function DuesAdd() {
  const [fee, setFee] = useState("");
  const [month, setMonth] = useState("");
  const [year, setYear] = useState("");


  const addDues = () => {
    let duesService = new DuesService();
    duesService.addDues(fee, month, year);
  };

  const layout = {
    labelCol: { span: 7 },
    wrapperCol: { span: 8 },
  };
  return (
    <div>
      Aidat Ekle
      <Form style={{}} name="basic" {...layout}>
        <Form.Item label="Ücret" name="fee">
          <Input
            name="fee"
            value={fee}
            onInput={(e) => setFee(e.target.value)}
          />
        </Form.Item>
        <Form.Item label="Ay" name="month">
          <Input
            name="month"
            value={month}
            onInput={(e) => setMonth(e.target.value)}
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
          <Button type="primary" htmlType="submit" onClick={addDues}>
            Aidat Ekle
          </Button>
        </Form.Item>
      </Form>
    </div>
  );
}
