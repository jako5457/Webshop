using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.Entity
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }

        public string Name { get; set; }

        public IEnumerable<Product> Products { get; set; }

        public IEnumerable<ManufacturerLocation> Locations { get; set; }
    }
}
