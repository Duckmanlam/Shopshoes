using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShopShoes.IService.Admin.IShop;

namespace WebShopShoes.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryDetail_Admin : ControllerBase
    {
        private readonly IShop _shop;

        public CategoryDetail_Admin(IShop shop)
        {
            _shop = shop;
        }

        [HttpGet("{productId}") ,Authorize(Roles = "True")]
        public IActionResult GetCategoryDetail(int productId)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }    
            var product = _shop.GetDetailShop_Admins(productId);
            if (product == null)
                BadRequest($"Didn't find product with id {productId}");
            return Ok(product);
        }
    }
}
