using Datalayer.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer
{
    public class AppContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Manufacturer> Manufacturers { get; set; }

        public AppContext() : base(new DbContextOptionsBuilder().Options) { }

        public AppContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = WebShopDb; Trusted_Connection = True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            //Join tables
            builder.Entity<CustomerLocation>().HasKey(c => new { c.CustomerId, c.LocationId });
            builder.Entity<ManufacturerLocation>().HasKey(m => new { m.ManufacturerId, m.LocationId });
            builder.Entity<ProductOrder>().HasKey(p => new { p.OrderId, p.ProductId });

            builder.Entity<Location>().HasData(
                new Location()
                {
                    LocationId = 1,
                    City = "Sønderborg",
                    Address = "Hilmarfinsensgade 12",
                    Country = "Denmark",
                    Zipcode = 6400
                },
                new Location()
                {
                    LocationId = 2,
                    City = "Aabenraa",
                    Address = "Bredgade 33",
                    Country = "Denmark",
                    Zipcode = 6200
                },
                new Location()
                {
                    LocationId = 3,
                    City = "Aalborg",
                    Address = "Landevejen 144",
                    Country = "Denmark",
                    Zipcode = 9029
                }
            );

            builder.Entity<Manufacturer>().HasData(
                new Manufacturer()
                {
                    ManufacturerId = 1,
                    Name = "Euc syd"
                },
                new Manufacturer()
                {
                    ManufacturerId = 2,
                    Name = "Aabenraa makinfabrik"
                }
            );

            builder.Entity<ManufacturerLocation>().HasData(
                new ManufacturerLocation()
                {
                    LocationId = 1,
                    ManufacturerId = 1
                },
                new ManufacturerLocation()
                {
                    LocationId = 2,
                    ManufacturerId = 2
                }
            );

            builder.Entity<Customer>().HasData(
                new Customer()
                {
                    CustomerId = 1,
                    FirstName = "Ole",
                    LastName = "Sigurd",
                    Email = "Ole@eksample.dk",
                }
            );

            builder.Entity<CustomerLocation>().HasData(
                new CustomerLocation()
                {
                    CustomerId = 1,
                    LocationId = 3
                }
            );

            int ProductCount = 20;
            Random rnd = new Random();

            for (int i = 1; i < ProductCount +1; i++)
            {
                builder.Entity<Product>().HasData(
                    new Product()
                    {
                        ProductId = i,
                        Name = $"Product{rnd.Next(1000, 9999)}",
                        Description = "This product is an Awesome piece of craftsmanship",
                        Hidden = false,
                        ManufacturerId = rnd.Next(1, 2),
                        Price = rnd.NextDouble()
                    }
                );
            }

            builder.Entity<Order>().HasData(
                new Order()
                {
                    OrderId = 1,
                    CustomerId = 1,
                    TotalPrice = 100
                }
            );

            builder.Entity<ProductOrder>().HasData(
                new ProductOrder()
                {
                    ProductId = rnd.Next(1,ProductCount),
                    OrderId = 1,
                }
            );
        }

    }

}
