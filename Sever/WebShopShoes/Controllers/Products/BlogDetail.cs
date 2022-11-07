using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopShoes.IService.IBlog;

namespace WebShopShoes.Controllers.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogDetail : ControllerBase
    {
        private readonly IBlog _blog;

        public BlogDetail(IBlog blog)
        {
            _blog = blog;
        }
        [HttpGet("ProductBlog")]
        public IActionResult GetProductBlog(string? search, int productId = 19)
        {
            int categoryId = 4;
            var blogDetail = _blog.BlogDetail(search, categoryId, productId);
            return Ok(blogDetail);
        }
        // GET api/<Blog>/5
        [HttpGet("RecentPost")]
        public IActionResult GetRecentPost()
        {
            int CategoryId = 4;
            var blogs = _blog.RecentPost(CategoryId);
            return Ok(blogs);
        }

        // GET api/<Blog>/5
        [HttpGet("PopularPost")]
        public IActionResult GetPopularPost()
        {
            int CategoryId = 4;
            var blogs = _blog.PopularPost(CategoryId);
            return Ok(blogs);
        }

        // GET api/<Blog>/5
        [HttpGet("PopularAuthor")]
        public IActionResult GetPopularAuthor()
        {
            int CategoryId = 4;
            var blogs = _blog.PopularAuthor(CategoryId);
            return Ok(blogs);
        }
    }
}
