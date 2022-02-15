using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResidenceManagement.Application.Features.Queries.Residences.GetUserResidences;
using System;

namespace ResidenceManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserResidencesController : ControllerBase
    {
        private IMediator _mediator;

        public UserResidencesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var result = _mediator.Send(new GetUserResidenceListQuery());
            return Ok(result);
        }

       
    }
}
