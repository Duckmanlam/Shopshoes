
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using ShopShoes.Data;
using ShopShoes.IService.DetailPage_Description;
using ShopShoes.IService.IBlog;
using ShopShoes.IService.IHomePage;
using ShopShoes.Service.Blog;
using ShopShoes.Service.DetailPage_Description;
using ShopShoes.Service.HomePage;
using Swashbuckle.AspNetCore.Filters;
using System.Text;
using System.Text.Json.Serialization;
using WebShopShoes.Common;
using WebShopShoes.IService.Admin.IShop;
using WebShopShoes.IService.IAccount;
using WebShopShoes.IService.IShop;
using WebShopShoes.Service.Account;
using WebShopShoes.Service.Admin.Shop;
using WebShopShoes.Service.Shop;

namespace ShopShoes
{
    class StartUp
    {
        private readonly IConfiguration _configuration;

        public StartUp(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddTransient<IStorageService, FileStorageService>();
            services.AddScoped<IProduct, ProductResposity>();
            services.AddScoped<IHomePage, HomePageResposity>();
            services.AddScoped<IBlog, BlogResposity>();
            //services.AddScoped<ICartProduct, CartRespository>();
            services.AddScoped<IAllProduct, AllProductResposity>();
            services.AddScoped<IShop, ShopRepository>();
            services.AddScoped<IAccount, AccountRepository>();
            services.AddScoped<IPaymentPage, OrdersRepository>();
            services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
            services.AddDbContext<ShopDbContext>(options =>
            {
                options.UseSqlServer(_configuration.GetConnectionString("ShopShoes"));
            }); 
            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.AddSwaggerGen(options =>
            {
                options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "Standard Authorization header using the Bearer scheme (\"bearer {token}\")",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
                options.OperationFilter<SecurityRequirementsOperationFilter>();
            });

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        //ký Token
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:SecretKey").Value)),
                        // tự cấp token
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });
            services.AddCors(options =>
            {
                options.AddPolicy(name: "AllowOrigin",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyHeader()
                               .AllowAnyMethod();
                    });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ShopShoes v1"));
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseCors("AllowOrigin");
            
            app.UseStaticFiles();


            app.UseSession();
            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

        }
    }
}