using System.ComponentModel.DataAnnotations;

namespace WebShopShoes.Data.Enum
{
    public enum OrderStatus
    {
        [Display(Name = "InProgress")]
        InProgress,
        [Display(Name = "Confirmed")]
        Confirmed,
        [Display(Name = "Shipping")]
        Shipping,
        [Display(Name = "Success")]
        Success,
        [Display(Name = "Canceled")]
        Canceled
    }
}
