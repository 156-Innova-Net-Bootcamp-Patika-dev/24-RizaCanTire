using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResidenceManagement.Application.Contracts.Repositories;
using ResidenceManagement.Application.Features.Queries.Residences.GetResidences;
using ResidenceManagement.Domain.Entities.Managements;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ResidenceManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResidencesController : ControllerBase
    {
        private readonly IMediator _mediator;     

        public ResidencesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
           
            var result = _mediator.Send(new GetResidenceListQuery());
            return Ok(result);
        }
    }
}
