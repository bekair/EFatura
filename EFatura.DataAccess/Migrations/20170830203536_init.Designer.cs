using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EFatura.DataAccess.Base.DBContexts;
using EFatura.Core.EnumBase;

namespace EFatura.DataAccess.Migrations
{
    [DbContext(typeof(EFaturaDbContext))]
    [Migration("20170830203536_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFatura.Entities.Domain.Address", b =>
                {
                    b.Property<long?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ADDRESS_ID");

                    b.Property<string>("Avenue")
                        .HasColumnName("AVENUE");

                    b.Property<string>("BuildingName")
                        .HasColumnName("BUILDING_NAME");

                    b.Property<int>("BuildingNumber")
                        .HasColumnName("BUILDING_NUMBER");

                    b.Property<long?>("CityID")
                        .IsRequired()
                        .HasColumnName("CITY_ID_FOREIGN");

                    b.Property<long?>("CountryID")
                        .HasColumnName("COUNTRY_ID_FOREIGN");

                    b.Property<long?>("CountyID")
                        .IsRequired()
                        .HasColumnName("COUNTY_ID_FOREIGN");

                    b.Property<string>("District")
                        .HasColumnName("DISTRICT");

                    b.Property<int>("DoorNumber")
                        .HasColumnName("DOOR_NUMBER");

                    b.Property<string>("Neighbourhood")
                        .IsRequired()
                        .HasColumnName("NEIGHBOURHOOD");

                    b.Property<string>("PostalCode")
                        .HasColumnName("POSTAL_CODE");

                    b.Property<string>("Street")
                        .HasColumnName("STREET");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.HasIndex("CountryID");

                    b.HasIndex("CountyID");

                    b.ToTable("ADDRESSES");
                });

            modelBuilder.Entity("EFatura.Entities.Domain.Category", b =>
                {
                    b.Property<long?>("ID")
                        .HasColumnName("CATEGORY_ID");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnName("CATEGORY_NAME")
                        .HasMaxLength(50);

                    b.Property<long?>("TopCategoryID")
                        .IsRequired()
                        .HasColumnName("TOP_CATEGORY");

                    b.HasKey("ID");

                    b.ToTable("CATEGORIES");
                });

            modelBuilder.Entity("EFatura.Entities.Domain.City", b =>
                {
                    b.Property<long?>("ID")
                        .HasColumnName("CITY_ID");

                    b.Property<string>("CityName")
                        .HasColumnName("CITY_NAME");

                    b.Property<long?>("CountryID")
                        .IsRequired()
                        .HasColumnName("COUNTRY_ID_FOREIGN");

                    b.HasKey("ID");

                    b.HasIndex("CountryID");

                    b.ToTable("CITIES");
                });

            modelBuilder.Entity("EFatura.Entities.Domain.Company", b =>
                {
                    b.Property<long?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("COMPANY_ID");

                    b.Property<long?>("AddressID")
                        .IsRequired()
                        .HasColumnName("ADDRESS_ID_FOREIGN");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnName("COMPANY_NAME")
                        .HasMaxLength(150);

                    b.Property<int>("CustomerType")
                        .HasColumnName("CUSTOMER_TYPE");

                    b.Property<string>("FaxNumber")
                        .IsRequired()
                        .HasColumnName("FAX_NUMBER")
                        .HasMaxLength(20);

                    b.Property<string>("MernisNo")
                        .IsRequired()
                        .HasColumnName("MERNIS_NO")
                        .HasMaxLength(20);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnName("PHONE_NUMBER")
                        .HasMaxLength(20);

                    b.Property<string>("TaxIdentificationNo")
                        .IsRequired()
                        .HasColumnName("TAX_IDENTIFICATION_NO")
                        .HasMaxLength(20);

                    b.Property<string>("TaxOffice")
                        .IsRequired()
                        .HasColumnName("TAX_OFFICE")
                        .HasMaxLength(100);

                    b.Property<string>("TradeRegisterNo")
                        .IsRequired()
                        .HasColumnName("TRADE_REGISTER_NO")
                        .HasMaxLength(20);

                    b.Property<string>("WebSite")
                        .HasColumnName("WEB_SITE")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.HasIndex("AddressID");

                    b.ToTable("COMPANIES");
                });

            modelBuilder.Entity("EFatura.Entities.Domain.CorporateBill", b =>
                {
                    b.Property<long?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CORPORATE_BILL_ID");

                    b.Property<DateTime>("BillDate")
                        .HasColumnName("BILL_DATE");

                    b.Property<long?>("OrderID")
                        .HasColumnName("ORDER_ID_FOREIGN");

                    b.Property<int>("Scenario");

                    b.HasKey("ID");

                    b.ToTable("CORPORATE_BILLS");
                });

            modelBuilder.Entity("EFatura.Entities.Domain.Country", b =>
                {
                    b.Property<long?>("ID")
                        .HasColumnName("COUNTRY_ID");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnName("COUNTRY_NAME");

                    b.HasKey("ID");

                    b.ToTable("COUNTRIES");
                });

            modelBuilder.Entity("EFatura.Entities.Domain.County", b =>
                {
                    b.Property<long?>("ID")
                        .HasColumnName("COUNTY_ID");

                    b.Property<long?>("CityID")
                        .IsRequired()
                        .HasColumnName("CITY_ID_FOREIGN");

                    b.Property<string>("CountyName")
                        .IsRequired()
                        .HasColumnName("COUNTY_NAME");

                    b.HasKey("ID");

                    b.HasIndex("CityID");

                    b.ToTable("COUNTIES");
                });

            modelBuilder.Entity("EFatura.Entities.Domain.Individual", b =>
                {
                    b.Property<long?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("INDIVIDUAL_ID_NUMBER")
                        .HasMaxLength(11);

                    b.Property<long?>("AddressID")
                        .IsRequired()
                        .HasColumnName("ADDRESS_ID_FOREIGN");

                    b.Property<long?>("CompanyID")
                        .HasColumnName("COMPANY_ID_FOREIGN");

                    b.Property<int>("CustomerType")
                        .HasColumnName("CUSTOMER_TYPE");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnName("DATE_OF_BIRTH");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("EMAIL")
                        .HasMaxLength(100);

                    b.Property<int>("Gender")
                        .HasColumnName("GENDER");

                    b.Property<int>("IsWorking")
                        .HasColumnName("IS_WORKING");

                    b.Property<string>("JobPhone")
                        .HasColumnName("JOB_PHONE")
                        .HasMaxLength(20);

                    b.Property<string>("MobilePhone")
                        .IsRequired()
                        .HasColumnName("MOBILE_PHONE")
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("NAME")
                        .HasMaxLength(50);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnName("SURNAME")
                        .HasMaxLength(50);

                    b.Property<string>("TaxIdentificationNo")
                        .IsRequired()
                        .HasColumnName("TAX_IDENTIFICATION_NO")
                        .HasMaxLength(20);

                    b.Property<string>("WebSite")
                        .HasColumnName("WEB_SITE")
                        .HasMaxLength(100);

                    b.HasKey("ID");

                    b.HasIndex("AddressID");

                    b.HasIndex("CompanyID");

                    b.ToTable("INDIVIDUALS");
                });

            modelBuilder.Entity("EFatura.Entities.Domain.IndividualBill", b =>
                {
                    b.Property<long?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("INDIVIDUAL_BILL_ID");

                    b.Property<DateTime>("BillDate")
                        .HasColumnName("BILL_DATE");

                    b.Property<long?>("OrderID")
                        .HasColumnName("ORDER_ID_FOREIGN");

                    b.Property<int>("Scenario");

                    b.HasKey("ID");

                    b.ToTable("INDIVIDUAL_BILLS");
                });

            modelBuilder.Entity("EFatura.Entities.Domain.Order", b =>
                {
                    b.Property<long?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ORDER_ID");

                    b.Property<long?>("CompanyID")
                        .HasColumnName("COMPANY_ID_FOREIGN");

                    b.Property<long?>("CorporateBillID");

                    b.Property<long?>("IndividualBillID");

                    b.Property<long?>("IndividualID")
                        .HasColumnName("INDIVIDUAL_ID_FOREIGN");

                    b.HasKey("ID");

                    b.HasIndex("CompanyID");

                    b.HasIndex("CorporateBillID");

                    b.HasIndex("IndividualBillID");

                    b.HasIndex("IndividualID");

                    b.ToTable("ORDERS");
                });

            modelBuilder.Entity("EFatura.Entities.Domain.OrderDetail", b =>
                {
                    b.Property<long?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ORDER_DETAIL_ID");

                    b.Property<long?>("OrderID")
                        .IsRequired()
                        .HasColumnName("ORDER_ID_FOREIGN");

                    b.Property<long?>("ProductID")
                        .IsRequired()
                        .HasColumnName("PRODUCT_ID_FOREIGN");

                    b.Property<int>("Quantity")
                        .HasColumnName("QUANTITY");

                    b.Property<double>("TotalPrice")
                        .HasColumnName("TOTAL_PRICE");

                    b.Property<double>("UnitPrice")
                        .HasColumnName("UNIT_PRICE");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("ORDER_DETAILS");
                });

            modelBuilder.Entity("EFatura.Entities.Domain.Product", b =>
                {
                    b.Property<long?>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PRODUCT_ID");

                    b.Property<long?>("CategoryID")
                        .IsRequired()
                        .HasColumnName("CATEGORY_ID_FOREIGN");

                    b.Property<string>("Description")
                        .HasColumnName("DESCRIPTION");

                    b.Property<int>("DiscountRate")
                        .HasColumnName("DISCOUNT_RATE");

                    b.Property<int>("KdvRate")
                        .HasColumnName("KDV_RATE");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnName("PRODUCT_NAME")
                        .HasMaxLength(100);

                    b.Property<int>("StockAmount")
                        .HasColumnName("STOCK_AMOUNT");

                    b.Property<double>("UnitPrice")
                        .HasColumnName("UNIT_PRICE");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("PRODUCTS");
                });

            modelBuilder.Entity("EFatura.Entities.Domain.Address", b =>
                {
                    b.HasOne("EFatura.Entities.Domain.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EFatura.Entities.Domain.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryID");

                    b.HasOne("EFatura.Entities.Domain.County", "County")
                        .WithMany()
                        .HasForeignKey("CountyID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFatura.Entities.Domain.City", b =>
                {
                    b.HasOne("EFatura.Entities.Domain.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFatura.Entities.Domain.Company", b =>
                {
                    b.HasOne("EFatura.Entities.Domain.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFatura.Entities.Domain.County", b =>
                {
                    b.HasOne("EFatura.Entities.Domain.City", "City")
                        .WithMany("Counties")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFatura.Entities.Domain.Individual", b =>
                {
                    b.HasOne("EFatura.Entities.Domain.Address", "Address")
                        .WithMany("People")
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EFatura.Entities.Domain.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyID");
                });

            modelBuilder.Entity("EFatura.Entities.Domain.Order", b =>
                {
                    b.HasOne("EFatura.Entities.Domain.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyID");

                    b.HasOne("EFatura.Entities.Domain.CorporateBill")
                        .WithMany("Order")
                        .HasForeignKey("CorporateBillID");

                    b.HasOne("EFatura.Entities.Domain.IndividualBill")
                        .WithMany("Order")
                        .HasForeignKey("IndividualBillID");

                    b.HasOne("EFatura.Entities.Domain.Individual", "Individual")
                        .WithMany()
                        .HasForeignKey("IndividualID");
                });

            modelBuilder.Entity("EFatura.Entities.Domain.OrderDetail", b =>
                {
                    b.HasOne("EFatura.Entities.Domain.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EFatura.Entities.Domain.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EFatura.Entities.Domain.Product", b =>
                {
                    b.HasOne("EFatura.Entities.Domain.Category", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
