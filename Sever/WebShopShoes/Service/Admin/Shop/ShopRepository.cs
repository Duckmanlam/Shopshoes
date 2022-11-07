using com.sun.org.glassfish.gmbal;
using com.sun.xml.@internal.fastinfoset.util;
using eShopSolution.Utilities.Exceptions;
using ShopShoes.Data;
using ShopShoes.Data.DetailPage_Description.DetailPage;
using ShopShoes.Data.DetailPage_Description_Home.DetailPage;
using System.Net.Http.Headers;
using WebShopShoes.Common;
using WebShopShoes.Dto.Product_Admin;
using WebShopShoes.Dto.ProductImage;
using WebShopShoes.IService.Admin.IShop;
using WebShopShoes.IService.IAccount;
using WebShopShoes.Model.Admin;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebShopShoes.Service.Admin.Shop
{
    public class ShopRepository : IShop
    {
        private readonly ShopDbContext _shopDbContext;
        private readonly IAccount _account;
        private readonly IStorageService _storageService;
        private const string USER_CONTENT_FOLDER_NAME = "user-content";

        public ShopRepository(ShopDbContext shopDbContext ,IAccount account , IStorageService storageService)
        {
            _shopDbContext = shopDbContext;
            _account = account;
            _storageService = storageService;
        }
        public static int page_size { get; set; } = 5;

        public RequestApiMes AddProduct(AddProductAdmin product, ProductImageCreateRequest request)
        {
            var user = _account.UserName().Result;
            if (user == null)
            {
                throw new Exception("Error Username");
            }    
           
            var productData = new ProductData()
            {
                CreateAt = DateTime.Now,
                CreateBy = user,
                UpdateBy = user,
                UpdateAt = DateTime.Now,
                CateId = 1,
                UserInfoId = _shopDbContext.Accounts.FirstOrDefault(x => x.Username == user).UserInfoId,
                AccountId = _shopDbContext.Accounts.FirstOrDefault(x => x.Username == user).Id,
                
            };
            if (productData == null)
            {
                throw new Exception("Value didn't empty");
            }
            _shopDbContext.Add(productData);
            _shopDbContext.SaveChanges();
            var productId = _shopDbContext.Products.FirstOrDefault(c => c.CreateAt == productData.CreateAt).Id;
            var productDetail = new ProductDetail()
            {
                BrandName = product.BrandName,
                CreateAt = DateTime.Now,
                CreateBy = user,
                UpdateBy = user,
                UpdateAt = DateTime.Now,
                ProductName = product.ProductName,
                Type = product.Type,
                Description = product.Description,
                Price = product.Price,
                Status = product.Status,
                Style = null,
                Size = product.Size,
                Stock = product.Stock,
                ProductId = productId, 
                ViewCount = 0
            };
            _shopDbContext.Add(productDetail);
            _shopDbContext.SaveChanges();
            if (productDetail == null)
            {
                productData = _shopDbContext.Products.Find(productDetail.ProductId);
                throw new Exception("Value didn't empty");
                _shopDbContext.Remove(productData);
            }

            var productImage = new ProductImage()
            {
                CreateAt = DateTime.Now,
                CreateBy = user,
                UpdateBy = user,
                UpdateAt = DateTime.Now,
                ProductId = productId,
            };
            if (request.ImageFile != null)
            {
                productImage.Url =  this.SaveFile(request.ImageFile);
            }
            _shopDbContext.Add(productImage);
            _shopDbContext.SaveChanges();
            return new RequestApiMes { Message = "Success" };

        }

        public RequestApiMes DeleteProduct(int productId)
        {
            var product = _shopDbContext.Products.Find(productId);
            if (product != null)
                _shopDbContext.Products.Remove(product);
            _shopDbContext.SaveChanges();
            return new RequestApiMes { Message = "Success" };
        }

        public  List<ProductModel_Admin> GetAllProduct(string search, double? from, double? to, string sortBy, int cateId, int page)
        {
            //1. Select join
            var products = from p in _shopDbContext.Products
                        join pt in _shopDbContext.ProductDetails on p.Id equals pt.ProductId
                        join pts in _shopDbContext.ProductImages on p.Id equals pts.ProductId
                        where p.CateId == cateId
                        select new { p, pt, pts };
            

            // Filtering
            if (!string.IsNullOrEmpty(search))
            {
                products = products.Where(x => x.pt.ProductName.Contains(search));
            }
            if (from.HasValue)
            {
                products = products.Where(x => x.pt.Price >= from);
            }
            if (to.HasValue)
            {
                products = products.Where(x => x.pt.Price <= to);
            }

            // Sort
            if (!string.IsNullOrEmpty(search))
            {
                switch (sortBy)
                {
                    case "Price High - Low":
                        products = products.OrderByDescending(x => x.pt.Price);
                        break;
                    case "Price Low - High":
                        products = products.OrderBy(x => x.pt.Price);
                        break;
                }
            }
            // Paging
            int totalRow =  products.Count();

            var data = products.Skip((page - 1) * page_size)
                .Take(page_size)
                .Select(x => new ProductModel_Admin()
                {
                    ProductId = x.pt.ProductId,
                    BrandName = x.pt.BrandName,
                    ProductName = x.pt.ProductName,
                    Price = x.pt.Price,
                    CreateAt = x.pt.CreateAt,
                    Status = x.pt.Status,
                    ViewCount = x.pt.ViewCount,
                    ProductImage = x.pts.Url
                }).ToList();

            return data.OrderByDescending(c => c.CreateAt).ToList();
        }

        public List<ProductModel_Admin> GetById(int productId)
        {
            var product = _shopDbContext.Products.Find(productId);
            if (product == null)
            {
                throw new EShopException($"Cannot find a product: {productId}");
            }

            var products = from p in _shopDbContext.Products
                           join pt in _shopDbContext.ProductDetails on p.Id equals pt.ProductId
                           join pts in _shopDbContext.ProductImages on p.Id equals pts.ProductId
                           where p.Id == productId
                           select new { p, pt ,pts};
            var data = products
                .Select(x => new ProductModel_Admin()
                {
                    ProductId = x.pt.ProductId,
                    BrandName = x.pt.BrandName,
                    ProductName = x.pt.ProductName,
                    Price = x.pt.Price,
                    CreateAt = x.pt.CreateAt,
                    Status = x.pt.Status,
                    ViewCount = x.pt.ViewCount,
                    ProductImage = x.pts.Url
                }).ToList();

            return data;
        }

        public RequestApiMes UpdateProduct(int productId,UpdateProduct updateProduct)
        {
            var user = _account.UserName().Result;
            var products =  _shopDbContext.Products.Find(productId);
            if ( products == null)
            {
                throw new EShopException($"Cannot find a product with id: {productId}");
            }
            var productDetail = _shopDbContext.ProductDetails.FirstOrDefault(c => c.ProductId == productId);
            var productImages = _shopDbContext.ProductImages.FirstOrDefault(c => c.ProductId == productId);
            productDetail.Status = updateProduct.Status;
            productDetail.ProductName = updateProduct.ProductName;
            productDetail.Price = updateProduct.Price;
            productDetail.UpdateBy = user;
            productDetail.Description = updateProduct.Description;
            productDetail.BrandName = updateProduct.BrandName;
            productDetail.UpdateAt = DateTime.Now;
            productDetail.Type = updateProduct.Type;
            productImages.Url = this.SaveFile(updateProduct.ImageFile);
            _shopDbContext.Update(productDetail);
            _shopDbContext.SaveChanges();
            return new RequestApiMes { Message = "Success" };


        }

        private string SaveFile(IFormFile file)
        {
            var originalFileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
            var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";
            _storageService.SaveFileAsync(file.OpenReadStream(), fileName);
            return  fileName;
        }

        public List<DetailShop_Admin> GetDetailShop_Admins(int productId)
        {
            var product = _shopDbContext.Products.Find(productId);
            if (product == null)
            {
                throw new EShopException($"Cannot find a product: {productId}");
            }

            var products = from p in _shopDbContext.Products
                           join pt in _shopDbContext.ProductDetails on p.Id equals pt.ProductId
                           join pts in _shopDbContext.ProductImages on p.Id equals pts.ProductId
                           where p.Id == productId
                           select new { p, pt, pts };
            var data = products
                .Select(x => new DetailShop_Admin()
                {
                    ProductId = x.pt.ProductId,
                    BrandName = x.pt.BrandName,
                    ProductName = x.pt.ProductName,
                    Price = x.pt.Price,
                    CreateAt = x.pt.CreateAt,
                    Status = x.pt.Status,
                    ViewCount = x.pt.ViewCount,
                    ProductImage = x.pts.Url,
                    Description = x.pt.Description,
                    Stock = x.pt.Stock
                }).Take(1).ToList();

            return data;
        }
    }
}
