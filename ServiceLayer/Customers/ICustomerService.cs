using ServiceLayer.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Customers
{
    public interface ICustomerService
    {

        public Task<List<CustomerDto>> GetCustomersAsync();

        public Task<CustomerDto> GetCustomerAsync(int CustomerId);

        public Task CreateCustomerAsync(CustomerDto customer);

        public Task RemoveCustomerAsync(int CustomerId);

        public Task EditCustomerAsync(CustomerDto customer);

        public Task CreateCustomerLocationAsync(int CustomerId, LocationDto location);

        public Task<List<LocationDto>> GetCustomerLocationsAsync(int CustomerId);


    }
}
