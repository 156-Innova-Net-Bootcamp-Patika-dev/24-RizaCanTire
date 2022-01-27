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
    public class CategoryController : ControllerBase
    {
         ICategoryService _categoryService;
        private IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
         [HttpGet]
         public ActionResult<List<Category>> Get()
         {
             var list = _categoryService.GetAll();
             return Ok(list);
         }

         [HttpPost]
         public ActionResult AddCategory([FromBody] CategoryDto newCategory)
         {
             var category = _categoryService.GetAll().SingleOrDefault(c=>c.Name == newCategory.Name);
             if(category is not null)
                return BadRequest("Kategori sistemde mevcut");
            Category cat = new Category();
            cat.Name = newCategory.Name;
            _categoryService.Add(cat);
            return Ok("Ýþlem Baþarýlý");
         }
        [HttpPut]
        public ActionResult Update([FromBody] CategoryDto updateCategory)
        {
            var result = _categoryService.GetById(updateCategory.Id);
            if (result == null)
                return BadRequest("Kategori sistemde bulunamadý.");
            _categoryService.Update(_mapper.Map<Category>(updateCategory));
            return Ok("Ýþlem Baþarýlý");
        }


        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var removeItem = _categoryService.GetById(id);
            if (removeItem is null)
                return BadRequest("Kategori sistemde bulunamadý.");
            _categoryService.Delete(removeItem);
            return Ok("Ýþlem Baþarýlý");

        }

    }
}