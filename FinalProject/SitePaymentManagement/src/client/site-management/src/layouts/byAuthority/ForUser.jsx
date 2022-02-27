import React from "react";
import { Row, Col } from "antd";
import Userside from "../users/UserSide"
import UserDash from "../users/UserDash"

export default function ForUser() {
  return (
    <div>
      <b>Site Sakini</b>
     <Row>
        
        <Col xs={3} sm={4}>
           <Userside/>
         </Col>
         <Col xs={21} sm={20}>
         <UserDash/>
         </Col>
       </Row>
    </div>
  );
}
