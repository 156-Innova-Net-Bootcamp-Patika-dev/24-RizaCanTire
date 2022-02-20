using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResidenceManagement.Application.Contracts.Repositories;
using ResidenceManagement.Application.Features.Commands.DuesControl.AddDues;
using ResidenceManagement.Application.Features.Commands.DuesControl.AddDuesRange;
using ResidenceManagement.Application.Features.Commands.DuesControl.DeleteDues;
using ResidenceManagement.Application.Features.Commands.DuesControl.UpdateDues;
using ResidenceManagement.Application.Features.Queries.DuesController.GetDues;
using System.Threading.Tasks;

namespace ResidenceManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DuesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public DuesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public IActionResult Add([FromQuery] AddDuesCommand request)
        {
            return Ok(_mediator.Send(request));
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_mediator.Send(new GetDuesListQuery()));
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery] DeleteDuesCommand request)
        {
            return Ok(_mediator.Send(request));
        }

        [HttpPut]
        public IActionResult Update([FromQuery] UpdateDuesCommand request)
        {
            return Ok(_mediator.Send(request));
        }

        [HttpPost]
        [Route("AddRange")]
        public IActionResult AddRange([FromQuery] AddDuesRangeCommand request)
        {
            return Ok(_mediator.Send(request));
        }
    }
}
