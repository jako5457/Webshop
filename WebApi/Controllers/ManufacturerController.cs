using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Manufacturer;
using ServiceLayer.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManufacturerController : ControllerBase
    {
        private readonly IManufacturerService _ManufacturerService;

        public ManufacturerController(IManufacturerService manufacturerService)
        {
            _ManufacturerService = manufacturerService;
        }

        [HttpGet]
        [Route("all")]
        public async Task<List<ManufacturerDto>> GetManufacturers()
        {
            return await _ManufacturerService.GetManufacturersAsync();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<ManufacturerDto> GetManufacturer(int id)
        {
            return await _ManufacturerService.GetManufacturerAsync(id);
        }

        [HttpPost]
        public async Task<IActionResult> CreateManufacturer(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                try
                {
                    await _ManufacturerService.CreateManufacturerAsync(name);
                    return Ok("Manufacturer created");
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
            else
            {
                return BadRequest("Name cant't be empty");
            }
        }

        [HttpPut]
        public async Task<IActionResult> EditManufacturer(ManufacturerDto manufacturer)
        {
            try
            {
                await _ManufacturerService.EditManufacturerAsync(manufacturer);
                return Ok("Manufacturer Changed");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
