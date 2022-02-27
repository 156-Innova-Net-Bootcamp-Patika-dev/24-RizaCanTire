import React, { useState } from "react";
import ResidenceInvoiceService from "../../services/residenceInvoiceService";
import { Button, Form, Input } from "antd";

export default function ResidenceAddRange() {
  const [year, setYear] = useState("");

  const addResidenceInvoiceRange = () => {
    let residenceInvoiceService = new ResidenceInvoiceService();
    residenceInvoiceService.addResidenceInvoiceRange(
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
        <Form.Item label="Fatura Yılı" name="year">
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
          <Button type="primary" htmlType="submit" onClick={addResidenceInvoiceRange}>
            Toplu Fatura  Ekle
          </Button>
        </Form.Item>
      </Form>
    </div>
  );
}
