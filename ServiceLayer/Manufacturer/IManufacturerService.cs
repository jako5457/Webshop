using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ServiceLayer.Dto;

namespace ServiceLayer.Manufacturer
{
    public interface IManufacturerService
    {

        public Task<List<ManufacturerDto>> GetManufacturersAsync();

        public Task<ManufacturerDto> GetManufacturerAsync(int id);

        public Task CreateManufacturerAsync(string name);

        public Task EditManufacturerAsync(ManufacturerDto manufacturer);

    }
}
