using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResidenceManagement.Application.Contracts.Repositories;
using ResidenceManagement.Application.Features.Commands.DuesController.AddDues;
using System.Threading.Tasks;

namespace ResidenceManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DuesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private IDuesRepository _repository;
        public DuesController(IMediator mediator, IDuesRepository repository)
        {
            _mediator = mediator;
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Add([FromQuery] AddDuesCommand request)
        {
            return Ok(_mediator.Send(request));
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _repository.GetAllAsync());
        }
    }
}
