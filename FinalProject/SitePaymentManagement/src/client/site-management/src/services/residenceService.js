import axios from "axios";
import ResidenceAddRangeModel from "../models/residences/residenceAddRangeModel";
import ResidenceModel from "../models/residences/residenceModel";
import AuthHeader from "./auths/authHeader";
export default class ResidenceService {
  getResidences() {
    return axios.get("https://localhost:44326/api/Residences",{headers:AuthHeader()});
  }

  addResidence(block, floor, doorNumber, residenceType) {
    let residence = new ResidenceModel(
      block,
      floor,
      doorNumber,
      residenceType
    );
    return axios.post("https://localhost:44326/api/Residences", residence,{headers:AuthHeader()}).then(res => {
      console.log(res);
      console.log(res.data);
    });
  }

  addResidenceRange(blockNumber,
    floorPerBlock,
    housePerBlock,
    residenceTypeId) {
    let residence = new ResidenceAddRangeModel(
      this.blockNumber = blockNumber,
      this.floorPerBlock = floorPerBlock,
      this.housePerBlock = housePerBlock,
      this.residenceTypeId = residenceTypeId
    );
    return axios.post("https://localhost:44326/api/Residences/range", residence,{headers:AuthHeader()}).then(res => {
      console.log(res);
      console.log(res.data);
    });
  }
}
