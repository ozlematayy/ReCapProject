using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {

            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
  
            return _carDal.GetAll(p => p.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(p => p.ColorId == colorId);
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0 || car.Description.Length > 2)
            {
                _carDal.Add(car);
                Console.WriteLine("Araba başarıyla eklendi.");
            }
            else
            {
                if (car.DailyPrice < 0)
                {
                    Console.WriteLine($"Lütfen günlük fiyat kısmını 0'dan büyük giriniz. Girdiğiniz değer : {car.DailyPrice}");
                }
                else if(car.Description.Length<2)
                {
                    Console.WriteLine($"Lütfen açıklama kısmına 2 karakterden fazla giriş yapınız. Yazılan açıklama : { car.Description}");
                }
            }
        }

        public List<CarDetailDto> GetCarDetailDtos()
        {
            return _carDal.GetCarDetailDtos();
        }
    }
}
