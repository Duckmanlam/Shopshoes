using System.ComponentModel.DataAnnotations;

namespace WebShopShoes.Dto.AccountDto
{
    public class AccountDto
    {
        public string Username { get; set; }
        [Required]
        [MaxLength(20)]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool isAdmin { get; set; } = false;
        [Required]
        [MaxLength(12)]
        public string Phone { get; set; }
        [Required]
        [MaxLength(100)]
        public string Address { get; set; }
        public string FullName { get; set; }
    }
}
