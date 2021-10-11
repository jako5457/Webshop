﻿// <auto-generated />
using Datalayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Datalayer.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Datalayer.Entity.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Email = "Ole@eksample.dk",
                            FirstName = "Ole",
                            LastName = "Sigurd"
                        });
                });

            modelBuilder.Entity("Datalayer.Entity.CustomerLocation", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.HasKey("CustomerId", "LocationId");

                    b.HasIndex("LocationId");

                    b.ToTable("CustomerLocation");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            LocationId = 3
                        });
                });

            modelBuilder.Entity("Datalayer.Entity.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Zipcode")
                        .HasColumnType("int");

                    b.HasKey("LocationId");

                    b.ToTable("Location");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            Address = "Hilmarfinsensgade 12",
                            City = "Sønderborg",
                            Country = "Denmark",
                            Zipcode = 6400
                        },
                        new
                        {
                            LocationId = 2,
                            Address = "Bredgade 33",
                            City = "Aabenraa",
                            Country = "Denmark",
                            Zipcode = 6200
                        },
                        new
                        {
                            LocationId = 3,
                            Address = "Landevejen 144",
                            City = "Aalborg",
                            Country = "Denmark",
                            Zipcode = 9029
                        });
                });

            modelBuilder.Entity("Datalayer.Entity.Manufacturer", b =>
                {
                    b.Property<int>("ManufacturerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ManufacturerId");

                    b.ToTable("Manufacturers");

                    b.HasData(
                        new
                        {
                            ManufacturerId = 1,
                            Name = "Euc syd"
                        },
                        new
                        {
                            ManufacturerId = 2,
                            Name = "Aabenraa makinfabrik"
                        });
                });

            modelBuilder.Entity("Datalayer.Entity.ManufacturerLocation", b =>
                {
                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.HasKey("ManufacturerId", "LocationId");

                    b.HasIndex("LocationId");

                    b.ToTable("ManufacturerLocation");

                    b.HasData(
                        new
                        {
                            ManufacturerId = 1,
                            LocationId = 1
                        },
                        new
                        {
                            ManufacturerId = 2,
                            LocationId = 2
                        });
                });

            modelBuilder.Entity("Datalayer.Entity.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            CustomerId = 1,
                            TotalPrice = 100.0
                        });
                });

            modelBuilder.Entity("Datalayer.Entity.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Hidden")
                        .HasColumnType("bit");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.HasIndex("ManufacturerId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Description = "This product is an Awesome piece of craftsmanship",
                            Hidden = false,
                            ManufacturerId = 1,
                            Name = "Product4510",
                            Price = 0.13782152772779649
                        },
                        new
                        {
                            ProductId = 2,
                            Description = "This product is an Awesome piece of craftsmanship",
                            Hidden = false,
                            ManufacturerId = 1,
                            Name = "Product8184",
                            Price = 0.82861133004939713
                        },
                        new
                        {
                            ProductId = 3,
                            Description = "This product is an Awesome piece of craftsmanship",
                            Hidden = false,
                            ManufacturerId = 1,
                            Name = "Product4594",
                            Price = 0.026904471696775626
                        },
                        new
                        {
                            ProductId = 4,
                            Description = "This product is an Awesome piece of craftsmanship",
                            Hidden = false,
                            ManufacturerId = 1,
                            Name = "Product6729",
                            Price = 0.99687428446341042
                        },
                        new
                        {
                            ProductId = 5,
                            Description = "This product is an Awesome piece of craftsmanship",
                            Hidden = false,
                            ManufacturerId = 1,
                            Name = "Product9599",
                            Price = 0.05805989450684744
                        },
                        new
                        {
                            ProductId = 6,
                            Description = "This product is an Awesome piece of craftsmanship",
                            Hidden = false,
                            ManufacturerId = 1,
                            Name = "Product6680",
                            Price = 0.59594522537474759
                        },
                        new
                        {
                            ProductId = 7,
                            Description = "This product is an Awesome piece of craftsmanship",
                            Hidden = false,
                            ManufacturerId = 1,
                            Name = "Product2666",
                            Price = 0.41928267870996272
                        },
                        new
                        {
                            ProductId = 8,
                            Description = "This product is an Awesome piece of craftsmanship",
                            Hidden = false,
                            ManufacturerId = 1,
                            Name = "Product1536",
                            Price = 0.94153446654860606
                        },
                        new
                        {
                            ProductId = 9,
                            Description = "This product is an Awesome piece of craftsmanship",
                            Hidden = false,
                            ManufacturerId = 1,
                            Name = "Product3451",
                            Price = 0.079871053378968992
                        },
                        new
                        {
                            ProductId = 10,
                            Description = "This product is an Awesome piece of craftsmanship",
                            Hidden = false,
                            ManufacturerId = 1,
                            Name = "Product7613",
                            Price = 0.5388925944170414
                        },
                        new
                        {
                            ProductId = 11,
                            Description = "This product is an Awesome piece of craftsmanship",
                            Hidden = false,
                            ManufacturerId = 1,
                            Name = "Product2891",
                            Price = 0.12926765630453249
                        },
                        new
                        {
                            ProductId = 12,
                            Description = "This product is an Awesome piece of craftsmanship",
                            Hidden = false,
                            ManufacturerId = 1,
                            Name = "Product1041",
                            Price = 0.56402758209222348
                        },
                        new
                        {
                            ProductId = 13,
                            Description = "This product is an Awesome piece of craftsmanship",
                            Hidden = false,
                            ManufacturerId = 1,
                            Name = "Product9646",
                            Price = 0.012724678969348166
                        },
                        new
                        {
                            ProductId = 14,
                            Description = "This product is an Awesome piece of craftsmanship",
                            Hidden = false,
                            ManufacturerId = 1,
                            Name = "Product4233",
                            Price = 0.89173890458966554
                        },
                        new
                        {
                            ProductId = 15,
                            Description = "This product is an Awesome piece of craftsmanship",
                            Hidden = false,
                            ManufacturerId = 1,
                            Name = "Product1510",
                            Price = 0.93296121849350688
                        },
                        new
                        {
                            ProductId = 16,
                            Description = "This product is an Awesome piece of craftsmanship",
                            Hidden = false,
                            ManufacturerId = 1,
                            Name = "Product2588",
                            Price = 0.58267959746656917
                        },
                        new
                        {
                            ProductId = 17,
                            Description = "This product is an Awesome piece of craftsmanship",
                            Hidden = false,
                            ManufacturerId = 1,
                            Name = "Product8353",
                            Price = 0.21315525714920613
                        },
                        new
                        {
                            ProductId = 18,
                            Description = "This product is an Awesome piece of craftsmanship",
                            Hidden = false,
                            ManufacturerId = 1,
                            Name = "Product1441",
                            Price = 0.42984472281757963
                        },
                        new
                        {
                            ProductId = 19,
                            Description = "This product is an Awesome piece of craftsmanship",
                            Hidden = false,
                            ManufacturerId = 1,
                            Name = "Product9961",
                            Price = 0.46216725207034837
                        },
                        new
                        {
                            ProductId = 20,
                            Description = "This product is an Awesome piece of craftsmanship",
                            Hidden = false,
                            ManufacturerId = 1,
                            Name = "Product2766",
                            Price = 0.5853943878716763
                        });
                });

            modelBuilder.Entity("Datalayer.Entity.ProductImage", b =>
                {
                    b.Property<int>("ProductImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("ProductImageId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductImage");
                });

            modelBuilder.Entity("Datalayer.Entity.ProductOrder", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductOrder");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            ProductId = 15
                        });
                });

            modelBuilder.Entity("Datalayer.Entity.CustomerLocation", b =>
                {
                    b.HasOne("Datalayer.Entity.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Datalayer.Entity.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("Datalayer.Entity.ManufacturerLocation", b =>
                {
                    b.HasOne("Datalayer.Entity.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Datalayer.Entity.Manufacturer", "Manufacturer")
                        .WithMany("Locations")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("Datalayer.Entity.Order", b =>
                {
                    b.HasOne("Datalayer.Entity.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Datalayer.Entity.Product", b =>
                {
                    b.HasOne("Datalayer.Entity.Manufacturer", "Manufacturer")
                        .WithMany("Products")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("Datalayer.Entity.ProductImage", b =>
                {
                    b.HasOne("Datalayer.Entity.Product", "Product")
                        .WithMany("ProductImages")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Datalayer.Entity.ProductOrder", b =>
                {
                    b.HasOne("Datalayer.Entity.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Datalayer.Entity.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Datalayer.Entity.Manufacturer", b =>
                {
                    b.Navigation("Locations");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("Datalayer.Entity.Product", b =>
                {
                    b.Navigation("ProductImages");
                });
#pragma warning restore 612, 618
        }
    }
}
