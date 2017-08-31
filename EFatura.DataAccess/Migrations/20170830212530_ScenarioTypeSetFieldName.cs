using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFatura.DataAccess.Migrations
{
    public partial class ScenarioTypeSetFieldName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Scenario",
                table: "INDIVIDUAL_BILLS",
                newName: "SCENARIO_TYPE");

            migrationBuilder.RenameColumn(
                name: "Scenario",
                table: "CORPORATE_BILLS",
                newName: "SCENARIO_TYPE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SCENARIO_TYPE",
                table: "INDIVIDUAL_BILLS",
                newName: "Scenario");

            migrationBuilder.RenameColumn(
                name: "SCENARIO_TYPE",
                table: "CORPORATE_BILLS",
                newName: "Scenario");
        }
    }
}
