using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopShoes.Data.DetailPage_Description_Home.DetailPage
{
    [Table("Post")]
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
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
