import React, { useState } from "react";
import InvoiceService from "../../services/invoiceService";
import { Button, Form, Input } from "antd";

export default function InvoiceAdd() {
  const [fee, setFee] = useState("");
  const [month, setMonth] = useState("");
  const [year, setYear] = useState("");


  const addInvoice = () => {
    let invoiceService = new InvoiceService();
    invoiceService.addInvoice(fee, month, year);
  };

  const layout = {
    labelCol: { span: 7 },
    wrapperCol: { span: 8 },
  };
  return (
    <div>
      Fatura Ekle
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
          <Button type="primary" htmlType="submit" onClick={addInvoice}>
            Fatura Ekle
          </Button>
        </Form.Item>
      </Form>
    </div>
  );
}
