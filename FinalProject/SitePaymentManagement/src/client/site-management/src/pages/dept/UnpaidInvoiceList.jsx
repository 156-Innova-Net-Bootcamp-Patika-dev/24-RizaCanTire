import React from 'react'
import { useEffect } from 'react'
import { useState } from 'react'
import UnpaidInvoiceService from "../../services/unpadInoviceService"
import { Table } from "antd";

export default function UnpaidInvoiceList() {
    const [unpaidList, setUnpaidList] = useState([])
    useEffect(() => {
      let unpaidService = new UnpaidInvoiceService()
      unpaidService.getUnpaidInovices().then(result=>setUnpaidList(result.data.result.entity))      
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
      const data = unpaidList.map(invoice=>({
        fee : invoice.invoiceFee,
        month : invoice.invoiceMonth,
        year : invoice.invoiceYear,
        firstName : invoice.userResidenceUserFirstName,
        lastName : invoice.userResidenceUserLastName,
        block: invoice.userResidenceResidenceBlock,
        floor:invoice.userResidenceResidenceFloor,
        doorNumber:invoice.userResidenceResidenceDoorNumber,
        isPaid : invoice.isPaid === false?"Borçlu":"Ödendi"
        
      }))
    
  return (
    <div>UnpaidInvoiceList
          <Table columns={columns} dataSource={data} size="small" />

    </div>
  )
}
