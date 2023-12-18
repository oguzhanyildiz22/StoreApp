using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.Migrations
{
    public partial class Oguz3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2023, 12, 18, 16, 49, 1, 825, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2023, 12, 18, 16, 49, 1, 825, DateTimeKind.Local).AddTicks(9011));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2023, 12, 18, 16, 49, 1, 825, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2023, 12, 18, 16, 49, 1, 825, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2023, 12, 18, 16, 49, 1, 825, DateTimeKind.Local).AddTicks(9024));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2023, 12, 18, 16, 44, 31, 586, DateTimeKind.Local).AddTicks(4845));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2023, 12, 18, 16, 44, 31, 586, DateTimeKind.Local).AddTicks(4865));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2023, 12, 18, 16, 44, 31, 586, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2023, 12, 18, 16, 44, 31, 586, DateTimeKind.Local).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2023, 12, 18, 16, 44, 31, 586, DateTimeKind.Local).AddTicks(4876));
        }
    }
}
