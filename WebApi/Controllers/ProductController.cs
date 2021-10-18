using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceLayer.Products;
using ServiceLayer.Dto;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _ProductService;

        public ProductController(IProductService productService)
        {
            _ProductService = productService;
        }

        [HttpGet]
        [Route("all")]
        public async Task<List<ProductDto>> GetProducts()
        {
            return await _ProductService.GetProductsAsync();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ProductDto> GetProduct(int id)
        {
            return await _ProductService.GetProductAsync(id);
        }

        [HttpGet]
        [Route("page/{Page}/{PageSize}")]
        public async Task<List<ProductDto>> GetPage(int Page,int PageSize)
        {
            return await _ProductService.GetProductsAsync(Page, PageSize);
        }

        [HttpGet]
        [Route("page/count/{PageSize}")]
        public async Task<int> GetPageCount(int PageSize)
        {
           return await _ProductService.GetPageCountAsync(PageSize);
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateProduct(ProductDto product)
        {
            try
            {
                await _ProductService.CreateProductAsync(product);
                return Ok("Product created");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut]
        [Route("edit/{id}")]
        public async Task<IActionResult> EditProduct(ProductDto product,int id)
        {
            if (product.ProductId == id)
            {
                try
                {
                    await _ProductService.EditProductAsync(product);
                    return Ok("Product changed");
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
            else
            {
                return BadRequest("Product and id does not match");
            }
        }
        
        [HttpDelete]
        [Route("delete/{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
                await _ProductService.SetProductHiddenAsync(id, true);
                return Ok("Product deleted");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
