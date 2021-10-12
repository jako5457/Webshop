using ServiceLayer.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Products
{
    public interface IProductService
    {

        public Task<List<ProductDto>> GetProductsAsync();

        public Task<ProductDto> GetProductAsync(int id);

        public Task<List<ProductDto>> GetProductsAsync(int page,int PageSize);

        public Task<int> GetPageCountAsync(int PageSize);

        public Task CreateProductAsync(ProductDto product);

        public Task EditProductAsync(ProductDto product);

        public Task SetProductHiddenAsync(int ProductId,bool Hidden);
    }
}
