using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopShoes.Migrations
{
    public partial class AddTableOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "ProductDetail");

            migrationBuilder.AlterColumn<string>(
                name: "Style",
                table: "ProductDetail",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShipPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_UserInfos_UserId",
                        column: x => x.UserId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8510), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8522) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8524), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8525), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8526), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8527) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8822), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8825), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8826), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8827), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8828), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8829), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8831), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8833), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8834), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8835), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8837), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8838), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8838) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8839), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8840), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8840) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8841), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8841) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8842), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8843), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8843) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8844), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8845), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8846), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8847) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8847), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8849), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8849) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8850), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8851), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8851) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8853), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8651), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8653), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8654) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8655), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8655) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8656), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8657), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8658) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8659), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8662), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8663), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8663) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8664), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8665), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8666) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8666), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8667) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8668), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8668) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8669), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8669) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8670), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8671) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8671), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8673), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8674), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8674) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8675), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8676) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8676), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8677) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8677), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8680), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8681), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8681) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8682), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8683), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8684) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8685), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8685) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8686), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8715), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8716) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8718), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8720), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8721) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8722), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8724), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8724) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8725), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8727), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8728), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8730), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8731), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8733), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8734), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8736), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8738), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8739), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8741), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8742), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8744), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8744) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8745), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8746) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8747), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8748), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8750), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8752), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8753), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8755), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8755) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8756), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8870), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8871) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8872), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8872) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8873), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8873) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8874), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8875) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8875), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8876), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8878), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8878) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8879), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8880), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8880) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8881), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8881) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8882), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8883), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8884), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8885), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8887), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8888), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8889), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8890), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8891), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8893), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8894), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8895), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8896), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8897), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8898), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8899), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8899) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8900), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8901), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8902), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8903), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8909), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8910), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8911) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8912), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8913), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9027), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9029), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9030), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9031), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9032) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9032), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9033), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9009), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9009) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9010), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9012), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9013), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9014), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9014) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9015), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9015) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8930), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8931), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8933), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8934), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8936), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8936), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8937) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8937), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8938), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8939), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8939), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8940), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8941), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8942), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8943), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8945), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8945), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8945) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8946), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8947), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8948), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8948), new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.AlterColumn<string>(
                name: "Style",
                table: "ProductDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "ProductDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1537), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1548), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1549), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1551), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1551) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1819), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1820), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1821) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1822), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1822) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1823), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1823) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1824), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1824) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1825), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1825) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1826), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1826) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1827), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1828), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1829) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1829), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1830) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1830), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1831) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1831), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1832) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1833), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1834), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1835), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1835) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1836), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1836) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1837), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1838), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1839) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1839), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1841), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1842), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1843) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1843), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1844), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1845), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1846) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1847), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1848), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1848) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1674), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1676), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1677), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1678) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1678), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1680), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1681), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1682), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1683), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1684), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1684) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1685), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1687), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1688), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1689), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1690), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1691), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1693), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1694), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1695), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1696), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1697), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1698), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1699), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1701), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1702), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1703), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1704), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1756), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1758), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1760), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1762), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1762) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1763), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1765), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1766) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1767), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1769), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1770) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1771), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1772), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1775), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1776), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1778), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1779), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1780), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1783), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1784), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1786), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1787), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1789), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1790), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1792), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1793), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1795), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1797), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "Quantity", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1798), 100, new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1864), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1866), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1867), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1868), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1869), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1870), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1871), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1872), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1873), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1874), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1876), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1877), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1903), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1904), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1905), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1906), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1908), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1909), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1910), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1911), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1912), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1913), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1915), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1915) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1916), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1917), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1918), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1919), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1919) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1920), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1921), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1921) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1922), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1923), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1923) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1924), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1926), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1927), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(2013), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(2015), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(2016), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(2017) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(2018), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(2019), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "ProductSize",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(2020), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1994), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1996), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1998), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1999), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(2000), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "Size",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(2001), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1948), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1949), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1951), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1952), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1953), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1953), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1955), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1955), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1956), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1957), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1958), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1958), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1959) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1959), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1960), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1961), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1962), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1963), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1964), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1965), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1966), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1966) });
        }
    }
}
