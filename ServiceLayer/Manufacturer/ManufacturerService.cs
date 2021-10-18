using ServiceLayer.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Datalayer;
using Microsoft.EntityFrameworkCore;

namespace ServiceLayer.Manufacturer
{
    public class ManufacturerService : IManufacturerService
    {

        private readonly Datalayer.AppContext _context;

        public ManufacturerService(Datalayer.AppContext context)
        {
            _context = context;
        }

        public async Task CreateManufacturerAsync(string name)
        {
            var NewManufacturer = new Datalayer.Entity.Manufacturer()
            {
                Name = name
            };

            try
            {
                _context.Manufacturers.Add(NewManufacturer);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Can't create manufacturer",e);
            }
        }

        public async Task EditManufacturerAsync(ManufacturerDto manufacturer)
        {
            Datalayer.Entity.Manufacturer man = await _context.Manufacturers
                                                              .Where(m => m.ManufacturerId == manufacturer.ManufacturerId)
                                                              .FirstOrDefaultAsync();

            man.Name = manufacturer.Name;

            try
            {
               await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception("Can't create manufacturer");
            }
        }

        public Task<ManufacturerDto> GetManufacturerAsync(int id)
        {
            return _context.Manufacturers
                            .Where(m => m.ManufacturerId == id)
                            .ToDto()
                            .FirstOrDefaultAsync();
        }

        public async Task<List<ManufacturerDto>> GetManufacturersAsync()
        {
            return await _context.Manufacturers.ToDto().ToListAsync();
        }
    }
}
