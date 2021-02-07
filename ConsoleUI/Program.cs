using Business.Entity;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryDal());
            foreach (var car in carManager.GetAll())
            {
                Console.Write(car.Id+ "------------");
                Console.WriteLine(car.DailyPrice);
            }
        }
    }
}
