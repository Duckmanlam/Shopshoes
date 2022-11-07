using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebShopShoes.Data.Enum;

namespace WebShopShoes.Data.Order
{
    [Table("Order")]
    public class OrderData
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string ProductName { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipPhoneNumber { get; set; }
        public OrderStatus Status { get; set; }
        [ForeignKey("OrderId")]
        public List<OrderDetail> OrderDetail { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        


    }
}
