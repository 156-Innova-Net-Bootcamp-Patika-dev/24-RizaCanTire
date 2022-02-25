using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ResidenceManagement.Application.Features.Commands.ResidenceDuesControl.AddResidenceDues;
using ResidenceManagement.Application.Features.Commands.ResidenceDuesControl.AddResidenceDuesRange;
using ResidenceManagement.Application.Features.Commands.ResidenceDuesControl.DeleteResidenceDues;
using ResidenceManagement.Application.Features.Commands.ResidenceDuesControl.UpdateResidenceDues;
using ResidenceManagement.Application.Features.Queries.ResidenceDues.GetResidenceDues;
using ResidenceManagement.Application.Features.Queries.ResidenceDues.GetResidenceDuessByUser;

namespace ResidenceManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Admin")]

    public class ResidenceDuesController : ControllerBase
    {
        private IMediator _mediator;

        public ResidenceDuesController(IMediator mediator)
        {

            _mediator = mediator;
        }


        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_mediator.Send(new GetResidenceDuesListQuery()));
        }
        [HttpGet]
        [Route("GetByUser")]
        //[Authorize]


        public IActionResult GetByUser([FromBody] GetResidenceDuesByUserQuery request)
        {
            

            return Ok(_mediator.Send(request));
        }

        [HttpPost]
        //[Authorize(Roles = "Admin")]

        public IActionResult Add([FromBody] AddResidenceDuesCommand request)
        {
            return Ok(_mediator.Send(request));
        }

        [HttpDelete]
        //[Authorize(Roles = "Admin")]

        public IActionResult Delete([FromBody] DeleteResidenceDuesCommand request)
        {
            return Ok(_mediator.Send(request));
        }

        [HttpPut]
        //[Authorize(Roles = "Admin")]

        public IActionResult Update([FromBody] UpdateResidenceDuesCommand request)
        {

            return Ok(_mediator.Send(request));
        }

        [HttpPost]
        [Route("AddRange")]
        //[Authorize(Roles = "Admin")]

        public IActionResult AddRand([FromBody] AddRangeResidenceDuesCommand request)
        {
            return Ok(_mediator.Send(request));
        }
    }
}
