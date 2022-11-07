using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopShoes.Data;
using ShopShoes.Data.DetailPage_Description.DetailPage;
using ShopShoes.IService.DetailPage_Description;

namespace WebShopShoes.Controllers.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailProductDescription : ControllerBase
    {
        private readonly IProduct _product;

        public DetailProductDescription(IProduct product)
        {
            _product = product;
        }
        [HttpGet("GetByLocal")]
        public IActionResult GetByLocal(string ProductName = "Nike Air Max INTRLK1")
        {
            var products = _product.GetByLocal(ProductName);
            return Ok(products);
        }

        [HttpGet("GetRelatedProducts")]
        public IActionResult GetRelatedProducts()
        {
            int id = 1;
            var products = _product.GetRelatedProducts(id);
            return Ok(products);
        }
    }
}
