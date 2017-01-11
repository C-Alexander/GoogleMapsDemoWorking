using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoogleMapsDemoWorking.Data.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Longitude",
                table: "CoordinateModel",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "Latitude",
                table: "CoordinateModel",
                nullable: false);
        }
    }
}
