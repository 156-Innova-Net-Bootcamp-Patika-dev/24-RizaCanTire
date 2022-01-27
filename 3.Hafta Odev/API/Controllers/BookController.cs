using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Application.Contracts.Repository;
using Application.Contracts.Services;
using Application.Models;
using AutoMapper;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private IBookService _bookService;
        private readonly IMapper _mapper;

        public BookController(IBookService bookService,IMapper mapper)
        {
            _bookService = bookService;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult AddItem([FromBody] BookAddDto entity)
        {
            
            var result = _mapper.Map<Book>(entity);
            Console.WriteLine(result);
            _bookService.Add(result);
            return Ok();
        }

        [HttpGet]
        public List<BookDto> Get()
        {
            var list = _bookService.GetBooksDetail();
            return _mapper.Map<List<BookDto>>(list);
        }

        [HttpPut]
        public ActionResult Update([FromBody] BookUpdateDto entity)
        {
            var result = _mapper.Map<Book>(entity);
            _bookService.Update(result);
            return Ok();

        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var removeItem = _bookService.GetById(id);
            _bookService.Delete(removeItem);
            return Ok();

        }

    }
}