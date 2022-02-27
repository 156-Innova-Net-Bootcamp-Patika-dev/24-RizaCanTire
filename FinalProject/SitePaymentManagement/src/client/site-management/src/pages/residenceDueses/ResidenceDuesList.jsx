import React, { useEffect, useState } from "react";
import ResidenceDuesService from "../../services/residenceDuesService";
import { Table } from "antd";

export default function ResidenceDuesList() {
  const [residenceDueses, setResidenceDueses] = useState([]);
  useEffect(() => {
    let residenceDuesService = new ResidenceDuesService();
    residenceDuesService
      .getResidenceDueses()
      .then((result) => setResidenceDueses(result.data.result.entity));
  }, []);
  const columns = [
    { title: "Aidat Yılı", dataIndex: "duesYear" },
    { title: "Aidat Ayı", dataIndex: "duesMonth" },
    { title: "Block", dataIndex: "userResidenceResidenceBlock" },
    { title: "Kat", dataIndex: "userResidenceResidenceFloor" },
    { title: "Daire No", dataIndex: "userResidenceResidenceDoorNumber" },
    { title: "Sakin Adı", dataIndex: "userResidenceUserFirstName" },
    { title: "Sakin Soyadı", dataIndex: "userResidenceUserLastName" },
    { title: "Ücret", dataIndex: "duesFee" },
    { title: "Ödeme durumu", dataIndex: "isPaid" },
    { title: "Oturan Tipi", dataIndex: "userResidenceResidentTypeType" }
  ];
  const data = residenceDueses.map(residenceDues=>({
    duesYear : residenceDues.duesYear,
    duesMonth : residenceDues.duesMonth,
    userResidenceResidenceBlock : residenceDues.userResidenceResidenceBlock,
    userResidenceResidenceFloor : residenceDues.userResidenceResidenceFloor,
    userResidenceResidenceDoorNumber : residenceDues.userResidenceResidenceDoorNumber,
    userResidenceUserFirstName : residenceDues.userResidenceUserFirstName,
    userResidenceUserLastName : residenceDues.userResidenceUserLastName,
    duesFee : residenceDues.duesFee,
    isPaid : residenceDues.isPaid === true?"Ödedi":"Borçlu",
    userResidenceResidentTypeType : residenceDues.userResidenceResidentTypeType
  }))
  return <div className="container">
  <Table columns={columns} dataSource={data} size="small" />
</div>
}
