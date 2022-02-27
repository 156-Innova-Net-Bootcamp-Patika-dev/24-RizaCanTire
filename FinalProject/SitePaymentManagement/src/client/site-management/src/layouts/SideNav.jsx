import React, { useState } from "react";
import { Menu, Button } from "antd";
import {
  MenuUnfoldOutlined,
  MenuFoldOutlined,
  PieChartOutlined,
  DesktopOutlined
} from "@ant-design/icons";
import { Link } from "react-router-dom";
const { SubMenu } = Menu;

export default function SideNav() {
  const [showShow, setShowShow] = useState(false);
  
  const toggleShow = () => {
    setShowShow(!showShow);
  };
  function handleResize() {
    window.innerWidth < 600 ? setShowShow(true) : setShowShow(false);
  }

  const [isAdmin, setIsAdmin] = useState(true);

  window.addEventListener("resize", handleResize);

  return (
    <div>
      
      <Button type="primary" onClick={toggleShow} style={{ marginBottom: 16 }}>
        {React.createElement(
          showShow.collapsed ? MenuUnfoldOutlined : MenuFoldOutlined
        )}
      </Button>
      <Menu
        className="hideMenu"
        defaultSelectedKeys={["1"]}
        defaultOpenKeys={["sub1"]}
        mode="inline"
        theme="light"
        inlineCollapsed={showShow}
      >
        <Menu.Item key="1" icon={<PieChartOutlined />}>
          <Link to="/">Site yönetimi</Link>
        </Menu.Item>
        { isAdmin ? <SubMenu key="apartman" icon={<DesktopOutlined />} title="Apartman">
          <Menu.Item>
            <Link to="apartman">Apartman</Link>
          </Menu.Item>
          <Menu.Item>
            <Link to="apartman/daire-ekle">Daire Ekle</Link>
          </Menu.Item>
          <Menu.Item>
            <Link to="apartman/blok-ekle">Blok Ekle</Link>
          </Menu.Item>
        </SubMenu> : null }
        
        <SubMenu key="dueses" icon={<DesktopOutlined />} title="Aidatlar">
          <Menu.Item>
            <Link to="aidat">Aidat Listesi</Link>
          </Menu.Item>
          <Menu.Item>
            <Link to="aidat/ekle">Aidat Ekle</Link>
          </Menu.Item>
          <Menu.Item>
            <Link to="aidat/toplu-ekle">Toplu Aidat Ekle</Link>
          </Menu.Item>
        </SubMenu>

        <SubMenu key="invoices" icon={<DesktopOutlined />} title="Faturalar">
          <Menu.Item>
            <Link to="fatura">Fatura Listesi</Link>
          </Menu.Item>
          <Menu.Item>
            <Link to="fatura/ekle">Fatura Ekle</Link>
          </Menu.Item>
          <Menu.Item>
            <Link to="fatura/toplu-ekle">Toplu Fatura Ekle</Link>
          </Menu.Item>
        </SubMenu>

        <SubMenu key="userResidences" icon={<DesktopOutlined />} title="Site Sakini">
          <Menu.Item>
            <Link to="site-sakini">Site Sakini Listesi</Link>
          </Menu.Item>
          <Menu.Item>
            <Link to="site-sakini/ekle">Site Sakini Ekle</Link>
          </Menu.Item>
        </SubMenu>

        <SubMenu key="residenceInvoices" icon={<DesktopOutlined />} title="Site Sakini Fatura">
          <Menu.Item>
            <Link to="site-sakini-fatura">Site Sakini Fatura Listesi</Link>
          </Menu.Item>
          <Menu.Item>
            <Link to="site-sakini-fatura/ekle">Site Sakini Fatura Ekle</Link>
          </Menu.Item>
          <Menu.Item>
            <Link to="site-sakini-fatura/toplu-ekle">Site Sakini Fatura Ekle</Link>
          </Menu.Item>
        </SubMenu>

        <SubMenu key="residenceDueses" icon={<DesktopOutlined />} title="Site Sakini Aidat">
          <Menu.Item>
            <Link to="site-sakini-aidat">Site Sakini Aidat Listesi</Link>
          </Menu.Item>
          <Menu.Item>
            <Link to="site-sakini-aidat/ekle">Site Sakini Aidat Ekle</Link>
          </Menu.Item>
          <Menu.Item>
            <Link to="site-sakini-aidat/toplu-ekle">Site Sakini Aidat Ekle</Link>
          </Menu.Item>
        </SubMenu>
        
        
      </Menu>
    </div>
  );
}
