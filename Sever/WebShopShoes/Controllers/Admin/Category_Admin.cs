using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopShoes.Data.DetailPage_Description.DetailPage;
using WebShopShoes.Dto.Product_Admin;
using WebShopShoes.Dto.ProductImage;
using WebShopShoes.IService.Admin.IShop;
using WebShopShoes.IService.IShop;

namespace WebShopShoes.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class Category_Admin : ControllerBase
    {
        private readonly IShop _shop;

        public Category_Admin (IShop shop)
        {
            _shop = shop;
        }

        [HttpGet, Authorize(Roles = "True")]
        public IActionResult AllProduct(string? search, double? from, double? to, string? sortBy, int page = 1)
        {
            int cateId = 1;
            var allProducts = _shop.GetAllProduct(search, from, to, sortBy, cateId, page).DistinctBy(x => x.ProductId);
            return Ok(allProducts);
        }

        [HttpGet("{productId}"), Authorize(Roles = "True")]
        public IActionResult GetProductById(int productId)
        {
            var allProducts = _shop.GetById(productId);
            return Ok(allProducts);
        }

        [HttpPut, Authorize(Roles = "True")]
        public IActionResult Update(int productId,[FromForm] UpdateProduct updateProduct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var putProduct = _shop.UpdateProduct(productId,updateProduct);
            return Ok(putProduct);
        }

        [HttpPost("AddProduct") ,Authorize(Roles = "True")]
        public async Task<IActionResult> AddProduct([FromForm] AddProductAdmin product , [FromForm] ProductImageCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var addProduct = _shop.AddProduct(product ,request);
            return Ok(addProduct);
        }

        [HttpDelete ("{productId}"), Authorize(Roles = "True")]
        public IActionResult DeleteProduct(int productId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var deleteProduct = _shop.DeleteProduct(productId);
            return Ok(deleteProduct);
        }
    }
}
