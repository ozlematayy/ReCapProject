using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (RentCarContext rentCarContext = new RentCarContext())
            {
                var addedBrand = rentCarContext.Entry(entity);
                addedBrand.State = EntityState.Added;
                rentCarContext.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (RentCarContext rentCarContext = new RentCarContext())
            {
                var deletedBrand = rentCarContext.Entry(entity);
                deletedBrand.State = EntityState.Added;
                rentCarContext.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter = null)
        {
            using (RentCarContext rentCarContext = new RentCarContext())
            {
                return rentCarContext.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (RentCarContext rentCarContext = new RentCarContext())
            {
                return filter == null
                    ? rentCarContext.Set<Brand>().ToList()
                    : rentCarContext.Set<Brand>().Where(filter).ToList();
            }
        }

        public void Update(Brand entity)
        {
            using (RentCarContext rentCarContext = new RentCarContext())
            {
                var updatedBrand = rentCarContext.Entry(entity);
                updatedBrand.State = EntityState.Added;
                rentCarContext.SaveChanges();
            }
        }
    }
}
