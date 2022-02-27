import axios from "axios";
import AuthHeader from "./authHeader"
const API_URL = "https://localhost:44326/api/Auth/";

export default class AuthService {
  signIn(email, password) {
    return axios
      .post(API_URL + "SignIn", { email, password })
      .then((response) => {
        if (response.data) {
          localStorage.setItem("token", JSON.stringify(response.data));
        }
        return response.data;
      }).catch(err=>{console.log(err)});
  }
  signOut() {
    localStorage.removeItem("token");
  }

  signUp(email, firstName, lastName, carPlate, nationalId) {
    return axios.post(API_URL + "SignUp", {
      email,
      firstName,
      lastName,
      carPlate,
      nationalId,
    },{headers:AuthHeader()});
  }
}
