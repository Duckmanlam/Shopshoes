using Microsoft.EntityFrameworkCore;
using ShopShoes.Data.DetailPage_Description.DetailPage;
using ShopShoes.Data.DetailPage_Description_Home.DetailPage;
using WebShopShoes.Data.Account;
using WebShopShoes.Data.Extensions;
using WebShopShoes.Data.Order;

namespace ShopShoes.Data
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductData> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<AccountData> Accounts{ get; set; }
        public DbSet<ProductDetail>  ProductDetails { get; set; }
        public DbSet<OrderData>  OrderDatas { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrderDetail>()
            .HasKey(p => new { p.OrderId, p.ProductId });
            modelBuilder.Entity<OrderDetail>().HasOne(c => c.Product).WithMany(h => h.OrderDetails).OnDelete(DeleteBehavior.NoAction);
            


            modelBuilder.Seed();
        }
    }
}
