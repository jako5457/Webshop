using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceLayer.Dto;
using ServiceLayer.Customers;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("all")]
        public async Task<List<CustomerDto>> GetAllCustomers()
        {
            return await _customerService.GetCustomersAsync();
        }

        [HttpGet]
        [Route("{CustomerId}")]
        public async Task<CustomerDto> GetCustomer(int CustomerId)
        {
            return await _customerService.GetCustomerAsync(CustomerId);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CustomerDto customer)
        {
            try
            {
                await _customerService.CreateCustomerAsync(customer);
                return Ok("Customer created");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> EditCustomer(CustomerDto customer)
        {
            try
            {
                await _customerService.EditCustomerAsync(customer);
                return Ok("Customer changed");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCustomer(int CustomerId)
        {
            try
            {
                await _customerService.RemoveCustomerAsync(CustomerId);
                return Ok("Customer removed");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
