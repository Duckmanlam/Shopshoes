//using ShopShoes.Data;
//using WebShopShoes.Controllers.Products;
//using WebShopShoes.IService.Products.ICart;
//using WebShopShoes.Model;

//namespace WebShopShoes.Service.Product.Cart
//{
//    public class CartRespository : ICartProduct
//    {
//        private readonly ShopDbContext _shopDbContext;
//        public CartRespository(ShopDbContext shopDbContext)
//        {
//            _shopDbContext = shopDbContext;
//        }
        
//        public List<CartItem> GetAllCart(int id ,List<CartItem> carts)
//        {
//            var myCart = carts;
//            var item = myCart.SingleOrDefault(p => p.Id == id);
//            if (item == null)
//            {

//                item = new CartItem()
//                {
//                    Brand = _shopDbContext.ProductDetails.FirstOrDefault(c => c.ProductId == id).BrandName,
//                    Id = _shopDbContext.ProductDetails.FirstOrDefault(c => c.ProductId == id).Id,
//                    Image = _shopDbContext.ProductImages.FirstOrDefault(c => c.ProductId == id).Url,
//                    Price = _shopDbContext.ProductDetails.FirstOrDefault(c => c.ProductId == id).Price,
//                    ProductName = _shopDbContext.ProductDetails.FirstOrDefault(c => c.ProductId == id).ProductName
//                };
//                myCart.Add(item);
//            }
//            else
//            {
//                item.Quantity++;
//            }
//            return myCart;
//        }
//    }
//}
