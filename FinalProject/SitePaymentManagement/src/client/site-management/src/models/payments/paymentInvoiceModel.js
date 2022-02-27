export default class PaymentInvoiceModel{
    constructor(firstName,lastName,cardNumber,fee,paymentId,paymentType){
        this.firstName=firstName;
        this.lastName = lastName;
        this.cardNumber = cardNumber;
        this.fee = fee;
        this.paymentId = paymentId;
        this.paymentType = paymentType;
    }
}