using ShopShoes.Data.DetailPage_Description.DetailPage;
using ShopShoes.Data.DetailPage_Description_Home.DetailPage;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using WebShopShoes.Data.DetailPage_Description_Home.DetailPage;

namespace WebShopShoes.Model
{
    public class ProductModel
    {

        
        public int Id { get; set; }
        public object ProductDetails { get; set; }
        public object ProductSizes { get; set; }
        public object ProductImage { get; set; }
        public object Account { get; set; }
        public object Posts { get; set; }
    }
}
