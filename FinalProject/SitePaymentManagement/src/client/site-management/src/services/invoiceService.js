import axios from "axios";
import InvoiceAddRangeModel from "../models/invoices/invoiceAddRangeModel";
import InvoiceModel from "../models/invoices/invoiceModel";
import AuthHeader from "./auths/authHeader";
const url = "https://localhost:44326/api/Invoices";

export default class InvoiceService {
  getInvoices() {
    return axios.get("https://localhost:44326/api/Invoices",{headers:AuthHeader()});
  }

  addInvoice(fee,month,year) {
      let invoice = new InvoiceModel(
          this.fee = fee,
          this.month = month,
          this.year = year
      );

      return axios.post(url,invoice,{headers:AuthHeader()});
  }

  addInvoiceRange(fee,year){
    let invoice = new InvoiceAddRangeModel(
      this.fee = fee,
      this.year = year
    );
    return axios.post(url+"/addrange",invoice,{headers:AuthHeader()});
  }
}
