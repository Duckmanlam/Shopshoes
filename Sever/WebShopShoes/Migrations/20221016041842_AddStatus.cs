using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopShoes.Migrations
{
    public partial class AddStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ProductDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ProductDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "CateId", "CreateAt", "UpdateAt" },
                values: new object[] { 4, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5026), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5027) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CateId", "CreateAt", "UpdateAt" },
                values: new object[] { 4, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5027), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5028) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CateId", "CreateAt", "UpdateAt" },
                values: new object[] { 4, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5028), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5029) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CateId", "CreateAt", "UpdateAt" },
                values: new object[] { 4, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5030), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5030) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CateId", "CreateAt", "UpdateAt" },
                values: new object[] { 4, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5031), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5031) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CateId", "CreateAt", "UpdateAt" },
                values: new object[] { 4, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5032), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5032) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CateId", "CreateAt", "UpdateAt" },
                values: new object[] { 4, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5033), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5034) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CateId", "CreateAt", "UpdateAt" },
                values: new object[] { 4, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5034), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CateId", "CreateAt", "UpdateAt" },
                values: new object[] { 4, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5035), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5037) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CateId", "CreateAt", "UpdateAt" },
                values: new object[] { 4, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5037), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5038) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CateId", "CreateAt", "UpdateAt" },
                values: new object[] { 4, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5038), new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5039) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5057), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5060), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5061) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5062), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5063), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5065), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5066), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5067) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5069), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5070), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5071), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5073), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5074), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5076), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5076) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5077), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5078) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5079), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5079) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5080), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5081) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5082), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5082) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5084), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5085), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5087), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5087) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5088), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5090), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5091), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5092), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5094), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5123), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5124) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "Quantity", "Status", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5125), 100, 1, new DateTime(2022, 10, 16, 11, 18, 41, 948, DateTimeKind.Local).AddTicks(5126) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ProductDetail");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ProductDetail");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(936), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(948), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(950), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(951), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(951) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1182), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1183) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1184), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1186), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1186) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1187), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1187) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1188), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1188) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1189), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1190), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1190) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1191), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1192) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1192), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1193) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1193), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1194) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1194), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1195) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1196), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1197) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1197), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1198) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1198), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1199) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1199), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1200) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1200), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1201) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1202), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1202) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1203), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1204), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1204) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1205), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1205) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1206), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1207) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1207), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1208) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1208), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1209) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1209), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1214), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1215) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1215), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1216) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1036), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1037) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1039), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1040), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1041) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1041), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1042) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1043), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1044) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1044), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1045) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1046), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1046) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1047), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1047) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1048), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1049), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1050), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1051) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1051), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1052) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1053), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1054), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1057) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1058), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1059) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CateId", "CreateAt", "UpdateAt" },
                values: new object[] { 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1059), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1060) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CateId", "CreateAt", "UpdateAt" },
                values: new object[] { 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1061), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1061) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CateId", "CreateAt", "UpdateAt" },
                values: new object[] { 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1062), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1063) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CateId", "CreateAt", "UpdateAt" },
                values: new object[] { 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1063), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1064) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CateId", "CreateAt", "UpdateAt" },
                values: new object[] { 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1065), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1065) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CateId", "CreateAt", "UpdateAt" },
                values: new object[] { 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1066), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CateId", "CreateAt", "UpdateAt" },
                values: new object[] { 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1067), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CateId", "CreateAt", "UpdateAt" },
                values: new object[] { 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1068), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1068) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CateId", "CreateAt", "UpdateAt" },
                values: new object[] { 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1069), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CateId", "CreateAt", "UpdateAt" },
                values: new object[] { 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1070), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CateId", "CreateAt", "UpdateAt" },
                values: new object[] { 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1072), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1072) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1094), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1097), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1098), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1099), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1100) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1101), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1102), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1102) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1103), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1104) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1105), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1105) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1106), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1108), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1109), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1109) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1110), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1111) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1112), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1114), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1114) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1115), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1116) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1116), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1118), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1119), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1120), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1122), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1124), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1125), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1126), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1128), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1130), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1130) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1162), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1162) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1231), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1232) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1233), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1234) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1235), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1235) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1236), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1236) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1237), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1237) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1238), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1239), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1239) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1240), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1241) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1241), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1242) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1242), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1243) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1243), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1244) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1244), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1245) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1245), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1246) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1246), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1248), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1248) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1249), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1250) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1251), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1251) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1252), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1252) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1253), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1254), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1254) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1255), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1256), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1256) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1257), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1258) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1258), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1259) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1259), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1260) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1260), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1261) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1261), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1262) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1262), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1263) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1263), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1264) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1265), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1265) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1266), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1266) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1267), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1268) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1269), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1270), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1374), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1375) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1376), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1376) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1377), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1377) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1378), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1379) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1379), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1380) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1380), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1381) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1357), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1359), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1360), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1361) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1361), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1362) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1362), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1364), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1364) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1288), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1289), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1290), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1291), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1292), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1293), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1293) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1294), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1295), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1295) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1296), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1296), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1297) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1297), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1298), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1298) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1324), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1324), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1325) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1326), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1326), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1327) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1327), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1328), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1328) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1329), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1329), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1330) });
        }
    }
}
