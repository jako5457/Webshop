using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.Entity
{
    public class ManufacturerLocation
    {
        public int LocationId { get; set; }

        public int ManufacturerId { get; set; }

        public Manufacturer Manufacturer { get; set; }

        public Location Location { get; set; }
    }
}
