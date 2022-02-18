using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResidenceManagement.Application.Contracts.Repositories;
using ResidenceManagement.Application.Features.Commands.ResidenceInvoices.AddResidenceInvoice;
using ResidenceManagement.Application.Features.Commands.ResidenceInvoices.AddResidenceInvoiceRange;
using ResidenceManagement.Application.Features.Commands.ResidenceInvoices.DeleteResidenceInvoice;
using ResidenceManagement.Application.Features.Commands.ResidenceInvoices.UpdateResidenceInvoice;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ResidenceManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResidenceInvoicesController : ControllerBase
    {
        private IMediator _mediator;
        private readonly IResidenceInvoiceRepository _invoiceRepository;
        private readonly IMapper _mapper;

        public ResidenceInvoicesController(IMapper mapper, IResidenceInvoiceRepository invoiceRepository, IMediator mediator)
        {
            _mapper = mapper;
            _invoiceRepository = invoiceRepository;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list = await _invoiceRepository.GetAllAsync();
            return Ok((list));
        }

        [HttpPost]
        public IActionResult Add([FromQuery] AddResidenceInvoiceCommand request)
        {
            return Ok(_mediator.Send(request));
        }

        [HttpDelete]
        public IActionResult Add([FromQuery] DeleteResidenceInvoiceCommand request)
        {
            return Ok(_mediator.Send(request));
        }

        [HttpPut]
        public IActionResult Update([FromQuery] UpdateResidenceInvoiceCommand request)
        {

            return Ok(_mediator.Send(request));
        }

        [HttpPost]
        [Route("AddRange")]
        public IActionResult AddRand([FromQuery] AddRangeResidenceInvoiceCommand request)
        {
            return Ok(_mediator.Send(request));
        }
    }


}
