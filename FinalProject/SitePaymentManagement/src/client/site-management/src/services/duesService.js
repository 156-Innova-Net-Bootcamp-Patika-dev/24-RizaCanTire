import axios from "axios";
import DuesAddRangeModel from "../models/dueses/duesAddRangeModel";
import DuesModel from "../models/dueses/duesModel";
import AuthHeader from "./auths/authHeader";
const url = "https://localhost:44326/api/Duesses";

export default class DuesService {
  getDueses() {
    return axios.get("https://localhost:44326/api/Duesses",{headers:AuthHeader()});
  }

  addDues(fee,month,year) {
      let dues = new DuesModel(
          this.fee = fee,
          this.month = month,
          this.year = year
      );

      return axios.post(url,dues,{headers:AuthHeader()});
  }

  addDuesRange(fee,year){
    let dues = new DuesAddRangeModel(
      this.fee = fee,
      this.year = year
    );
    return axios.post(url+"/addrange",dues,{headers:AuthHeader()});
  }
}
