using Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace DataAccess.Concrete
{

    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        public InMemoryCarDal()
        {

            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId = 1, ModelYear = 2021, ColorId = 1, DailyPrice = 300, Description = "Egea" },
            new Car { Id = 2, BrandId = 2, ModelYear = 2021, ColorId = 2, DailyPrice = 400, Description = "Mercedes" },
            new Car { Id = 3, BrandId = 3, ModelYear = 2021, ColorId = 3, DailyPrice = 400, Description = "BMW" }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(c=>car.Id==car.Id);
        }

        public Car Get(Expression<Func<Car, bool>> fiter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}   
