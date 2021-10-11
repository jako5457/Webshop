using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.Entity
{
    public class ProductImage
    {

        public int ProductImageId { get; set; }

        public string ImageName { get; set; }

        public string ImagePath { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

    }
}
