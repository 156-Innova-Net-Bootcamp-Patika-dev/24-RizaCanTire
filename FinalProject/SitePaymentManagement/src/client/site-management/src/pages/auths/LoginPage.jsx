import React, { useState } from "react";
import { Button, Form, Input } from "antd";
import AuthService from "../../services/auths/authService";

export default function LoginPage({signIn}) {
  const [email, setEmail] = useState("");
  const [password, setPassword] = useState("");

  const  login =async () => {
    let authService = new AuthService();
    let auth =await authService.signIn(email, password);
    if(auth){
      signIn()
    }
  };

 
  const layout = {
    labelCol: { span: 28 },
    wrapperCol: { span: 28 },
  };
  return (
    <div style={{ width: "60%", margin: "auto", marginTop: "50px" }}>
      <Form style={{}} name="basic" {...layout}>
        <Form.Item label="Email" name="email">
          <Input
            name="email"
            value={email}
            onInput={(e) => setEmail(e.target.value)}
          />
        </Form.Item>
        <Form.Item label="Password" name="password">
          <Input
            name="password"
            value={password}
            onInput={(e) => setPassword(e.target.value)}
          />
        </Form.Item>

        <Form.Item>
          <Button type="primary" htmlType="submit" onClick={login}>
            Giriş Yap
          </Button>
        </Form.Item>
      </Form>
    </div>
  );
}
