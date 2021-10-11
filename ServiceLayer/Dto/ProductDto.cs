using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Dto
{
    public class ProductDto
    {

        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string ManufacturerName { get; set; }

        public int ManufacturerId { get; set; }
    }
}
