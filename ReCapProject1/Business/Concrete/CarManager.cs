using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using ReCapProject1.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
       

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByDailyPrice(int az, int cok)
        {
            throw new NotImplementedException();
        }

        public Car GeyById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
