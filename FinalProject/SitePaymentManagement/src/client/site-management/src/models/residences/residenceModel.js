export default class ResidenceModel{
    constructor(block,floor,doorNumber,residenceTypeId ) {
        this.block = block;
        this.floor = floor;
        this.doorNumber = doorNumber;
        this.isFull = false;
        this.residenceTypeId = residenceTypeId; 
      }
}