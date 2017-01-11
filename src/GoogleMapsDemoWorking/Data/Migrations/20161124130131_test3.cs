using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoogleMapsDemoWorking.Data.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "CoordinateModel",
                nullable: false);

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "CoordinateModel",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Longitude",
                table: "CoordinateModel",
                nullable: false);

            migrationBuilder.AlterColumn<decimal>(
                name: "Latitude",
                table: "CoordinateModel",
                nullable: false);
        }
    }
}
