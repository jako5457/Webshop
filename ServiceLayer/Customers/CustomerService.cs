using ServiceLayer.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Datalayer.Entity;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ServiceLayer.Customers
{
    public class CustomerService : ICustomerService
    {

        Datalayer.AppContext _context;

        public CustomerService(Datalayer.AppContext context)
        {
            _context = context;
        }

        public async Task CreateCustomerAsync(CustomerDto customer)
        {
            Customer cust = new Customer()
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email
            };

            try
            {
                _context.Customers.Add(cust);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Can't create customer",e);
            }
        }

        public async Task CreateCustomerLocationAsync(int CustomerId, LocationDto location)
        {
            Location loc = new Location()
            {
                Address = location.Address,
                City = location.City,
                Country = location.Country,
                Zipcode = location.Zipcode,
            };

            Customer customer = _context.Customers.Where(c => c.CustomerId == CustomerId).FirstOrDefault();

            try
            {
                ((List<Location>)customer.Locations).Add(loc);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Can't create location",e);
            }

        }

        public async Task<CustomerDto> GetCustomerAsync(int CustomerId)
        {
            return await _context.Customers
                                    .Where(c => c.CustomerId == CustomerId)
                                    .ToDto()
                                    .FirstOrDefaultAsync();
        }

        public async Task<List<LocationDto>> GetCustomerLocationsAsync(int CustomerId)
        {
            return await _context.Locations
                                .Where(l => l.CustomerLocations
                                    .Where(cl => cl.CustomerId == CustomerId)
                                    .Any()
                                )
                                .ToDto()
                                .ToListAsync();
        }

        public Task<List<CustomerDto>> GetCustomersAsync()
        {
            return _context.Customers.ToDto().ToListAsync();
        }

        public async Task RemoveCustomerAsync(int CustomerId)
        {
            var customer = _context.Customers
                                    .Where(c => c.CustomerId == CustomerId)
                                    .FirstOrDefault();
            try
            {
                _context.Remove(customer);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Can't remove Customer");
            }
        }

        public async Task EditCustomerAsync(CustomerDto customer)
        {
            var cust = await _context.Customers
                                        .Where(c => c.CustomerId == customer.CustomerId)
                                        .FirstOrDefaultAsync();

            cust.FirstName = customer.FirstName;
            cust.LastName = customer.LastName;
            cust.Email = customer.Email;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Can't edit Customer",e);
            }
        }
    }
}
