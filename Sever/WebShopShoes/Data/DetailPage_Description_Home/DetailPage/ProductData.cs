
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using ShopShoes.Data.DetailPage_Description_Home.DetailPage;
using WebShopShoes.Controllers;
using WebShopShoes.Data.DetailPage_Description_Home.DetailPage;
using WebShopShoes.Data.Account;
using WebShopShoes.Data.Order;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace ShopShoes.Data.DetailPage_Description.DetailPage
{
    [Table("Product")]
    public class ProductData
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ProductId")]
        public List<ProductDetail> ProductDetails { get; set; }
        [ForeignKey("CateId")]
        public int CateId { get; set; }
        [ForeignKey("ProductId")]
        public List<ProductImage> ProductImages { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public virtual UserInfo UserInfo { get; set; }
        public int? UserInfoId { get; set; }
        [ForeignKey("AccountId")]
        public int AccountId { get; set; }
        [ForeignKey("ProductId")]
        public List<Post> Posts{ get; set; }
        [Required]
        public DateTime CreateAt { get; set; }
        [Required]
        public DateTime UpdateAt { get; set; }
        [Required]
        public string CreateBy { get; set; }
        [Required]
        public string UpdateBy { get; set; }


    }
}
