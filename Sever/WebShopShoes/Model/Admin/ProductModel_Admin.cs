using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebShopShoes.Data.Enum;

namespace WebShopShoes.Model.Admin
{
    public class ProductModel_Admin
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public int ViewCount { get; set; }
        public double Price { get; set; }
        public Status Status { get; set; }
        public DateTime CreateAt { get; set; }
        public string ProductImage { get; set; }

    }
}
