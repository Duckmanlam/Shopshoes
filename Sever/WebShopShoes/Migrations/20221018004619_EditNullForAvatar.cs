using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopShoes.Migrations
{
    public partial class EditNullForAvatar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Avatar",
                table: "UserInfos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1756), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1758), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1760), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1762), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1762) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1763), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1765), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1766) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1767), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1769), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1770) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1771), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1772), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1775), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1776), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1778), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1779), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1780), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1781) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1783), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1784), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1786), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1786) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1787), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1789), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1790), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1792), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1793), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1795), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1797), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1798), new DateTime(2022, 10, 18, 7, 46, 18, 461, DateTimeKind.Local).AddTicks(1799) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Avatar",
                table: "UserInfos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8922), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8925), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8927), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8929), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8930), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8931) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8932), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8933), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8935), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8939), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8939) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8940), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8941) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8942), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8944), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8946), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8947), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8947) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8948), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8949) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8950), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8993), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8993) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8995), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8996), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8999), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9000), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9002), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9003), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9005), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9005) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9006), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "ProductDetail",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreateAt", "UpdateAt" },
                values: new object[] { new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9008), new DateTime(2022, 10, 16, 13, 52, 7, 83, DateTimeKind.Local).AddTicks(9008) });

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
    }
}
