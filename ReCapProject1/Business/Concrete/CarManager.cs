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


        public void Add(Car car)
        {
            if (car.Description.Length < 2 || car.DailyPrice <= 0)
            {

                Console.WriteLine("Araç ismini en az 2 karakter, günlük ücreti de 0'dan büyük olmalıdr.");

            }
            else
            {
                _carDal.Add(car);
            }

        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
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

        public Car GetById(int id)
        {
            return _carDal.Get(c => c.Id == id);
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public Car GeyById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
