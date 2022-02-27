import React, { useEffect, useState } from "react";
import DuesService from "../../services/duesService";
import { Table } from "antd";

export default function DuesList() {
  const [dueses, setDueses] = useState([]);
  useEffect(() => {
    let duesService = new DuesService();
    console.log(dueses)
    duesService
      .getDueses()
      .then((result) => setDueses(result.data.entity));
      console.log(dueses)
  }, []);
  const columns = [
    { title: "Ücret", dataIndex: "fee" },
    { title: "Ay", dataIndex: "month" },
    { title: "Yıl", dataIndex: "year" },
   
  ];
  const data = dueses.map(dues=>({
    fee : dues.fee,
    month : dues.month,
    year : dues.year,
    
  }))
  return <div className="container">
  <Table columns={columns} dataSource={data} size="small" />
</div>
}
