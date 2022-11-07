using WebShopShoes.Data.Enum;

namespace WebShopShoes.Model.Admin
{
    public class DetailShop_Admin
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string BrandName { get; set; }
        public int ViewCount { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Status Status { get; set; }
        public DateTime CreateAt { get; set; }
        public string ProductImage { get; set; }
    }
}
