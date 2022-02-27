import axios from "axios";
import ResidenceInvoiceAddRangeModel from "../models/residenceInvoices/residenceInvoiceAddRangeModel";
import ResidenceInvoiceAddModel from "../models/residenceInvoices/residenceInvoiceAddModel";
import AuthHeader from "./auths/authHeader";
export default class ResidenceInvoiceService {
  getResidenceInvoices() {
    return axios.get("https://localhost:44326/api/ResidenceInvoices",{headers:AuthHeader()});
  }

  addResidenceInvoice(invoiceId,userResidenceId) {
    let residenceInvoice = new ResidenceInvoiceAddModel(invoiceId,userResidenceId);
    return axios
      .post("https://localhost:44326/api/ResidenceInvoices", residenceInvoice,{headers:AuthHeader()})
      .then((res) => {
        console.log(res);
        console.log(res.data);
      });
  }

  addResidenceInvoiceRange(
    year
  ) {
    let residenceInvoice = new ResidenceInvoiceAddRangeModel(
      (this.year = year)     
    );
    return axios
      .post("https://localhost:44326/api/ResidenceInvoices/AddRange", residenceInvoice,{headers:AuthHeader()})
      .then((res) => {
        console.log(res);
        console.log(res.data);
      });
  }

  
}
