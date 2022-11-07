using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebShopShoes.Data.Order;
using WebShopShoes.Data.Enum;

namespace WebShopShoes.Model.Admin
{
    public class OrderDetailModel_Admin
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string ProductName { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipPhoneNumber { get; set; }
        public OrderStatus Status { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total { get; set; }
        public string BrandName { get; set; }
        public string Size { get; set; }
        public string ProductImage { get; set; }
    }
}
