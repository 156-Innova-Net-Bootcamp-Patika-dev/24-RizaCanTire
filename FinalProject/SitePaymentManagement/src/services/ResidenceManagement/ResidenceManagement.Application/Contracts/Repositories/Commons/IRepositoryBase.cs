using ResidenceManagement.Domain.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ResidenceManagement.Application.Contracts.Repositories.Commons
{
    public interface IRepositoryBase<T> where T : EntityBase
    {
        Task<IReadOnlyList<T>> GetAllAsync();

        Task<T> GetAsync(Expression<Func<T, bool>> predicate);

        Task<IReadOnlyList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null,
                                       Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                       List<Expression<Func<T, object>>> includes = null,
                                       bool disableTracking = true, 
                                       string includeString = null, params Expression<Func<T, Object>>[] includeStrings);
        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetByIdsAsync(IEnumerable<int> ids);

        Task<T> AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);

        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(IEnumerable<T> entities);


        Task RemoveAsync(T entity);
        Task RemoveRangeAsync(IEnumerable<T> entities);
    }
}
