import React, { useEffect, useState } from "react";
import UserResidenceService from "../../services/userResidenceService";
import { Table } from "antd";

export default function UserResidenceList() {
  const [userResidences, setUserResidences] = useState([]);
  useEffect(() => {
    let userResidenceService = new UserResidenceService();
    userResidenceService
      .getUserResidences()
      .then((result) => setUserResidences(result.data.result));
      console.log(userResidences)
  }, []);
  const columns = [
    { title: "İsim", dataIndex: "firstName" },
    { title: "Soyisim", dataIndex: "lastName" },
    { title: "Blok", dataIndex: "block" },
    { title: "Kat", dataIndex: "floor" },
    { title: "Kapı No", dataIndex: "doorNumber" },
   
  ];
  const data = userResidences.map(userResidence=>({
    firstName : userResidence.user.firstName,
    lastName : userResidence.user.lastName,
    block : userResidence.residence.block,
    floor : userResidence.residence.floor,
    doorNumber :userResidence.residence.doorNumber
  }))
  return <div className="container">
  <Table columns={columns} dataSource={data} size="small" />
</div>
}
