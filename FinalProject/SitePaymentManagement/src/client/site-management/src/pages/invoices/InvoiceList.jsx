import React, { useEffect, useState } from "react";
import InvoiceService from "../../services/invoiceService";
import { Table } from "antd";

export default function InvoiceList() {
  const [invoices, setInvoices] = useState([]);
  useEffect(() => {
    let invoiceService = new InvoiceService();
    console.log(invoices)
    invoiceService
      .getInvoices()
      .then((result) => setInvoices(result.data.entity));
      console.log(invoices)
  }, []);
  const columns = [
    { title: "Ücret", dataIndex: "fee" },
    { title: "Ay", dataIndex: "month" },
    { title: "Yıl", dataIndex: "year" },
   
  ];
  const data = invoices.map(invoice=>({
    fee : invoice.fee,
    month : invoice.month,
    year : invoice.year,
    
  }))
  return <div className="container">
  <Table columns={columns} dataSource={data} size="small" />
</div>
}
