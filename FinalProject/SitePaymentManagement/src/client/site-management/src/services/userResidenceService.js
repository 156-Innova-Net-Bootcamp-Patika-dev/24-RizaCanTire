import axios from "axios";
import UserResidenceModel from "../models/userResidences/userResidenceModel";
import AuthHeader from "./auths/authHeader";
const url = "https://localhost:44326/api/UserResidences";

export default class UserResidenceService {
  getUserResidences() {
    return axios.get("https://localhost:44326/api/UserResidences",{headers:AuthHeader()});
  }

  addUserResidence(userId, residenceId,residentTypeId) {
      let userResidence = new UserResidenceModel(
          this.userId = userId,
          this.residenceId = residenceId,
          this.residentTypeId = residentTypeId
      );

      return axios.post(url,userResidence,{headers:AuthHeader()});
  }
}
