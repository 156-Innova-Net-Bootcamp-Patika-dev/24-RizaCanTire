import React from 'react'
import { useEffect } from 'react'
import { useState } from 'react'
import ResidentService from '../../services/residentService'
import { Table } from "antd";

export default function ResidentDetail() {
    const [residents, setResidents] = useState([])
    useEffect(() => {
      let residentService = new ResidentService();
        console.log( residentService.getResidenceDetail());
      residentService.getResidenceDetail().then(result=>setResidents(result))
    }, [])

    const columns = [
        { title: "İsim", dataIndex: "firstName" },
        { title: "Soyisim", dataIndex: "lastName" },
        { title: "Blok", dataIndex: "block" },
        { title: "Kat", dataIndex: "floor" },
        { title: "Kapı No", dataIndex: "doorNumber" },
       
      ];
      const data = residents.map(userResidence=>({
        firstName : userResidence.user.firstName,
        lastName : userResidence.user.lastName,
        block : userResidence.residence.block,
        floor : userResidence.residence.floor,
        doorNumber :userResidence.residence.doorNumber
      }))
    
  return (
    <div>
        ResidentDetail
        <Table columns={columns} dataSource={data} size="small" />
</div>
  )
}
