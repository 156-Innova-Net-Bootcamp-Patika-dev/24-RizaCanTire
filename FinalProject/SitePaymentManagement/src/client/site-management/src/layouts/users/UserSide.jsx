import React, { useState } from "react";
import { Menu, Button } from "antd";
import {
  MenuUnfoldOutlined,
  MenuFoldOutlined,
  PieChartOutlined,
  DesktopOutlined,
} from "@ant-design/icons";
import { Link } from "react-router-dom";
const { SubMenu } = Menu;

export default function AddminSide() {
  const [showShow, setShowShow] = useState(false);

  const toggleShow = () => {
    setShowShow(!showShow);
  };
  function handleResize() {
    window.innerWidth < 600 ? setShowShow(true) : setShowShow(false);
  }

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
          <Link to="/">Site Sakini</Link>
        </Menu.Item>
        <SubMenu key="apartman/user" icon={<DesktopOutlined />} title="Apartman">
          <Menu.Item>
            <Link to="apartman/user">Dairem</Link>
          </Menu.Item>
          
        </SubMenu>

        <SubMenu key="dueses" icon={<DesktopOutlined />} title="Aidatlarım">
          <Menu.Item>
            <Link to="aidat/user">Aidat Listesi</Link>
          </Menu.Item>
          <Menu.Item>
            <Link to="aidat/user/aidat-odenmemis">Ödenmemiş Aidatlar</Link>
          </Menu.Item>
          <Menu.Item>
            <Link to="aidat/user/aidat-ode">Aidat Öde</Link>
          </Menu.Item>
          <Menu.Item>
            <Link to="aidat/user/toplu-aidat-ode">Toplu Aidat Öde</Link>
          </Menu.Item>
      
        </SubMenu>

        <SubMenu key="invoices" icon={<DesktopOutlined />} title="Faturalarım">
          <Menu.Item>
            <Link to="fatura/user">Fatura Listesi</Link>
          </Menu.Item>
          <Menu.Item>
            <Link to="fatura/user/fatura-odenmemis">Ödenmemiş Fatualar</Link>
          </Menu.Item>
          <Menu.Item>
            <Link to="fatura/user/fatura-ode">Fatura Öde</Link>
          </Menu.Item>
          <Menu.Item>
            <Link to="fatura/user/toplu-fatura-ode">Toplu-Fatura Öde</Link>
          </Menu.Item>
        </SubMenu>

        <SubMenu
          key="messages"
          icon={<DesktopOutlined />}
          title="Mesaj kutusu"
        >
          <Menu.Item>
            <Link to="mesaj/gelen-kutusu">Gelen Mesajlar</Link>
          </Menu.Item>
          <Menu.Item>
            <Link to="mesaj/gonder">Mesaj Yolla</Link>
          </Menu.Item>
          
        </SubMenu>

      </Menu>
    </div>
  );
}
