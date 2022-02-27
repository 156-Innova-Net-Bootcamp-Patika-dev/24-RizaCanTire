import React from "react";
import { useEffect } from "react";
import { useState } from "react";
import UserDueservice from "../../../services/userDuesService";
import { Table } from "antd";
export default function GetDueses() {
  const [dueses, setDueses] = useState([]);
  useEffect(() => {
    let service = new UserDueservice();
    service
      .getResidenceDuesByUser()
      .then((result) => setDueses(result.entity));
  }, []);
  const columns = [
    { title: "Id", dataIndex: "id" },
    { title: "Yıl", dataIndex: "year" },
    { title: "Ay", dataIndex: "month" },
    { title: "Fiyat", dataIndex: "fee" },
    { title: "Durum", dataIndex: "isPaid" },
  ];
  const data = dueses.map((dues) => ({
    id: dues.id,
    fee: dues.duesFee,
    month: dues.duesMonth,
    year: dues.duesYear,
    isPaid: dues.isPaid === true ? "Ödendi" : "Borçlu",
  }));
  console.log(dueses);
  return (
    <div>
      <Table columns={columns} dataSource={data} size="small" />
    </div>
  );
}
