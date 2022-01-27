using System;
using System.Collections.Generic;
using System.Linq;
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
    public class AuthorController : ControllerBase
    {
        IAuthorService _authorService;
        private IMapper _mapper;

        public AuthorController(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        [HttpPost]
        public ActionResult AddItem([FromBody] AuthorDto entity)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = _mapper.Map<Author>(entity);
            _authorService.Add(result);
            return Ok();

        }

        [HttpGet]
        public ActionResult<List<AuthorDto>> Get()
        {
            var list = _authorService.GetAll();

            return Ok(_mapper.Map<List<AuthorDto>>(list));
        }

        [HttpPut]
        public ActionResult Update([FromBody] AuthorUpdateDto entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            else
            {
                var result = _mapper.Map<Author>(entity);
                _authorService.Update(result);
                return Ok();

            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            else
            {
                var removeItem = _authorService.GetById(id);
                _authorService.Delete(removeItem);
                return Ok();
            }

        }
    }
}