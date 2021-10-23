using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.Entity
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public bool Hidden { get; set; }

        public int ManufacturerId { get; set; }

        public Manufacturer Manufacturer { get; set; }

        public IEnumerable<ProductImage> ProductImages { get; set; }

        public IEnumerable<ProductOrder> ProductOrders { get; set; }
    }
}
