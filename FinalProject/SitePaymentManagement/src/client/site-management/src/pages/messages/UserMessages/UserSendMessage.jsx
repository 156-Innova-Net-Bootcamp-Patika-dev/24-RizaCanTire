import React,{useState} from 'react'
import { Button, Form, Input } from "antd";
import MessageService from '../../../services/messageService';

export default function SendMessage() {
  const [title, setTitle] = useState("");
  const [content, setContent] = useState("")


  const sendMessage = () => {
    let messageService = new MessageService();
    messageService.sendMessageUser(title,content);
  };

  const layout = {
    labelCol: { span: 7 },
    wrapperCol: { span: 8 },
  };
  return (
    <div>SendMessage
      <Form style={{}} name="basic" {...layout}>
       
        <Form.Item label="Başlık" name="title">
          <Input
            name="title"
            value={title}
            onInput={(e) => setTitle(e.target.value)}
          />
        </Form.Item>
        <Form.Item label="İçerik" name="content">
          <Input
            name="content"
            value={content}
            onInput={(e) => setContent(e.target.value)}
          />
        </Form.Item>
        
        <Form.Item
          wrapperCol={{
            offset: 8,
            span: 6,
          }}
        >
          <Button type="primary" htmlType="submit" onClick={sendMessage}>
            Mesaj Gönder
          </Button>
        </Form.Item>
      </Form>
    </div>
  )
}
