using Business.Abstract;
using Business.Constats;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentacarManager:IRentacarService
    {
        IRentacarDal _rentacarDal;
        public RentacarManager(IRentacarDal rentalDal)
        {
            rentalDal = _rentacarDal;
        }

        public IResult Add(Rentacar rentacar)
        {
            if (rentacar.ReturnDate == null)
            {
                return new ErrorResult();
            }
            else
            {
                _rentacarDal.Add(rentacar);
                return new SuccessResult();
            }
        }

        public IResult Delete(Rentacar rentacar)
        {
            _rentacarDal.Delete(rentacar);
            return new SuccessResult(Messages.Deleted);
        }
        public IResult Update(Rentacar rentacar)
        {
            _rentacarDal.Update(rentacar);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<List<Rentacar>> GetAll()
        {
            return new SuccessDataResult<List<Rentacar>>(_rentacarDal.GetAll());
        }
    }
}
