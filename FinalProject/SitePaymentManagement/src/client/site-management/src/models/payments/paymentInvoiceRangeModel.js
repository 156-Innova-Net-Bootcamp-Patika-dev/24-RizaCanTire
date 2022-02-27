export default class PaymentInvoiceRangeModel{
    constructor(firstName,lastName,cardNumber,fee,paymentType,paymentIds){
        this.firstName=firstName;
        this.lastName = lastName;
        this.cardNumber = cardNumber;
        this.fee = fee;
        this.paymentType = paymentType;
        this.paymentIds = paymentIds;
    }
}