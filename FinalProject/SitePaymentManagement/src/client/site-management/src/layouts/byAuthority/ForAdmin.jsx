import React from "react";
import { Row, Col } from "antd";
import AdminDash from "../admins/AdminDash";
import AdminSide from "../admins/AdminSide";
export default function ForAdmin() {
  return (
    <div>
      <b> Admin Panel</b>
      <Row>
        <Col xs={3} sm={4}>
          <AdminSide />
        </Col>
        <Col xs={21} sm={20}>
          <AdminDash />
        </Col>
      </Row>
    </div>
  );
}
