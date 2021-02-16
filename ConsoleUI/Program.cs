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
        {
            CarTest();

            // UserTest();
            //RentalTest();

        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetailDtos();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + " markalı " + car.ColorName + " renkli aracın günlük fiyatı : " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
      


        private static void UserTest()
        {
            UserManager usersManager = new UserManager(new EfUserDal());
            User user = new User
            {
                FirstName = "Özlem ",
                LastName = "Atay",
                Email = "ozlem@gmail.com",
                Password = "1478963"
            };
            usersManager.Add(user);
            
            var result = usersManager.GetAll();
            if (result.Success==true)
            {
                foreach (var users in result.Data)
                {
                    Console.WriteLine(users.FirstName + " " + users.LastName + "\n");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        private static void RentalTest()
        {
            RentalManager rentalsManager = new RentalManager(new EfRentalDal());
            DateTime rentDate = new DateTime(2017, 10, 6);
            DateTime returnDate = new DateTime(2018, 10, 18);
            Rental rentals = new Rental
            {
                CarId = 1,
                CustomerId = 1,
                RentDate = rentDate,
                ReturnDate = returnDate
            };
            var result = rentalsManager.Add(rentals);
            Console.WriteLine(result.Message);


        }



    }
}
