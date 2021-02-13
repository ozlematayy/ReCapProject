using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService:IServiceRepository<Brand>
    {
        List<Brand> GetBrandsByBrandName(string brandName);
        List<Brand> GetBrandsByBrandId(int brandId);
    }
}
