using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject1.Business.Abstract
{
   public interface ICarService
    {
        List<Car> GetAll();
        Car GeyById(int id);
        List<Car> GetAllByColorId(int id);
        List<Car> GetAllByBrandId(int id);        
        List<Car> GetByDailyPrice(int az, int cok);
    }
}
