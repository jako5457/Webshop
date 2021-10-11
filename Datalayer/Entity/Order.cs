using System;
using System.Collections.Generic;
using System.Text;

namespace Datalayer.Entity
{
    public class Order
    {

        public int OrderId { get; set; }

        public double TotalPrice { get; set; }
        
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
