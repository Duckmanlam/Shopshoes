using com.sun.xml.@internal.bind.v2.model.core;
using ShopShoes.Data;
using System.Net;
using System.Net.WebSockets;
using WebShopShoes.Data.Enum;
using WebShopShoes.Data.Order;
using WebShopShoes.Dto.Product_Admin;
using WebShopShoes.IService.Admin.IShop;
using WebShopShoes.IService.IAccount;
using WebShopShoes.Model.Admin;

namespace WebShopShoes.Service.Admin.Shop
{
    public class OrdersRepository : IPaymentPage
    {
        private readonly ShopDbContext _shopDbContext;
        private readonly IAccount _account;

        public OrdersRepository(ShopDbContext shopDbContext ,IAccount account)
        {
            _shopDbContext = shopDbContext;
            _account = account;
        }

        public OrderModel_Admin GetOrder()
        {
            var product = _shopDbContext.OrderDatas.Select(x => new OrderDetailModel_Admin
            {
                Id = x.Id,
                OrderDate = x.OrderDate,
                ProductName = x.ProductName,
                ShipAddress = x.ShipAddress,
                ShipName = x.ShipName,
                ShipPhoneNumber = x.ShipPhoneNumber,
                Status = x.Status,
                Price = x.OrderDetail.FirstOrDefault(c => c.OrderId == x.Id).Price,
                Quantity = x.OrderDetail.FirstOrDefault(c => c.OrderId == x.Id).Quantity,
                Total = x.OrderDetail.FirstOrDefault(c => c.OrderId == x.Id).Total,
                BrandName = x.OrderDetail.FirstOrDefault(c => c.OrderId == x.Id).BrandName,
                Size = x.OrderDetail.FirstOrDefault(c => c.OrderId == x.Id).Size,
                ProductImage = x.OrderDetail.FirstOrDefault(c => c.OrderId == x.Id).ProductImage
            }).ToList();
            return new OrderModel_Admin
            {
                Data = product
            };
        }

        public OrderModel_Admin Order(List<OrderPageDto> paymentPage)
        {
            double totalInCart = 0;
            if (paymentPage.Select(c => c.ProductId) == null || paymentPage.Select(c => c.Quantity) == null) 
            {
                throw new Exception("No product found");
            }
            var order = new OrderData();
            var orderDetail = new OrderDetail();
            foreach (var item in paymentPage)
            {
                var product = _shopDbContext.ProductDetails.FirstOrDefault(c => c.ProductId == item.ProductId).Price;
                var user = _account.UserName().Result;
                var userId = _shopDbContext.Accounts.FirstOrDefault(c => c.Username == user).UserInfoId;
                var UserInfo = _shopDbContext.UserInfos.FirstOrDefault(x => x.Id == userId);
                totalInCart += product * item.Quantity;
                double total = 0;
                total = product * item.Quantity;
                order = new OrderData();
                orderDetail = new OrderDetail();

                order = new OrderData
                {
                    Id = Guid.NewGuid(),
                    OrderDate = DateTime.Now,
                    ProductName = _shopDbContext.ProductDetails.FirstOrDefault(c => c.ProductId == item.ProductId).ProductName,
                    ShipAddress = UserInfo.Address,
                    ShipName = UserInfo.UserName,
                    ShipPhoneNumber = UserInfo.Phone,
                    Status = OrderStatus.InProgress,
                    UserId = UserInfo.Id
                };
                

                var newestProduct = order.OrderDate;
                orderDetail = new OrderDetail()
                {    
                    Price = _shopDbContext.ProductDetails.FirstOrDefault(c => c.ProductId == item.ProductId).Price,
                    ProductId = item.ProductId,
                    OrderId = order.Id,
                    Quantity = item.Quantity,
                    Total = total,
                    BrandName = item.BrandName,
                    ProductImage = item.ProductImage,
                    ProductName = item.ProductName  ,
                    Size = item.Size
                };

                _shopDbContext.Add(order);
                _shopDbContext.SaveChanges();
                _shopDbContext.Add(orderDetail);
                _shopDbContext.SaveChanges();

            }
            
            return new OrderModel_Admin { Message = "Success",Total = totalInCart};
        }
    }
}
