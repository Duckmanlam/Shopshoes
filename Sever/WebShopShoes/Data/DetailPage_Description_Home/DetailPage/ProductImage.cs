using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopShoes.Data.DetailPage_Description.DetailPage
{
    [Table("ProductImage")]
    public class ProductImage
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }
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
