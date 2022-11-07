using Microsoft.EntityFrameworkCore;
using ShopShoes.Data;
using ShopShoes.Data.DetailPage_Description.DetailPage;
using ShopShoes.IService.DetailPage_Description;
using ShopShoes.Model;
using WebShopShoes.Model;

namespace ShopShoes.Service.DetailPage_Description
{
    public class ProductResposity : IProduct
    {
        private readonly ShopDbContext _shopDbContext;

        public ProductResposity(ShopDbContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
        }
        public List<ProductModel> GetByLocal(string username)
        {
            var products = (from product in _shopDbContext.Products
                            where product.ProductDetails.FirstOrDefault().ProductName == username
                            select new ProductModel
                            {
                                Id = product.Id,
                                ProductDetails = new DetailProductModel
                                {
                                    Id = product.ProductDetails.FirstOrDefault().Id,
                                    ProductName = product.ProductDetails.FirstOrDefault().ProductName,
                                    BrandName = product.ProductDetails.FirstOrDefault().BrandName,
                                    ProductImage = product.ProductImages.FirstOrDefault().Url,
                                    Description = product.ProductDetails.FirstOrDefault().Description,
                                    Price = product.ProductDetails.FirstOrDefault().Price
                                }
                            }).Take(1);
            return products.ToList();
        }

        public List<ProductModel> GetRelatedProducts(int id)
        {
            var products = (from product in _shopDbContext.Products
                            where product.CateId == id
                            orderby product.CreateAt descending
                            select new ProductModel
                            {
                                Id = product.Id,
                                ProductDetails = new DetailProductModel
                                {
                                    Id = product.ProductDetails.FirstOrDefault().Id,
                                    ProductName = product.ProductDetails.FirstOrDefault().ProductName,
                                    BrandName = product.ProductDetails.FirstOrDefault().BrandName,
                                    Price = product.ProductDetails.FirstOrDefault().Price,
                                    ProductImage = product.ProductImages.FirstOrDefault().Url
                                }
                            }
                           ).Take(4).ToList();
            return products;
        }
    }
}
