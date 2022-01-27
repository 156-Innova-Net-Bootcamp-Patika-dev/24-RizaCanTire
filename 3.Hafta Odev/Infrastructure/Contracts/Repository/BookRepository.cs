using Application.Contracts.Repository;
using Domain.Entities;
using Infrastructure.Contracts.Repository.Common;
using Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Contracts.Repository
{
    public class BookRepository : EntityRepositoryBase<Book, LibraryContext>, IBookRepository
    {
       public List<Book> GetBooksDetail() 
        {
            using (var c = new LibraryContext())
            {
                return c.Books.Include(c => c.Author).Include(c=>c.Category).ToList();
            }
        }
    }
}
