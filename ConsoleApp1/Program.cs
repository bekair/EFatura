using EFatura.DataAccess.Base.DBContexts;
using EFatura.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EFatura.DataAccess.Base.EntityFramework;
using EFatura.DataAccess.Base;
using EFatura.DataAccess.EntityAccessors;
using static EFatura.Core.EnumBase.EnumsArea;
using EFatura.Core.EnumBase;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            EFaturaDbContext _db = new EFaturaDbContext();

            ICountryDAO countryDao = new CountryManager(_db);
            IIndividualDAO personDao = new IndividualManager(_db);
            ICompanyDAO companyDao = new CompanyManager(_db);
            ICategoryDAO categoryDao = new CategoryManager(_db);
            IProductDAO productDao = new ProductManager(_db);
            ICityDAO cityDao = new CityManager(_db);

            Company comp = new Company()
            {
                MernisNo = "12345678910",
                PhoneNumber = "03124426891",
                TaxIdentificationNo = "111333222444",
                TaxOffice = "Baskent",
                TradeRegisterNo = "23456789123",
                FaxNumber = "03122223456",
                CompanyName = "Trust A.S",
                Address = new Address()
                {
                    BuildingName = "Burgan",
                    BuildingNumber = 50,
                    Neighbourhood = "Aziz",
                    DoorNumber = 20,
                    CityID = (long)CitiesOfTurkey.Adana,
                    CountryID = (long)Countries.Turkey,
                    CountyID = 945
                },
                WebSite = "test@example.com"
            };
            companyDao.AddAsync(comp);

            //Product prod = new Product()
            //{
            //    ProductName = "L koltuk",
            //    CategoryID = 1,
            //    UnitPrice = 10.1,
            //    KdvRate = 10,
            //    StockAmount = 10
            //};
            //Product prod1 = new Product()
            //{
            //    ProductName = "2. koltuk",
            //    CategoryID = 1,
            //    UnitPrice = 8.2,
            //    KdvRate = 18,
            //    StockAmount = 22,
            //    DiscountRate = 5
            //};
            //productDao.AddMoreAsync(prod, prod1);

            //Category c = new Category()
            //{
            //    ID = 1,
            //    CategoryName = "Mobilya",
            //    TopCategoryID = 0
            //};
            //Category c1 = new Category()
            //{
            //    ID = 2,
            //    CategoryName = "Koltuk",
            //    TopCategoryID = 1
            //};
            //Category c2 = new Category()
            //{
            //    ID = 3,
            //    CategoryName = "Masa",
            //    TopCategoryID = 1
            //};
            //Category c3 = new Category()
            //{
            //    ID = 4,
            //    CategoryName = "Elektronik Esya",
            //    TopCategoryID = 0
            //};
            //Category c4 = new Category()
            //{
            //    ID = 5,
            //    CategoryName = "Bilgisayar",
            //    TopCategoryID = 4
            //};
            //Category c5 = new Category()
            //{
            //    ID = 6,
            //    CategoryName = "Tablet",
            //    TopCategoryID = 4
            //};

            //categoryDao.AddMore(c, c1, c2, c3, c4, c5);
            //Person me = new Person
            //{
            //    AddressID = 1,
            //    MobilePhone = "5554344444",
            //    Name = "Can",
            //    Surname = "Baykal",
            //    Email = "can.baykal@example.com",
            //    Gender = Gender.Male,
            //    DateOfBirth = new DateTime(1992, 06, 05),
            //    TaxIdentificationNo = "5556789108"
            //};

            //personDao.Add(me);
            //Person alınan = personDao.Get(q => q.ID == 1);
            IEnumerable<Category> alinan = _db.Categories.Where(q => q.ID == 1).Include(cat=>cat.Products);
            Company company1 = companyDao.GetSingle(q => q.CompanyName == "Trust A.S");

            int a = 0;

            Console.ReadLine();
        }
    }
}
