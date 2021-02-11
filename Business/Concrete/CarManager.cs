using Business.Abstract;
using DataAccess.Abstract;
using Entities.DTOs;
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
            if (car.DailyPrice <= 0)
            {
                Console.WriteLine("Aracın Günlük Bedeli 0dan büyük olmalıdır");
                Console.WriteLine("Arabanız sisteme eklenmiştir");
            }else if (car.Description.Length<=2)
                Console.WriteLine("Araba açıklaması 2 karakterden küçük olamaz");
            // brand name ile brand id eşleştiremediğimden dolayı açıklamasını koşul olarak verdim.
            else
            {
                _carDal.Add(car);
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetailDtos()
        {
            return _carDal.GetCarDetails();
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
