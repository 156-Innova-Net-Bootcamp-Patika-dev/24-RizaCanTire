import React from 'react'
import { useState} from 'react'
import { Button, Form, Input } from "antd";
import DuesPaymentService from "../../services/payments/duesPaymentService"
export default function DuesPayment() {
    const [firstName, setFirstName] = useState("")
    const [lastName, setLastName] = useState("");
    const [cardNumber, setCardNumber] = useState("");
    const [fee, setFee] = useState("")
    const [paymentId, setPaymentId] = useState("")
  const payDues = () => {
    let service = new DuesPaymentService();
   
    console.log( service.payDues(firstName, lastName,cardNumber,fee,paymentId,2))
  };


    const layout = {
        labelCol: { span: 7 },
        wrapperCol: { span: 8 },
      };
  return (
    <div>
        Aidat Ödeme

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
            onClick={payDues}
          >
            Site Sakini Aidat Öde
          </Button>
        </Form.Item>
      </Form>
    </div>
  )
}
