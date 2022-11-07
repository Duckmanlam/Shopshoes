using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopShoes.Migrations
{
    public partial class RemoveTableSize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSize");

            migrationBuilder.DropTable(
                name: "Size");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductSize",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSize", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSize_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSize_Size_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Size",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "CreateAt", "CreateBy", "UpdateAt", "UpdateBy", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9009), "Thọ", new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9009), "Thọ", "S" },
                    { 2, new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9010), "Thọ", new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9011), "Thọ", "M" },
                    { 3, new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9012), "Thọ", new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9012), "Thọ", "L" },
                    { 4, new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9013), "Thọ", new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9013), "Thọ", "XL" },
                    { 5, new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9014), "Thọ", new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9014), "Thọ", "XXL" },
                    { 6, new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9015), "Thọ", new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9015), "Thọ", "XXXL" }
                });

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

            migrationBuilder.InsertData(
                table: "ProductSize",
                columns: new[] { "Id", "CreateAt", "CreateBy", "ProductId", "SizeId", "UpdateAt", "UpdateBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9027), "Thọ", 1, 1, new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9028), "Thọ" },
                    { 2, new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9029), "Thọ", 1, 2, new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9029), "Thọ" },
                    { 3, new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9030), "Thọ", 1, 3, new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9031), "Thọ" },
                    { 4, new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9031), "Thọ", 1, 4, new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9032), "Thọ" },
                    { 5, new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9032), "Thọ", 1, 5, new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9033), "Thọ" },
                    { 6, new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9033), "Thọ", 1, 6, new DateTime(2022, 11, 3, 17, 14, 24, 963, DateTimeKind.Local).AddTicks(9034), "Thọ" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductSize_ProductId",
                table: "ProductSize",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSize_SizeId",
                table: "ProductSize",
                column: "SizeId");
        }
    }
}
