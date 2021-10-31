using Microsoft.EntityFrameworkCore;
using ServiceLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLayer
{
    public static class MapHelpers
    {
        #region Product

        public static IQueryable<ProductDto> ToDto(this IQueryable<Datalayer.Entity.Product> products)
        {
            return products
                       .Include(p => p.Manufacturer)
                       .Select(p => new ProductDto() {
                           ProductId = p.ProductId,
                           Name = p.Name,
                           Description = p.Description,
                           ManufacturerName = p.Manufacturer.Name,
                           Price = p.Price,
                           ProductImages = p.ProductImages.Count(),
                           ManufacturerId = p.ManufacturerId
                       });
        }

        public static IQueryable<OrderProductDto> ToDto(this IQueryable<Datalayer.Entity.Product> products,int orderId)
        {
            return products
                      .Include(p => p.Manufacturer)
                      .Select(p => new OrderProductDto()
                      {
                          ProductId = p.ProductId,
                          Name = p.Name,
                          Description = p.Description,
                          ManufacturerName = p.Manufacturer.Name,
                          Price = p.Price,
                          ManufacturerId = p.ManufacturerId,
                          Amount = p.ProductOrders.Where(o => o.OrderId == orderId).Select(o => o.Amount).FirstOrDefault()
                      });
        }

        #endregion

        #region Customer

        public static IQueryable<CustomerDto> ToDto(this IQueryable<Datalayer.Entity.Customer> customers)
        {
            return customers.Select(c => new CustomerDto()
            {
                CustomerId = c.CustomerId,
                FirstName = c.FirstName,
                LastName = c.LastName,
                Email = c.Email
            });
        }

        #endregion

        #region Location

        public static IQueryable<LocationDto> ToDto(this IQueryable<Datalayer.Entity.Location> locations)
        {
            return locations.Select(l => new LocationDto()
            {
                LocationId = l.LocationId,
                Address = l.Address,
                City = l.City,
                Country = l.Country,
                Zipcode = l.Zipcode
            });
        }

        #endregion

        #region Order

        public static IQueryable<OrderDto> ToDto(this IQueryable<Datalayer.Entity.Order> orders)
        {
            return orders
                .Include(o => o.Customer)
                .Select(o => new OrderDto()
                {
                    CustomerId = o.CustomerId,
                    OrderId = o.OrderId,
                    TotalPrice = o.TotalPrice,
                    FirstName = o.Customer.FirstName,
                    LastName = o.Customer.LastName,
                    Email = o.Customer.Email
                });
        }

        #endregion

        #region Manufacturer

        public static IQueryable<ManufacturerDto> ToDto(this IQueryable<Datalayer.Entity.Manufacturer> manufacturers)
        {
            return manufacturers.Select(m => new ManufacturerDto()
            {
                ManufacturerId = m.ManufacturerId,
                Name = m.Name
            });
        }

        #endregion

        public static IQueryable<ProductImageDto> ToDto(this IQueryable<Datalayer.Entity.ProductImage> images)
        {
            return images.Select(i => new ProductImageDto()
            {
                ImageName = i.ImageName,
                ImagePath = i.ImagePath,
                ProductId = i.ProductId,
                ProductImageId = i.ProductImageId
            });
        }
    }
}
