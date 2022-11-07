using ShopShoes.Data;
using ShopShoes.IService.IHomePage;
using ShopShoes.Model;
using WebShopShoes.Model;

namespace ShopShoes.Service.HomePage
{
    public class HomePageResposity : IHomePage
    {
        private readonly ShopDbContext _shopDbContext;

        public HomePageResposity(ShopDbContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
        }

        public List<ProductModel> Banner(int productId)
        {
            var products = (from product in _shopDbContext.Products
                            join p in _shopDbContext.ProductImages on product.Id equals p.ProductId
                            join pt in _shopDbContext.ProductDetails on product.Id equals pt.ProductId
                            where product.Id == productId
                            orderby p.CreateAt 
                            select new ProductModel
                            {
                                Id = productId,
                                ProductDetails = new DetailProductModel
                                {
                                    Id = p.Id,
                                    ProductName = pt.ProductName,
                                    ProductImage = p.Url,
                                    Type = pt.Type,
                                    Description = pt.Description,
                                    Price = pt.Price
                                }
                            }).Take(1);
            return products.ToList();
        }

        public List<ProductModel> ListCategory(int id)
        {
            var cate = (from product in _shopDbContext.Products
                        join p in _shopDbContext.ProductImages on product.Id equals p.ProductId
                        join pt in _shopDbContext.ProductDetails on product.Id equals pt.ProductId
                        where product.CateId == id
                        select new ProductModel
                        {
                            Id= product.Id,
                            
                            Account = new ListCategory_User
                            {
                                Id = product.Id,
                                Avatar = product.UserInfo.Avatar,
                                UserName = product.UserInfo.UserName,
                                OrderBy = product.UserInfo.CommentDate
                            },
                            ProductDetails = pt.Description,
                            Posts = product.Posts.FirstOrDefault().Title,
                            ProductImage = p.Url
                        }).Take(3);
            return cate.ToList();
        }
        public List<ProductModel> ProductCategory(int CateId)
        {
            var products = (from product in _shopDbContext.Products

                            where product.CateId == CateId
                            orderby product.CreateAt descending
                            select new ProductModel
                            {
                               Id = product.Id,
                               ProductDetails = new DetailProductModel
                               {
                                   Id = product.ProductImages.FirstOrDefault().Id,
                                   ProductName = product.ProductDetails.FirstOrDefault().ProductName,
                                   BrandName = product.ProductDetails.FirstOrDefault().BrandName,
                                   Price = product.ProductDetails.FirstOrDefault().Price,
                                   ProductImage = product.ProductImages.FirstOrDefault()
                               }
                            }
                           ).Take(4).ToList();
            return products;
        }

        //public List<ProductImageModel> ProductImage(int id)
        //{
        //    var productImage = (from product in _shopDbContext.products
        //                        where product.CateId == id
        //                        select new ProductImageModel
        //                        {
        //                            FeatureImage = product.ProductImages.Select(x => x.FeatureImage).Take(6).ToList()
        //                        }).ToList();
        //    return productImage;
        //}

        public List<ProductModel> Trending(int cateId)
        {
            var products = (from product in _shopDbContext.Products
                            where product.CateId == cateId
                            join p in _shopDbContext.ProductImages on product.Id equals p.ProductId
                            join pt in _shopDbContext.ProductDetails on product.Id equals pt.ProductId
                            orderby pt.CreateAt
                            select new ProductModel
                            {
                                Id=product.Id,
                                ProductDetails = new DetailProductModel
                                {
                                    Id = pt.Id,
                                    ProductName = pt.ProductName,
                                    BrandName = pt.BrandName,
                                    Price = pt.Price,
                                    ProductImage = p.Url
                                }
                            }
                           ).Take(2).ToList();
            return products;
        }

    }
}
