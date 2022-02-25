using MediatR;
using PaymentService.API.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace PaymentService.API.Features
{
    public class PaymentCommandHandler : IRequestHandler<PaymentCommad, bool>
    {
        private readonly CardRepository _cardRepository;

        public PaymentCommandHandler(CardRepository cardRepository)
        {
            _cardRepository = cardRepository;
        }

        public async Task<bool> Handle(PaymentCommad request, CancellationToken cancellationToken)
        {
            var checkCard = await _cardRepository.GetCardByCardNumber(request.CardNumber);
            if (checkCard == null) return false;
            if(request.LastName != checkCard.LastName && request.FirstName != checkCard.LastName) return false;
            if (request.Fee != checkCard.Balance) return false;
            throw new System.NotImplementedException();
        }
    }
}
