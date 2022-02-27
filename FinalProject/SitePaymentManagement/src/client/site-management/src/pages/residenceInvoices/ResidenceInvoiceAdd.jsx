import React, { useState } from "react";
import ResidenceInvoiceService from "../../services/residenceInvoiceService";
import { Button, Form, Input } from "antd";

export default function ResidenceInvoiceAdd() {
  const [invoiceId, setInvoiceId] = useState("");
  const [userResidenceId, setUserResidenceId] = useState("");

  const addResidenceInvoice = () => {
    let residenceInvoiceService = new ResidenceInvoiceService();
    residenceInvoiceService.addResidenceInvoice(invoiceId, userResidenceId);
  };

  const layout = {
    labelCol: { span: 7 },
    wrapperCol: { span: 8 },
  };
  return (
    <div>
      Site Sakini Fatura Ekle
      <Form style={{}} name="basic" {...layout}>
        <Form.Item label="Fatura Numarası" name="invoiceId">
          <Input
            name="invoiceId"
            value={invoiceId}
            onInput={(e) => setInvoiceId(e.target.value)}
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
            onClick={addResidenceInvoice}
          >
            Site Sakini Fatura Ekle
          </Button>
        </Form.Item>
      </Form>
    </div>
  );
}
