using WebShopShoes.Dto.AccountDto;
using WebShopShoes.Model.Account;

namespace WebShopShoes.IService.IAccount
{
    public interface IAccount
    {
        ApiResponse Register(AccountDto accountDto);
        TokenModel Login (LoginDto login);
        Task<bool> UserAlreadyExist(AccountDto accountDto);
        Task<bool> UserAlreadyExistsForLogin(LoginDto login);
        Task<string> UserName();
    }
}
