using ShopShoes.Data.DetailPage_Description.DetailPage;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebShopShoes.Data.Account
{
    [Table("Account")]
    public class AccountData
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Username { get; set; }
        [Required]
        [MaxLength(200)]
        public string Password { get; set; }
        public bool isAdmin { get; set; }
        
        [ForeignKey("UserInfoId")]
        public int UserInfoId { get; set; }
        [ForeignKey("AccountId")]
        public List<ProductData> ProductId { get; set; }

    }
}
