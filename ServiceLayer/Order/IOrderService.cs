using ServiceLayer.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Order
{
    public interface IOrderService
    {

        public Task<OrderDto> GetOrderAsync(int OrderId);

        public Task<List<OrderDto>> GetOrdersAsync();

        public Task<List<OrderDto>> GetOrdersAsync(int CustomerId);

        public Task CreateOrderAsync(OrderDto order,List<OrderProductDto> products);

        public Task<List<OrderProductDto>> GetOrderProductsAsync(int orderId);
    }
}
