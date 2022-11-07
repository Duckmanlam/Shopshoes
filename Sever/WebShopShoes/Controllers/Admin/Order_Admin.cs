using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopShoes.Data;
using WebShopShoes.Dto.Product_Admin;
using WebShopShoes.IService.Admin.IShop;

namespace WebShopShoes.Controllers.Admin
{
    [Route("api/[controller]"),Authorize ]
    [ApiController]
    public class Order_Admin : ControllerBase
    {
        private readonly IPaymentPage _paymentPage;

        public Order_Admin(IPaymentPage paymentPage)
        {
            _paymentPage = paymentPage;
        }

        [HttpPost]
        public IActionResult Order(List<OrderPageDto> paymentPage)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var order = _paymentPage.Order(paymentPage);
            return Ok(order);
        }

        [HttpGet, Authorize(Roles = "True")]
        public IActionResult GetOrder()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var order = _paymentPage.GetOrder();
            return Ok(order);
        }
    }
}
