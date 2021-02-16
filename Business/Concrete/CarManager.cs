using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IResult Add(Car car)
        {
            if (car.DailyPrice <= 0)
            {
                return new ErrorResult("Aracın Günlük Bedeli 0dan büyük olmalıdır");
                
                
            } else if (car.Description.Length <= 2) {  
                
            // brand name ile brand id eşleştiremediğimden dolayı açıklamasını koşul olarak verdim.
              return new ErrorResult("Araba açıklaması 2 karakterden küçük olamaz");
            }
            else
            {
                _carDal.Add(car);
                
                return new SuccessResult(Messages.CarAdded);
            }
        }

        public IResult DeleteById(int id)
        {
            
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>();
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailDtos()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), "ürünler listelendi");
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int BrandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == BrandId),Messages.CarListed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int ColorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == ColorId),Messages.CarListed);
        }
    }
}
