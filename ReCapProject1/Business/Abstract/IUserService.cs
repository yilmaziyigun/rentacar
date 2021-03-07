using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Add(Users users);
        IResult Delete(Users users);
        IResult Update(Users users);
        IDataResult<List<Users>> GetAllByUserId(int Id);
        IDataResult<List<Users>> GetAll();
    }
} 