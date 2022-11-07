using ShopShoes.Data.DetailPage_Description.DetailPage;
using ShopShoes.Model;
using WebShopShoes.Dto.Product_Admin;
using WebShopShoes.Dto.ProductImage;
using WebShopShoes.Model.Admin;

namespace WebShopShoes.IService.Admin.IShop
{
    public interface IShop
    {
        List<ProductModel_Admin> GetAllProduct(string search, double? from, double? to, string sortBy, int cateId, int page);
        List<ProductModel_Admin> GetById(int productId);
        RequestApiMes AddProduct(AddProductAdmin product, ProductImageCreateRequest request);
        RequestApiMes UpdateProduct(int productId, UpdateProduct updateProduct);
        RequestApiMes DeleteProduct(int productId);


        List<DetailShop_Admin> GetDetailShop_Admins(int productId);




    }
}
