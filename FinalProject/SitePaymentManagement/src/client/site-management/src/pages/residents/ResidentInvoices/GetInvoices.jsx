import React from "react";
import { useEffect } from "react";
import { useState } from "react";
import UserInvoiceService from "../../../services/userInvoiceService";
import { Table } from "antd";

export default function GetInvoices() {
  const [invoices, setInvoices] = useState([]);
  useEffect(() => {
    let service = new UserInvoiceService();
    service
      .getResidenceInvoicesByUser()
      .then((result) => setInvoices(result.entity));
  }, []);
  const columns = [
    { title: "Id", dataIndex: "id" },
    { title: "Yıl", dataIndex: "fee" },
    { title: "Ay", dataIndex: "month" },
    { title: "Fiyat", dataIndex: "year" },
    { title: "Durum", dataIndex: "isPaid" },
  ];
  const data = invoices.map((invoice) => ({
    id: invoice.id,
    fee: invoice.invoiceFee,
    month: invoice.invoiceMonth,
    year: invoice.invoiceYear,
    isPaid: invoice.isPaid === true ? "Ödendi" : "Borçlu",
  }));
  console.log(invoices);
  return (
    <div>
      <Table columns={columns} dataSource={data} size="small" />
    </div>
  );
}
