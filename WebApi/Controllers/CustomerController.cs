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

        #region Customer

        #region GET

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

        [HttpGet]
        [Route("email/{Email}")]
        public async Task<CustomerDto> GetCustomer(string Email)
        {
            return await _customerService.GetCustomerByEmailAsync(Email);
        }

        #endregion

        #region POST

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CustomerDto customer)
        {
            try
            {
                await _customerService.CreateCustomerAsync(customer);
                var cust = await _customerService.GetCustomerByEmailAsync(customer.Email);
                return Ok(cust);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        #endregion

        #region PUT

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

        #endregion

        #region DELETE

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

        #endregion

        #endregion

        #region Locations

        [HttpPost]
        [Route("location/{CustomerId}")]
        public async Task<IActionResult> AddCustomerLocation(int customerId,LocationDto location)
        {
            try
            {
                await _customerService.CreateCustomerLocationAsync(customerId, location);
                return Ok("Location Created");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("location/{CustomerId}")]
        public async Task<List<LocationDto>> GetCustomerLocations(int CustomerId)
        {
            return await _customerService.GetCustomerLocationsAsync(CustomerId);
        }

        #endregion
    }
}
