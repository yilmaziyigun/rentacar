using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IRentacarService
    {
        IResult Add(Rentacar rentacar);
        IResult Delete(Rentacar rentacar);
        IResult Update(Rentacar rentacar);
        IDataResult<List<Rentacar>> GetAll();
    }
}
