using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class OrderProductModel
    {
        public OrderModel Order { get; set; }
        public List<ProductModel> Products { get; set; }
    }

    public class OrderModel
    {
        public long CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public long OrderId { get; set; }
        public double TotalPrice { get; set; }
    }

    public class CustomerModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
    }
}
