using BCrypt.Net;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ShopShoes.Data;
using ShopShoes.Data.DetailPage_Description.DetailPage;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebShopShoes.Data.Account;
using WebShopShoes.Dto.AccountDto;
using WebShopShoes.IService.IAccount;
using WebShopShoes.Model.Account;

namespace WebShopShoes.Service.Account
{
    public class AccountRepository : IAccount
    {
        private readonly IConfiguration _configuration;
        private readonly ShopDbContext _shopDbContext;

        public AccountRepository(IConfiguration configuration, ShopDbContext shopDbContext)
        {
            _configuration = configuration;
            _shopDbContext = shopDbContext;
        }
        public static LoginDto loginDto = new LoginDto();

        public TokenModel Login(LoginDto login)
        {
            string passwordHash = _shopDbContext.Accounts.FirstOrDefault(p => p.Username == login.UserName).Password;
            var passwords = BCrypt.Net.BCrypt.Verify(login.Password, passwordHash);
            loginDto.Password = passwordHash;
            loginDto.UserName = login.UserName;
            var token = Create(loginDto);
            if (passwords)
            {
                return new TokenModel
                {
                    AccessToken = token.AccessToken
                };
            }
            return null;


        }

        private TokenModel Create(LoginDto loginDto)
        {
            var user = _shopDbContext.UserInfos.FirstOrDefault(p => p.AccountDatas.FirstOrDefault().Username == loginDto.UserName);
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,loginDto.UserName),
                new Claim(ClaimTypes.MobilePhone,user.Phone),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.StreetAddress, user.Address),
                new Claim("Id", user.Id.ToString()),
                new Claim(ClaimTypes.Role, user.AccountDatas.FirstOrDefault().isAdmin.ToString())

            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:SecretKey").Value));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: cred
                );
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return new TokenModel
            {
                AccessToken = jwt,
            };

        }

        public ApiResponse Register(AccountDto accountDto)
        {
            var password = BCrypt.Net.BCrypt.HashPassword(accountDto.Password, Constant.Constant.PasswordSalt);
            if (accountDto.Password != accountDto.ConfirmPassword)
            {
                throw new Exception("Password have to same together ");
            }
            var dataUser = new UserInfo()
            {
                Phone = accountDto.Phone,
                UpdateBy = accountDto.FullName,
                CreateBy = accountDto.FullName,
                CreateAt = DateTime.Now,
                UpdateAt = DateTime.Now,
                CommentDate = DateTime.Now,
                Articles = 0,
                Address = accountDto.Address,
                UserName = accountDto.FullName
            };
            
            
           
            if (dataUser == null)
            {
                throw new Exception("Didn't empty");
            }
            _shopDbContext.Add(dataUser);
            _shopDbContext.SaveChanges();
            var dataAccount = new AccountData()
            {
                Password = password,
                Username = accountDto.Username,
                isAdmin = accountDto.isAdmin,
                UserInfoId = _shopDbContext.UserInfos.FirstOrDefault(c => c.UserName == accountDto.FullName).Id
            };
            if (dataAccount == null)
            {
                throw new Exception("Didn't empty");
            }
            _shopDbContext.Add(dataAccount);
            _shopDbContext.SaveChanges();
            return new ApiResponse
            {
                Success = true,
                Message = "Sign Up Success"
            };

        }
        public async Task<bool> UserAlreadyExist(AccountDto accountDto)
        {
            return await _shopDbContext.Accounts.AnyAsync(p => p.Username == accountDto.Username);
        }

        public async Task<bool> UserAlreadyExistsForLogin(LoginDto login)
        {
            return await _shopDbContext.Accounts.AnyAsync(p => p.Username == login.UserName);
        }

        public async Task<string> UserName()
        {
            return loginDto.UserName.ToString();
        }
    }
}
