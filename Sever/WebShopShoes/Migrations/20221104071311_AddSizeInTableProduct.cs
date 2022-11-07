using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopShoes.Migrations
{
    public partial class AddSizeInTableProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "ProductDetail",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3214), "M", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3215) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3218), "S", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3220), "L", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3221), "M", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3223), "M", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3224), "M", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3225) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3226), "M", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3226) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3227), "L", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3228) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3230), "L", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3231), "L", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3233), "S", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3234), "L", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3235) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3236), "M", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3237), "L", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3238) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3239), "L", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3239) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3240), "L", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3241) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3243), "S", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3243) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3244), "S", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3245) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3246), "S", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3246) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3247), "S", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3249), "S", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3249) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3250), "S", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3252), "S", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3253), "S", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3255), "S", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "Size", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3257), "S", new DateTime(2022, 11, 4, 14, 13, 10, 885, DateTimeKind.Local).AddTicks(3258) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "ProductDetail");

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3309), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3322), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3323), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3324), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3325) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3622), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3622) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3624), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3624) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3625), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3626), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3627) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3627), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3628) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3628), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3629), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3631), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3632), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3632) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3633), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3634), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3635), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3635) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3636), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3636) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3637), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3638) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3638), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3640), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3641), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3642), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3643), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3644) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3644), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3645), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3646), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3647) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3647), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3648), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3649) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3650), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Post",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3651), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3450), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3451) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3452), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3454), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3454) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3455), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3456) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3457), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3457) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3458), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3459) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3460), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3460) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3461), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3462) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3463), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3465), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3466), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3469), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3470), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3471) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3472), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3473), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3474), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3476), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3476) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3477), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3479), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3480), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3482), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3483) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3484), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3484) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3485), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3486) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3487), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3487) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3493), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3494) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3495), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3495) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3535), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3537), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3539), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3540), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3542), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3543), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3545), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3546), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3548) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3549), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3550), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3551) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3552), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3552) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3553), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3554), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3555) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3556), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3556) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3557), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3558) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3559), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3561), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3561) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3562), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3564), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3565), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3566) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3567), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3570) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3571), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3572) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3573), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3573) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3574), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3576), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3576) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3578), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3578) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3672), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3674), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3674) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3675), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3676), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3677), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3678), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3679), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3680), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3681), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3682), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3683), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3684) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3685), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3686), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3686) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3687), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3687) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3688), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3688) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3689), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3689) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3690), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3691), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3691) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3692), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3693), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3694) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3695), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3695) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3696), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3697), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3698), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3699) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3699), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3700), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3701), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3702) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3704), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3705) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3705), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3706) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3706), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3707) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3707), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3708) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3708), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3709) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3709), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "ProductImage",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3710), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3711) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3734), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3735), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3735) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3739), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3740), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3740) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3741), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3742), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3742) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3743), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3743), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3744) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3744), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3745), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3745) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3746), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3747), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3747) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3748), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3748), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3749) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3749), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3750), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3750) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3751), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3751), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3752) });

            migrationBuilder.UpdateData(
                table: "UserInfos",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CommentDate", "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3752), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3753), new DateTime(2022, 11, 4, 13, 23, 11, 134, DateTimeKind.Local).AddTicks(3753) });
        }
    }
}
