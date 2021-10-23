using ServiceLayer.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ServiceLayer.Order
{
    public class OrderService : IOrderService
    {
        public Datalayer.AppContext _Context;

        public OrderService(Datalayer.AppContext context)
        {
            _Context = context;
        }

        public async Task CreateOrderAsync(OrderDto order,List<OrderProductDto> products)
        {

            var customer = await _Context.Customers
                                        .Where(c => c.CustomerId == order.CustomerId)
                                        .FirstOrDefaultAsync();

            Datalayer.Entity.Order newOrder = new Datalayer.Entity.Order()
            {
                CustomerId = order.CustomerId,
                TotalPrice = products.Select(p => p.Price).Sum(),
                Customer = customer,
                ProductOrders = products.Select(p => new Datalayer.Entity.ProductOrder() {
                    ProductId = p.ProductId, 
                    Amount = p.Amount 
                }).ToList(),
            };

            try
            {
                _Context.Orders.Add(newOrder);
                await _Context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Can't create order",e);
            }
        }

        public async Task<OrderDto> GetOrderAsync(int OrderId)
        {
           return await  _Context.Orders
                            .Where(o => o.OrderId == OrderId)
                            .ToDto()
                            .FirstOrDefaultAsync();
        }

        public async Task<List<OrderProductDto>> GetOrderProductsAsync(int orderId)
        {
            return await _Context.Products
                                    .Where(O => O.ProductOrders.Where(po => po.OrderId == orderId).Any())
                                    .ToDto(orderId)
                                    .ToListAsync();
        }

        public Task<List<OrderDto>> GetOrdersAsync()
        {
            return _Context.Orders.ToDto().ToListAsync();
        }

        public async Task<List<OrderDto>> GetOrdersAsync(int CustomerId)
        {
            return await _Context.Orders
                            .Where(o => o.CustomerId == CustomerId)
                            .ToDto()
                            .ToListAsync();
        }
    }
}
