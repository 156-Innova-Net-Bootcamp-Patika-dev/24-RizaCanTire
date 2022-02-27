import axios from "axios";
import AuthHeader from "./auths/authHeader";

export default class UnpadDuesService{
    getUnpaidDues(){
        return axios.get("https://localhost:44326/api/ResidenceDues/GetUnpaidDues",{headers:AuthHeader()})
    }
}