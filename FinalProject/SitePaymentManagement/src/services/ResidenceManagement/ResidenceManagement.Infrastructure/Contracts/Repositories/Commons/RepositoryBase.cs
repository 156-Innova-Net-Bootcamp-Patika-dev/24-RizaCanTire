﻿using Microsoft.EntityFrameworkCore;
using ResidenceManagement.Application.Contracts.Repositories.Commons;
using ResidenceManagement.Domain.Commons;
using ResidenceManagement.Domain.Entities.Managements;
using ResidenceManagement.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ResidenceManagement.Infrastructure.Contracts.Repositories.Commons
{
    public class RepositoryBase<T> :IRepositoryBase<T> where T : EntityBase
    {
        private readonly SiteContext _dbContext;

        public RepositoryBase(SiteContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }
        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbContext.Set<T>().AddRangeAsync(entities);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task RemoveAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }


        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            var list = await _dbContext.Set<T>().ToListAsync();

            return list;

        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate = null)
        {
            return await _dbContext.Set<T>().Where(predicate).FirstOrDefaultAsync();
        }


        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }


        public async Task<IReadOnlyList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, List<Expression<Func<T, object>>> includes = null, bool disableTracking = true, string includeString = null, params Expression<Func<T, Object>>[] includeStrings)
        {
            IQueryable<T> query = _dbContext.Set<T>();
            if (disableTracking) query = query.AsNoTracking();

            if (includes != null) query = includes.Aggregate(query, (current, include) => current.Include(include));

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null)
                return await orderBy(query).ToListAsync();

            if (!string.IsNullOrWhiteSpace(includeString)) query = query.Include(includeString);

            if (includeStrings.Length > 0)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            return await query.ToListAsync();
        }



        public virtual async Task<IEnumerable<T>> GetByIdsAsync(IEnumerable<int> ids)
        {
            return await _dbContext.Set<IEnumerable<T>>().FindAsync(ids);
        }



        public async Task UpdateRangeAsync(IEnumerable<T> entities)
        {
            _dbContext.Entry(entities).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task RemoveRangeAsync(IEnumerable<T> entities)
        {
            _dbContext.Set<T>().RemoveRange(entities);
            await _dbContext.SaveChangesAsync();
        }

        
    }
}