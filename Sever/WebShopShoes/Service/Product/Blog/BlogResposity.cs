using Microsoft.AspNetCore.Mvc;
using ShopShoes.Data;
using ShopShoes.Data.DetailPage_Description.DetailPage;
using ShopShoes.IService.IBlog;
using ShopShoes.Model;
using ShopShoes.Model.Paging;
using WebShopShoes.Model;

namespace ShopShoes.Service.Blog
{
    public class BlogResposity : IBlog
    {
        private readonly ShopDbContext _shopDbContext;
        public static int page_size { get; set; } = 6;
        public BlogResposity(ShopDbContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
        }
        public List<ProductModel> AllBlog(string? search, int CategoryId, int page)
        {
            var blogs = (from blog in _shopDbContext.Products
                         where blog.CateId == CategoryId
                         select new ProductModel
                         {
                             Id = blog.Id,

                             Account = new ListCategory_User
                             {
                                 Id = blog.Id,
                                 Avatar = blog.UserInfo.Avatar,
                                 UserName = blog.UserInfo.UserName,
                                 OrderBy = blog.UserInfo.CommentDate
                             },
                             ProductDetails = new DetailProductModel
                             {
                                 Id = blog.ProductDetails.FirstOrDefault().Id,
                                 Description = blog.ProductDetails.FirstOrDefault().Description,
                                 Style = blog.ProductDetails.FirstOrDefault().Style
                             },
                             Posts = blog.Posts.FirstOrDefault().Title,
                             ProductImage = blog.ProductImages.FirstOrDefault().Url
                         });
            // search
            if (!string.IsNullOrEmpty(search))
            {
                blogs = blogs.Where(x => x.ProductDetails.Equals(search));
            }

            var result = PaginatedList<ProductModel>.Create(blogs, page, page_size);
            return result;
        }

        public List<ProductModel> PopularAuthor(int CategoryId)
        {

            var blogs = from blog in _shopDbContext.Products
                        where blog.CateId == CategoryId
                        orderby blog.UserInfo.Articles descending
                        select new ProductModel
                        {
                            Id=blog.Id,
                            Account = new ListCategory_User
                            {
                                Id = blog.UserInfo.Id,
                                Avatar = blog.UserInfo.Avatar,
                                Articles = blog.UserInfo.Articles
                            }
                        };
            return blogs.Take(3).ToList();
        }

        public List<ProductModel> PopularPost(int CategoryId)
        {

            var blogs = from blog in _shopDbContext.Products
                        where blog.CateId == CategoryId
                        orderby blog.UserInfo.Articles descending
                        select new ProductModel
                        {
                             Id = blog.Id,
                             ProductDetails = blog.ProductDetails.FirstOrDefault().Description,
                             Account = blog.UserInfo.CommentDate
                        };
            return blogs.Take(3).ToList();
        }

        public List<ProductModel> RecentPost(int CategoryId)
        {

            var blogs = from blog in _shopDbContext.Products
                        where blog.CateId == CategoryId
                        orderby blog.CreateAt descending
                        select new ProductModel
                        {
                            Id = blog.Id,
                            ProductDetails = new DetailProductModel
                            {
                                ProductImage = blog.ProductImages.FirstOrDefault().Url,
                                Description = blog.ProductDetails.FirstOrDefault().Description,
                                Create = blog.ProductDetails.FirstOrDefault().CreateAt
                            }
                        };
            return blogs.Take(4).ToList();
        }
        public List<ProductModel> BlogDetail(string? search, int CategoryId, int ProductId)
        {
            var blogs = (from blog in _shopDbContext.Products
                         join p in _shopDbContext.ProductImages on blog.Id equals p.ProductId
                         join pt in _shopDbContext.ProductDetails on blog.Id equals pt.ProductId
                         where blog.CateId == CategoryId && p.ProductId == ProductId
                         select new ProductModel
                         {
                             Id = blog.Id,

                             Account = new ListCategory_User
                             {
                                 Id = p.Id,
                                 Avatar = blog.UserInfo.Avatar,
                                 UserName = blog.UserInfo.UserName,
                                 OrderBy = blog.UserInfo.CommentDate
                             },
                             ProductDetails = new DetailProductModel
                             {  
                                 Id = pt.Id,
                                 Description = pt.Description,
                                 Style = pt.Style
                             },
                             Posts = blog.Posts.FirstOrDefault().Title,
                             ProductImage = blog.ProductImages.Select(c => c.Url)
                         }).Take(1);
            ////search
            //if (!string.IsNullOrEmpty(search))
            //{
            //    blogs = blogs.Where(x => x.Style.Contains(search));
            //}

            return blogs.ToList();
        }

    }
}
