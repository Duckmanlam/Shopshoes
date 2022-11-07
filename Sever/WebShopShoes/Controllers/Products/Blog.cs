using Microsoft.AspNetCore.Mvc;
using ShopShoes.IService.IBlog;
using WebShopShoes.Model;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebShopShoes.Controllers.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class Blog : ControllerBase
    {
        private readonly IBlog _blog;
        

        public Blog(IBlog blog)
        {
            _blog = blog;
        }
        // GET: api/<Blog>
        [HttpGet("GetAllBlog")]
        public IActionResult GetAllBlog(string? search , int page = 1)
        {
            int CategoryId = 4;
            var blogs = _blog.AllBlog(search, CategoryId, page);
            return Ok(blogs);
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
