using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService:IServiceRepository<Color>
    {
        IDataResult<List<Color>> GetColorsByColorName(string colorName);
        IDataResult<List<Color>> GetColorsByColorId(int colorId);
    }
}
