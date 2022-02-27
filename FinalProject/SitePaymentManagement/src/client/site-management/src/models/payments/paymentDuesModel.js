export default class PaymentDuesModel{
    constructor(firstName,lastName,cardNumber,fee,paymentId){
        this.firstName=firstName;
        this.lastName = lastName;
        this.cardNumber = cardNumber;
        this.fee = fee;
        this.paymentId = paymentId;
        this.paymentType = 2;
    }
}