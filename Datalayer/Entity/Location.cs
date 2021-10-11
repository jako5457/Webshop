using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.Entity
{
    public class Location
    {

        public int LocationId { get; set; }

        public string Country { get; set; }

        public string Address { get; set; }

        public int Zipcode { get; set; }

        public string City { get; set; } 
    }
}
