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

            //Country turkey = new Country()
            //{
            //    ID = 1,
            //    CountryName = "Turkey"
            //};
            //countryDao.Add(turkey);


            Person me = new Person
            {
                Address = new Address
                {
                    Neighbourhood = "Aziziye",
                    Street = "Andrey Karlov",
                    CountyID = 216,
                    PostalCode = "06540",
                    CityID = (long)CitiesOfTurkey.Ankara,
                    CountryID = (long)Countries.Turkey,
                    BuildingName = "Bahar",
                    BuildingNumber = 50,
                    DoorNumber = 14,
                },
                //AddressID = 1,
                MobilePhone = "5554344444",
                Name = "Can",
                Surname = "Baykal",
                Email = "can.baykal@example.com",
                Gender = Gender.Male,
                DateOfBirth = new DateTime(1992, 06, 05),
                TaxIdentificationNo = "5556789108"
            };

            personDao.Add(me);
            Person alınan = personDao.Get(q => q.ID == 1);


            int a = 0;
        }
    }
}
