using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //AllBrandsTest();
            //CarDetailsTest();
            //AllCustomersTest();
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            foreach (var rental in rentalManager.GetRentalDetails().Data)
            {
                Console.WriteLine("{0} /// {1}", rental.BrandName,rental.CustomerId);
            }
        }

        private static void AllCustomersTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine("{0} /// {1}", customer.UserId, customer.CompanyName);
            }
        }

        private static void CarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine("{0} - {1} - {2} - {3}", car.BrandName, car.Description, car.ColorName, car.DailyPrice);
            }
        }

        private static void AllBrandsTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var car in brandManager.GetAllBrands().Data)
            {
                Console.WriteLine(car.BrandId + " " + car.BrandName);
            }
        }
    }
}
