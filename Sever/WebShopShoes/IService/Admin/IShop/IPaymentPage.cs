using WebShopShoes.Data.Order;
using WebShopShoes.Dto.Product_Admin;
using WebShopShoes.Model.Admin;

namespace WebShopShoes.IService.Admin.IShop
{
    public interface IPaymentPage
    {
        public OrderModel_Admin Order(List<OrderPageDto> paymentPage);
        public OrderModel_Admin GetOrder();

    }
}
