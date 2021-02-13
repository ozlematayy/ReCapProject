﻿using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var cars in carManager.GetCarDetailDtos())
            {
                Console.WriteLine(cars.ColorName+" renkli "+cars.BrandName+" markalı aracın günlük fiyatı : "+cars.DailyPrice);
            }

      
        }
    }
}
