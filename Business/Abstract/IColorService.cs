using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService:IServiceRepository<Color>
    {
        List<Color> GetColorsByColorName(string colorName);
        List<Color> GetColorsByColorId(int colorId);
    }
}
