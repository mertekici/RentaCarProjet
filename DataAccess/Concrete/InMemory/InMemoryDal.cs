using DataAccess.Abstract;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryDal:IEntityRepository<Car>
    {
        List<Car> _myCars;        
        public InMemoryDal()
        {
           _myCars=new List<Car>
           {
            new Car { Id = 1, ColorId = 2, BrandId = 1, ModelYear = 2009, DailyPrice = 320, Description = "Kaput Çizik" },
            new Car { Id = 2, ColorId = 1, BrandId = 2, ModelYear = 2020, DailyPrice = 250, Description = "Doblo" },
            new Car { Id = 3, ColorId = 3, BrandId = 3, ModelYear = 2021, DailyPrice = 1000, Description = "Kaplaması sökük" },
            new Car { Id = 4, ColorId = 2, BrandId = 1, ModelYear = 2009, DailyPrice = 500, Description = "Kapı boyalı" },
            new Car { Id = 5, ColorId = 4, BrandId = 2, ModelYear = 2012, DailyPrice = 400, Description = "Bakımı yapıldı" },
            new Car { Id = 6, ColorId = 5, BrandId = 2, ModelYear = 2019, DailyPrice = 1500, Description = "tavan değişik" },
            };
        }

        public void Add(Car car)
        {
            _myCars.Add(car);
            Console.WriteLine("Arabanız Başarıyla Sisteme eklendi");
        }

        public void Delete(Car car)
        {
            Car DeleteToCar = _myCars.SingleOrDefault(c => c.Id == car.Id);
            _myCars.Remove(DeleteToCar);
            Console.WriteLine("Arabanız sistemden silinmiştir.");
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _myCars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            return _myCars.SingleOrDefault(c => c.Id == id);
        }

  
        public void Update(Car car)
        {
            Car UpdateToCar = _myCars.SingleOrDefault(c => c.Id == car.Id);
            UpdateToCar.Id = car.Id;
            UpdateToCar.BrandId = car.BrandId;
            UpdateToCar.ColorId = car.ColorId;
            UpdateToCar.DailyPrice = car.DailyPrice;
            UpdateToCar.Description = car.Description;
            UpdateToCar.ModelYear = car.ModelYear;
            Console.WriteLine("Arabanız sistemde güncellenmiştir.");
        }
    }
}
