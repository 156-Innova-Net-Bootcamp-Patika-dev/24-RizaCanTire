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
    public class AuthorService : IAuthorService
    {
        private IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public void Add(Author entity)
        {
            _authorRepository.Add(entity);
        }

        public void Delete(Author entity)
        {
            _authorRepository.Delete(entity);
        }

        public List<Author> GetAll()
        {
            return _authorRepository.GetAll();
        }

        public List<Author> GetAllByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Author GetById(int id)
        {
            return _authorRepository.Get(a=>a.Id == id);
        }

        public void Update(Author entity)
        {
            _authorRepository.Update(entity);
        }
    }
}