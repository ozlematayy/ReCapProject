using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService:IServiceRepository<Brand>
    {
        IDataResult<List<Brand>> GetBrandsByBrandName(string brandName);
        IDataResult<List<Brand>> GetBrandsByBrandId(int brandId);
    }
}
