import axios from "axios"
import AuthHeader from "./auths/authHeader"
export default class ResidentService{
    getResidenceDetail(){
        return axios.get("https://localhost:44326/api/UserResidences/GetByUser",{headers:AuthHeader()}).then(result=>result.data.result)
    }
}