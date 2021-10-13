using Microsoft.EntityFrameworkCore;
using System;
using Xunit;
using Datalayer;
using ServiceLayer.Dto;
using ServiceLayer.Products;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Test
{
    public class ProductTest
    {

        private readonly IServiceProvider serviceProvider;

        public ProductTest()
        {
            serviceProvider = TestDependency.CreateServiceProvider(services => {
                services.AddScoped<IProductService, ProductService>();
            });
        }

        [Fact]
        public async void GetProducts()
        {
            TestDependency.CreateDatabase(serviceProvider);
            IProductService productService = serviceProvider.GetRequiredService<IProductService>();

            var products = await productService.GetProductsAsync();

            Assert.NotEmpty(products);
            Assert.Equal(20,products.Count);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(10)]
        [InlineData(20)]
        public async void FindProduct(int id)
        {
            TestDependency.CreateDatabase(serviceProvider);
            var service = serviceProvider.GetRequiredService<IProductService>();

            var product = await service.GetProductAsync(id);

            Assert.NotNull(product);
            Assert.Equal(id,product.ProductId);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        public async void GetPage(int pagesize)
        {
            TestDependency.CreateDatabase(serviceProvider);
            var service = serviceProvider.GetRequiredService<IProductService>();

            var products = await service.GetProductsAsync(1, pagesize);

            Assert.NotEmpty(products);
            Assert.Equal(pagesize, products.Count);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(6)]
        public async void GetPageCount(int pagesize)
        {
            decimal rawcalc = 20 / pagesize;
            int expectedpages = Convert.ToInt32(Math.Ceiling(rawcalc));

            TestDependency.CreateDatabase(serviceProvider);
            var service = serviceProvider.GetRequiredService<IProductService>();

            int Pages = await service.GetPageCountAsync(pagesize);
        }

        [Fact]
        public async void CreateProduct()
        {
            TestDependency.CreateDatabase(serviceProvider);
            var service = serviceProvider.GetRequiredService<IProductService>();
            var context = serviceProvider.GetRequiredService<Datalayer.AppContext>();

            ProductDto product = new() {
                Name = "Bacon",
                Description = "Rigtig godt bacon",
                ManufacturerId = 1,
                Price = 10
            };

            await service.CreateProductAsync(product);

            int actualCount = await context.Products.CountAsync();
            Datalayer.Entity.Product ActualProduct = await context.Products.Where(p => p.Name == product.Name).FirstOrDefaultAsync();

            Assert.Equal(21, actualCount);
            Assert.NotNull(ActualProduct);
            Assert.Equal(product.Description,ActualProduct.Description);
        }

        [Fact]
        public async void HideProduct()
        {
            TestDependency.CreateDatabase(serviceProvider);
            var service = serviceProvider.GetRequiredService<IProductService>();
            var context = serviceProvider.GetRequiredService<Datalayer.AppContext>();

            await service.SetProductHiddenAsync(1, true);

            Datalayer.Entity.Product product = await context.Products.FirstOrDefaultAsync();
            int productCount = await context.Products.Where(p => !p.Hidden).CountAsync();

            Assert.Equal(19, productCount);
            Assert.NotNull(product);
            Assert.True(product.Hidden);
        }

        
    }
}
