import React, { useEffect, useState } from "react";
import ResidenceInvoiceService from "../../services/residenceInvoiceService";
import { Table } from "antd";

export default function ResidenceInvoiceList() {
  const [residenceInvoices, setResidenceInvoices] = useState([]);
  useEffect(() => {
    let residenceInvoiceService = new ResidenceInvoiceService();
    residenceInvoiceService
      .getResidenceInvoices()
      .then((result) => setResidenceInvoices(result.data.result.entity));
  }, []);
  const columns = [
    { title: "Fatura Yılı", dataIndex: "invoiceYear" },
    { title: "Fatura Ayı", dataIndex: "invoiceMonth" },
    { title: "Block", dataIndex: "userResidenceResidenceBlock" },
    { title: "Kat", dataIndex: "userResidenceResidenceFloor" },
    { title: "Daire No", dataIndex: "userResidenceResidenceDoorNumber" },
    { title: "Sakin Adı", dataIndex: "userResidenceUserFirstName" },
    { title: "Sakin Soyadı", dataIndex: "userResidenceUserLastName" },
    { title: "Ücret", dataIndex: "invoiceFee" },
    { title: "Ödeme durumu", dataIndex: "isPaid" },
    { title: "Oturan Tipi", dataIndex: "userResidenceResidentTypeType" }
  ];
  const data = residenceInvoices.map(residenceInvoice=>({
    invoiceYear : residenceInvoice.invoiceYear,
    invoiceMonth : residenceInvoice.invoiceMonth,
    userResidenceResidenceBlock : residenceInvoice.userResidenceResidenceBlock,
    userResidenceResidenceFloor : residenceInvoice.userResidenceResidenceFloor,
    userResidenceResidenceDoorNumber : residenceInvoice.userResidenceResidenceDoorNumber,
    userResidenceUserFirstName : residenceInvoice.userResidenceUserFirstName,
    userResidenceUserLastName : residenceInvoice.userResidenceUserLastName,
    invoiceFee : residenceInvoice.invoiceFee,
    isPaid : residenceInvoice.isPaid === true?"Ödedi":"Borçlu",
    userResidenceResidentTypeType : residenceInvoice.userResidenceResidentTypeType
  }))
  return <div className="container">
  <Table columns={columns} dataSource={data} size="small" />
</div>
}
