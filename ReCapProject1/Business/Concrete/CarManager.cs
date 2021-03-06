using Business.Constats;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using ReCapProject1.Business.Abstract;
using System;
using System.Linq;
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


        public IResult Add(Car car)
        {
            if (car.Description.Length < 2 )
            {

                return new ErrorDataResult<Car>(Messages.BrandNameLimit);

            }
            if(car.DailyPrice <= 0)
            {
                return new ErrorDataResult<Car>(Messages.CheckDailyPrice);
            }

            _carDal.Add(car);
            return new SuccessResult(Messages.Added);

        }

        public IResult Delete(Car car)
        {
            return new SuccessResult(Messages.Deleted);
        }


        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<List<Car>> GetAllByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId));
        }

        public   IDataResult<List<Car>> GetAllByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId));
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }

        public IResult Update(Car car)
        {
            return new SuccessResult(Messages.Updated);
        }
    }
}
