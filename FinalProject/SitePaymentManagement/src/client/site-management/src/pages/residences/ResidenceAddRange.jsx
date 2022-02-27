import React, { useState } from "react";
import ResidenceService from "../../services/residenceService";
import { Button, Form, Input } from "antd";

export default function ResidenceAddRange() {
  const [blockNumber, setBlockNumber] = useState("");
  const [floorPerBlock, setFloorPerBlock] = useState("");
  const [housePerBlock, setHousePerBlock] = useState("");
  const [residenceTypeId, setResidenceTypeId] = useState("");

  const addResidenceRange = () => {
    let residenceService = new ResidenceService();
    residenceService.addResidenceRange(
      blockNumber,
      floorPerBlock,
      housePerBlock,
      residenceTypeId
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
        <Form.Item label="Blok Sayısı" name="block">
          <Input
            name="blockNumber"
            value={blockNumber}
            onInput={(e) => setBlockNumber(e.target.value)}
          />
        </Form.Item>
        <Form.Item label="Kat Sayısı" name="floorPerBlock">
          <Input
            name="floorPerBlock"
            value={floorPerBlock}
            onInput={(e) => setFloorPerBlock(e.target.value)}
          />
        </Form.Item>
        <Form.Item label="Kat Başı DAire" name="housePerBlock">
          <Input
            name="housePerBlock"
            value={housePerBlock}
            onInput={(e) => setHousePerBlock(e.target.value)}
          />
        </Form.Item>
        <Form.Item label="Oda Sayısı" name="residenceTypeId">
          <Input
            name="residenceTypeId"
            value={residenceTypeId}
            onInput={(e) => setResidenceTypeId(e.target.value)}
          />
        </Form.Item>
        <Form.Item
          wrapperCol={{
            offset: 8,
            span: 6,
          }}
        >
          <Button type="primary" htmlType="submit" onClick={addResidenceRange}>
            Blok Ekle
          </Button>
        </Form.Item>
      </Form>
    </div>
  );
}
