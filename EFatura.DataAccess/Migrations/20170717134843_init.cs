﻿using System;
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
                    COUNTY_NAME = table.Column<string>(nullable: false),
                    CITY_ID_FOREIGN = table.Column<long>(nullable: false)
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
                    COUNTRY_ID_FOREIGN = table.Column<long>(nullable: false),
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
                name: "PEOPLE",
                columns: table => new
                {
                    PERSON_ID_NUMBER = table.Column<long>(maxLength: 11, nullable: false),
                    ADDRESS_ID_FOREIGN = table.Column<long>(nullable: false),
                    DATE_OF_BIRTH = table.Column<DateTime>(nullable: false),
                    EMAIL = table.Column<string>(maxLength: 100, nullable: false),
                    GENDER = table.Column<int>(nullable: false),
                    JOB_PHONE = table.Column<string>(maxLength: 20, nullable: true),
                    MOBILE_PHONE = table.Column<string>(maxLength: 20, nullable: false),
                    NAME = table.Column<string>(maxLength: 50, nullable: false),
                    SURNAME = table.Column<string>(maxLength: 50, nullable: false),
                    TAX_IDENTIFICATION_NO = table.Column<string>(maxLength: 11, nullable: false),
                    WEB_SITE = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PEOPLE", x => x.PERSON_ID_NUMBER);
                    table.ForeignKey(
                        name: "FK_PEOPLE_ADDRESSES_ADDRESS_ID_FOREIGN",
                        column: x => x.ADDRESS_ID_FOREIGN,
                        principalTable: "ADDRESSES",
                        principalColumn: "ADDRESS_ID",
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
                name: "IX_COUNTIES_CITY_ID_FOREIGN",
                table: "COUNTIES",
                column: "CITY_ID_FOREIGN");

            migrationBuilder.CreateIndex(
                name: "IX_PEOPLE_ADDRESS_ID_FOREIGN",
                table: "PEOPLE",
                column: "ADDRESS_ID_FOREIGN");

            migrationBuilder.CreateIndex(
                name: "IX_PRODUCTS_CATEGORY_ID_FOREIGN",
                table: "PRODUCTS",
                column: "CATEGORY_ID_FOREIGN");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PEOPLE");

            migrationBuilder.DropTable(
                name: "PRODUCTS");

            migrationBuilder.DropTable(
                name: "ADDRESSES");

            migrationBuilder.DropTable(
                name: "CATEGORIES");

            migrationBuilder.DropTable(
                name: "COUNTIES");

            migrationBuilder.DropTable(
                name: "CITIES");

            migrationBuilder.DropTable(
                name: "COUNTRIES");
        }
    }
}