import React, { useState, useEffect } from "react";
import MessageService from "../../services/messageService";
import { Table } from "antd";

export default function MessageList() {
  const [sendingMessages, setSendingMessages] = useState([]);
  const [receivingMessages, setReceivingMessages] = useState([]);

  useEffect(() => {
    let messageService = new MessageService();
    let messages = messageService.getMessages();
    messages.then((result) =>
      setSendingMessages(result.data.result.entity.sendingList)
    );
    messages.then((result) =>
      setReceivingMessages(result.data.result.entity.recievingList)
    );
  }, []);
  const getColumns = [
    { title: "Gönderen", dataIndex: "senderEmail" },
    { title: "Başlık", dataIndex: "title" },
    { title: "içerik", dataIndex: "content" },
    { title: "Okunma durumu", dataIndex: "isRead" },
  ];
  const getData = receivingMessages.map((message) => ({
    senderEmail: message.senderEmail,
    receiverEmail: message.receiverEmail,
    title: message.title,
    content: message.content,
    isRead: message.isRead === true ? "Okundu" : "Okunmadı",
  }));
  const sendColumns = [
    { title: "Giden", dataIndex: "senderEmail" },
    { title: "Başlık", dataIndex: "title" },
    { title: "içerik", dataIndex: "content" },
    { title: "Okunma durumu", dataIndex: "isRead" },
  ];
  const sendData = sendingMessages.map((message) => ({
    senderEmail: message.senderEmail,
    receiverEmail: message.receiverEmail,
    title: message.title,
    content: message.content,
    isRead: message.isRead === true ? "Okundu" : "Okunmadı",
  }));
  return (
    <div>
      Gelen Mesajlar
      <Table columns={getColumns} dataSource={getData} size="small" />
<br />
      Giden Mesajlar
      <Table columns={sendColumns} dataSource={sendData} size="small" />
      
    </div>
  );
}
