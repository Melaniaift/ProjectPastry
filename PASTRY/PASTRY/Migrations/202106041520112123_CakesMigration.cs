using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using PASTRY.Data;
using PASTRYInfrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace PASTRY.Migrations.MvcCake
{
    [DbContext(typeof(MvcCakeContext))]
    [Migration("_202106041520112123_CakesMigration")]
    public class _202106041520112123_CakesMigration : Migration
    {
        protected override void Up([NotNullAttribute] MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>("ImageCake", "Cake", nullable: true);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("ImageCake", "Cake");
        }

    }
}
