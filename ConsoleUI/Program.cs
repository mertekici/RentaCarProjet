using Business.Entity;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Entity;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car
            {
                Id = 6,
                BrandId = 1,
                ColorId = 1,
                DailyPrice = -5,
                ModelYear = 2020,
                Description = "Cillop gibi araba"

            };
            carManager.Add(car);
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Id+"---------------"+car.DailyPrice+"------------"+car.Description);
            //} ;

        }
    }
}
