using System.ComponentModel.DataAnnotations;

namespace WebShopShoes.Data.Enum
{
    public enum Status
    {
        [Display(Name = "InAction")]
        InAction,
        [Display(Name = "Action")]
        Action
    }
}
