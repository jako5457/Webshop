using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.Entity
{
    public class CustomerLocation
    {
        public int LocationId { get; set; }

        public int CustomerId { get; set; }

        public Location Location { get; set; }

        public Customer Customer { get; set; }
    }
}
