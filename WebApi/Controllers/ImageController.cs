using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using ServiceLayer.Products;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImageController : ControllerBase
    {

        private readonly IWebHostEnvironment _enviroment;
        private readonly IProductService _productService;

        public ImageController(IWebHostEnvironment enviroment,IProductService productService)
        {
            _enviroment = enviroment;
            _productService = productService;
        }

        [HttpGet]
        [Route("{productId}/{imagenumber}")]
        public async Task<IActionResult> GetProductImage(int productId,int imagenumber)
        {
            try
            {
                var imagedto = await _productService.GetProductImageAsync(productId, imagenumber);

                string path = Path.Combine(_enviroment.ContentRootPath, "wwwroot", "images", "NoImage.png");

                if (imagedto != null)
                {
                    path = Path.Combine(_enviroment.ContentRootPath, "wwwroot", "images", imagedto.ImagePath);
                }

                var image = System.IO.File.OpenRead(path);
                return File(image, "image/jpeg");
            }
            catch (Exception)
            {
               string path = Path.Combine(_enviroment.ContentRootPath, "wwwroot", "images","NoImage.png");
               var image = System.IO.File.OpenRead(path);
               return File(image, "image/jpeg");
            }
        }

    }
}
