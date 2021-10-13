using Microsoft.Extensions.DependencyInjection;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Customers;
using Microsoft.EntityFrameworkCore;
using Xunit;
using ServiceLayer.Dto;

namespace Test
{
    public class CustomerTest
    {

        private readonly IServiceProvider serviceProvider;

        public CustomerTest()
        {
            serviceProvider = TestDependency.CreateServiceProvider(services => {
                services.AddScoped<ICustomerService,CustomerService>();
            });
        }

        [Fact]
        public async void GetCustomers()
        {
            serviceProvider.CreateDatabase();
            var service = serviceProvider.GetRequiredService<ICustomerService>();

            var customers = await service.GetCustomersAsync();

            int actualCount = customers.Count();

            Assert.NotEmpty(customers);
            Assert.Equal(1, actualCount);
        }

        [Fact]
        public async void GetCustomerLocations()
        {
            serviceProvider.CreateDatabase();
            ICustomerService service = serviceProvider.GetRequiredService<ICustomerService>();

            var locations = await service.GetCustomerLocationsAsync(1);

            Assert.NotEmpty(locations);
            Assert.Equal(3, locations.FirstOrDefault().LocationId);
        }
    }
}
