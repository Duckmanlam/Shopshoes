using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShopShoes.Dto.AccountDto;
using WebShopShoes.IService.IAccount;

namespace WebShopShoes.Controllers.Accounts
{
    [Route("api/[controller]")]
    [ApiController]
    public class Account : ControllerBase
    {
        private readonly IAccount _account;

        public Account(IAccount account)
        {
            _account = account;
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register(AccountDto accountDto)
        {
            if (await _account.UserAlreadyExist(accountDto))
            {
                return BadRequest("User already exists ,please try something else");
            }
            var user = _account.Register(accountDto);
            return Ok(user);
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDto Login)
        {
            if (await _account.UserAlreadyExistsForLogin(Login))
            {

                var login = _account.Login(Login);
                if (login == null)
                {
                    return BadRequest("Username or password is incorrect");
                }
                return Ok(login);
            }
            return BadRequest("User does not exist");
        }

    }
}
