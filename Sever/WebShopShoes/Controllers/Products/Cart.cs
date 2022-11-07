//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using WebShopShoes.IService.Products.ICart;
//using WebShopShoes.Model;
//using WebShopShoes.Helpers;
//using ShopShoes.Data;

//namespace WebShopShoes.Controllers.Products
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class Cart : ControllerBase
//    {
//        private readonly ICartProduct _cartProduct;
//        private readonly ShopDbContext _shopDbContext;

//        public Cart(ICartProduct cartProduct, ShopDbContext shopDbContext)
//        {
//            _cartProduct = cartProduct;
//            _shopDbContext = shopDbContext;
//        }
//        public List<CartItem> carts
//        {
//            get
//            {
//                var data = HttpContext.Session.Get<List<CartItem>>("Cart");
//                if (data == null)
//                {
//                    data = new List<CartItem>();

//                }
//                return data;
//            }
//        }

//        [HttpGet]
//        public IActionResult GetCart(int id)
//        {
//            var myCart = _cartProduct.GetAllCart(id, carts);
//            HttpContext.Session.Set("Cart", myCart);
//            return Ok(myCart);
//        }
//    }
//}
