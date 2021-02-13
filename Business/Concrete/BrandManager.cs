using Business.Abstract;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void Add(Brand entity)
        {
            _brandDal.Add(entity);
        }

        public void Delete(Brand entity)
        {
            _brandDal.Delete(entity);
        }

        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public List<Brand> GetBrandsByBrandId(int brandId)
        {
            return _brandDal.GetAll(b => b.BrandId == brandId);
        }

        public List<Brand> GetBrandsByBrandName(string brandName)
        {
            return _brandDal.GetAll(b => b.BrandName == brandName);
        }

        public void Update(Brand entity)
        {
            _brandDal.Update(entity);
        }
    }
}
