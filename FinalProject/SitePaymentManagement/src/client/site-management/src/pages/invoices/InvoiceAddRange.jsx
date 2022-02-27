import React, { useState } from "react";
import InvoiceService from "../../services/invoiceService";
import { Button, Form, Input } from "antd";

export default function InvoiceAddRange() {
  const [fee, setFee] = useState("");
  const [year, setYear] = useState("");
  


  const addInvoiceRange = () => {
    let invoiceService = new InvoiceService();
    invoiceService.addInvoiceRange(
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
      Yıllık Fatura Ekle
      <Form style={{}} name="basic" {...layout}>
        <Form.Item label="Fatura ücreti" name="fee">
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
          <Button type="primary" htmlType="submit" onClick={addInvoiceRange}>
            Yıllık Fatura Ekle
          </Button>
        </Form.Item>
      </Form>
    </div>
  );
}
