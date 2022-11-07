
using WebShopShoes.Model;

namespace ShopShoes.IService.IBlog
{
    public interface IBlog
    {
        List<ProductModel> AllBlog(string? search, int CategoryId, int page = 1);
        List<ProductModel> RecentPost(int CategoryId);
        List<ProductModel> PopularPost(int CategoryId);
        List<ProductModel> PopularAuthor(int CategoryId);
        List<ProductModel> BlogDetail(string? search, int categoryId, int productId);

    }
}
