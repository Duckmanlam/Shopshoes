using ShopShoes.Model;
using WebShopShoes.Model;

namespace ShopShoes.IService.DetailPage_Description
{
    public interface IProduct
    {
        List<ProductModel> GetByLocal(string productName);
        // cateId
        List<ProductModel> GetRelatedProducts(int id);
    }
}
