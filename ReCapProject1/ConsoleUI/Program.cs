using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
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
            Console.WriteLine("Yılmaz RentACar");
            CarManager carManager = new CarManager(new EfCarDal());

            Console.WriteLine(" TÜM ARAÇLAR ");
            foreach (var car in carManager.GetAll())
            {//select*from
               Console.WriteLine("Markası {0} Renk {1} Model Yılı {2} Günlük Fiyat {3} Açıklama {4}", car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

            Console.WriteLine("BrandId 1 olanlar");
            foreach (var car in carManager.GetCarsByBrandId(1))
            {//Id==1
                Console.WriteLine("Markası {0} Renk {1} Model  {2} Günlük Fiyat {3} Açıklama {4}", car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }



            Console.WriteLine(" ColorId 2 olanlar ");
            foreach (var car in carManager.GetCarsByColorId(2))
            {//ColorId==2
                Console.WriteLine("Araç {0} model , {1} fiyatı {2}", car.ModelYear, car.Description, car.DailyPrice);
            }



            Console.WriteLine(" Yeni Araç Ekleme ");
            CarManager carManageradd = new CarManager(new EfCarDal());
            carManageradd.Add(new Car { BrandId = 4, ColorId = 4, Id = 4, DailyPrice = 450, Description = "Honda", ModelYear = 2021 });

            foreach (var car in carManageradd.GetAll())
            {
                Console.WriteLine("Markası {0} Renk {1} Model {2} Günlük Fiyat {3} Acıklaması {4}", car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }

        }
    }
}
