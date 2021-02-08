using Business.Abstract;
using DataAccess.Abstract;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Entity
{
    public class CarManager : ICarService
    {

        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Arabanız sisteme eklenmiştir");
            }
            else
            {
                Console.WriteLine("Aracın Günlük Bedeli 0dan büyük olmalıdır");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int BrandId)
        {
            return _carDal.GetAll(c => c.BrandId == BrandId);
        }

        public List<Car> GetCarsByColorId(int ColorId)
        {
            return _carDal.GetAll(c => c.ColorId == ColorId);
        }
    }
}
