using Application.Contracts.Repository;
using Application.Contracts.Services;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Contracts.Services
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;

        }
        public void Add(Category category)
        {
            _categoryRepository.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryRepository.Delete(category);
        }

        public List<Category> GetAll()
        {
            var list = _categoryRepository.GetAll();
            return list;
        }

        public List<Category> GetAllByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetBookDetails()
        {
            throw new NotImplementedException();
        }

        public List<Category> GetBookDetailsByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int categoryId)
        {
            return _categoryRepository.Get(c => c.Id == categoryId);
        }

        public void Update(Category category)
        {
            _categoryRepository.Update(category);
        }
    }
}
