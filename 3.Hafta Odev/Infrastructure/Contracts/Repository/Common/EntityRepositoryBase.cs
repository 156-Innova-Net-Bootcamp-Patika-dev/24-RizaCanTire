using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Application.Contracts.Repository;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Contracts.Repository.Common
{
    public class EntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : Domain.Common.EntityBase
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using(var context = new TContext())
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }
    }
}