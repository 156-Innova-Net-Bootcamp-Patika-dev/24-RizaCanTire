import React from "react";
import { Route,Routes } from 'react-router-dom'
import ResidenceAddRange from "../../pages/residences/ResidenceAddRange";
import ResidentDetail from "../../pages/residents/ResidentDetail";
import GetInvoices from "../../pages/residents/ResidentInvoices/GetInvoices";
import GetDueses from "../../pages/residents/ResidentDueses/GetDueses"
import MessageList from "../../pages/messages/MessageList";
import SendMessage from "../../pages/messages/UserMessages/UserSendMessage";
import InvoicePayment from "../../pages/payments/InvoicePayment";
import DuesPayment from "../../pages/payments/DuesPayment"
import InvoiceRangePayment from "../../pages/payments/rangePayments/InvoiceRangePayment";
export default function UserDash() {
  return (
    <div className="container">
     <Routes>
        <Route exact path="apartman/user" element={<ResidentDetail/>} />

        <Route exact path="aidat/user" element={<GetDueses/>} />
        <Route exact path="aidat/user/aidat-odenmemis" element={<DuesPayment/>} />
        <Route exact path="aidat/user/aidat-ode" element={<DuesPayment/>} />
        <Route exact path="aidat/user/toplu-aidat-ode" element={<DuesPayment/>} />

        <Route exact path="fatura/user" element={<GetInvoices/>} />
        <Route exact path="fatura/user/fatura-odenmemis" element={<ResidenceAddRange/>} />
        <Route exact path="fatura/user/fatura-ode" element={<InvoicePayment/>} />
        <Route exact path="fatura/user/toplu-fatura-ode" element={<InvoiceRangePayment/>} />

        <Route exact path="mesaj/gelen-kutusu" element={<MessageList/>} />
        <Route exact path="mesaj/gonder" element={<SendMessage/>} />
      </Routes>
    
    </div>
  );
}
