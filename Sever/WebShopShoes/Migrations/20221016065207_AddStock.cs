using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopShoes.Migrations
{
    public partial class AddStock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "ProductDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8739), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8752), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8753) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8754), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8755), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9030), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9031), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9033), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9034), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9035), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9035) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9036), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9037), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9038), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9039), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9040), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9041) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9041), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9042), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9044), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9044) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9045), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9045) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9046), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9047), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9048), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9049), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9050), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9050) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9052), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9053), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9054), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9055), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9055) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9056), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9056) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9057), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9058), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9059) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8866), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8869), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8870), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8872), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8873), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8874), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8874) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8875), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8876), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8878), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8879), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8880), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8881), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8882), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8883), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8885), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8886), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8888), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8889), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8890), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8891), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8893), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8894), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8895), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8896), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8897), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8898), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8922), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8925), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8927), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8929), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8930), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8932), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8933), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8935), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8939), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8940), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8942), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8944), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8946), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8947), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8948), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8950), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8993), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8993) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8995), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8996), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8999), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9000), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9002), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9003), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9005), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9006), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "Stock", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9008), 50, new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9077), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9078) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9080), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9081), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9083), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9083) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9084), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9084) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9085), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9085) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9086), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9087) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9087), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9089), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9089) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9090), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9091) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9091), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9092) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9092), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9094), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9095), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9096), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9097), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9098), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9100), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9101), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9102), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9103), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9103) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9104), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9104) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9105), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9106), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9109), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9109) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9110), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9111) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9112), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9113) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9113), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9114), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9115) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9115), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9116), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9117), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9118) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9119), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9120), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9120) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9229), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9231), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9232), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9233), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9234), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9235) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9235), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9212), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9213), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9214), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9216), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9217), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9218) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9218), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9164), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9165), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9165) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9167), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9167), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9169), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9169), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9172), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9173), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9174), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9174), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9175), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9176), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9177), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9178), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9179), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9179), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9181), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9181), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9182), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9183), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9183) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stock",
                table: "ProductDetail");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(4907), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(4917) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(4919), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(4920) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(4922), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(4922) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(4923), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(4923) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5144), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5146), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5147), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5148), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5149), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5150), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5152), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5153), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5154), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5155), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5156), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5157), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5158), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5159), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5161), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5162), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5163), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5164), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5165), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5167), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5167) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5168), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5169), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5169) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5170), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5171), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5174), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5176), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5176) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5005), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5007), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5008) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5009), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5009) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5010), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5010) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5011), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5011) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5012), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5013) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5013), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5015), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5015) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5018), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5019), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5019) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5020), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5021), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5022) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5022), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5023) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5024), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5025), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5026), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5027), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5028) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5028), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5030), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5031), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5031) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5032), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5033), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5034) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5034), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5035), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5037), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5038) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5038), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5039) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5057), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5060), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5062), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5063), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5065), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5066), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5069), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5070), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5071), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5073), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5074), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5076), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5076) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5077), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5079), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5080), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5081) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5082), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5084), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5085), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5087), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5088), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5090), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5091), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5092), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5094), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5123), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5124) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5125), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5192), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5194), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5195), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5196) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5196), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5198), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5199), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5200), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5201), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5202), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5203), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5204) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5204), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5205), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5206), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5207), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5208) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5209), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5210), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5211), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5212), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5213), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5214) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5215), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5216), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5217) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5217), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5218), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5219), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5220), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5221) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5222), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5222) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5223), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5224), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5225), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5225) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5226), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5227), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5227) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5228), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5228) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5229), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5230), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5358), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5359), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5361), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5362), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5363), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5364) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5365), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5340), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5341) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5343), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5344), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5344) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5346), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5347), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5347) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5348), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5253), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5253), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5255), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5256), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5258), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5258), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5259), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5260), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5261), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5261), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5299), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5300), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5301) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5302), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5302), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5302) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5303), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5304), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5304) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5305), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5305), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5306) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5306), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5308), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5308) });
        }
    }
}
