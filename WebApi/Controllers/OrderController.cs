using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceLayer.Dto;
using ServiceLayer.Order;
using ServiceLayer.Emails;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly IOrderService _orderService;
        private readonly IEmailSenderService _emailSenderService;

        public OrderController(IOrderService orderService,IEmailSenderService emailSenderService)
        {
            _orderService = orderService;
            _emailSenderService = emailSenderService;
        }


        [HttpGet]
        [Route("all")]
        public async Task<List<OrderDto>> GetOrders()
        {
            return await _orderService.GetOrdersAsync();
        }

        [HttpGet]
        [Route("{orderId}")]
        public async Task<OrderDto> GetOrder(int orderId)
        {
            return await _orderService.GetOrderAsync(orderId);
        }

        [HttpGet]
        [Route("customer/{CustomerId}")]
        public async Task<List<OrderDto>> GetOrdersByCustomer(int CustomerId)
        {
            return await _orderService.GetOrdersAsync(CustomerId);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder(OrderLine orderline)
        {
            try
            {
                await _orderService.CreateOrderAsync(orderline.order,orderline.products);
                await _emailSenderService.SendRecieptAsync(orderline.order, orderline.products);
                return Ok("Order created. you will get the reciept on mail");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        public class OrderLine
        {
            public OrderDto order { get; set; }
            public List<OrderProductDto> products { get; set; }
        }

    }
}
