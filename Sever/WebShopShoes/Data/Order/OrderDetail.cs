using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ShopShoes.Data.DetailPage_Description.DetailPage;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebShopShoes.Data.Enum;

namespace WebShopShoes.Data.Order
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Key, ForeignKey("OrderId")]
        public Guid OrderId { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public ProductData Product { get; set; }
        
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public string ProductImage { get; set; }
        public string Size { get; set; }



    }
}
