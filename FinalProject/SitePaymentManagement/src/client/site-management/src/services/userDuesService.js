import axios from "axios"
import AuthHeader from "./auths/authHeader"
export default class UserDueservice{
    getResidenceDuesByUser(){
        return axios.get("https://localhost:44326/api/ResidenceDues/GetByUser",{headers:AuthHeader()}).then(result=>result.data.result)
      }
}