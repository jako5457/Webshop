using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ProductModel
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public string ManufacturerName { get; set; }

        public int ManufacturerId { get; set; }

        public int ProductImages { get; set; }

        public int Amount { get; set; }
    }
}
