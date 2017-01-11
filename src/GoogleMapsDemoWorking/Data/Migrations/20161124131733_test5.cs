using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GoogleMapsDemoWorking.Data.Migrations
{
    public partial class test5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SectorViewID",
                table: "CoordinateModel");

            migrationBuilder.AddColumn<int>(
                name: "SectorView",
                table: "CoordinateModel",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SectorView",
                table: "CoordinateModel");

            migrationBuilder.AddColumn<int>(
                name: "SectorViewID",
                table: "CoordinateModel",
                nullable: false,
                defaultValue: 0);
        }
    }
}
