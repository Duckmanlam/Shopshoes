using WebShopShoes.Data.Enum;

namespace WebShopShoes.Dto.Product_Admin
{
    public class AddProductAdmin
    {

        public string ProductName { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string BrandName { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Size { get; set; }

        public Status Status { get; set; }
    }
}
