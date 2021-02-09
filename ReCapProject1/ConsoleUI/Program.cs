using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReCapProject1.ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Marka {0} Model Yılı {1} Günlük Fiyatı {2} Açıklama {3}", car.BrandId, car.ModelYear, car.DailyPrice, car.Description);

            }

        }
    }
}
