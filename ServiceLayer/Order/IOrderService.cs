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

        public Task<List<OrderDto>> GetOrders();

        public Task<List<OrderDto>> GetOrders(int CustomerId);

        public Task CreateOrderAsync(OrderDto order,List<ProductDto> products);
    }
}
