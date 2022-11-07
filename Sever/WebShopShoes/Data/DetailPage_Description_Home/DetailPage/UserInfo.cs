using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using WebShopShoes.Data.Account;
using WebShopShoes.Data.Order;

namespace ShopShoes.Data.DetailPage_Description.DetailPage
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string? Avatar { get; set; }
        public DateTime CommentDate { get; set; }
        public int? Articles { get; set; }
        [Required]
        [MaxLength(12)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(100)]
        public string Address { get; set; } 
        [ForeignKey("UserInfoId")]
        public List<AccountData> AccountDatas { get; set; }
        [ForeignKey("UserId")]
        public List<OrderData> Orders { get; set; }


        public List<ProductData> Products { get; set; }
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
