import React from 'react'
import { useEffect } from 'react'
import { useState } from 'react'
import { Table } from "antd";
import UnpaidDuesService from "../../services/unpaidDuesService"
export default function UnpaidDuesList() {
  const [unpaidList, setUnpaidList] = useState([])
  useEffect(() => {
    let unpaidDuesService = new UnpaidDuesService()
    unpaidDuesService.getUnpaidDues().then(result=>setUnpaidList(result.data.result.entity))
  
  }, [])

  const columns = [
    { title: "Blok", dataIndex: "block" },
    { title: "Kat", dataIndex: "floor" },
    { title: "Daire", dataIndex: "doorNumber" },
    { title: "İsim", dataIndex: "firstName" },
    { title: "Soyisim", dataIndex: "lastName" },
    { title: "Yıl", dataIndex: "year" },
    { title: "Ay", dataIndex: "month" },
    { title: "Ücret", dataIndex: "fee" },
    { title: "Durum", dataIndex: "isPaid" },
   
  ];
  const data = unpaidList.map(dues=>({
    fee : dues.duesFee,
    month : dues.duesMonth,
    year : dues.duesYear,
    firstName : dues.userResidenceUserFirstName,
    lastName : dues.userResidenceUserLastName,
    block: dues.userResidenceResidenceBlock,
    floor:dues.userResidenceResidenceFloor,
    doorNumber:dues.userResidenceResidenceDoorNumber,
    isPaid : dues.isPaid === false?"Borçlu":"Ödendi"
    
  }))
  return (
    <div><Table columns={columns} dataSource={data} size="small" /></div>
  )
}
