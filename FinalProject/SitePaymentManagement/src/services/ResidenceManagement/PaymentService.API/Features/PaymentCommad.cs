using MediatR;

namespace PaymentService.API.Features
{
    public class PaymentCommad : IRequest<bool>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CardNumber { get; set; }
        public double Fee { get; set; }
    }
}
