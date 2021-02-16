using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {/*
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetailDtos();
            if (result.Success == true)
            {
                foreach (var cars in carManager.GetCarDetailDtos().Data)
                {
                    Console.WriteLine(cars.BrandName + " markalı " + cars.ColorName + " renkli aracın günlük fiyatı : " + cars.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine( result.Message ); 
            }
            */
            Car car = new Car()
            {
                BrandId = 3,
                ColorId = 1,
                DailyPrice = 200,
                Description = "Manuel Benzin",
                ModelYear = "2015"
            };
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(car);

        }
    }
}
