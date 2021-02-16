using Business.Concrete;
using Business.Entity;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.Entity;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            UserManager userManager = new UserManager(new EfUserDal());
            //AddUser(userManager);
            //CarAdd(carManager);
            //CarDetailDtoView(carManager);
            var result =userManager.DeleteById(4);
            Console.WriteLine(result.Message);
        }

        private static void AddUser(UserManager userManager)
        {
            var a = userManager.Add(new User()
            {
                FirstName = "Palwin",
                LastName = "Lahey",
                Email = "palvinLahey@hotmail.com",
                Passwordd = "tsadamosadato"
            });
            Console.WriteLine(a.Message);
        }

        private static void CarAdd(CarManager carManager)
        {
            Car car = new Car();

            car.Id = 199;
            car.ModelYear = 2000;
            car.BrandId = 3;
            car.ColorId = 5;
            car.DailyPrice = 120;
            car.Description = "ucuz ve güncel";



            Console.WriteLine(carManager.Add(car).Message);
        }

        private static void CarDetailDtoView(CarManager carManager)
        {
            foreach (var car in carManager.GetCarDetailDtos().Data)
            {
                Console.WriteLine(car.CarId + "-" + car.CarName + "-" + car.ColorName + "-" + car.ModelYear + "-" + car.DailyPrice);
                Console.WriteLine("-------------------------------------------------");
            }
        }
    }
}
