import axios from "axios"
import AuthHeader from "./auths/authHeader"
export default class UserInvoiceService{
    getResidenceInvoicesByUser(){
        return axios.get("https://localhost:44326/api/ResidenceInvoices/GetByUser",{headers:AuthHeader()}).then(result=>result.data.result)
      }
}