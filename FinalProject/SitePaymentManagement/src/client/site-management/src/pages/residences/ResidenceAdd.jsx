import React, { useState } from "react";
import ResidenceService from "../../services/residenceService";
import { Button, Form, Input } from "antd";

export default function ResidenceAdd() {
  const [block, setBlock] = useState("");
  const [floor, setFloor] = useState("");
  const [doorNumber, setDoorNumber] = useState("");
  const [residenceType, setResidenceType] = useState("");

  const addResidence = () => {
    let residenceService = new ResidenceService();
    residenceService.addResidence(block, floor, doorNumber, residenceType);
  };

  const layout = {
    labelCol: { span: 7 },
    wrapperCol: { span: 8 },
  };
  return (
    <div>
      Daire Ekle
      <Form style={{}} name="basic" {...layout}>
        <Form.Item label="Apartman numarası" name="block">
          <Input
            name="block"
            value={block}
            onInput={(e) => setBlock(e.target.value)}
          />
        </Form.Item>
        <Form.Item label="Kat Numarası" name="floor">
          <Input
            name="floor"
            value={floor}
            onInput={(e) => setFloor(e.target.value)}
          />
        </Form.Item>
        <Form.Item label="Kapı Numarası" name="floor">
          <Input
            name="doorNumber"
            value={doorNumber}
            onInput={(e) => setDoorNumber(e.target.value)}
          />
        </Form.Item>
        <Form.Item label="Oda Sayısı" name="residenceType">
          <Input
            name="residenceType"
            value={residenceType}
            onInput={(e) => setResidenceType(e.target.value)}
          />
        </Form.Item>
        <Form.Item
          wrapperCol={{
            offset: 8,
            span: 6,
          }}
        >
          <Button type="primary" htmlType="submit" onClick={addResidence}>
            Apartman Ekle
          </Button>
        </Form.Item>
      </Form>
    </div>
  );
}
