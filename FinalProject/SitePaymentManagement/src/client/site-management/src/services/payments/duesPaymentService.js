import axios from "axios";
import PaymentDuesModel from "../../models/payments/paymentDuesModel"
export default class DuesPaymentService{
    payDues(firstName, lastName,cardNumber,fee,paymentId)
    {
        let paymentModel = new PaymentDuesModel(firstName, lastName,cardNumber,fee,paymentId);
        return axios.post("https://localhost:44312/api/Payment",paymentModel).then(res=>console.log(res))
    }
}