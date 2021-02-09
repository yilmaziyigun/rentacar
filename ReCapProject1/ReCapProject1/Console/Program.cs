using ReCapProject1.Business.Concrete;
using ReCapProject1.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject1.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                System.Console.WriteLine("Modelyılı {0} Marka {1} Günlük Fiyatı {2} Tanımı {3}", car.ModelYear, car.BrandId, car.DailyPrice, car.Description);

            }

        }   
    }
}
        


   
