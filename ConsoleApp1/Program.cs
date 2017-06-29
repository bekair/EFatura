using EFatura.DataAccess.Base.DBContexts;
using EFatura.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            EFaturaDbContext _db = new EFaturaDbContext();

            Person me = new Person
            {
                //Address = new Address
                //{
                //    Neighbourhood = "Aziziye",
                //    Street = "Andrey Karlov",
                //    CountyID = 216,
                //    PostalCode = 06540,
                //    CityID = 6,
                //    BuildingName = "Bahar",
                //    BuildingNumber = 50,
                //    DoorNumber = 14,
                //},
                AddressID = 1,
                MobilePhone = "5554344444",
                Name = "Bekir",
                Surname = "Ali",
            };

            _db.People.Add(me);
            _db.SaveChanges();

            int a = 0;
        }
    }
}
