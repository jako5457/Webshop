using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Dto
{
    public class ProductImageDto
    {

        public int ProductImageId { get; set; }

        public string ImageName { get; set; }

        public string ImagePath { get; set; }

        public int ProductId { get; set; }

    }
}
