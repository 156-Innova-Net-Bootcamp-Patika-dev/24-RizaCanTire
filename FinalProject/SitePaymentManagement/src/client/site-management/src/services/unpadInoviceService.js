import axios from "axios";
import AuthHeader from "./auths/authHeader";

export default class UnpaidInvoceService{
    getUnpaidInovices(){
        return axios.get("https://localhost:44326/api/ResidenceInvoices/GetUnpaidInvoice",{headers:AuthHeader()})
    }
}