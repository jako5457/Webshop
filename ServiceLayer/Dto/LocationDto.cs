using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Dto
{
    public class LocationDto
    {
        public int LocationId { get; set; }

        public string Country { get; set; }

        public string Address { get; set; }

        public int Zipcode { get; set; }

        public string City { get; set; }
    }
}
