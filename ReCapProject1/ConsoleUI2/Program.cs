using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI2
{
    class Program
    {
        static void Main(string[] args)
        {

            CarAllDetails();
            // ColorDetails();
            // BrandDetails();
            //  CarADD();
            CustomerAllDetails();
            //CustomerAdd();
            //UserAdd();
            UserAllDetails();
            //RentacarAdd();
            //RentacarGetDetails();
        }

        private static void RentacarGetDetails()
        {
            RentacarManager rentacarManager = new RentacarManager(new EfRentacarDal());
            var result = rentacarManager.GetAll();
            Console.WriteLine("-------KİRALANMIŞ ARAÇ BİLGİSİ LİSTESİ----");
            if (result.Success == true)
            {
                foreach (var rentacar in result.Data)
                {
                    Console.WriteLine("Model bilgisi" + rentacar.CarId + " | "
                        + "Kullanıcı No = " + rentacar.CustomerId + " | "
                        + "Başlangıç Tarihi = " + rentacar.RentDate
                        + "Bitiş Tarihi =" + rentacar.ReturnDate);
                }
                Console.WriteLine(result.Message);
            }
        }

        private static void UserAllDetails()
        {
            UsersManager usersManager = new UsersManager(new EfUserDal());

            foreach (var user in usersManager.GetAll().Data)
            {
                Console.WriteLine("Kullanıcı Adı: " + user.FirstName + " - " + "Kullanıcı Mail: " + user.Email);
            }
        }

        private static void CustomerAdd()
        {
            CustomersManager customerManager = new CustomersManager(new EfCustomerDal());
            customerManager.Add(new Customer { CompanyName = "SoganSoft1", CustomerName = "Yilmaz1" });
        }

        private static void UserAdd()
            {
                UsersManager userManager = new UsersManager(new EfUserDal());
                userManager.Add(new Users { FirstName = "Yılmaz", LastName = "İyigün", Email = "yilmaz@yilmaz", Password = "321" });
            }

            private static void CustomerAllDetails()
            {
                CustomersManager customerManager = new CustomersManager(new EfCustomerDal());

                foreach (var customer in customerManager.GetAll().Data)
                {
                    Console.WriteLine("Müşteri Adı: "+customer.CustomerName+" - "+ "Şirket Adı: " + customer.CompanyName);
                }
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
                foreach (var branddetail in brandManager.GetAll().Data)
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
                foreach (var colorGetAll in colorManager.GetAll().Data)
                {
                    Console.WriteLine(colorGetAll.Id + "/" + colorGetAll.ColorName);
                }
            }

            private static void CarAllDetails()
            {
                CarManager carManager = new CarManager(new EfCarDal());
                Console.WriteLine(" TÜM ARAÇLAR ");
                foreach (var car in carManager.GetAll().Data)
                {//select*from
                    Console.WriteLine("Markası {0} Renk {1} Model Yılı {2} Günlük Fiyat {3} Açıklama {4}", car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
                }
            }

            private static void CarBrandDetail(CarManager carManager)
            {
                Console.WriteLine("BrandId 1 olanlar");
                foreach (var car in carManager.GetAllByBrandId(1).Data)
                {//BrandId==1
                    Console.WriteLine("Markası {0} Renk {1} Model  {2} Günlük Fiyat {3} Açıklama {4}", car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
                }
            }

            private static void CarColorDetail(CarManager carManager)
            {
                Console.WriteLine(" ColorId 2 olanlar ");
                foreach (var car in carManager.GetAllByColorId(2).Data)
                {//ColorId==2
                    Console.WriteLine("Araç {0} model , {1} fiyatı {2}", car.BrandId, car.ModelYear, car.Description, car.DailyPrice);
                }
            }

            private static void CarADD()
            {
                Console.WriteLine(" Yeni Araç Ekleme ");
                CarManager carManageradd = new CarManager(new EfCarDal());
                //carManageradd.Add(new Car { BrandId = 6, ColorId = 4, Id = 8, DailyPrice = 250, Description = "i40", ModelYear = 2021 });
                // carManager.Update(new Car { Id = 2, DailyPrice = 350, Description = "Dizel Sedan" });
                foreach (var car in carManageradd.GetAll().Data)
                {
                    Console.WriteLine("Markası {0} Renk {1} Model {2} Günlük Fiyat {3} Acıklaması {4}", car.BrandId, car.ColorId, car.ModelYear, car.DailyPrice, car.Description);
                }
            }
        }

       /* private static void RentacarAdd()
        {
            RentacarManager rentacarManager = new RentacarManager(new EfRentacarDal());
            rentacarManager.Add(new Rentacar { RentacarId = 1, CarId = 1, CustomerId = 1, RentDate=System.DateTime.Now, ReturnDate=System.DateTime.Today});
        }*/
    }
