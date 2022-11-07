
using WebShopShoes.Model;

namespace ShopShoes.IService.IHomePage
{
    public interface IHomePage
    {
        List<ProductModel> Banner(int productId);
        List<ProductModel> ProductCategory(int CateId);
        List<ProductModel> Trending(int cateId);
        //List<ProductImageModel> ProductImage(int id);
        List<ProductModel> ListCategory(int id);

    }
}
