using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.Migrations
{
    public partial class new3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2023, 12, 18, 18, 52, 17, 375, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2023, 12, 18, 18, 52, 17, 375, DateTimeKind.Local).AddTicks(4426));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2023, 12, 18, 18, 52, 17, 375, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                columns: new[] { "AddedDate", "ProductName" },
                values: new object[] { new DateTime(2023, 12, 18, 18, 52, 17, 375, DateTimeKind.Local).AddTicks(4431), "Desk" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AddedDate", "Description", "Price", "ProductName", "Quantity" },
                values: new object[] { 1, new DateTime(2023, 12, 18, 18, 52, 17, 375, DateTimeKind.Local).AddTicks(4405), "High-performance computer", 17000m, "Computer", 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "AddedDate", "ProductName" },
                values: new object[] { new DateTime(2023, 12, 18, 16, 55, 1, 597, DateTimeKind.Local).AddTicks(5806), "Deck" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "AddedDate", "Description", "Price", "ProductName", "Quantity" },
                values: new object[] { 19, new DateTime(2023, 12, 18, 16, 55, 1, 597, DateTimeKind.Local).AddTicks(5759), "High-performance computer", 17000m, "Computer", 10 });
        }
    }
}
