using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext rentCarContext = new TContext())
            {
                var addedCar = rentCarContext.Entry(entity);
                addedCar.State = EntityState.Added;
                rentCarContext.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext rentCarContext = new TContext())
            {
                var deletedCar = rentCarContext.Entry(entity);
                deletedCar.State = EntityState.Deleted;
                rentCarContext.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext rentCarContext = new TContext())
            {
                return rentCarContext.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext rentCarContext = new TContext())
            {
                return filter == null
                    ? rentCarContext.Set<TEntity>().ToList()
                    : rentCarContext.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext rentCarContext = new TContext())
            {
                var updatedCar = rentCarContext.Entry(entity);
                updatedCar.State = EntityState.Modified;
                rentCarContext.SaveChanges();
            }
        }
    }
}
