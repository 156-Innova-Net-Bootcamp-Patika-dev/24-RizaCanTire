using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResidenceManagement.Application.Contracts.Repositories;
using ResidenceManagement.Application.Features.Commands.Invoices.AddInvoice;
using ResidenceManagement.Application.Features.Commands.Invoices.AddInvoiceRange;
using ResidenceManagement.Application.Features.Commands.Invoices.DeleteInvoice;
using ResidenceManagement.Application.Features.Commands.Invoices.UpdateInvoice;
using ResidenceManagement.Application.Models.Invoices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ResidenceManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]

    public class InvoicesController : ControllerBase
    {
        private IMediator _mediator;
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IMapper _mapper;

        public InvoicesController(IMediator mediator, IInvoiceRepository invoiceRepository, IMapper mapper)
        {
            _mediator = mediator;
            _invoiceRepository = invoiceRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list = await _invoiceRepository.GetAllAsync();
            return Ok(_mapper.Map<IReadOnlyList<InvoiceDto>>(list));
        }

        [HttpPost]
        public IActionResult Add([FromQuery] AddInvoiceCommand request)
        {
            return Ok(_mediator.Send(request));
        }

        [HttpDelete]
        public IActionResult Add([FromQuery] DeleteInvoiceCommand request)
        {
            return Ok(_mediator.Send(request));
        }

        [HttpPut]
        public IActionResult Update([FromQuery] UpdateInvoiceCommand request)
        {

            return Ok(_mediator.Send(request));
        }

        [HttpPost]
        [Route("AddRange")]
        public IActionResult AddRand([FromQuery] AddInvoiceRangeCommand request)
        {
            return Ok(_mediator.Send(request));
        }
    }
}
