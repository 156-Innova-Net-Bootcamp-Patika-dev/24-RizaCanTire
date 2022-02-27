import axios from "axios";
import PaymentInvoiceModel from "../../models/payments/paymentInvoiceModel";
import PaymentInvoiceRangeModel from "../../models/payments/paymentInvoiceRangeModel";
export default class InvoicePaymentService{
    payInvoice(firstName, lastName,cardNumber,fee,paymentId)
    {
        let paymentModel = new PaymentInvoiceModel(firstName, lastName,cardNumber,fee,paymentId,1);
        return axios.post("https://localhost:44312/api/Payment",paymentModel).then(response => { 
            console.log(response)
        })
        .catch(error => {
            console.log(error.response)})
    }

    payInvoiceRange(firstName,lastName,cardNumber,fee,paymentType,paymentIds)
    {
        let paymentModel = new PaymentInvoiceRangeModel(firstName,lastName,cardNumber,fee,paymentType,paymentIds);
        return axios.post("https://localhost:44312/api/PaymentRange",paymentModel).then(response => { 
            console.log(response)
        })
        .catch(error => {
            console.log(error.response)})
    }
    
}