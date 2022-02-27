import { Button } from "antd";
import React from "react";
export default function SiteHeader(props) {
 
  return (
    <div 
      style={{
        background: "#0092ff",
        width: "100%",
        height: "120px",
      }}
    >
    
      {props.check ? <Button onClick={props.checkLogin} style={{position: "absolute",
        right: "45px",marginTop:"25px"}}>Çıkış Yap</Button>:null}
      
      <p style={{ marginTop: "25px", color: "white" }}> Aidat  Uygulaması </p>
    </div>
  );
}
