using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2023, 12, 18, 16, 55, 1, 597, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2023, 12, 18, 16, 55, 1, 597, DateTimeKind.Local).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2023, 12, 18, 16, 55, 1, 597, DateTimeKind.Local).AddTicks(5801));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "AddedDate",
                value: new DateTime(2023, 12, 18, 16, 55, 1, 597, DateTimeKind.Local).AddTicks(5806));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AddedDate", "Description", "Price", "ProductName", "Quantity" },
                values: new object[] { 19, new DateTime(2023, 12, 18, 16, 55, 1, 597, DateTimeKind.Local).AddTicks(5759), "High-performance computer", 17000m, "Computer", 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AddedDate", "Description", "Price", "ProductName", "Quantity" },
                values: new object[] { 1, new DateTime(2023, 12, 18, 16, 49, 1, 825, DateTimeKind.Local).AddTicks(8984), "High-performance computer", 17000m, "Computer", 10 });
        }
    }
}
