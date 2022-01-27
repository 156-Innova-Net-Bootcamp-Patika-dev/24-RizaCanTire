using Application.Contracts.Repository;
using Domain.Entities;
using Infrastructure.Contracts.Repository.Common;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Contracts.Repository
{
    public class CategoryRepository : EntityRepositoryBase<Category, LibraryContext>, ICategoryRepository
    {
       
    }
}
