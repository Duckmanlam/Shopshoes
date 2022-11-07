using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopShoes.Data.DetailPage_Description.DetailPage;
using ShopShoes.IService.IHomePage;

namespace WebShopShoes.Controllers.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomePage : ControllerBase
    {
        private readonly IHomePage _homePage;

        public HomePage(IHomePage homePage)
        {
            _homePage = homePage;
        }

        [HttpGet("Banner")]
        public IActionResult GetBanner()
        {
            int productId = 1;
            var products = _homePage.Banner(productId);
            return Ok(products);
        }
        [HttpGet("ProductCategory")]

        public IActionResult GetProductCategory()
        {
            int CateId = 1;
            var products = _homePage.ProductCategory(CateId);
            return Ok(products);
        }
        [HttpGet("Trending")]
        public IActionResult GetProductLatest()
        {
            int cateId = 2;
            var products = _homePage.Trending(cateId);
            return Ok(products);
        }
        //[HttpGet("ProductImage")]
        //public IActionResult GetProductImage(int id = 5)
        //{
        //    var products = _homePage.ProductImage(id);
        //    return Ok(products);
        //}
        [HttpGet("ListCategory")]
        public IActionResult GetListCategory()
        {
            int id = 4;
            var products = _homePage.ListCategory(id);
            return Ok(products);
        }
    }
}
