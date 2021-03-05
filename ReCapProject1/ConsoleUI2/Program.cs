using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI2
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            CarAllDetails(carManager);
            ColorDetails();
            BrandDetails();
            //  CarADD();
        }

        private static void BrandDetails()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
           /* Brand brand = new Brand() { BrandName = "Audi" };
            Brand brand2 = new Brand() { BrandName = "Citroen" };
            Brand brand3 = new Brand() { BrandName = "Hyundai" };

            brandManager.Add(brand);
            brandManager.Add(brand2);
            brandManager.Add(brand3);*/
            // brandManager.Delete(brand2);
            // brandManager.Update(brand3);
            foreach (var branddetail in brandManager.GetAll())
            {
                Console.WriteLine(branddetail.BrandName);
            }
        }

        private static void ColorDetails()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
           // Color color = new Color() { Id = 5, ColorName = "Gece Mavisi" };
            //Color color2 = new Color() { Id = 6, ColorName = "Gri" };
            //colorManager.Add(color);
            // colorManager.Add(color2);
            //  colorManager.Delete(color);
           // colorManager.Update(new Color { Id = 6, ColorName = "Metalik Gri" });
            foreach (var colorGetAll in colorManager.GetAll())
            {
                Console.WriteLine(colorGetAll.Id + "/" + colorGetAll.ColorName);
            }
        }

        private static void CarAllDetails(CarManager carManager)
        {
            Console.WriteLine(" TÜM ARAÇLAR ");
            foreach (var car in carManager.GetAll())
            {//select*from
                Console.WriteLine("Markası {0} Renk {1} Model Yılı {2} Günlük Fiyat {3} Açıklama {4}", car.BrandName, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }
        }

        private static void CarBrandDetail(CarManager carManager)
        {
            Console.WriteLine("BrandId 1 olanlar");
            foreach (var car in carManager.GetCarsByBrandId(1))
            {//BrandId==1
                Console.WriteLine("Markası {0} Renk {1} Model  {2} Günlük Fiyat {3} Açıklama {4}", car.BrandName, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }
        }

        private static void CarColorDetail(CarManager carManager)
        {
            Console.WriteLine(" ColorId 2 olanlar ");
            foreach (var car in carManager.GetCarsByColorId(2))
            {//ColorId==2
                Console.WriteLine("Araç {0} model , {1} fiyatı {2}", car.BrandName, car.ModelYear, car.Description, car.DailyPrice);
            }
        }

        private static void CarADD()
        {
            Console.WriteLine(" Yeni Araç Ekleme ");
            CarManager carManageradd = new CarManager(new EfCarDal());
            carManageradd.Add(new Car { BrandId = 6, ColorId = 4, Id = 8, DailyPrice = 250, BrandName = "Hyundai", Description = "i40", ModelYear = 2021 });
            // carManager.Update(new Car { Id = 2, DailyPrice = 350, Description = "Dizel Sedan" });
            foreach (var car in carManageradd.GetAll())
            {
                Console.WriteLine("Markası {0} Renk {1} Model {2} Günlük Fiyat {3} Acıklaması {4}", car.BrandName, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
            }
        }
    }
}
