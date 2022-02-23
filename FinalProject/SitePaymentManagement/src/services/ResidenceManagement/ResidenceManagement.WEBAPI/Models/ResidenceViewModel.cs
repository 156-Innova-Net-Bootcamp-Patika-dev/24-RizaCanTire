namespace ResidenceManagement.WEBAPI.Models
{
    public class ResidenceViewModel
    {
        public int Block { get; set; }
        public int Floor { get; set; }
        public int DoorNumber { get; set; }
        public bool IsFull { get; set; }
        public int ResidenceTypeId { get; set; }
    }
}
