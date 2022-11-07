using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShopShoes.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Articles = table.Column<int>(type: "int", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    isAdmin = table.Column<bool>(type: "bit", nullable: false),
                    UserInfoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Account_UserInfos_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CateId = table.Column<int>(type: "int", nullable: false),
                    UserInfoId = table.Column<int>(type: "int", nullable: true),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Category_CateId",
                        column: x => x.CateId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_UserInfos_UserInfoId",
                        column: x => x.UserInfoId,
                        principalTable: "UserInfos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Post_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "Text", nullable: false),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViewCount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImage_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSize",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreateAt", "CreateBy", "UpdateAt", "UpdateBy", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(936), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(947), "Thọ", "Nike Air Max 2021" },
                    { 2, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(948), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(949), "Thọ", "What’s Trending Now" },
                    { 3, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(950), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(950), "Thọ", "Share With #Shoppes" },
                    { 4, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(951), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(951), "Thọ", "Latest From Blogs" }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "Id", "CreateAt", "CreateBy", "UpdateAt", "UpdateBy", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1357), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1358), "Thọ", "S" },
                    { 2, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1359), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1359), "Thọ", "M" },
                    { 3, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1360), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1361), "Thọ", "L" },
                    { 4, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1361), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1362), "Thọ", "XL" },
                    { 5, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1362), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1363), "Thọ", "XXL" },
                    { 6, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1364), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1364), "Thọ", "XXXL" }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "Address", "Articles", "Avatar", "CommentDate", "CreateAt", "CreateBy", "Phone", "UpdateAt", "UpdateBy", "UserName" },
                values: new object[,]
                {
                    { 1, "TPHCM", 22, "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTkno76-PO7yj1SWFtb7xXymbwwx_ELrptddJQTqx1w4CAeED45Oxq9dKA1pJ7MKr7XKILtx2A=w1227-h942", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1288), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1289), "Thọ", "0912334556", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1289), "Thọ", "Cameron Williamson" },
                    { 2, "TPHCM", 22, "https://lh3.googleusercontent.com/drive-viewer/AJc5JmSllVOpJ4bFn8KhYuU2AoK7cjpATKDAFaVTigqQA48SvIZUnkJQhRZJcUkeoNc7d5TBHoTaDPM=w1227-h942", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1290), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1291), "Thọ", "0912334556", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1292), "Thọ", "Marvin McKinney" },
                    { 3, "TPHCM", 22, "https://lh3.googleusercontent.com/drive-viewer/AJc5JmQHfbxWQbi9UUAC5yBmIQ6CFtyRpJWFdn86xK19uUOMkFwYhp9NCzicFjW64lVIVBugxqXcpTk=w1227-h942", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1292), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1293), "Thọ", "0912334556", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1293), "Thọ", "Savannah Nguyen" },
                    { 4, "TPHCM", 22, "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTTPOtVqTt44d9bl4A39QsUjDy6ase9QP7ngNLmMdRBHbXJxe2tSCTp3TXt-Bn_sMGaXZkCopM=w1227-h942", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1294), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1295), "Thọ", "0912334556", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1295), "Thọ", "Floyd Miles" },
                    { 5, "TPHCM", 22, "https://lh3.googleusercontent.com/drive-viewer/AJc5JmSd_ZBOEd96gm5DXZ2xNLKFEou_yMnVkESUMsNcMRH7F3uSo5iA6yROmGLdey2m2MyJiKyIvwg=w1227-h942", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1296), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1296), "Thọ", "0912334556", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1297), "Thọ", "Robert Fox" },
                    { 6, "TPHCM", 22, "https://lh3.googleusercontent.com/drive-viewer/AJc5JmQgAUbcyrXWpcEjWHzfor_RdhZq4iJPcf3P75H-rHNeH9_qXb_Ra_yFxVRHfRCTm7mpop-IrmU=w1227-h942", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1297), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1298), "Thọ", "0912334556", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1298), "Thọ", "Annette Black" },
                    { 7, "TPHCM", 22, "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTECUDyD6CrPj-uKThzv6a-_FhTupFlJHqXYEVagDJ8FJMtixXxTfjmgNytCa5UxuOJeGd3hkM=w1227-h942", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1324), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1324), "Thọ", "0912334556", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1325), "Thọ", "Albert Flores" },
                    { 8, "TPHCM", 22, "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTFHAXFwtup8lamnrjVUjY8bVzqtr7ruK0Qs1IcVyVWE2ghe3FjAgxOSTj3jL5Bh7MnReltkcM=w1227-h942", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1326), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1326), "Thọ", "0912334556", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1327), "Thọ", "Ralph Edwards" },
                    { 9, "TPHCM", 22, "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTjymN3FZshBq7TsEp2tlXl17hKZEtJ4qFxy2s0uDwkS5zRI61EhW6TbtxGz-p8dbKJUzErTx0=w1227-h942", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1327), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1328), "Thọ", "0912334556", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1328), "Thọ", "Darrell Steward" },
                    { 10, "TPHCM", 22, "https://lh3.googleusercontent.com/drive-viewer/AJc5JmQ6ogjNNiTjeBWtaB35AhoZ_xqtFH4dkeGNDxs11RdZxeEB6H6ZIBeKkRaTlm0yBOwiI9OIkE8=w1227-h942", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1329), new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1329), "Thọ", "0912334556", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1330), "Thọ", "Ronald Richards" }
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "Password", "UserInfoId", "Username", "isAdmin" },
                values: new object[,]
                {
                    { 1, "$2a$06$UjYOc10v92VdCNzx82jRSuOrsOPY8lugsVPQwMdYIxxttcG7.tuHK", 1, "thonguyen123", true },
                    { 2, "$2a$06$UjYOc10v92VdCNzx82jRSuOrsOPY8lugsVPQwMdYIxxttcG7.tuHK", 2, "tranvan123", true },
                    { 3, "$2a$06$UjYOc10v92VdCNzx82jRSuOrsOPY8lugsVPQwMdYIxxttcG7.tuHK", 3, "ducchi123", true },
                    { 4, "$2a$06$UjYOc10v92VdCNzx82jRSuOrsOPY8lugsVPQwMdYIxxttcG7.tuHK", 4, "dinhtho123", true },
                    { 5, "$2a$06$UjYOc10v92VdCNzx82jRSuOrsOPY8lugsVPQwMdYIxxttcG7.tuHK", 5, "conghau123", true },
                    { 6, "$2a$06$UjYOc10v92VdCNzx82jRSuOrsOPY8lugsVPQwMdYIxxttcG7.tuHK", 6, "baovo123", true },
                    { 7, "$2a$06$UjYOc10v92VdCNzx82jRSuOrsOPY8lugsVPQwMdYIxxttcG7.tuHK", 7, "hieunguyen123", true },
                    { 8, "$2a$06$UjYOc10v92VdCNzx82jRSuOrsOPY8lugsVPQwMdYIxxttcG7.tuHK", 8, "nhinguyen123", true },
                    { 9, "$2a$06$UjYOc10v92VdCNzx82jRSuOrsOPY8lugsVPQwMdYIxxttcG7.tuHK", 9, "thuannguyen123", true },
                    { 10, "$2a$06$UjYOc10v92VdCNzx82jRSuOrsOPY8lugsVPQwMdYIxxttcG7.tuHK", 10, "baonguyen123", true }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "AccountId", "CateId", "CreateAt", "CreateBy", "UpdateAt", "UpdateBy", "UserInfoId" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1036), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1037), "Thọ", 1 },
                    { 2, 1, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1039), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1039), "Thọ", 1 },
                    { 3, 1, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1040), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1041), "Thọ", 1 },
                    { 4, 1, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1041), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1042), "Thọ", 1 },
                    { 5, 1, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1043), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1044), "Thọ", 1 },
                    { 6, 1, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1044), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1045), "Thọ", 1 },
                    { 7, 1, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1046), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1046), "Thọ", 1 },
                    { 8, 1, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1047), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1047), "Thọ", 1 },
                    { 9, 1, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1048), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1048), "Thọ", 1 },
                    { 10, 1, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1049), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1050), "Thọ", 1 },
                    { 11, 1, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1050), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1051), "Thọ", 1 },
                    { 12, 1, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1051), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1052), "Thọ", 1 },
                    { 13, 1, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1053), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1053), "Thọ", 1 },
                    { 14, 1, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1054), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1057), "Thọ", 1 },
                    { 15, 1, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1058), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1059), "Thọ", 1 },
                    { 16, 1, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1059), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1060), "Thọ", 1 },
                    { 17, 2, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1061), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1061), "Thọ", 2 },
                    { 18, 3, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1062), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1063), "Thọ", 3 },
                    { 19, 4, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1063), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1064), "Thọ", 4 },
                    { 20, 5, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1065), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1065), "Thọ", 5 },
                    { 21, 6, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1066), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1066), "Thọ", 6 },
                    { 22, 7, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1067), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1067), "Thọ", 7 },
                    { 23, 8, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1068), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1068), "Thọ", 8 },
                    { 24, 9, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1069), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1070), "Thọ", 9 },
                    { 25, 10, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1070), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1071), "Thọ", 10 },
                    { 26, 10, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1072), "Thọ", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1072), "Thọ", 10 }
                });

            migrationBuilder.InsertData(
                table: "Post",
                columns: new[] { "Id", "CreateAt", "CreateBy", "ProductId", "Title", "UpdateAt", "UpdateBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1182), "Thọ", 1, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1183), "Thọ" },
                    { 2, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1184), "Thọ", 2, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1185), "Thọ" },
                    { 3, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1186), "Thọ", 3, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1186), "Thọ" },
                    { 4, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1187), "Thọ", 4, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1187), "Thọ" },
                    { 5, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1188), "Thọ", 5, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1188), "Thọ" },
                    { 6, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1189), "Thọ", 6, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1189), "Thọ" },
                    { 7, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1190), "Thọ", 7, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1190), "Thọ" },
                    { 8, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1191), "Thọ", 8, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1192), "Thọ" },
                    { 9, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1192), "Thọ", 9, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1193), "Thọ" },
                    { 10, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1193), "Thọ", 10, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1194), "Thọ" },
                    { 11, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1194), "Thọ", 11, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1195), "Thọ" },
                    { 12, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1196), "Thọ", 12, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1197), "Thọ" },
                    { 13, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1197), "Thọ", 13, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1198), "Thọ" },
                    { 14, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1198), "Thọ", 14, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1199), "Thọ" },
                    { 15, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1199), "Thọ", 15, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1200), "Thọ" },
                    { 16, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1200), "Thọ", 16, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1201), "Thọ" },
                    { 17, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1202), "Thọ", 17, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1202), "Thọ" },
                    { 18, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1203), "Thọ", 18, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1203), "Thọ" },
                    { 19, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1204), "Thọ", 19, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1204), "Thọ" },
                    { 20, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1205), "Thọ", 20, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1205), "Thọ" },
                    { 21, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1206), "Thọ", 21, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1207), "Thọ" },
                    { 22, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1207), "Thọ", 22, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1208), "Thọ" },
                    { 23, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1208), "Thọ", 23, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1209), "Thọ" },
                    { 24, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1209), "Thọ", 24, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1210), "Thọ" },
                    { 25, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1214), "Thọ", 25, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1215), "Thọ" },
                    { 26, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1215), "Thọ", 26, "Lorem ipsum dolor sit amet", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1216), "Thọ" }
                });

            migrationBuilder.InsertData(
                table: "ProductDetail",
                columns: new[] { "Id", "BrandName", "CreateAt", "CreateBy", "Description", "Price", "ProductId", "ProductName", "Style", "Type", "UpdateAt", "UpdateBy", "ViewCount" },
                values: new object[,]
                {
                    { 1, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1094), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 213.0, 1, "Nike ZoomX Streakfly", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1095), "Thọ", 99 },
                    { 2, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1097), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 189.0, 1, "Nike Air Max 2021", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1097), "Thọ", 99 },
                    { 3, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1098), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 173.0, 1, "Nike Air Max 2021", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1099), "Thọ", 99 },
                    { 4, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1099), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 120.0, 1, "Nike Air Max 2021", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1100), "Thọ", 99 },
                    { 5, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1101), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 213.0, 1, "Nike ZoomX Streakfly", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1101), "Thọ", 99 },
                    { 6, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1102), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 213.0, 1, "Nike ZoomX Streakfly", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1102), "Thọ", 99 },
                    { 7, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1103), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 213.0, 1, "Nike ZoomX Streakfly", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1104), "Thọ", 99 },
                    { 8, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1105), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 213.0, 1, "Nike ZoomX Streakfly", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1105), "Thọ", 99 },
                    { 9, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1106), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 213.0, 1, "Nike ZoomX Streakfly", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1107), "Thọ", 99 },
                    { 10, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1108), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 213.0, 1, "Nike ZoomX Streakfly", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1108), "Thọ", 99 },
                    { 11, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1109), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 213.0, 1, "Nike ZoomX Streakfly", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1109), "Thọ", 99 },
                    { 12, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1110), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 213.0, 1, "Nike ZoomX Streakfly", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1111), "Thọ", 99 },
                    { 13, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1112), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 213.0, 2, "Nike Air Max INTRLK1", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1112), "Thọ", 99 },
                    { 14, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1114), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 213.0, 2, "Nike Air Max INTRLK", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1114), "Thọ", 99 },
                    { 15, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1115), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 213.0, 3, "Nike Air Max", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1116), "Thọ", 99 },
                    { 16, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1116), "Thọ", "Velit officia consequat duis enim velit mollit. Exercitation veniam consequat sunt nostrud amet. ", 213.0, 4, "Nike Air Max", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1117), "Thọ", 99 }
                });

            migrationBuilder.InsertData(
                table: "ProductDetail",
                columns: new[] { "Id", "BrandName", "CreateAt", "CreateBy", "Description", "Price", "ProductId", "ProductName", "Style", "Type", "UpdateAt", "UpdateBy", "ViewCount" },
                values: new object[,]
                {
                    { 17, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1118), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 213.0, 4, "Nike ZoomX Streakfly", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1118), "Thọ", 99 },
                    { 18, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1119), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 213.0, 4, "Nike ZoomX Streakfly", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1120), "Thọ", 99 },
                    { 19, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1120), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 213.0, 4, "Nike ZoomX Streakfly", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1121), "Thọ", 99 },
                    { 20, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1122), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 213.0, 4, "Nike ZoomX Streakfly", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1122), "Thọ", 99 },
                    { 21, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1124), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 213.0, 4, "Nike ZoomX Streakfly", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1124), "Thọ", 99 },
                    { 22, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1125), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 213.0, 4, "Nike ZoomX Streakfly", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1125), "Thọ", 99 },
                    { 23, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1126), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 213.0, 4, "Nike ZoomX Streakfly", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1127), "Thọ", 99 },
                    { 24, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1128), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 213.0, 4, "Nike ZoomX Streakfly", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1129), "Thọ", 99 },
                    { 25, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1130), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 213.0, 4, "Nike ZoomX Streakfly", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1130), "Thọ", 99 },
                    { 26, "Men's Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1162), "Thọ", "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.", 213.0, 4, "Nike ZoomX Streakfly", "Sport, Design, Lifestyle", "Road Racing Shoes", new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1162), "Thọ", 99 }
                });

            migrationBuilder.InsertData(
                table: "ProductImage",
                columns: new[] { "Id", "CreateAt", "CreateBy", "ProductId", "UpdateAt", "UpdateBy", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1231), "Thọ", 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1232), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmR4vAg9_VJqlg0WiateWDeoYd84lQzvlnvyHE3ltsfWXAl51_Zbqo6djfpEtbb1Ce_QMOZLLcY=w1920-h870" },
                    { 2, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1233), "Thọ", 2, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1234), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmR0Qt1lRYg8j6MohwJizIoHlmtCMAWr1Xz9rOo9fgG4FDmn9Lsr_iS35PHV8WZJpsvMpEzDmuw=w1227-h942" },
                    { 3, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1235), "Thọ", 3, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1235), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTgImoHZJrU_oKyn3jSyXhZ9H4f_P0wnLnTLgJ5ot5b7cbu7w_8QTDAKcfeG9HRxmrYcyVRVrM=w1227-h942" },
                    { 4, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1236), "Thọ", 4, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1236), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmSzha5C6XgTCNn6T7eTHsPtK3xbrPYozPTB6H9ncdhslaIQ5_fbC2ZEdeZRb3jVAmb0tUXOOzQ=w1227-h942" },
                    { 5, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1237), "Thọ", 5, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1237), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmS7fSF_4Vne106vjZYi5BCCoOwTp1dMMMss0VGspT710V0we8uD1XSQsbVKXeAgwAoY3x-ALe8=w1920-h942" },
                    { 6, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1238), "Thọ", 6, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1238), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmS2DdTXZn7JHxzvtenGEFP54si7KwpA5zbDXJrdV827T10ywAGDfbA6SYy9M-oQPMZwJhnuY7M=w1227-h942" },
                    { 7, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1239), "Thọ", 7, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1239), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTWUXZTo8l_TA45IxD7M8fC4n_pwEOjDGruNxId2OlkGAHyTNCfla2krsgrnWD2DspL6jOaeKA=w1227-h942" },
                    { 8, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1240), "Thọ", 8, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1241), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmSYDQlTou0wVQAgJP4zwOZh974gYnghEBSWW7osgjwmOVTnPzokGHxrAGfTpjjDIYHUxpj1-q8=w1227-h942" },
                    { 9, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1241), "Thọ", 9, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1242), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmRfbfebyhTCGvqmRRUBbzVQWAYRlIYTcAV1RpXRmezYF5ul1t-n0pvc7-AYmYAS_PSuyQ5WSYE=w1227-h942" },
                    { 10, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1242), "Thọ", 10, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1243), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmT2FOk__XzMJMAwi4O52i1SSaNOsq9rvC4nKCsmZpoAtxMjsaLnD-4V6fDxHaUQXd9POiGMSdI=w1227-h942" },
                    { 11, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1243), "Thọ", 11, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1244), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmS1_joTMhNpGm3G8wlOUMu2_-wIXJIZOmcFXdm0OHN9VPujgDZpNE9a8OAW9BLbBSV9uovPJpU=w1227-h942" },
                    { 12, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1244), "Thọ", 12, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1245), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTbqSDLhKZn64IvFgHoxBMjtMCQaY4-uvbZFOXSxJ_Xdx2XMwNn_Q_SqX35UPHJbLTTW3LjynI=w1227-h942" },
                    { 13, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1245), "Thọ", 13, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1246), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTPwB6XLePBDMdQIxmULC-p8nGvxdc2489xhdoxkvUmlYO8_h8tsEcJfth-fYV7qeCllHfyELs=w1227-h942" },
                    { 14, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1246), "Thọ", 14, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1247), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTPwB6XLePBDMdQIxmULC-p8nGvxdc2489xhdoxkvUmlYO8_h8tsEcJfth-fYV7qeCllHfyELs=w1227-h942" },
                    { 15, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1248), "Thọ", 15, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1248), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmRPMfPGpYXIST9WSiO7XEZ4xwlXe7jdLP50a7zbAuieuj1KQk37XzH1o5iSkucYsbMCaG9nV7s=w1227-h942" },
                    { 16, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1249), "Thọ", 15, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1250), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmSFndNwoL38dLS02ZQZq23lySy2b_owXoh8g3_F-grg_K2pzpPr-i5mW9o-TvAOqKxy7ujgxwE=w1227-h942" },
                    { 17, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1251), "Thọ", 15, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1251), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTdqjIzoQZMeanNAY451fIqFA5jXkPin8tUsyRBvdnxP2-8fLTIU_g_L33-DNVFwQc-c5PIoQA=w1227-h942" },
                    { 18, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1252), "Thọ", 15, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1252), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmQEMkYhXMgz8hyq1qUSEStTMWKr2HEx2MQJ05XEL1KGsekFvwJ5O0F5vvHpLHV30aCk6aE5SfY=w1227-h942" },
                    { 19, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1253), "Thọ", 15, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1253), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTaS169x9VUuSmGkLI3AovRuj-1x3ksDBdcLa6u5DqXwyi_4eFo7Cjor1dyz-n1U_Q2AgvdXhQ=w1227-h942" },
                    { 20, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1254), "Thọ", 15, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1254), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmRVTTvkT3h8aCxHpD1oph_9LeUf3yG_XSPuv78Wc_vv2GvOUK0stF9uuA_6YJfF5C7ZvVtY4BY=w1227-h942" },
                    { 21, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1255), "Thọ", 16, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1255), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTvLtmK_3tvbcpYmnFYDj3ZFdorwQwyIZ7gLqELtYzzmGTLgIcsyHTDChyd_U58qkNSkL1k8s0=w1227-h942" },
                    { 22, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1256), "Thọ", 17, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1256), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTuZc5_TEzRQrm39Or3fiZ9Eq-C8Om7dTUzKkPcN6zAYZoq-YBhAqv_mGg9yH--PXQEd3nhvFI=w1227-h942" },
                    { 23, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1257), "Thọ", 18, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1258), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmQzZOUm0GObCQ0a02AYELgaqllB_mty-xfnceYJO8kqKhr50H7TwkTRfP6SGkKXBL5dzwQCYDg=w1920-h942" },
                    { 24, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1258), "Thọ", 19, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1259), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmRfdJ3oCpC7sLj0s_xe3futZBGrFbmshAUwtLBzrHRCizSLb64w3z22ZjF3Dr_K5h4otfzTcB8=w1227-h942" },
                    { 25, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1259), "Thọ", 19, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1260), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTyf7uAxvp8Q1mbPWyy4gjyZHbmEpBcyVFl7oLXTj-ZXprskDlWFVbFyAQ2v7rzTMMK30uwX_s=w1920-h870" },
                    { 26, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1260), "Thọ", 19, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1261), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTxzqu_dRaDCjrAtb8o2_1MWhL68FRUiXxzjDgnuuszkQaYjhRhe39gzwtoA7TV3dSJoVC7QvQ=w1920-h870" },
                    { 27, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1261), "Thọ", 19, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1262), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmT0SF5XBkpO1AM14Jh1JzARgXoeaqUpPTpYHqOwsLfd7WWgi-5Fz7Bi8kQl3Qybqg-wuCl0vxs=w1227-h870" },
                    { 28, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1262), "Thọ", 20, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1263), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmS5DOTG8NRDf6i-nyl8KaVMphdi_r9IH-gWJOVeiDZq_7o_kz9USfR5PgG_YKIIkyvSR0c0SPc=w1920-h942" },
                    { 29, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1263), "Thọ", 21, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1264), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmQz-WwJ7-i2eJ45Qr6BiRUwCo8DHwkVwlCbxs1MtwPmSw-lHiVvWLrTAs3iMzJVF8w1IOjrWDM=w1227-h942" },
                    { 30, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1265), "Thọ", 22, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1265), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmSuK7_uZK82f_66unnoVo6u4dRzBo5T5zUQR_u8TnI8XARlMtRe6N6F8vE91uD21CKuDk0ELtY=w1227-h942" },
                    { 31, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1266), "Thọ", 23, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1266), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTilrtmH9aBybqu0V9jTv1o22Wp8js_VpUlOBQzuFK1_qdoTOt0UhOGaWd5EJEasUH4N-J9vmA=w1227-h942" },
                    { 32, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1267), "Thọ", 24, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1268), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmSFqrTdJT99U1F7HntKeHOjTAS7sgECBplhkw-TSiITLAyuhoX1sQTB4cjrm0N7DBwXFAz5-D4=w1227-h942" }
                });

            migrationBuilder.InsertData(
                table: "ProductImage",
                columns: new[] { "Id", "CreateAt", "CreateBy", "ProductId", "UpdateAt", "UpdateBy", "Url" },
                values: new object[,]
                {
                    { 33, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1269), "Thọ", 25, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1269), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTEUEKwQOEewqV-ESF-pl3aR9sP8HkrfD5jdqphisjOX3McbNK0T-27YTIKZUI9GJkyoLvbPEw=w1227-h942" },
                    { 34, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1270), "Thọ", 26, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1270), "Thọ", "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTQbOt-mTEei7yMw9j7rGCMhD9MVFIXiLPzDWyWdjTFdPeynXMev4fF9cF6w9W727c4O_MhRoo=w1227-h942" }
                });

            migrationBuilder.InsertData(
                table: "ProductSize",
                columns: new[] { "Id", "CreateAt", "CreateBy", "ProductId", "SizeId", "UpdateAt", "UpdateBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1374), "Thọ", 1, 1, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1375), "Thọ" },
                    { 2, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1376), "Thọ", 1, 2, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1376), "Thọ" },
                    { 3, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1377), "Thọ", 1, 3, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1377), "Thọ" },
                    { 4, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1378), "Thọ", 1, 4, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1379), "Thọ" },
                    { 5, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1379), "Thọ", 1, 5, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1380), "Thọ" },
                    { 6, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1380), "Thọ", 1, 6, new DateTime(2022, 9, 25, 12, 16, 28, 134, DateTimeKind.Local).AddTicks(1381), "Thọ" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Account_UserInfoId",
                table: "Account",
                column: "UserInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_ProductId",
                table: "Post",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_AccountId",
                table: "Product",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CateId",
                table: "Product",
                column: "CateId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_UserInfoId",
                table: "Product",
                column: "UserInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetail_ProductId",
                table: "ProductDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ProductId",
                table: "ProductImage",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSize_ProductId",
                table: "ProductSize",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSize_SizeId",
                table: "ProductSize",
                column: "SizeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "ProductDetail");

            migrationBuilder.DropTable(
                name: "ProductImage");

            migrationBuilder.DropTable(
                name: "ProductSize");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "UserInfos");
        }
    }
}
