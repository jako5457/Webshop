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

        public Task<ManufacturerDto> GetManufacturer(int id);

        public Task CreateManufacturer(string name);

        public Task EditManufacturer(ManufacturerDto manufacturer);

    }
}
