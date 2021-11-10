using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BSM.Ticaret.BLL.Migrations
{
    public partial class KategoriBilgi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Kullanici",
                table: "Kategori",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Tarih",
                table: "Kategori",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kullanici",
                table: "Kategori");

            migrationBuilder.DropColumn(
                name: "Tarih",
                table: "Kategori");
        }
    }
}
