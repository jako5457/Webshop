using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Dto
{
    public class OrderProductDto : ProductDto
    {
        public int Amount { get; set; }
    }
}
