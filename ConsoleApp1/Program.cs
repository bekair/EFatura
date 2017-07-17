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

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            EFaturaDbContext _db = new EFaturaDbContext();

            ICountryDAO countryDao = new CountryManager(_db);
            IPersonDAO personDao = new PersonManager(_db);
            ICompanyDAO companyDao = new CompanyManager(_db);
            ICategoryDAO categoryDao = new CategoryManager(_db);
            IProductDAO productDao = new ProductManager(_db);

            Category c = new Category()
            {
                ID = 1,
                CategoryName = "Mobilya",
                TopCategoryID = 0
            };
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

            //categoryDao.AddMore(c1, c2, c3, c4, c5);
            //categoryDao.Add(c);
            //Person me = new Person
            //{
            //    Address = new Address
            //    {
            //        Neighbourhood = "Aziziye",
            //        Street = "Andrey Karlov",
            //        CountyID = 216,
            //        PostalCode = "06540",
            //        CityID = (long)CitiesOfTurkey.Ankara,
            //        CountryID = (long)Countries.Turkey,
            //        BuildingName = "Bahar",
            //        BuildingNumber = 50,
            //        DoorNumber = 14,
            //    },
            //    //AddressID = 1,
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
            IEnumerable<Category> alinan = categoryDao.GetAll();
            IEnumerable<Person> kisiler = personDao.GetAll();

            int a = 0;

            Console.ReadLine();
        }
    }
}
