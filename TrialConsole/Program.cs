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
using Microsoft.EntityFrameworkCore;

namespace TrialConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            EFaturaDbContext _db = new EFaturaDbContext();

            ICountryDAO countryDao = new CountryManager(_db);
            IIndividualDAO individualDao = new IndividualManager(_db);
            ICompanyDAO companyDao = new CompanyManager(_db);
            ICategoryDAO categoryDao = new CategoryManager(_db);
            IProductDAO productDao = new ProductManager(_db);
            ICityDAO cityDao = new CityManager(_db);
            IOrderDAO orderDao = new OrderManager(_db);
            IOrderDetailDAO orderDetailDao = new OrderDetailManager(_db);
            IAddressDAO addressDao = new AddressManager(_db);

            //Address address1 = new Address()
            //{
            //    BuildingName = "Burgan",
            //    BuildingNumber = 50,
            //    Neighbourhood = "Aziz",
            //    DoorNumber = 20,
            //    CityID = (long?)CitiesOfTurkey.Adana,
            //    CountryID = (long?)Countries.Turkey,
            //    CountyID = 945
            //};
            //addressDao.Add(address1);

            //Company comp = new Company()
            //{
            //    MernisNo = "12345678910",
            //    Address = address1,
            //    PhoneNumber = "03124426891",
            //    TaxIdentificationNo = "111333222444",
            //    TaxOffice = "Baskent",
            //    TradeRegisterNo = "23456789123",
            //    FaxNumber = "03122223456",
            //    CompanyName = "Trust A.S",
            //    WebSite = "test@example.com"
            //};
            //companyDao.Add(comp);


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


            //Product prod1 = new Product()
            //{
            //    ProductName = "L koltuk",
            //    CategoryID = 1,
            //    UnitPrice = 10.1,
            //    KdvRate = 10,
            //    StockAmount = 10
            //};
            //Product prod2 = new Product()
            //{
            //    ProductName = "2. koltuk",
            //    CategoryID = 1,
            //    UnitPrice = 8.2,
            //    KdvRate = 18,
            //    StockAmount = 22,
            //    DiscountRate = 5
            //};
            //productDao.AddMore(prod1, prod2);



            //Individual individual1 = new Individual
            //{
            //    AddressID = 1,
            //    MobilePhone = "5554344444",
            //    Name = "Can",
            //    Surname = "Baykal",
            //    Email = "can.baykal@example.com",
            //    Gender = Gender.Male,
            //    DateOfBirth = new DateTime(1992, 06, 05),
            //    TaxIdentificationNo = "5556789108",
            //    IsWorking = WorkingStatus.Working,
            //    CompanyID = 1
            //};

            //Individual individual2 = new Individual
            //{
            //    AddressID = 1,
            //    MobilePhone = "5300009876",
            //    Name = "Hande",
            //    Surname = "Türk",
            //    Email = "hande.turk@example.com",
            //    Gender = Gender.Female,
            //    DateOfBirth = new DateTime(1992, 06, 05),
            //    TaxIdentificationNo = "2234959167",
            //    IsWorking = WorkingStatus.NotWorking,
            //};
            //individualDao.AddMore(individual1, individual2);

            //Order order1 = new Order
            //{
            //    IndividualID = 1
            //};

            //Order order2 = new Order
            //{
            //    IndividualID = 1
            //};

            //Order order3 = new Order
            //{
            //    CompanyID = 1
            //};
            //orderDao.AddMore(order1, order2, order3);

            //OrderDetail orderDetail1 = new OrderDetail()
            //{
            //    OrderID = 1,
            //    ProductID = 1,
            //    Quantity = 2,
            //    UnitPrice = 10.1,
            //    TotalPrice = 20.2
            //};

            //OrderDetail orderDetail2 = new OrderDetail()
            //{
            //    OrderID = 1,
            //    ProductID = 2,
            //    Quantity = 3,
            //    UnitPrice = 8.2,
            //    TotalPrice = 24.6
            //};

            //OrderDetail orderDetail3 = new OrderDetail()
            //{
            //    OrderID = 2,
            //    ProductID = 1,
            //    Quantity = 1,
            //    UnitPrice = 10.1,
            //    TotalPrice = 10.1
            //};

            //OrderDetail orderDetail4 = new OrderDetail()
            //{
            //    OrderID = 2,
            //    ProductID = 2,
            //    Quantity = 5,
            //    UnitPrice = 8.2,
            //    TotalPrice = 41
            //};

            //OrderDetail orderDetail5 = new OrderDetail()
            //{
            //    OrderID = 3,
            //    ProductID = 1,
            //    Quantity = 2,
            //    UnitPrice = 10.1,
            //    TotalPrice = 20.2
            //};

            //OrderDetail orderDetail6 = new OrderDetail()
            //{
            //    OrderID = 3,
            //    ProductID = 2,
            //    Quantity = 3,
            //    UnitPrice = 8.2,
            //    TotalPrice = 24.6
            //};
            //orderDetailDao.AddMore(orderDetail1, orderDetail2, orderDetail3,
            //                       orderDetail4, orderDetail5, orderDetail6);

            //Individual individualAlinan = individualDao.GetSingle(q => q.ID == 1);
            //Company companyAlinan = companyDao.GetSingle(q => q.ID == 1);
            //Category categoryAlinan = _db.Categories.Include(cat => cat.Products).FirstOrDefault(q => q.ID == 1);
            //Order orderIndAlinan1 = _db.Orders.Include(o => o.Individual)
            //                                  .Include(d => d.OrderDetails)
            //                                  .FirstOrDefault(o => o.ID == 1);

            //Order orderIndAlinan2 = _db.Orders.Include(o => o.Individual)
            //                                  .Include(d => d.OrderDetails)
            //                                  .FirstOrDefault(o => o.ID == 2);

            //Order orderCompAlinan1 = _db.Orders.Include(o => o.Company)
            //                                   .Include(d => d.OrderDetails)
            //                                   .FirstOrDefault(o => o.ID == 3);

            ////ID = 2 olan birinin top category'sini getirmek
            //Category topCateg = _db.Categories.FirstOrDefault(q => q.ID ==
            //                                   (_db.Categories.FirstOrDefault(a => a.ID == 2).TopCategoryID));

            String d = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            Console.WriteLine(d);


            Console.ReadLine();
        }
    }
}
