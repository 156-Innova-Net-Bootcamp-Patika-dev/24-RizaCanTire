import "./App.css";
import SiteHeader from "./layouts/SiteHeader";
import { Row } from "antd";
import LoginPage from "./pages/auths/LoginPage";
import { useState } from "react";
import Main from "./layouts/Main";

function App() {
  const [isAuthenticated, setIsAuthenticated] = useState(false);
  function handleSignOut() {
    setIsAuthenticated(false);
    localStorage.removeItem("token");

  }
  function handleSignIn() {
    setIsAuthenticated(true);
  }

  return (
    <div className="App">
      <Row>
        <SiteHeader checkLogin={handleSignOut} check={isAuthenticated}  />
      </Row>

      {isAuthenticated ? <Main />:<LoginPage signIn={handleSignIn} />}
    </div>
  );
}

export default App;
