using Microsoft.EntityFrameworkCore;
using ShopShoes.Data.DetailPage_Description.DetailPage;
using ShopShoes.Data.DetailPage_Description_Home.DetailPage;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebShopShoes.Data.Account;
using WebShopShoes.Data.DetailPage_Description_Home.DetailPage;
using WebShopShoes.Data.Enum;

namespace WebShopShoes.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Value = "Nike Air Max 2021"
                }, new Category()
                {
                    Id = 2,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Value = "What’s Trending Now"
                }, new Category()
                {
                    Id = 3,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Value = "Share With #Shoppes"
                }, new Category()
                {
                    Id = 4,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Value = "Latest From Blogs"
                }
                );
            modelBuilder.Entity<ProductData>().HasData(
                new ProductData
                {
                    Id = 1,
                    AccountId = 1,
                    UserInfoId = 1,
                    CateId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 2,
                    CateId = 1,
                    AccountId = 1,
                    UserInfoId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 3,
                    CateId = 1,
                    AccountId = 1,
                    UserInfoId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 4,
                    CateId = 1,
                    AccountId = 1,
                    UserInfoId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 5,
                    CateId = 1,
                    AccountId = 1,
                    UserInfoId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 6,
                    CateId = 1,
                    AccountId = 1,
                    UserInfoId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 7,
                    CateId = 1,
                    AccountId = 1,
                    UserInfoId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 8,
                    CateId = 1,
                    AccountId = 1,
                    UserInfoId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 9,
                    CateId = 1,
                    AccountId = 1,
                    UserInfoId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 10,
                    CateId = 1,
                    AccountId = 1,
                    UserInfoId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 11,
                    CateId = 1,
                    AccountId = 1,
                    UserInfoId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 12,
                    CateId = 1,
                    AccountId = 1,
                    UserInfoId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 13,
                    CateId = 1,
                    AccountId = 1,
                    UserInfoId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 14,
                    CateId = 1,
                    AccountId = 1,
                    UserInfoId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 15,
                    CateId = 1,
                    AccountId = 1,
                    UserInfoId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 16,
                    CateId = 4,
                    AccountId = 1,
                    UserInfoId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 17,
                    CateId = 4,
                    AccountId = 2,
                    UserInfoId = 2,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 18,
                    CateId = 4,
                    AccountId = 3,
                    UserInfoId = 3,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 19,
                    CateId = 4,
                    AccountId = 4,
                    UserInfoId = 4,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 20,
                    CateId = 4,
                    AccountId = 5,
                    UserInfoId = 5,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 21,
                    CateId = 4,
                    AccountId = 6,
                    UserInfoId = 6,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 22,
                    CateId = 4,
                    AccountId = 7,
                    UserInfoId = 7,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 23,
                    CateId = 4,
                    AccountId = 8,
                    UserInfoId = 8,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 24,
                    CateId = 4,
                    AccountId = 9,
                    UserInfoId = 9,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 25,
                    CateId = 4,
                    AccountId = 10,
                    UserInfoId = 10,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                },
                new ProductData
                {
                    Id = 26,
                    CateId = 4,
                    AccountId = 10,
                    UserInfoId = 10,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                }
                );
            modelBuilder.Entity<ProductDetail>().HasData(
                new ProductDetail
                {
                    Id = 1,
                    ProductName = "Nike ZoomX Streakfly",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 213,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "M"
                },
                new ProductDetail
                {
                    Id = 2,
                    ProductName = "Nike Air Max 2021",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 189,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "S"
                },
                new ProductDetail
                {
                    Id = 3,
                    ProductName = "Nike Air Max 2021",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 173,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "L"
                },
                new ProductDetail
                {
                    Id = 4,
                    ProductName = "Nike Air Max 2021",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 120,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "M"
                },
                new ProductDetail
                {
                    Id = 5,
                    ProductName = "Nike ZoomX Streakfly",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 213,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "M"
                },
                new ProductDetail
                {
                    Id = 6,
                    ProductName = "Nike ZoomX Streakfly",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 213,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "M"
                },
                new ProductDetail
                {
                    Id = 7,
                    ProductName = "Nike ZoomX Streakfly",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 213,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "M"
                },
                new ProductDetail
                {
                    Id = 8,
                    ProductName = "Nike ZoomX Streakfly",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 213,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "L"
                },
                new ProductDetail
                {
                    Id = 9,
                    ProductName = "Nike ZoomX Streakfly",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 213,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "L"
                },
                new ProductDetail
                {
                    Id = 10,
                    ProductName = "Nike ZoomX Streakfly",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 213,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "L"
                },
                new ProductDetail
                {
                    Id = 11,
                    ProductName = "Nike ZoomX Streakfly",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 213,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "S"
                },
                new ProductDetail
                {
                    Id = 12,
                    ProductName = "Nike ZoomX Streakfly",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 213,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 1,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "L"
                },
                new ProductDetail
                {
                    Id = 13,
                    ProductName = "Nike Air Max INTRLK1",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 213,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 2,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "M"
                },
                new ProductDetail
                {
                    Id = 14,
                    ProductName = "Nike Air Max INTRLK",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 213,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 2,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "L"
                },
                new ProductDetail
                {
                    Id = 15,
                    ProductName = "Nike Air Max",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 213,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 3,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "L"
                },
                new ProductDetail
                {
                    Id = 16,
                    ProductName = "Nike Air Max",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Velit officia consequat duis enim velit mollit. Exercitation veniam consequat sunt nostrud amet. ",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 213,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 4,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "L"
                },
                new ProductDetail
                {
                    Id = 17,
                    ProductName = "Nike ZoomX Streakfly",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 213,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 4,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "S"
                },
                new ProductDetail
                {
                    Id = 18,
                    ProductName = "Nike ZoomX Streakfly",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 213,
                    Status = Status.Action,
                    Stock = 50,
                    
                    ProductId = 4,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "S"
                },
                new ProductDetail
                {
                    Id = 19,
                    ProductName = "Nike ZoomX Streakfly",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 213,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 4,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "S"
                },
                new ProductDetail
                {
                    Id = 20,
                    ProductName = "Nike ZoomX Streakfly",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 213,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 4,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "S"
                },
                new ProductDetail
                {
                    Id = 21,
                    ProductName = "Nike ZoomX Streakfly",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 213,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 4,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "S"
                },
                new ProductDetail
                {
                    Id = 22,
                    ProductName = "Nike ZoomX Streakfly",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 213,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 4,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "S"
                },
                new ProductDetail
                {
                    Id = 23,
                    ProductName = "Nike ZoomX Streakfly",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 213,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 4,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "S"
                },
                new ProductDetail
                {
                    Id = 24,
                    ProductName = "Nike ZoomX Streakfly",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 213,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 4,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "S"
                },
                new ProductDetail
                {
                    Id = 25,
                    ProductName = "Nike ZoomX Streakfly",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 213,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 4,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "S"
                },
                new ProductDetail
                {
                    Id = 26,
                    ProductName = "Nike ZoomX Streakfly",
                    ViewCount = 99,
                    Type = "Road Racing Shoes",
                    Description = "Our lightest racing shoe, the Nike ZoomX Streakfly is all about the speed you need to take on the competition in a mile, 5K or 10K race.",
                    BrandName = "Men's Shoes",
                    Style = "Sport, Design, Lifestyle",
                    Price = 213,
                    Status = Status.Action,
                    Stock = 50,
                    ProductId = 4,
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ",
                    Size = "S"
                }
                );
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = 1,
                    ProductId = 1,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 2,
                    ProductId = 2,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 3,
                    ProductId = 3,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 4,
                    ProductId = 4,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 5,
                    ProductId = 5,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 6,
                    ProductId = 6,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 7,
                    ProductId = 7,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 8,
                    ProductId = 8,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 9,
                    ProductId = 9,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 10,
                    ProductId = 10,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 11,
                    ProductId = 11,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 12,
                    ProductId = 12,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 13,
                    ProductId = 13,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 14,
                    ProductId = 14,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 15,
                    ProductId = 15,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 16,
                    ProductId = 16,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 17,
                    ProductId = 17,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 18,
                    ProductId = 18,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 19,
                    ProductId = 19,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 20,
                    ProductId = 20,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 21,
                    ProductId = 21,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 22,
                    ProductId = 22,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 23,
                    ProductId = 23,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 24,
                    ProductId = 24,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 25,
                    ProductId = 25,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new Post
                {
                    Id = 26,
                    ProductId = 26,
                    Title = "Lorem ipsum dolor sit amet",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                }
                );
            modelBuilder.Entity<ProductImage>().HasData(
                new ProductImage
                {
                    Id = 1,
                    ProductId = 1,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmR4vAg9_VJqlg0WiateWDeoYd84lQzvlnvyHE3ltsfWXAl51_Zbqo6djfpEtbb1Ce_QMOZLLcY=w1920-h870",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 2,
                    ProductId = 2,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmR0Qt1lRYg8j6MohwJizIoHlmtCMAWr1Xz9rOo9fgG4FDmn9Lsr_iS35PHV8WZJpsvMpEzDmuw=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 3,
                    ProductId = 3,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTgImoHZJrU_oKyn3jSyXhZ9H4f_P0wnLnTLgJ5ot5b7cbu7w_8QTDAKcfeG9HRxmrYcyVRVrM=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 4,
                    ProductId = 4,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmSzha5C6XgTCNn6T7eTHsPtK3xbrPYozPTB6H9ncdhslaIQ5_fbC2ZEdeZRb3jVAmb0tUXOOzQ=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 5,
                    ProductId = 5,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmS7fSF_4Vne106vjZYi5BCCoOwTp1dMMMss0VGspT710V0we8uD1XSQsbVKXeAgwAoY3x-ALe8=w1920-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 6,
                    ProductId = 6,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmS2DdTXZn7JHxzvtenGEFP54si7KwpA5zbDXJrdV827T10ywAGDfbA6SYy9M-oQPMZwJhnuY7M=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 7,
                    ProductId = 7,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTWUXZTo8l_TA45IxD7M8fC4n_pwEOjDGruNxId2OlkGAHyTNCfla2krsgrnWD2DspL6jOaeKA=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 8,
                    ProductId = 8,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmSYDQlTou0wVQAgJP4zwOZh974gYnghEBSWW7osgjwmOVTnPzokGHxrAGfTpjjDIYHUxpj1-q8=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 9,
                    ProductId = 9,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmRfbfebyhTCGvqmRRUBbzVQWAYRlIYTcAV1RpXRmezYF5ul1t-n0pvc7-AYmYAS_PSuyQ5WSYE=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 10,
                    ProductId = 10,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmT2FOk__XzMJMAwi4O52i1SSaNOsq9rvC4nKCsmZpoAtxMjsaLnD-4V6fDxHaUQXd9POiGMSdI=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 11,
                    ProductId = 11,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmS1_joTMhNpGm3G8wlOUMu2_-wIXJIZOmcFXdm0OHN9VPujgDZpNE9a8OAW9BLbBSV9uovPJpU=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 12,
                    ProductId = 12,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTbqSDLhKZn64IvFgHoxBMjtMCQaY4-uvbZFOXSxJ_Xdx2XMwNn_Q_SqX35UPHJbLTTW3LjynI=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 13,
                    ProductId = 13,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTPwB6XLePBDMdQIxmULC-p8nGvxdc2489xhdoxkvUmlYO8_h8tsEcJfth-fYV7qeCllHfyELs=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 14,
                    ProductId = 14,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTPwB6XLePBDMdQIxmULC-p8nGvxdc2489xhdoxkvUmlYO8_h8tsEcJfth-fYV7qeCllHfyELs=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 15,
                    ProductId = 15,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmRPMfPGpYXIST9WSiO7XEZ4xwlXe7jdLP50a7zbAuieuj1KQk37XzH1o5iSkucYsbMCaG9nV7s=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 16,
                    ProductId = 15,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmSFndNwoL38dLS02ZQZq23lySy2b_owXoh8g3_F-grg_K2pzpPr-i5mW9o-TvAOqKxy7ujgxwE=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 17,
                    ProductId = 15,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTdqjIzoQZMeanNAY451fIqFA5jXkPin8tUsyRBvdnxP2-8fLTIU_g_L33-DNVFwQc-c5PIoQA=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 18,
                    ProductId = 15,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmQEMkYhXMgz8hyq1qUSEStTMWKr2HEx2MQJ05XEL1KGsekFvwJ5O0F5vvHpLHV30aCk6aE5SfY=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 19,
                    ProductId = 15,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTaS169x9VUuSmGkLI3AovRuj-1x3ksDBdcLa6u5DqXwyi_4eFo7Cjor1dyz-n1U_Q2AgvdXhQ=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 20,
                    ProductId = 15,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmRVTTvkT3h8aCxHpD1oph_9LeUf3yG_XSPuv78Wc_vv2GvOUK0stF9uuA_6YJfF5C7ZvVtY4BY=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 21,
                    ProductId = 16,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTvLtmK_3tvbcpYmnFYDj3ZFdorwQwyIZ7gLqELtYzzmGTLgIcsyHTDChyd_U58qkNSkL1k8s0=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 22,
                    ProductId = 17,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTuZc5_TEzRQrm39Or3fiZ9Eq-C8Om7dTUzKkPcN6zAYZoq-YBhAqv_mGg9yH--PXQEd3nhvFI=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 23,
                    ProductId = 18,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmQzZOUm0GObCQ0a02AYELgaqllB_mty-xfnceYJO8kqKhr50H7TwkTRfP6SGkKXBL5dzwQCYDg=w1920-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 24,
                    ProductId = 19,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmRfdJ3oCpC7sLj0s_xe3futZBGrFbmshAUwtLBzrHRCizSLb64w3z22ZjF3Dr_K5h4otfzTcB8=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 25,
                    ProductId = 19,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTyf7uAxvp8Q1mbPWyy4gjyZHbmEpBcyVFl7oLXTj-ZXprskDlWFVbFyAQ2v7rzTMMK30uwX_s=w1920-h870",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 26,
                    ProductId = 19,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTxzqu_dRaDCjrAtb8o2_1MWhL68FRUiXxzjDgnuuszkQaYjhRhe39gzwtoA7TV3dSJoVC7QvQ=w1920-h870",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 27,
                    ProductId = 19,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmT0SF5XBkpO1AM14Jh1JzARgXoeaqUpPTpYHqOwsLfd7WWgi-5Fz7Bi8kQl3Qybqg-wuCl0vxs=w1227-h870",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 28,
                    ProductId = 20,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmS5DOTG8NRDf6i-nyl8KaVMphdi_r9IH-gWJOVeiDZq_7o_kz9USfR5PgG_YKIIkyvSR0c0SPc=w1920-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 29,
                    ProductId = 21,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmQz-WwJ7-i2eJ45Qr6BiRUwCo8DHwkVwlCbxs1MtwPmSw-lHiVvWLrTAs3iMzJVF8w1IOjrWDM=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 30,
                    ProductId = 22,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmSuK7_uZK82f_66unnoVo6u4dRzBo5T5zUQR_u8TnI8XARlMtRe6N6F8vE91uD21CKuDk0ELtY=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new ProductImage
                {
                    Id = 31,
                    ProductId = 23,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTilrtmH9aBybqu0V9jTv1o22Wp8js_VpUlOBQzuFK1_qdoTOt0UhOGaWd5EJEasUH4N-J9vmA=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                }, new ProductImage
                {
                    Id = 32,
                    ProductId = 24,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmSFqrTdJT99U1F7HntKeHOjTAS7sgECBplhkw-TSiITLAyuhoX1sQTB4cjrm0N7DBwXFAz5-D4=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                }, new ProductImage
                {
                    Id = 33,
                    ProductId = 25,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTEUEKwQOEewqV-ESF-pl3aR9sP8HkrfD5jdqphisjOX3McbNK0T-27YTIKZUI9GJkyoLvbPEw=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                }, new ProductImage
                {
                    Id = 34,
                    ProductId = 26,
                    Url = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTQbOt-mTEei7yMw9j7rGCMhD9MVFIXiLPzDWyWdjTFdPeynXMev4fF9cF6w9W727c4O_MhRoo=w1227-h942",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                }
                );
            modelBuilder.Entity<UserInfo>().HasData(
                new UserInfo
                {
                    Id = 1,
                    UserName = "Cameron Williamson",
                    Avatar = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTkno76-PO7yj1SWFtb7xXymbwwx_ELrptddJQTqx1w4CAeED45Oxq9dKA1pJ7MKr7XKILtx2A=w1227-h942",
                    CommentDate = DateTime.Now,
                    Articles = 22,
                    Phone = "0912334556",
                    Address = "TPHCM",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new UserInfo
                {
                    Id = 2,
                    UserName = "Marvin McKinney",
                    Avatar = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmSllVOpJ4bFn8KhYuU2AoK7cjpATKDAFaVTigqQA48SvIZUnkJQhRZJcUkeoNc7d5TBHoTaDPM=w1227-h942",
                    CommentDate = DateTime.Now,
                    Articles = 22,
                    Phone = "0912334556",
                    Address = "TPHCM",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new UserInfo
                {
                    Id = 3,
                    UserName = "Savannah Nguyen",
                    Avatar = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmQHfbxWQbi9UUAC5yBmIQ6CFtyRpJWFdn86xK19uUOMkFwYhp9NCzicFjW64lVIVBugxqXcpTk=w1227-h942",
                    CommentDate = DateTime.Now,
                    Articles = 22,
                    Phone = "0912334556",
                    Address = "TPHCM",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new UserInfo
                {
                    Id = 4,
                    UserName = "Floyd Miles",
                    Avatar = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTTPOtVqTt44d9bl4A39QsUjDy6ase9QP7ngNLmMdRBHbXJxe2tSCTp3TXt-Bn_sMGaXZkCopM=w1227-h942",
                    CommentDate = DateTime.Now,
                    Articles = 22,
                    Phone = "0912334556",
                    Address = "TPHCM",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new UserInfo
                {
                    Id = 5,
                    UserName = "Robert Fox",
                    Avatar = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmSd_ZBOEd96gm5DXZ2xNLKFEou_yMnVkESUMsNcMRH7F3uSo5iA6yROmGLdey2m2MyJiKyIvwg=w1227-h942",
                    CommentDate = DateTime.Now,
                    Articles = 22,
                    Phone = "0912334556",
                    Address = "TPHCM",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new UserInfo
                {
                    Id = 6,
                    UserName = "Annette Black",
                    Avatar = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmQgAUbcyrXWpcEjWHzfor_RdhZq4iJPcf3P75H-rHNeH9_qXb_Ra_yFxVRHfRCTm7mpop-IrmU=w1227-h942",
                    CommentDate = DateTime.Now,
                    Articles = 22,
                    Phone = "0912334556",
                    Address = "TPHCM",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new UserInfo
                {
                    Id = 7,
                    UserName = "Albert Flores",
                    Avatar = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTECUDyD6CrPj-uKThzv6a-_FhTupFlJHqXYEVagDJ8FJMtixXxTfjmgNytCa5UxuOJeGd3hkM=w1227-h942",
                    CommentDate = DateTime.Now,
                    Articles = 22,
                    Phone = "0912334556",
                    Address = "TPHCM",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new UserInfo
                {
                    Id = 8,
                    UserName = "Ralph Edwards",
                    Avatar = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTFHAXFwtup8lamnrjVUjY8bVzqtr7ruK0Qs1IcVyVWE2ghe3FjAgxOSTj3jL5Bh7MnReltkcM=w1227-h942",
                    CommentDate = DateTime.Now,
                    Articles = 22,
                    Phone = "0912334556",
                    Address = "TPHCM",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new UserInfo
                {
                    Id = 9,
                    UserName = "Darrell Steward",
                    Avatar = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmTjymN3FZshBq7TsEp2tlXl17hKZEtJ4qFxy2s0uDwkS5zRI61EhW6TbtxGz-p8dbKJUzErTx0=w1227-h942",
                    CommentDate = DateTime.Now,
                    Articles = 22,
                    Phone = "0912334556",
                    Address = "TPHCM",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                },
                new UserInfo
                {
                    Id = 10,
                    UserName = "Ronald Richards",
                    Avatar = "https://lh3.googleusercontent.com/drive-viewer/AJc5JmQ6ogjNNiTjeBWtaB35AhoZ_xqtFH4dkeGNDxs11RdZxeEB6H6ZIBeKkRaTlm0yBOwiI9OIkE8=w1227-h942",
                    CommentDate = DateTime.Now,
                    Articles = 22,
                    Phone = "0912334556",
                    Address = "TPHCM",
                    CreateAt = DateTime.Now,
                    CreateBy = "Thọ",
                    UpdateAt = DateTime.Now,
                    UpdateBy = "Thọ"
                }
                );
            modelBuilder.Entity<AccountData>().HasData(
                new AccountData
                {
                    Id = 1,
                    Username = "thonguyen123",
                    Password = "$2a$06$UjYOc10v92VdCNzx82jRSuOrsOPY8lugsVPQwMdYIxxttcG7.tuHK",
                    isAdmin = true,
                    UserInfoId = 1,
                },
                new AccountData
                {
                    Id = 2,
                    Username = "tranvan123",
                    Password = "$2a$06$UjYOc10v92VdCNzx82jRSuOrsOPY8lugsVPQwMdYIxxttcG7.tuHK",
                    isAdmin = true,
                    UserInfoId = 2,
                },
                new AccountData
                {
                    Id = 3,
                    Username = "ducchi123",
                    Password = "$2a$06$UjYOc10v92VdCNzx82jRSuOrsOPY8lugsVPQwMdYIxxttcG7.tuHK",
                    isAdmin = true,
                    UserInfoId = 3,
                },
                new AccountData
                {
                    Id = 4,
                    Username = "dinhtho123",
                    Password = "$2a$06$UjYOc10v92VdCNzx82jRSuOrsOPY8lugsVPQwMdYIxxttcG7.tuHK",
                    isAdmin = true,
                    UserInfoId = 4,
                },
                new AccountData
                {
                    Id = 5,
                    Username = "conghau123",
                    Password = "$2a$06$UjYOc10v92VdCNzx82jRSuOrsOPY8lugsVPQwMdYIxxttcG7.tuHK",
                    isAdmin = true,
                    UserInfoId = 5,
                },
                new AccountData
                {
                    Id = 6,
                    Username = "baovo123",
                    Password = "$2a$06$UjYOc10v92VdCNzx82jRSuOrsOPY8lugsVPQwMdYIxxttcG7.tuHK",
                    isAdmin = true,
                    UserInfoId = 6,
                },
                new AccountData
                {
                    Id = 7,
                    Username = "hieunguyen123",
                    Password = "$2a$06$UjYOc10v92VdCNzx82jRSuOrsOPY8lugsVPQwMdYIxxttcG7.tuHK",
                    isAdmin = true,
                    UserInfoId = 7,
                },
                new AccountData
                {
                    Id = 8,
                    Username = "nhinguyen123",
                    Password = "$2a$06$UjYOc10v92VdCNzx82jRSuOrsOPY8lugsVPQwMdYIxxttcG7.tuHK",
                    isAdmin = true,
                    UserInfoId = 8,
                },
                new AccountData
                {
                    Id = 9,
                    Username = "thuannguyen123",
                    Password = "$2a$06$UjYOc10v92VdCNzx82jRSuOrsOPY8lugsVPQwMdYIxxttcG7.tuHK",
                    isAdmin = true,
                    UserInfoId = 9,
                },
                new AccountData
                {
                    Id = 10,
                    Username = "baonguyen123",
                    Password = "$2a$06$UjYOc10v92VdCNzx82jRSuOrsOPY8lugsVPQwMdYIxxttcG7.tuHK",
                    isAdmin = true,
                    UserInfoId = 10,
                }
                );


        }
    }
}
