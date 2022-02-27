import React from 'react'
import { useState} from 'react'
import { Button, Form, Input } from "antd";
import InvoicePaymentService from "../../services/payments/invoicePaymentService"
export default function InvoicePayment() {
    const [firstName, setFirstName] = useState("")
    const [lastName, setLastName] = useState("");
    const [cardNumber, setCardNumber] = useState("");
    const [fee, setFee] = useState("")
    const [paymentId, setPaymentId] = useState("")
  const payInvoice = () => {
    let service = new InvoicePaymentService();
   
    console.log( service.payInvoice(firstName, lastName,cardNumber,fee,paymentId,1))
  };


    const layout = {
        labelCol: { span: 7 },
        wrapperCol: { span: 8 },
      };
  return (
    <div>
        InvoicePayment

        <Form style={{}} name="basic" {...layout}>
        <Form.Item label="İsim" name="firstName">
          <Input
            name="firstName"
            value={firstName}
            onInput={(e) => setFirstName(e.target.value)}
          />
        </Form.Item>
        <Form.Item label="Soyisim" name="lastName">
          <Input
            name="lastName"
            value={lastName}
            onInput={(e) => setLastName(e.target.value)}
          />
        </Form.Item>
        <Form.Item label="Kart Numarası" name="cardNumber">
          <Input
            name="cardNumber"
            value={cardNumber}
            onInput={(e) => setCardNumber(e.target.value)}
          />
        </Form.Item>
        <Form.Item label="Fatura Tutarı" name="fee">
          <Input
            name="fee"
            value={fee}
            onInput={(e) => setFee(e.target.value)}
          />
        </Form.Item>
        <Form.Item label="Fatura Numarası" name="paymentId">
          <Input
            name="paymentId"
            value={paymentId}
            onInput={(e) => setPaymentId(e.target.value)}
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
            onClick={payInvoice}
          >
            Site Sakini Fatura Öde
          </Button>
        </Form.Item>
      </Form>
    </div>
  )
}
