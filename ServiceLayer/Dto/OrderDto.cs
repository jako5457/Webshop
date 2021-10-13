using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Dto
{
    public class OrderDto : CustomerDto
    {
        public int OrderId { get; set; }

        public double TotalPrice { get; set; }
    }
}
