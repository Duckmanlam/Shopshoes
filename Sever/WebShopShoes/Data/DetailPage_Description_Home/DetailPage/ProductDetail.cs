using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebShopShoes.Data.Enum;

namespace ShopShoes.Data.DetailPage_Description_Home.DetailPage
{
    [Table("ProductDetail")]
    public class ProductDetail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        [Column(TypeName = "Text")]
        public string Description { get; set; }
        [Required]
        public string BrandName { get; set; }
        [Required]
        public int ViewCount { get; set; }
        [Required]
        public string Size { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public Status Status { get; set; }
        public string? Style { get; set; }

        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        [Required]
        public DateTime CreateAt { get; set; }
        [Required]
        public DateTime UpdateAt { get; set; }
        [Required]
        public string CreateBy { get; set; }
        [Required]
        public string UpdateBy { get; set; }
    }
}
