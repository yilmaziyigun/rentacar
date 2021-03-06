using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject1.Business.Abstract
{
   public interface ICarService
    {
       IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
       IDataResult<List<Car>> GetAllByColorId(int id);
       IDataResult<List<Car>> GetAllByBrandId(int id);        
       //IDataResult<List<Car>> GetByDailyPrice(int az, int cok);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
