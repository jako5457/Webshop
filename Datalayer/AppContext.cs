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

        public DbSet<Location> Locations { get; set; }

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
                    Name = "Aabenraa maskinfabrik"
                },
                new Manufacturer()
                {
                    ManufacturerId = 3,
                    Name = "Raspberrypi.dk"
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
                },
                new ManufacturerLocation()
                {
                    LocationId = 2,
                    ManufacturerId = 3
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
                        Name = $"Raspberry pi {rnd.Next(1, 100)}",
                        Description = $"This product is {rnd.Next(1, 100)}% better then the original",
                        Hidden = false,
                        ManufacturerId = rnd.Next(1, 2),
                        Price = Math.Round(rnd.NextDouble() * (1000 - 100) + 100, 2)
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
            int count = 1;
            for (int i = 1; i < ProductCount + 1; i++)
            {
                builder.Entity<ProductImage>().HasData(new ProductImage()
                {
                    ProductId = i,
                    ProductImageId = count,
                    ImageName = $"Pi{rnd.Next(1,100)}",
                    ImagePath = $"Pi{rnd.Next(1,8)}.jpg"
                });
                count++;

                if (rnd.Next(0,100) >= 50)
                {
                    builder.Entity<ProductImage>().HasData(new ProductImage()
                    {
                        ProductId = i,
                        ProductImageId = count,
                        ImageName = $"Pi{rnd.Next(1, 100)}",
                        ImagePath = $"Pi{rnd.Next(1, 8)}.jpg"
                    });
                    count++;
                }
            }

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
