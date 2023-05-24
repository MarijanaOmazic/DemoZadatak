using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoZadatak.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OIB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "BirthDate", "FirstName", "LastName", "OIB" },
                values: new object[,]
                {
                    { 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Darko", "Krofak", "01234567890" },
                    { 2, new DateTime(1998, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marko", "Markovic", "12345678900" },
                    { 3, new DateTime(1990, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zarko", "Zarkovic", "23456789001" },
                    { 4, new DateTime(1992, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Milo", "Hrnic", "34567890012" },
                    { 5, new DateTime(2001, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ana", "Klaric", "45678900123" },
                    { 6, new DateTime(2000, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kata", "Katic", "56789001234" },
                    { 7, new DateTime(1999, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ante", "Antic", "67890012345" },
                    { 8, new DateTime(1989, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivan", "Krolo", "78900123456" },
                    { 9, new DateTime(1993, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marijana", "Omazic", "89001234567" },
                    { 10, new DateTime(1970, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ivo", "Ivic", "90012345678" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
