import axios from "axios";
import ResidenceDuesAddRangeModel from "../models/residenceDueses/residenceDuesAddRangeModel";
import ResidenceDuesAddModel from "../models/residenceDueses/residenceDuesAddModel";
import AuthHeader from "./auths/authHeader";
export default class ResidenceDuesService {
  getResidenceDueses() {
    return axios.get("https://localhost:44326/api/ResidenceDues",{headers:AuthHeader()});
  }

  addResidenceDues(duesId,userResidenceId) {
    let residenceDues = new ResidenceDuesAddModel(duesId,userResidenceId);
    return axios
      .post("https://localhost:44326/api/ResidenceDues", residenceDues,{headers:AuthHeader()})
      .then((res) => {
        console.log(res);
        console.log(res.data);
      });
  }

  addResidenceDuesRange(
    year
  ) {
    let residenceDues = new ResidenceDuesAddRangeModel(
      (this.year = year)     
    );
    return axios
      .post("https://localhost:44326/api/ResidenceDues/AddRange", residenceDues,{headers:AuthHeader()})
      .then((res) => {
        console.log(res);
        console.log(res.data);
      });
  }

  getResidenceDuesesByUser(){
    return axios.get("https://localhost:44326/api/ResidenceDues/GetByUser",{headers:AuthHeader()})
  }
}
