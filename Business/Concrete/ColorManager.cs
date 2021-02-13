using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color entity)
        {
             _colorDal.Add(entity);
        }

        public void Delete(Color entity)
        {
            _colorDal.Delete(entity);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }


        public List<Color> GetColorsByColorId(int colorId)
        {
            return _colorDal.GetAll(c => c.ColorId == colorId);
        }

        public List<Color> GetColorsByColorName(string colorName)
        {
            return _colorDal.GetAll(c => c.ColorName == colorName);
        }

        public void Update(Color entity)
        {
            _colorDal.Update(entity);
        }
    }
}
