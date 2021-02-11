using Core.DataAccess.EntityFrameWork;
using DataAccess.Abstract;
using Entities.DTOs;
using Entities.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, MyDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (MyDatabaseContext myDatabaseContext=new MyDatabaseContext())
            {
                var sonuc = from c in myDatabaseContext.Cars
                            join b in myDatabaseContext.Brands
                            on c.BrandId equals b.BrandId
                            join color in myDatabaseContext.Colors
                            on c.ColorId equals color.ColorId
                            select new CarDetailDto
                            {
                                CarId=c.Id,
                                CarName=b.BrandName,
                                ColorName=color.ColorName,
                                ModelYear=c.ModelYear,
                                DailyPrice=c.DailyPrice
                            };

            return sonuc.ToList();
            }
            
        }
    }
}
