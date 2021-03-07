using Business.Abstract;
using Business.Constats;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class UsersManager:IUserService
    {
        IUserDal _userDal;
        public UsersManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(Users user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.Added);
        }
        public IResult Delete(Users user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.Deleted);
        }
        public IResult Update(Users user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<List<Users>> GetAll()
        {
            return new SuccessDataResult<List<Users>>(_userDal.GetAll());
        }

        public IDataResult<List<Users>> GetAllByUserId(int Id)
        {
            return new SuccessDataResult<List<Users>>(_userDal.GetAll(u => u.UserId == Id));
        }
    }
}
