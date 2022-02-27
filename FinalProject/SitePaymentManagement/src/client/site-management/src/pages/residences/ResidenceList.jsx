import React, { useEffect, useState } from "react";
import ResidenceService from "../../services/residenceService";
import { Table } from "antd";

export default function ResidenceList() {
  const [residences, setResidences] = useState([]);
  useEffect(() => {
    let residenceService = new ResidenceService();
    residenceService
      .getResidences()
      .then((result) => setResidences(result.data.result));
  }, []);
  const columns = [
    { title: "Apartman No", dataIndex: "block" },
    { title: "Kat", dataIndex: "floor" },
    { title: "Daire No", dataIndex: "doorNumber" },
    { title: "Oturan var mı?", dataIndex: "isFull" },
    { title: "Oda Sayısı", dataIndex: "residenceType" },
  ];
  const data = residences.map(residence=>({
    block : residence.block,
    floor : residence.floor,
    doorNumber : residence.doorNumber,
    isFull : residence.isFull === true?"Dolu":"Boş",
    residenceType : residence.residenceType
  }))
  return <div className="container">
  <Table columns={columns} dataSource={data} size="small" />
</div>
}
