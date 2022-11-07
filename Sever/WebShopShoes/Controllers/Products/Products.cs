using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShopShoes.IService.IShop;

namespace WebShopShoes.Controllers.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class Products : ControllerBase
    {
        private readonly IAllProduct _allProduct;

        public Products(IAllProduct allProduct)
        {
            _allProduct = allProduct;
        }

        [HttpGet("AllProductInUser")]
        public IActionResult AllProduct(string? search, double? from, double? to, string? sortBy, int page = 1)
        {
            int cateId = 1;
            var allProducts = _allProduct.AllProduct(search, from, to, sortBy, cateId, page);
            return Ok(allProducts);
        }
    }
}
