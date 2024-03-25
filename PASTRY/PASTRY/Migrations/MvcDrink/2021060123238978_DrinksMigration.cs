using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using PASTRY.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace PASTRY.Migrations.MvcDrink
{
    [DbContext(typeof(MvcDrinkContext))]
    [Migration("_2021060123238978_DrinksMigration")]
    public class _2021060123238978_DrinksMigration : Migration
    {
        protected override void Up([NotNullAttribute] MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>("ImageDrink", "Drink", nullable: true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("Age", "Employees");
        }

    }
}
