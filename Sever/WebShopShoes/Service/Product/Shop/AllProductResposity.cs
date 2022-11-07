using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using ShopShoes.Data;
using ShopShoes.Data.DetailPage_Description.DetailPage;
using ShopShoes.Data.DetailPage_Description_Home.DetailPage;
using ShopShoes.Model;
using ShopShoes.Model.Paging;
using WebShopShoes.Data.Enum;
using WebShopShoes.IService.IShop;

namespace WebShopShoes.Service.Shop
{
    public class AllProductResposity : IAllProduct
    {
        private readonly ShopDbContext _shopDbContext;

        public AllProductResposity(ShopDbContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
        }
        public static int page_size { get; set; } = 9;
        public List<DetailProductModel> AllProduct(string search, double? from, double? to, string sortBy, int cateId, int page)
        {
            Status status = Status.InAction;
            var products = _shopDbContext.Products.Where(c => c.CateId == cateId && c.ProductDetails.FirstOrDefault().Status != status).Select( x => new DetailProductModel
            {
                Id = x.Id,
                BrandName = x.ProductDetails.FirstOrDefault().BrandName,
                ProductName = x.ProductDetails.FirstOrDefault().ProductName,
                ProductImage = x.ProductImages.FirstOrDefault().Url,
                Price = x.ProductDetails.FirstOrDefault().Price,
                Create = x.CreateAt
            }).Distinct();
            //from product in _shopDbContext.Products

            //           where product.CateId == cateId
            //           join p in _shopDbContext.ProductImages on product.Id equals p.ProductId
            //           join pt in _shopDbContext.ProductDetails on product.Id equals pt.ProductId
            //           orderby product.CreateAt descending
            //           select new DetailProductModel
            //           { 
            //                Id = product.Id,
            //                BrandName = pt.BrandName,
            //                ProductName = pt.ProductName,
            //                ProductImage = p.Url,
            //                Price = pt.Price
            //           };


            // Filtering
            
            if (!string.IsNullOrEmpty(search))
            {
                products = products.Where(p => p.ProductName.Contains(search));
            }
            if (from.HasValue)
            {
                products = products.Where(p => p.Price >= from);
            }
            if (to.HasValue)
            {
                products = products.Where(p => p.Price <= to);
            }

            // Sort
            if (!string.IsNullOrEmpty(search))
            {
                switch (sortBy)
                {
                    case "Price High - Low":
                        products = products.OrderByDescending(p => p.Price);
                        break;
                    case "Price Low - High":
                        products = products.OrderBy(p => p.Price);
                        break;
                    case "Newest":
                        products = products.OrderByDescending(p => p.Create);
                        break;
                    case "Featured":
                        products = products.OrderBy(p => p.Create);
                        break;
                }
            }
            // Paging
            var allProduct = PaginatedList<DetailProductModel>.Create(products.OrderByDescending(c => c.Create), page, page_size);
               
            return allProduct.ToList();
        }
    }
}
