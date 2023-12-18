using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2023, 12, 18, 11, 23, 21, 227, DateTimeKind.Local).AddTicks(4666));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2023, 12, 18, 11, 23, 21, 227, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2023, 12, 18, 11, 23, 21, 227, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2023, 12, 18, 11, 23, 21, 227, DateTimeKind.Local).AddTicks(4696));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2023, 12, 18, 11, 23, 21, 227, DateTimeKind.Local).AddTicks(4699));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2023, 12, 16, 18, 8, 47, 419, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2023, 12, 16, 18, 8, 47, 419, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2023, 12, 16, 18, 8, 47, 419, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2023, 12, 16, 18, 8, 47, 419, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2023, 12, 16, 18, 8, 47, 419, DateTimeKind.Local).AddTicks(251));
        }
    }
}
