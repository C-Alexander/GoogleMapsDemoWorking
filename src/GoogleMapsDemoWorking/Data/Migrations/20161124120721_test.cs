using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoogleMapsDemoWorking.Data.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SectorViewID",
                table: "CoordinateModel",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<float>(
                name: "Longitude",
                table: "CoordinateModel",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "Latitude",
                table: "CoordinateModel",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SectorViewID",
                table: "CoordinateModel");

            migrationBuilder.AlterColumn<int>(
                name: "Longitude",
                table: "CoordinateModel",
                nullable: false);

            migrationBuilder.AlterColumn<int>(
                name: "Latitude",
                table: "CoordinateModel",
                nullable: false);
        }
    }
}
