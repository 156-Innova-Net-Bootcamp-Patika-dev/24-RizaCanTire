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
    public class BookService : IBookService
    {
        private IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void Add(Book entity)
        {
            _bookRepository.Add(entity);
        }

        public void Delete(Book entity)
        {
            _bookRepository.Delete(entity);
        }

        public List<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public List<Book> GetAllByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooksDetail()
        {
            return _bookRepository.GetBooksDetail();
        }

        public Book GetById(int bookId)
        {
            return _bookRepository.GetAll().SingleOrDefault(b=>b.Id==bookId);
        }

        public void Update(Book entity)
        {
            _bookRepository.Update(entity);
        }
    }
}