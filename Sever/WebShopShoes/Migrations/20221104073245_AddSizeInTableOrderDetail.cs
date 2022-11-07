using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopShoes.Migrations
{
    public partial class AddSizeInTableOrderDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "OrderDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(123), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(149) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(150), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(151) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(151), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(153), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(485), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(487), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(487) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(488), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(489), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(490), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(491) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(491), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(492) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(492), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(494), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(494) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(495), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(495) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(496), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(497), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(498) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(499), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(500), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(501) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(501), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(503), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(503) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(504), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(505), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(505) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(506), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(507), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(508), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(509) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(509), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(511), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(511) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(512), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(512) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(513), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(514), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(514) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(515), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(515) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(297), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(299), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(300), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(302), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(303), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(304), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(306), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(307), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(307) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(308), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(309), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(312), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(313), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(314), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(315) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(315), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(316), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(318), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(319), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(320), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(321) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(321), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(323), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(324), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(325), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(326), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(327) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(328), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(329) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(329), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(331), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(331) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(411), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(413) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(415), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(416), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(418), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(418) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(420), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(421), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(422) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(424), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(426), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(426) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(427), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(427) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(429), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(429) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(430), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(431) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(432), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(433), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(435), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(436), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(437) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(439), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(439) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(440), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(441) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(442), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(442) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(444), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(444) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(449), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(449) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(450), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(450) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(452), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(452) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(453), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(455), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(455) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(457), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(457) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(458), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(458) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(534), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(536), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(538), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(538) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(539), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(540), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(541), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(639), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(641), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(642), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(642) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(643), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(644), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(645) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(647), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(648) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(648), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(649) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(650), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(651), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(651) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(652), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(653) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(654), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(655), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(656) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(656), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(658), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(658) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(659), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(660), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(661), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(661) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(662), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(663), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(663) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(664), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(665) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(665), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(666) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(666), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(667) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(668), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(668) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(669), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(669) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(670), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(672), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(672) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(673), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(674) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(674), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(675) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(703), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(704), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(705) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(706), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(707), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(707) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(708), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(708), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(709) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(710), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(710), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(711) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(711), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(712), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(712) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(713), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(713), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(715), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(715), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(716), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(717), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(719), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(719), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(720) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(721), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(721), new DateTime(2022, 11, 4, 14, 32, 44, 922, DateTimeKind.Local).AddTicks(722) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "OrderDetail");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3036), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3047) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3049), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3050), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3051) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3078), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3303), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3306), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3307), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3308), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3309), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3310), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3312), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3313), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3314), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3315), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3316), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3317), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3318), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3320), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3321), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3322), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3323), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3324), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3325), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3326) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3327), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3327) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3328), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3329), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3330), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3331), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3332), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3333) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3333), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3334) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3156), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3159), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3160), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3161), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3163), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3164), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3165), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3166), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3168), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3168) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3169), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3169) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3170), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3171) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3171), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3174), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3175), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3176), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3177), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3179), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3180), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3181), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3182), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3184), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3184) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3185), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3186), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3187), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3188), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3189), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3190) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3214), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3218), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3220), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3221), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3223), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3224), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3226), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3227), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3230), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3231), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3233), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3234), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3236), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3237), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3239), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3240), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3243), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3244), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3246), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3247), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3249), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3250), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3252), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3253), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3255), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3257), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3350), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3351), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3353), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3354), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3354) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3355), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3355) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3356), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3357) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3357), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3358) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3358), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3359), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3360), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3361) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3362), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3362) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3363), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3364), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3364) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3365), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3365) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3366), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3367), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3367) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3368), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3369), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3372), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3373), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3375), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3375) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3376), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3377), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3378), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3379), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3379) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3380), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3381), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3382) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3382), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3383), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3384) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3384), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3385), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3387), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3388), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3389), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3408), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3409), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3411), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3412), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3413), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3414), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3415), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3415), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3416), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3417), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3418), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3419), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3420), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3420), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3421), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3422), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3423), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3423), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3445), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3446), new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3446) });
        }
    }
}
