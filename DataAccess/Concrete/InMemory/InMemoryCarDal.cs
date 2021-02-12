using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { CarId=1,BrandId=1,ColorId=112,ModelYear="2010",DailyPrice=500,Description="Peugeot 508 Dizel Otomatik "},
                new Car { CarId=2,BrandId=2,ColorId=243,ModelYear="2015",DailyPrice=450,Description="Audi A3 Dizel Otomatik"},
                new Car { CarId=3,BrandId=1,ColorId=344,ModelYear="2020",DailyPrice=600,Description="Peugeot 3008 Dizel Otomatik"},
                new Car { CarId=4,BrandId=3,ColorId=2,ModelYear="2010",DailyPrice=200,Description="Opel Corsa Dizel Otomatik"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            _cars.Remove(carDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.BrandId == id).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carUpdate.BrandId = car.BrandId;
            carUpdate.ColorId = car.ColorId;
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;

        }
    }
}
