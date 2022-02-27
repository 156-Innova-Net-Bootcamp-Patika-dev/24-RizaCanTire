import { Row,Col } from 'antd'
import React from 'react'
import jwtDecode from "jwt-decode";
import ForUser from './byAuthority/ForUser';
import ForAdmin from './byAuthority/ForAdmin';

export default function Main() {
  var role;
  let token = localStorage.getItem("token")
  if(token){
    var user = jwtDecode(token);
    console.log(user);
    role = user.UserRole;
    console.log(role);
  }
  return (
    <div>
     {role==="Admin"?<ForAdmin/>:<ForUser/>}
       
    </div>
  )
}
