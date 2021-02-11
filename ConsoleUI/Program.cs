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

            foreach (var car in carManager.GetCarDetailDtos())
            {
                Console.WriteLine(car.CarId+"-"+car.CarName+"-"+car.ColorName+"-"+car.ModelYear+"-"+car.DailyPrice);
                Console.WriteLine("-------------------------------------------------");
            } 
        }
    }
}
