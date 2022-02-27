import React from "react";
import { Route,Routes } from 'react-router-dom'
import ResidenceList from "../../pages/residences/ResidenceList"
import ResidenceAdd from "../../pages/residences/ResidenceAdd";
import ResidenceAddRange from "../../pages/residences/ResidenceAddRange";
import DuesList from "../../pages/dueses/DuesList";
import DuesAdd from "../../pages/dueses/DuesAdd";
import DuesAdRange from "../../pages/dueses/DuesAddRange";
import InvoiceList from "../../pages/invoices/InvoiceList";
import InvoiceAdd from "../../pages/invoices/InvoiceAdd";
import InvoiceAddRange from "../../pages/invoices/InvoiceAddRange";
import UserResidenceList from "../../pages/userResidences/UserResidenceList";
import UserResidenceAdd from "../../pages/userResidences/UserResidenceAdd";
import ResidenceInvoiceList from "../../pages/residenceInvoices/ResidenceInvoiceList";
import ResidenceInvoiceAdd from "../../pages/residenceInvoices/ResidenceInvoiceAdd";
import ResidenceInvoiceAddRange from "../../pages/residenceInvoices/ResidenceInvoiceAddRange";
import ResidenceDuesList from "../../pages/residenceDueses/ResidenceDuesList";
import ResidenceDuesAdd from "../../pages/residenceDueses/ResidenceDuesAdd";
import ResidenceDuesAddRange from "../../pages/residenceDueses/ResidenceDuesAddRange";
import UnpaidDuesList from "../../pages/dept/UnpaidDuesList";
import UnpaidInvoiceList from "../../pages/dept/UnpaidInvoiceList";
import MessageList from "../../pages/messages/MessageList";
import SendMessage from "../../pages/messages/SendMessage";

export default function AdminDash() {
  return (
    <div className="container">
     <Routes>
        <Route exact path="/apartman" element={<ResidenceList/>} />
        <Route exact path="apartman/daire-ekle" element={<ResidenceAdd/>} />
        <Route exact path="apartman/blok-ekle" element={<ResidenceAddRange/>} />
        <Route exact path="aidat" element={<DuesList/>} />
        <Route exact path="aidat/ekle" element={<DuesAdd/>} />
        <Route exact path="aidat/toplu-ekle" element={<DuesAdRange/>} />
        <Route exact path="fatura" element={<InvoiceList/>} />
        <Route exact path="fatura/ekle" element={<InvoiceAdd/>} />
        <Route exact path="fatura/toplu-ekle" element={<InvoiceAddRange/>} />

        <Route exact path="site-sakini" element={<UserResidenceList/>} />
        <Route exact path="site-sakini/ekle" element={<UserResidenceAdd/>} />

        <Route exact path="site-sakini-fatura" element={<ResidenceInvoiceList/>} />
        <Route exact path="site-sakini-fatura/ekle" element={<ResidenceInvoiceAdd/>} />
        <Route exact path="site-sakini-fatura/toplu-ekle" element={<ResidenceInvoiceAddRange/>} />

        <Route exact path="site-sakini-aidat" element={<ResidenceDuesList/>} />
        <Route exact path="site-sakini-aidat/ekle" element={<ResidenceDuesAdd/>} />
        <Route exact path="site-sakini-aidat/toplu-ekle" element={<ResidenceDuesAddRange/>} />

        <Route exact path="odenmemis-aidatlar" element={<UnpaidDuesList/>} />
        <Route exact path="odenmemis-faturalar" element={<UnpaidInvoiceList/>} />

        <Route exact path="mesaj/gelen-kutusu" element={<MessageList/>} />
        <Route exact path="mesaj/gonder" element={<SendMessage/>} />
      </Routes>

    </div>
  );
}
