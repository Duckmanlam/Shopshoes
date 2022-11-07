
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopShoes.Data.DetailPage_Description.DetailPage
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }
        [ForeignKey("CateId")]
        public List<ProductData> ProductCates { get; set; }
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
