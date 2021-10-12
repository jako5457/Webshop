using Datalayer.Entity;
using ServiceLayer.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ServiceLayer.Products
{
    public class ProductService : IProductService
    {

        public Datalayer.AppContext _Context;

        public ProductService(Datalayer.AppContext context)
        {
            _Context = context;
        }

        public async Task CreateProductAsync(ProductDto product)
        {
            Product Prod = new Product()
            {
                Name = product.Name,
                Description = product.Description,
                ManufacturerId = product.ManufacturerId,
                Price = product.Price,
                Hidden = false
            };

            try
            {
                _Context.Add(Prod);
                await _Context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Can't create Product",e);
            }
        }

        public async Task EditProductAsync(ProductDto product)
        {
            Product prod = _Context.Products
                                .Where(p => p.ProductId == product.ProductId)
                                .FirstOrDefault();

            prod.Name = product.Name;
            prod.Description = product.Description;
            prod.ManufacturerId = product.ManufacturerId;
            prod.Price = product.Price;

            try
            {
                await _Context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Can't edit product",e);
            }

        }

        public async Task<int> GetPageCountAsync(int PageSize)
        {
            return await _Context.Products.PageCountAsync(PageSize);
        }

        public Task<ProductDto> GetProductAsync(int id)
        {
            return _Context.Products
                            .Where(p => p.ProductId == id)
                            .ToDto()
                            .FirstOrDefaultAsync();
        }

        public async Task<List<ProductDto>> GetProductsAsync()
        {
            return await _Context.Products
                                    .Where(p => p.Hidden == false)
                                    .ToDto()
                                    .ToListAsync();
        }

        public async Task<List<ProductDto>> GetProductsAsync(int page, int PageSize)
        {
            return await _Context.Products
                                    .Where(p => p.Hidden == false)
                                    .ToDto()
                                    .Page(page,PageSize)
                                    .ToListAsync();
        }

        public async Task SetProductHiddenAsync(int ProductId, bool Hidden)
        {
            Product prod = await _Context.Products.Where(p => p.ProductId == ProductId).FirstOrDefaultAsync();

            prod.Hidden = Hidden;

            try
            {
                await _Context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Can't hide product",e);
            }
        }
    }
}
