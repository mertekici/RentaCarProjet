using Core.Utilities.Results;
using Entities.DTOs;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>>  GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int BrandId);
        IDataResult<List<Car>> GetCarsByColorId(int ColorId);
        IResult Add(Car car);  // Void data döndürmeyeceğinden dolayı IResult yaptık onda data yok
        IDataResult<List<CarDetailDto>> GetCarDetailDtos();
        IResult DeleteById(int id);
    }
}
