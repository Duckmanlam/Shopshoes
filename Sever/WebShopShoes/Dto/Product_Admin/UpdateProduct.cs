using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebShopShoes.Data.Enum;
using WebShopShoes.Migrations;
using ShopShoes.Data.DetailPage_Description_Home.DetailPage;

namespace WebShopShoes.Dto.Product_Admin
{
    public class UpdateProduct
    {
        public string ProductName { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public Status Status { get; set; }
        public IFormFile ImageFile { get; set; }

    }
}
