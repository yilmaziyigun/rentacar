using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO_S;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentaCarDBContext>, ICarDal
    {
        public List<CarDetailsDTO> GetCarDetails()
        {
            using (RentaCarDBContext context = new RentaCarDBContext())
            {
                var result = from car in context.Cars
                             join color in context.Colors on car.ColorId equals color.Id
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             select new CarDetailsDTO
                             {
                                 CarId = car.Id,
                                 DailyPrice = (int)car.DailyPrice,
                             };
                return result.ToList();

            }
        }
    }
}
