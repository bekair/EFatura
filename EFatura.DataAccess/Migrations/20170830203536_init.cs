using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFatura.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATEGORIES",
                columns: table => new
                {
                    CATEGORY_ID = table.Column<long>(nullable: false),
                    CATEGORY_NAME = table.Column<string>(maxLength: 50, nullable: false),
                    TOP_CATEGORY = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIES", x => x.CATEGORY_ID);
                });

            migrationBuilder.CreateTable(
                name: "CORPORATE_BILLS",
                columns: table => new
                {
                    CORPORATE_BILL_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BILL_DATE = table.Column<DateTime>(nullable: false),
                    ORDER_ID_FOREIGN = table.Column<long>(nullable: true),
                    Scenario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CORPORATE_BILLS", x => x.CORPORATE_BILL_ID);
                });

            migrationBuilder.CreateTable(
                name: "COUNTRIES",
                columns: table => new
                {
                    COUNTRY_ID = table.Column<long>(nullable: false),
                    COUNTRY_NAME = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COUNTRIES", x => x.COUNTRY_ID);
                });

            migrationBuilder.CreateTable(
                name: "INDIVIDUAL_BILLS",
                columns: table => new
                {
                    INDIVIDUAL_BILL_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BILL_DATE = table.Column<DateTime>(nullable: false),
                    ORDER_ID_FOREIGN = table.Column<long>(nullable: true),
                    Scenario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INDIVIDUAL_BILLS", x => x.INDIVIDUAL_BILL_ID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCTS",
                columns: table => new
                {
                    PRODUCT_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CATEGORY_ID_FOREIGN = table.Column<long>(nullable: false),
                    DESCRIPTION = table.Column<string>(nullable: true),
                    DISCOUNT_RATE = table.Column<int>(nullable: false),
                    KDV_RATE = table.Column<int>(nullable: false),
                    PRODUCT_NAME = table.Column<string>(maxLength: 100, nullable: false),
                    STOCK_AMOUNT = table.Column<int>(nullable: false),
                    UNIT_PRICE = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTS", x => x.PRODUCT_ID);
                    table.ForeignKey(
                        name: "FK_PRODUCTS_CATEGORIES_CATEGORY_ID_FOREIGN",
                        column: x => x.CATEGORY_ID_FOREIGN,
                        principalTable: "CATEGORIES",
                        principalColumn: "CATEGORY_ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CITIES",
                columns: table => new
                {
                    CITY_ID = table.Column<long>(nullable: false),
                    CITY_NAME = table.Column<string>(nullable: true),
                    COUNTRY_ID_FOREIGN = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CITIES", x => x.CITY_ID);
                    table.ForeignKey(
                        name: "FK_CITIES_COUNTRIES_COUNTRY_ID_FOREIGN",
                        column: x => x.COUNTRY_ID_FOREIGN,
                        principalTable: "COUNTRIES",
                        principalColumn: "COUNTRY_ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "COUNTIES",
                columns: table => new
                {
                    COUNTY_ID = table.Column<long>(nullable: false),
                    CITY_ID_FOREIGN = table.Column<long>(nullable: false),
                    COUNTY_NAME = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COUNTIES", x => x.COUNTY_ID);
                    table.ForeignKey(
                        name: "FK_COUNTIES_CITIES_CITY_ID_FOREIGN",
                        column: x => x.CITY_ID_FOREIGN,
                        principalTable: "CITIES",
                        principalColumn: "CITY_ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ADDRESSES",
                columns: table => new
                {
                    ADDRESS_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AVENUE = table.Column<string>(nullable: true),
                    BUILDING_NAME = table.Column<string>(nullable: true),
                    BUILDING_NUMBER = table.Column<int>(nullable: false),
                    CITY_ID_FOREIGN = table.Column<long>(nullable: false),
                    COUNTRY_ID_FOREIGN = table.Column<long>(nullable: true),
                    COUNTY_ID_FOREIGN = table.Column<long>(nullable: false),
                    DISTRICT = table.Column<string>(nullable: true),
                    DOOR_NUMBER = table.Column<int>(nullable: false),
                    NEIGHBOURHOOD = table.Column<string>(nullable: false),
                    POSTAL_CODE = table.Column<string>(nullable: true),
                    STREET = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ADDRESSES", x => x.ADDRESS_ID);
                    table.ForeignKey(
                        name: "FK_ADDRESSES_CITIES_CITY_ID_FOREIGN",
                        column: x => x.CITY_ID_FOREIGN,
                        principalTable: "CITIES",
                        principalColumn: "CITY_ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ADDRESSES_COUNTRIES_COUNTRY_ID_FOREIGN",
                        column: x => x.COUNTRY_ID_FOREIGN,
                        principalTable: "COUNTRIES",
                        principalColumn: "COUNTRY_ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ADDRESSES_COUNTIES_COUNTY_ID_FOREIGN",
                        column: x => x.COUNTY_ID_FOREIGN,
                        principalTable: "COUNTIES",
                        principalColumn: "COUNTY_ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "COMPANIES",
                columns: table => new
                {
                    COMPANY_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ADDRESS_ID_FOREIGN = table.Column<long>(nullable: false),
                    COMPANY_NAME = table.Column<string>(maxLength: 150, nullable: false),
                    CUSTOMER_TYPE = table.Column<int>(nullable: false),
                    FAX_NUMBER = table.Column<string>(maxLength: 20, nullable: false),
                    MERNIS_NO = table.Column<string>(maxLength: 20, nullable: false),
                    PHONE_NUMBER = table.Column<string>(maxLength: 20, nullable: false),
                    TAX_IDENTIFICATION_NO = table.Column<string>(maxLength: 20, nullable: false),
                    TAX_OFFICE = table.Column<string>(maxLength: 100, nullable: false),
                    TRADE_REGISTER_NO = table.Column<string>(maxLength: 20, nullable: false),
                    WEB_SITE = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_COMPANIES", x => x.COMPANY_ID);
                    table.ForeignKey(
                        name: "FK_COMPANIES_ADDRESSES_ADDRESS_ID_FOREIGN",
                        column: x => x.ADDRESS_ID_FOREIGN,
                        principalTable: "ADDRESSES",
                        principalColumn: "ADDRESS_ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "INDIVIDUALS",
                columns: table => new
                {
                    INDIVIDUAL_ID_NUMBER = table.Column<long>(maxLength: 11, nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ADDRESS_ID_FOREIGN = table.Column<long>(nullable: false),
                    COMPANY_ID_FOREIGN = table.Column<long>(nullable: true),
                    CUSTOMER_TYPE = table.Column<int>(nullable: false),
                    DATE_OF_BIRTH = table.Column<DateTime>(nullable: false),
                    EMAIL = table.Column<string>(maxLength: 100, nullable: false),
                    GENDER = table.Column<int>(nullable: false),
                    IS_WORKING = table.Column<int>(nullable: false),
                    JOB_PHONE = table.Column<string>(maxLength: 20, nullable: true),
                    MOBILE_PHONE = table.Column<string>(maxLength: 20, nullable: false),
                    NAME = table.Column<string>(maxLength: 50, nullable: false),
                    SURNAME = table.Column<string>(maxLength: 50, nullable: false),
                    TAX_IDENTIFICATION_NO = table.Column<string>(maxLength: 20, nullable: false),
                    WEB_SITE = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INDIVIDUALS", x => x.INDIVIDUAL_ID_NUMBER);
                    table.ForeignKey(
                        name: "FK_INDIVIDUALS_ADDRESSES_ADDRESS_ID_FOREIGN",
                        column: x => x.ADDRESS_ID_FOREIGN,
                        principalTable: "ADDRESSES",
                        principalColumn: "ADDRESS_ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_INDIVIDUALS_COMPANIES_COMPANY_ID_FOREIGN",
                        column: x => x.COMPANY_ID_FOREIGN,
                        principalTable: "COMPANIES",
                        principalColumn: "COMPANY_ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ORDERS",
                columns: table => new
                {
                    ORDER_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    COMPANY_ID_FOREIGN = table.Column<long>(nullable: true),
                    CorporateBillID = table.Column<long>(nullable: true),
                    IndividualBillID = table.Column<long>(nullable: true),
                    INDIVIDUAL_ID_FOREIGN = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDERS", x => x.ORDER_ID);
                    table.ForeignKey(
                        name: "FK_ORDERS_COMPANIES_COMPANY_ID_FOREIGN",
                        column: x => x.COMPANY_ID_FOREIGN,
                        principalTable: "COMPANIES",
                        principalColumn: "COMPANY_ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ORDERS_CORPORATE_BILLS_CorporateBillID",
                        column: x => x.CorporateBillID,
                        principalTable: "CORPORATE_BILLS",
                        principalColumn: "CORPORATE_BILL_ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ORDERS_INDIVIDUAL_BILLS_IndividualBillID",
                        column: x => x.IndividualBillID,
                        principalTable: "INDIVIDUAL_BILLS",
                        principalColumn: "INDIVIDUAL_BILL_ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ORDERS_INDIVIDUALS_INDIVIDUAL_ID_FOREIGN",
                        column: x => x.INDIVIDUAL_ID_FOREIGN,
                        principalTable: "INDIVIDUALS",
                        principalColumn: "INDIVIDUAL_ID_NUMBER",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ORDER_DETAILS",
                columns: table => new
                {
                    ORDER_DETAIL_ID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ORDER_ID_FOREIGN = table.Column<long>(nullable: false),
                    PRODUCT_ID_FOREIGN = table.Column<long>(nullable: false),
                    QUANTITY = table.Column<int>(nullable: false),
                    TOTAL_PRICE = table.Column<double>(nullable: false),
                    UNIT_PRICE = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORDER_DETAILS", x => x.ORDER_DETAIL_ID);
                    table.ForeignKey(
                        name: "FK_ORDER_DETAILS_ORDERS_ORDER_ID_FOREIGN",
                        column: x => x.ORDER_ID_FOREIGN,
                        principalTable: "ORDERS",
                        principalColumn: "ORDER_ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ORDER_DETAILS_PRODUCTS_PRODUCT_ID_FOREIGN",
                        column: x => x.PRODUCT_ID_FOREIGN,
                        principalTable: "PRODUCTS",
                        principalColumn: "PRODUCT_ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ADDRESSES_CITY_ID_FOREIGN",
                table: "ADDRESSES",
                column: "CITY_ID_FOREIGN");

            migrationBuilder.CreateIndex(
                name: "IX_ADDRESSES_COUNTRY_ID_FOREIGN",
                table: "ADDRESSES",
                column: "COUNTRY_ID_FOREIGN");

            migrationBuilder.CreateIndex(
                name: "IX_ADDRESSES_COUNTY_ID_FOREIGN",
                table: "ADDRESSES",
                column: "COUNTY_ID_FOREIGN");

            migrationBuilder.CreateIndex(
                name: "IX_CITIES_COUNTRY_ID_FOREIGN",
                table: "CITIES",
                column: "COUNTRY_ID_FOREIGN");

            migrationBuilder.CreateIndex(
                name: "IX_COMPANIES_ADDRESS_ID_FOREIGN",
                table: "COMPANIES",
                column: "ADDRESS_ID_FOREIGN");

            migrationBuilder.CreateIndex(
                name: "IX_COUNTIES_CITY_ID_FOREIGN",
                table: "COUNTIES",
                column: "CITY_ID_FOREIGN");

            migrationBuilder.CreateIndex(
                name: "IX_INDIVIDUALS_ADDRESS_ID_FOREIGN",
                table: "INDIVIDUALS",
                column: "ADDRESS_ID_FOREIGN");

            migrationBuilder.CreateIndex(
                name: "IX_INDIVIDUALS_COMPANY_ID_FOREIGN",
                table: "INDIVIDUALS",
                column: "COMPANY_ID_FOREIGN");

            migrationBuilder.CreateIndex(
                name: "IX_ORDERS_COMPANY_ID_FOREIGN",
                table: "ORDERS",
                column: "COMPANY_ID_FOREIGN");

            migrationBuilder.CreateIndex(
                name: "IX_ORDERS_CorporateBillID",
                table: "ORDERS",
                column: "CorporateBillID");

            migrationBuilder.CreateIndex(
                name: "IX_ORDERS_IndividualBillID",
                table: "ORDERS",
                column: "IndividualBillID");

            migrationBuilder.CreateIndex(
                name: "IX_ORDERS_INDIVIDUAL_ID_FOREIGN",
                table: "ORDERS",
                column: "INDIVIDUAL_ID_FOREIGN");

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_DETAILS_ORDER_ID_FOREIGN",
                table: "ORDER_DETAILS",
                column: "ORDER_ID_FOREIGN");

            migrationBuilder.CreateIndex(
                name: "IX_ORDER_DETAILS_PRODUCT_ID_FOREIGN",
                table: "ORDER_DETAILS",
                column: "PRODUCT_ID_FOREIGN");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTS_CATEGORY_ID_FOREIGN",
                table: "PRODUCTS",
                column: "CATEGORY_ID_FOREIGN");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ORDER_DETAILS");

            migrationBuilder.DropTable(
                name: "ORDERS");

            migrationBuilder.DropTable(
                name: "PRODUCTS");

            migrationBuilder.DropTable(
                name: "CORPORATE_BILLS");

            migrationBuilder.DropTable(
                name: "INDIVIDUAL_BILLS");

            migrationBuilder.DropTable(
                name: "INDIVIDUALS");

            migrationBuilder.DropTable(
                name: "CATEGORIES");

            migrationBuilder.DropTable(
                name: "COMPANIES");

            migrationBuilder.DropTable(
                name: "ADDRESSES");

            migrationBuilder.DropTable(
                name: "COUNTIES");

            migrationBuilder.DropTable(
                name: "CITIES");

            migrationBuilder.DropTable(
                name: "COUNTRIES");
        }
    }
}
